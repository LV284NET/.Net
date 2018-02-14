using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using EasyTravelWeb.Infrastructure.Validators;
using EasyTravelWeb.Models;
using EasyTravelWeb.Providers;
using EasyTravelWeb.Results;
using EasyTravelWeb.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.Provider;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    Controller for register, sign in or change User private info
    /// </summary>
    [Authorize]
    public class AccountController : ApiController
    {
        /// <summary>
        ///    Validation model
        /// </summary>
        private readonly IValidator<RegisterBindingModel> registerBindingModelValidator =
            new RegisterBindingModelValidator();

        /// <summary>
        ///    Aplication manager
        /// </summary>
        private ApplicationUserManager userManager;

        /// <summary>
        ///		Validator for first and last name
        /// </summary>
        private readonly IValidator<string> nameValidator =
            new NameValidator();

        /// <summary>
        ///		Instance of UserRepository, using methods to do actions with database
        /// </summary>
        private readonly UserRepository userRepository = new UserRepository();

        private OAuthGrantResourceOwnerCredentialsContext _context;

        private BaseContext _baseContext;

        /// <summary>
        ///    Constructor
        /// </summary>
        public AccountController()
        {
        }

        /// <summary>
        ///    Constructor
        /// </summary>
        /// <param name="userManager">Identity User Manager</param>
        /// <param name="accessTokenFormat">Token format</param> 
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
        ///    Controller for get UserInfo
        /// </summary>
        /// <returns>First, user information</returns>
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
        ///    Controller for logOut
        /// </summary>
        /// <returns>Status code of request</returns>
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
        ///		Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="newFirstName">First name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [HttpPost]
        public async Task<IHttpActionResult> ChangeFirstName(ChangeFirstName model)
        {
            var user = await this.UserManager.FindByIdAsync(this.User.Identity.GetUserId<int>());
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("The name is not Valid");
            }

            if (!this.nameValidator.IsValid(model.newFirstName))
            {
                return this.BadRequest("The name is not Valid");
            }


            if (this.nameValidator.IsValid(model.newFirstName))
            {
                this.userRepository.ChangeFirstName(user.Id, model.newFirstName);
            }

            return this.Ok();
        }

        /// <summary>
        ///		Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="newLastName">Last name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [HttpPost]
        public async Task<IHttpActionResult> ChangeLastName(ChangeLastName model)
        {
            var user = await this.UserManager.FindByIdAsync(this.User.Identity.GetUserId<int>());

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("The name is not Valid");
            }

            if(!this.nameValidator.IsValid(model.newLastName))
            {
                return this.BadRequest("The name is not Valid");
            }

            if (this.nameValidator.IsValid(model.newLastName))
            {
                this.userRepository.ChangeLastName(user.Id, model.newLastName);
            }

            return this.Ok();
        }

        /// <summary>
        ///    Controller for change User password
        /// </summary>
        // POST api/Account/ChangePassword
        /// <param name="model">User Model for change password</param>
        /// <returns>Status code of result</returns>
        [HttpPost]
        public async Task<IHttpActionResult> ChangePassword(ChangePasswordBindingModel model)
        {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            var user = await this.UserManager.FindByIdAsync(this.User.Identity.GetUserId<int>());

            PasswordHasher passwordHasher = new PasswordHasher();
            var verificationResult = passwordHasher.VerifyHashedPassword(user.PasswordHash, model.OldPassword);
            
            if (verificationResult != PasswordVerificationResult.Success)
                return this.BadRequest("Old password doesnt match");

            IdentityResult result;

            if (!model.OldPassword.Equals(model.NewPassword))
            {
                result = await this.UserManager.ChangePasswordAsync(this.User.Identity.GetUserId<int>(),
                model.OldPassword,
                model.NewPassword);
            }

            else
            {
                return this.BadRequest("Old Password match new Password pls");
            }

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
        ///  Authorization with External service (Facebook)
        /// </summary>
        // POST api/Account/AddExternalLogin
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> AddExternalLogin([FromBody] FacebookUserViewModel fbUser)
        {
           
            this.Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            ApplicationUser user = await UserManager.FindByEmailAsync(fbUser.Email);

            if (user == null)
            {
                user = new ApplicationUser
                {
                    Email = fbUser.Email,
                    FirstName = fbUser.FirstName,
                    LastName = fbUser.LastName,
                    UserName = fbUser.Email,
                    EmailConfirmed = true
                };

                IdentityResult
                    result = await UserManager.CreateAsync(user, "Aa1111!!"); //Membership.GeneratePassword(8, 1));

                if (!result.Succeeded)
                    return Content(HttpStatusCode.BadRequest, "Something went wrong, please try later");
            }

            ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(this.UserManager,
                OAuthDefaults.AuthenticationType);

            AuthenticationProperties properties =
                ApplicationOAuthProvider.CreateProperties(user.Id, user.UserName, user.FirstName);
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);

            var token = Startup.OAuthOptions.AccessTokenFormat.Protect(ticket);
            return Ok(new
            {
                access_token = token,
                userName = user.UserName,
                firstName = user.FirstName,
                id = user.Id,
                authentication_type = OAuthDefaults.AuthenticationType,
                expires_in = TimeSpan.FromSeconds(500.0).Ticks
            });
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
        /// Registers user in database
        /// </summary>
        /// <param name="model">Object, which incapsulates user data, needed to register user(email, password, first name, last name)</param>
        /// <returns>Http code according to success</returns>
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
        [Route("api/Account/ConfirmEmail", Name = "ConfirmEmailRoute")]
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
                if (strengthInBits % Constants.Constants.AccountControllerConstants.BitsPerByte != 0)
                    throw new ArgumentException("strengthInBits must be evenly divisible by 8.",
                        nameof(strengthInBits));

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