using EasyTravelWeb.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Providers
{
    /// <summary>
    ///    App Configuration
    /// </summary>

    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string publicClientId;

        /// <summary>
        ///    
        /// </summary>
        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == string.Empty)
            {
                throw new ArgumentNullException("publicClientId");
            }

            this.publicClientId = publicClientId;
        }

        /// <summary>
        ///    
        /// </summary>
        public override async Task GrantResourceOwnerCredentials (OAuthGrantResourceOwnerCredentialsContext context)
        {
            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();


            ApplicationUser user = await userManager.FindByEmailAsync(context.UserName);

            if (user==null)
            {
                context.SetError("invalid_grant", "The email is incorrect!");
                return;
            }
            if (!DoesPasswordMatch(context, userManager, user))
            {
                context.SetError("invalid_grant", "The password is incorrect!");
                return;
            }
            ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager, OAuthDefaults.AuthenticationType);
            ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager, CookieAuthenticationDefaults.AuthenticationType);
            //ClaimsIdentity oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            //ClaimsIdentity cookiesIdentity = new ClaimsIdentity(context.Options.AuthenticationType);

            AuthenticationProperties properties = CreateProperties(user.Id, context.UserName, user.FirstName);
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        /// <summary>
        ///    
        /// </summary>
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {

            foreach (KeyValuePair<string,
            string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        /// <summary>
        ///    
        /// </summary>
        public override Task ValidateClientAuthentication (OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        /// <summary>
        ///    
        /// </summary>
        public override Task ValidateClientRedirectUri (OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == this.publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        /// <summary>
        ///    
        /// </summary>
        public static AuthenticationProperties CreateProperties(int idUser, string userName, string firstName)
        {
            IDictionary<string, string>
            data = new Dictionary<string, string>
            {
                { "userName", userName },
                { "firstName", firstName},
                { "Id", idUser.ToString() }
            };
            return new AuthenticationProperties(data);
        }

        private bool DoesPasswordMatch(OAuthGrantResourceOwnerCredentialsContext context, ApplicationUserManager userManager, 
            ApplicationUser userFoundByEmail)
        {
            ApplicationUser userFoundByUsernameAndPassword =
                userManager.Find(userFoundByEmail.UserName, context.Password);
            return userFoundByUsernameAndPassword != null;
        }
    }
}