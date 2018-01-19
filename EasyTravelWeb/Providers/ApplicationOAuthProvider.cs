using EasyTravelWeb.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }

            _publicClientId = publicClientId;
        }

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

            AuthenticationProperties properties = CreateProperties(context.UserName, user.FirstName);
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {

            foreach (KeyValuePair<string,
            string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientAuthentication (OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri (OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName, string FirstName)
        {
            IDictionary<string, string>
            data = new Dictionary<string, string>
            {
                { "userName", userName },
                { "firstName", FirstName}
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