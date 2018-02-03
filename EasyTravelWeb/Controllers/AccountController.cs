using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using EasyTravelWeb.Infrastructure.Validators;
using EasyTravelWeb.Models;
using EasyTravelWeb.Providers;
using EasyTravelWeb.Results;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    
    /// </summary>
    [Authorize]
    public class AccountController : ApiController
    {
        /// <summary>
        ///    
        /// </summary>
        private readonly IValidator<RegisterBindingModel> registerBindingModelValidator =
            new RegisterBindingModelValidator();

        /// <summary>
        ///    
        /// </summary>
        private ApplicationUserManager userManager;

        //        private OAuthGrantResourceOwnerCredentialsContext _context;

        //        private BaseContext _baseContext;

        /// <summary>
        ///    
        /// </summary>
        public AccountController()
        {
        }

        /// <summary>
        ///    
        /// </summary>
        public AccountController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            this.UserManager = userManager;
            this.AccessTokenFormat = accessTokenFormat;
        }

        /// <summary>
        ///    
        /// </summary>

        public ApplicationUserManager UserManager
        {
            get => this.userManager ?? this.Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => this.userManager = value;
        }

        /// <summary>
        ///    
        /// </summary>
        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; }

        /// <summary>
        ///    
        /// </summary>
        // GET api/Account/UserInfo
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [HttpGet]
        public UserInfoViewModel GetUserInfo()
        {
            ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(this.User.Identity as ClaimsIdentity);

            return new UserInfoViewModel
            {
                Email = this.User.Identity.GetUserName(),
                HasRegistered = externalLogin == null,
                LoginProvider = externalLogin != null ? externalLogin.LoginProvider : null
            };
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/Logout
        [HttpPost]
        public IHttpActionResult Logout()
        {
            this.Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // GET api/Account/ManageInfo?returnUrl=%2F&generateState=true
        [HttpGet]
        public async Task<ManageInfoViewModel> GetManageInfo(string returnUrl, bool generateState = false)
        {
            var user = await this.UserManager.FindByIdAsync(this.User.Identity.GetUserId<int>());

            if (user == null) return null;

            var logins = new List<UserLoginInfoViewModel>();

            foreach (CustomUserLogin linkedAccount in user.Logins)
                logins.Add(new UserLoginInfoViewModel
                {
                    LoginProvider = linkedAccount.LoginProvider,
                    ProviderKey = linkedAccount.ProviderKey
                });

            if (user.PasswordHash != null)
                logins.Add(new UserLoginInfoViewModel
                {
                    LoginProvider = Constants.Constants.AccountControllerConstants.LocalLoginProvider,
                    ProviderKey = user.UserName
                });

            return new ManageInfoViewModel
            {
                LocalLoginProvider = Constants.Constants.AccountControllerConstants.LocalLoginProvider,
                Email = user.UserName,
                Logins = logins,
                ExternalLoginProviders = this.GetExternalLogins(returnUrl, generateState)
            };
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/ChangePassword
        [HttpPost]
        public async Task<IHttpActionResult> ChangePassword(ChangePasswordBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            IdentityResult result = await this.UserManager.ChangePasswordAsync(this.User.Identity.GetUserId<int>(),
                model.OldPassword,
                model.NewPassword);

            if (!result.Succeeded) return this.GetErrorResult(result);

            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/SetPassword
        [HttpPost]
        public async Task<IHttpActionResult> SetPassword(SetPasswordBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            IdentityResult result =
                await this.UserManager.AddPasswordAsync(this.User.Identity.GetUserId<int>(), model.NewPassword);

            if (!result.Succeeded) return this.GetErrorResult(result);

            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/AddExternalLogin
        [HttpPost]
        public async Task<IHttpActionResult> AddExternalLogin(AddExternalLoginBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            this.Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);

            AuthenticationTicket ticket = this.AccessTokenFormat.Unprotect(model.ExternalAccessToken);

            if (ticket == null || ticket.Identity == null || ticket.Properties != null
                && ticket.Properties.ExpiresUtc.HasValue
                && ticket.Properties.ExpiresUtc.Value < DateTimeOffset.UtcNow)
                return this.BadRequest("External login failure.");

            ExternalLoginData externalData = ExternalLoginData.FromIdentity(ticket.Identity);

            if (externalData == null)
                return this.BadRequest("The external login is already associated with an account.");

            IdentityResult result = await this.UserManager.AddLoginAsync(this.User.Identity.GetUserId<int>(),
                new UserLoginInfo(externalData.LoginProvider, externalData.ProviderKey));

            if (!result.Succeeded) return this.GetErrorResult(result);

            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/RemoveLogin
        [HttpPost]
        public async Task<IHttpActionResult> RemoveLogin(RemoveLoginBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            IdentityResult result;

            if (model.LoginProvider == Constants.Constants.AccountControllerConstants.LocalLoginProvider)
                result = await this.UserManager.RemovePasswordAsync(this.User.Identity.GetUserId<int>());
            else
                result = await this.UserManager.RemoveLoginAsync(this.User.Identity.GetUserId<int>(),
                    new UserLoginInfo(model.LoginProvider, model.ProviderKey));

            if (!result.Succeeded) return this.GetErrorResult(result);

            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // GET api/Account/ExternalLogin
        [OverrideAuthentication]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalCookie)]
        [AllowAnonymous]
        [HttpGet]
        public async Task<IHttpActionResult> GetExternalLogin(string provider, string error = null)
        {
            if (error != null) return this.Redirect(this.Url.Content("~/") + "#error=" + Uri.EscapeDataString(error));

            if (!this.User.Identity.IsAuthenticated) return new ChallengeResult(provider, this);

            ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(this.User.Identity as ClaimsIdentity);

            if (externalLogin == null) return this.InternalServerError();

            if (externalLogin.LoginProvider != provider)
            {
                this.Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                return new ChallengeResult(provider, this);
            }

            ApplicationUser user = await this.UserManager.FindAsync(new UserLoginInfo(externalLogin.LoginProvider,
                externalLogin.ProviderKey));

            bool hasRegistered = user != null;

            if (hasRegistered)
            {
                this.Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);

                ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(this.UserManager,
                    OAuthDefaults.AuthenticationType);
                ClaimsIdentity cookieIdentity = await user.GenerateUserIdentityAsync(this.UserManager,
                    CookieAuthenticationDefaults.AuthenticationType);

                AuthenticationProperties properties =
                    ApplicationOAuthProvider.CreateProperties(user.Id, user.UserName, user.FirstName);
                this.Authentication.SignIn(properties, oAuthIdentity, cookieIdentity);
            }
            else
            {
                IEnumerable<Claim> claims = externalLogin.GetClaims();
                var identity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);
                this.Authentication.SignIn(identity);
            }

            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        // GET api/Account/ExternalLogins?returnUrl=%2F&generateState=true
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<ExternalLoginViewModel> GetExternalLogins(string returnUrl, bool generateState = false)
        {
            IEnumerable<AuthenticationDescription> descriptions = this.Authentication.GetExternalAuthenticationTypes();
            var logins = new List<ExternalLoginViewModel>();

            string state;

            if (generateState)
            {
                const int strengthInBits = 256;
                state = RandomOAuthStateGenerator.Generate(strengthInBits);
            }
            else
            {
                state = null;
            }

            foreach (AuthenticationDescription description in descriptions)
            {
                var login = new ExternalLoginViewModel
                {
                    Name = description.Caption,
                    Url = this.Url.Route("ExternalLogin", new
                    {
                        provider = description.AuthenticationType,
                        response_type = "token",
                        client_id = Startup.PublicClientId,
                        redirect_uri = new Uri(this.Request.RequestUri, returnUrl).AbsoluteUri,
                        state
                    }),
                    State = state
                };
                logins.Add(login);
            }

            return logins;
        }

        // POST api/Account/Confirm
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IHttpActionResult> ConfirmUser([FromBody] User user)
        {
            ApplicationUser userConfirm = await this.UserManager.FindByEmailAsync(user.Email);

            if (userConfirm == null)
            {
                return this.Content(HttpStatusCode.NotFound, "There is no such user!");
            }

            if (!userConfirm.EmailConfirmed)
            {
                return this.Content(HttpStatusCode.Forbidden, "Email is not confirmed! Please check your email");
            }

            return this.Ok();
        }

        // POST api/Account/Register
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.registerBindingModelValidator.IsValid(model))
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                IdentityResult result = await this.UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    string code = await this.UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = new Uri(this.Url.Link("ConfirmEmailRoute", new {userId = user.Id, code = code}));
                    await this.UserManager.SendEmailAsync(user.Id, "Confirm your account",
	                    $"<a href=\"{callbackUrl}\">Clink to confirm your registration</a>");
                }
                else return this.Content(HttpStatusCode.BadRequest, "There is such user with same email!");
            }

            return this.Ok();
        }


        /// <summary>
        ///    
        /// </summary>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IHttpActionResult> ConfirmEmail(int userId = 0, string code = "")
        {
            if (userId == default(int) || code == string.Empty)
            {
	            this.ModelState.AddModelError("", "User Id and Code are required");
                return this.BadRequest(this.ModelState);
            }

            IdentityResult result = await this.UserManager.ConfirmEmailAsync(userId, code);

            if (!result.Succeeded)
            {
                return this.GetErrorResult(result);
            }

            return this.Redirect(Constants.Constants.AccountControllerConstants
	            .UrlForRedirectAfterEmailConfirmation);
        }

        /// <summary>
        ///    
        /// </summary>
        // POST api/Account/RegisterExternal
        [OverrideAuthentication]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        public async Task<IHttpActionResult> RegisterExternal(RegisterExternalBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            ExternalLoginInfo info = await this.Authentication.GetExternalLoginInfoAsync();
            if (info == null) return this.InternalServerError();

            var user = new ApplicationUser {UserName = model.Email, Email = model.Email};

            IdentityResult result = await this.UserManager.CreateAsync(user);
            if (!result.Succeeded) return this.GetErrorResult(result);

            result = await this.UserManager.AddLoginAsync(user.Id, info.Login);
            if (!result.Succeeded) return this.GetErrorResult(result);
            return this.Ok();
        }

        /// <summary>
        ///    
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.userManager != null)
            {
                this.userManager.Dispose();
                this.userManager = null;
            }

            base.Dispose(disposing);
        }

        #region Helpers

        private IAuthenticationManager Authentication => this.Request.GetOwinContext().Authentication;

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null) return this.InternalServerError();

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                    foreach (string error in result.Errors)
                        this.ModelState.AddModelError("", error);

                if (this.ModelState.IsValid) return this.BadRequest();

                return this.BadRequest(this.ModelState);
            }

            return null;
        }

        private class ExternalLoginData
        {
            public string LoginProvider { get; set; }
            public string ProviderKey { get; set; }
            public string UserName { get; set; }

            public IList<Claim> GetClaims()
            {
                IList<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, this.ProviderKey, null, this.LoginProvider));

                if (this.UserName != null)
                    claims.Add(new Claim(ClaimTypes.Name, this.UserName, null, this.LoginProvider));

                return claims;
            }

            public static ExternalLoginData FromIdentity(ClaimsIdentity identity)
            {
	            Claim providerKeyClaim = identity?.FindFirst(ClaimTypes.NameIdentifier);

                if (providerKeyClaim == null || string.IsNullOrEmpty(providerKeyClaim.Issuer)
                                             || string.IsNullOrEmpty(providerKeyClaim.Value))
                    return null;

                if (providerKeyClaim.Issuer == ClaimsIdentity.DefaultIssuer) return null;

                return new ExternalLoginData
                {
                    LoginProvider = providerKeyClaim.Issuer,
                    ProviderKey = providerKeyClaim.Value,
                    UserName = identity.FindFirstValue(ClaimTypes.Name)
                };
            }
        }

        private static class RandomOAuthStateGenerator
        {
            private static readonly RandomNumberGenerator random = new RNGCryptoServiceProvider();

            public static string Generate(int strengthInBits)
            {
                if (strengthInBits % Constants.Constants.
	                    AccountControllerConstants.BitsPerByte != 0)
                    throw new ArgumentException("strengthInBits must be evenly divisible by 8.", nameof(strengthInBits));

                int strengthInBytes = strengthInBits / 
                                      Constants.Constants.AccountControllerConstants.BitsPerByte;

                var data = new byte[strengthInBytes];
                random.GetBytes(data);
                return HttpServerUtility.UrlTokenEncode(data);
            }
        }

        #endregion
    }
}