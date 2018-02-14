<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [AccountController](#T-EasyTravelWeb-Controllers-AccountController 'EasyTravelWeb.Controllers.AccountController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-AccountController-#ctor 'EasyTravelWeb.Controllers.AccountController.#ctor')
  - [#ctor(userManager,accessTokenFormat)](#M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}- 'EasyTravelWeb.Controllers.AccountController.#ctor(EasyTravelWeb.ApplicationUserManager,Microsoft.Owin.Security.ISecureDataFormat{Microsoft.Owin.Security.AuthenticationTicket})')
  - [registerBindingModelValidator](#F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator 'EasyTravelWeb.Controllers.AccountController.registerBindingModelValidator')
  - [userManager](#F-EasyTravelWeb-Controllers-AccountController-userManager 'EasyTravelWeb.Controllers.AccountController.userManager')
  - [AccessTokenFormat](#P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat 'EasyTravelWeb.Controllers.AccountController.AccessTokenFormat')
  - [UserManager](#P-EasyTravelWeb-Controllers-AccountController-UserManager 'EasyTravelWeb.Controllers.AccountController.UserManager')
  - [AddExternalLogin()](#M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-ProviderInfo- 'EasyTravelWeb.Controllers.AccountController.AddExternalLogin(EasyTravelWeb.Models.ProviderInfo)')
  - [ChangePassword(model)](#M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel- 'EasyTravelWeb.Controllers.AccountController.ChangePassword(EasyTravelWeb.Models.ChangePasswordBindingModel)')
  - [ConfirmEmail()](#M-EasyTravelWeb-Controllers-AccountController-ConfirmEmail-System-Int32,System-String- 'EasyTravelWeb.Controllers.AccountController.ConfirmEmail(System.Int32,System.String)')
  - [ConfirmUser(user)](#M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User- 'EasyTravelWeb.Controllers.AccountController.ConfirmUser(EasyTravelWeb.Models.User)')
  - [Dispose()](#M-EasyTravelWeb-Controllers-AccountController-Dispose-System-Boolean- 'EasyTravelWeb.Controllers.AccountController.Dispose(System.Boolean)')
  - [GetExternalLogin()](#M-EasyTravelWeb-Controllers-AccountController-GetExternalLogin-System-String,System-String- 'EasyTravelWeb.Controllers.AccountController.GetExternalLogin(System.String,System.String)')
  - [GetExternalLogins()](#M-EasyTravelWeb-Controllers-AccountController-GetExternalLogins-System-String,System-Boolean- 'EasyTravelWeb.Controllers.AccountController.GetExternalLogins(System.String,System.Boolean)')
  - [GetManageInfo()](#M-EasyTravelWeb-Controllers-AccountController-GetManageInfo-System-String,System-Boolean- 'EasyTravelWeb.Controllers.AccountController.GetManageInfo(System.String,System.Boolean)')
  - [GetUserInfo()](#M-EasyTravelWeb-Controllers-AccountController-GetUserInfo 'EasyTravelWeb.Controllers.AccountController.GetUserInfo')
  - [Logout()](#M-EasyTravelWeb-Controllers-AccountController-Logout 'EasyTravelWeb.Controllers.AccountController.Logout')
  - [Register(model)](#M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Controllers.AccountController.Register(EasyTravelWeb.Models.RegisterBindingModel)')
  - [RegisterExternal()](#M-EasyTravelWeb-Controllers-AccountController-RegisterExternal-EasyTravelWeb-Models-RegisterExternalBindingModel- 'EasyTravelWeb.Controllers.AccountController.RegisterExternal(EasyTravelWeb.Models.RegisterExternalBindingModel)')
  - [RemoveLogin()](#M-EasyTravelWeb-Controllers-AccountController-RemoveLogin-EasyTravelWeb-Models-RemoveLoginBindingModel- 'EasyTravelWeb.Controllers.AccountController.RemoveLogin(EasyTravelWeb.Models.RemoveLoginBindingModel)')
  - [SetPassword()](#M-EasyTravelWeb-Controllers-AccountController-SetPassword-EasyTravelWeb-Models-SetPasswordBindingModel- 'EasyTravelWeb.Controllers.AccountController.SetPassword(EasyTravelWeb.Models.SetPasswordBindingModel)')
- [AccountControllerConstants](#T-EasyTravelWeb-Constants-Constants-AccountControllerConstants 'EasyTravelWeb.Constants.Constants.AccountControllerConstants')
  - [BitsPerByte](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-BitsPerByte 'EasyTravelWeb.Constants.Constants.AccountControllerConstants.BitsPerByte')
  - [LocalLoginProvider](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-LocalLoginProvider 'EasyTravelWeb.Constants.Constants.AccountControllerConstants.LocalLoginProvider')
  - [UrlForRedirectAfterEmailConfirmation](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-UrlForRedirectAfterEmailConfirmation 'EasyTravelWeb.Constants.Constants.AccountControllerConstants.UrlForRedirectAfterEmailConfirmation')
- [AddExternalLoginBindingModel](#T-EasyTravelWeb-Models-AddExternalLoginBindingModel 'EasyTravelWeb.Models.AddExternalLoginBindingModel')
  - [ExternalAccessToken](#P-EasyTravelWeb-Models-AddExternalLoginBindingModel-ExternalAccessToken 'EasyTravelWeb.Models.AddExternalLoginBindingModel.ExternalAccessToken')
- [ApplicationDbContext](#T-EasyTravelWeb-Models-ApplicationDbContext 'EasyTravelWeb.Models.ApplicationDbContext')
  - [#ctor()](#M-EasyTravelWeb-Models-ApplicationDbContext-#ctor 'EasyTravelWeb.Models.ApplicationDbContext.#ctor')
  - [Create()](#M-EasyTravelWeb-Models-ApplicationDbContext-Create 'EasyTravelWeb.Models.ApplicationDbContext.Create')
- [ApplicationOAuthProvider](#T-EasyTravelWeb-Providers-ApplicationOAuthProvider 'EasyTravelWeb.Providers.ApplicationOAuthProvider')
  - [#ctor()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-#ctor-System-String- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.#ctor(System.String)')
  - [CreateProperties(idUser,userName,firstName)](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-CreateProperties-System-Int32,System-String,System-String- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.CreateProperties(System.Int32,System.String,System.String)')
  - [DoesPasswordMatch(context,userManager,userFoundByEmail)](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-DoesPasswordMatch-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext,EasyTravelWeb-ApplicationUserManager,EasyTravelWeb-Models-ApplicationUser- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.DoesPasswordMatch(Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext,EasyTravelWeb.ApplicationUserManager,EasyTravelWeb.Models.ApplicationUser)')
  - [GrantResourceOwnerCredentials(context)](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.GrantResourceOwnerCredentials(Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext)')
  - [TokenEndpoint(context)](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.TokenEndpoint(Microsoft.Owin.Security.OAuth.OAuthTokenEndpointContext)')
  - [ValidateClientAuthentication(context)](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.ValidateClientAuthentication(Microsoft.Owin.Security.OAuth.OAuthValidateClientAuthenticationContext)')
  - [ValidateClientRedirectUri()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientRedirectUri-Microsoft-Owin-Security-OAuth-OAuthValidateClientRedirectUriContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.ValidateClientRedirectUri(Microsoft.Owin.Security.OAuth.OAuthValidateClientRedirectUriContext)')
- [ApplicationUser](#T-EasyTravelWeb-Models-ApplicationUser 'EasyTravelWeb.Models.ApplicationUser')
  - [FirstName](#P-EasyTravelWeb-Models-ApplicationUser-FirstName 'EasyTravelWeb.Models.ApplicationUser.FirstName')
  - [LastName](#P-EasyTravelWeb-Models-ApplicationUser-LastName 'EasyTravelWeb.Models.ApplicationUser.LastName')
  - [GenerateUserIdentityAsync()](#M-EasyTravelWeb-Models-ApplicationUser-GenerateUserIdentityAsync-Microsoft-AspNet-Identity-UserManager{EasyTravelWeb-Models-ApplicationUser,System-Int32},System-String- 'EasyTravelWeb.Models.ApplicationUser.GenerateUserIdentityAsync(Microsoft.AspNet.Identity.UserManager{EasyTravelWeb.Models.ApplicationUser,System.Int32},System.String)')
- [ApplicationUserManager](#T-EasyTravelWeb-ApplicationUserManager 'EasyTravelWeb.ApplicationUserManager')
  - [#ctor()](#M-EasyTravelWeb-ApplicationUserManager-#ctor-Microsoft-AspNet-Identity-IUserStore{EasyTravelWeb-Models-ApplicationUser,System-Int32}- 'EasyTravelWeb.ApplicationUserManager.#ctor(Microsoft.AspNet.Identity.IUserStore{EasyTravelWeb.Models.ApplicationUser,System.Int32})')
  - [Create()](#M-EasyTravelWeb-ApplicationUserManager-Create-Microsoft-AspNet-Identity-Owin-IdentityFactoryOptions{EasyTravelWeb-ApplicationUserManager},Microsoft-Owin-IOwinContext- 'EasyTravelWeb.ApplicationUserManager.Create(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions{EasyTravelWeb.ApplicationUserManager},Microsoft.Owin.IOwinContext)')
- [BadResponse](#T-EasyTravelWeb-Models-BlaBlaCarResponse-BadResponse 'EasyTravelWeb.Models.BlaBlaCarResponse.BadResponse')
- [BlaBlaCarResultParser](#T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarResultParser')
  - [BadResult(response)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-BadResult-System-Net-Http-HttpResponseMessage- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarResultParser.BadResult(System.Net.Http.HttpResponseMessage)')
  - [SuccessResult(response)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-SuccessResult-System-Net-Http-HttpResponseMessage- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarResultParser.SuccessResult(System.Net.Http.HttpResponseMessage)')
- [BlaBlaCarService](#T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService')
  - [urlParameters](#F-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-urlParameters 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.urlParameters')
  - [AddHeaders(client,header,value)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddHeaders-System-Net-Http-HttpClient,System-String,System-String- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.AddHeaders(System.Net.Http.HttpClient,System.String,System.String)')
  - [AddParam(name,value)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddParam-System-String,System-String- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.AddParam(System.String,System.String)')
  - [BlaBlaCarRequest(fromCity,toCity,travelDate)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String,System-DateTime- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.BlaBlaCarRequest(System.String,System.String,System.DateTime)')
  - [BlaBlaCarRequest(fromCity,toCity)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.BlaBlaCarRequest(System.String,System.String)')
  - [SendRequest(urlParams)](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-SendRequest-System-String- 'EasyTravelWeb.Services.BlaBlaCar.BlaBlaCarService.SendRequest(System.String)')
- [BundleConfig](#T-EasyTravelWeb-BundleConfig 'EasyTravelWeb.BundleConfig')
  - [RegisterBundles()](#M-EasyTravelWeb-BundleConfig-RegisterBundles-System-Web-Optimization-BundleCollection- 'EasyTravelWeb.BundleConfig.RegisterBundles(System.Web.Optimization.BundleCollection)')
- [ChallengeResult](#T-EasyTravelWeb-Results-ChallengeResult 'EasyTravelWeb.Results.ChallengeResult')
  - [#ctor()](#M-EasyTravelWeb-Results-ChallengeResult-#ctor-System-String,System-Web-Http-ApiController- 'EasyTravelWeb.Results.ChallengeResult.#ctor(System.String,System.Web.Http.ApiController)')
  - [LoginProvider](#P-EasyTravelWeb-Results-ChallengeResult-LoginProvider 'EasyTravelWeb.Results.ChallengeResult.LoginProvider')
  - [Request](#P-EasyTravelWeb-Results-ChallengeResult-Request 'EasyTravelWeb.Results.ChallengeResult.Request')
  - [ExecuteAsync()](#M-EasyTravelWeb-Results-ChallengeResult-ExecuteAsync-System-Threading-CancellationToken- 'EasyTravelWeb.Results.ChallengeResult.ExecuteAsync(System.Threading.CancellationToken)')
- [ChangePasswordBindingModel](#T-EasyTravelWeb-Models-ChangePasswordBindingModel 'EasyTravelWeb.Models.ChangePasswordBindingModel')
  - [ConfirmPassword](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-ConfirmPassword 'EasyTravelWeb.Models.ChangePasswordBindingModel.ConfirmPassword')
  - [NewPassword](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-NewPassword 'EasyTravelWeb.Models.ChangePasswordBindingModel.NewPassword')
  - [OldPassword](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-OldPassword 'EasyTravelWeb.Models.ChangePasswordBindingModel.OldPassword')
- [City](#T-EasyTravelWeb-Models-City 'EasyTravelWeb.Models.City')
  - [CityRating](#P-EasyTravelWeb-Models-City-CityRating 'EasyTravelWeb.Models.City.CityRating')
  - [Description](#P-EasyTravelWeb-Models-City-Description 'EasyTravelWeb.Models.City.Description')
  - [Id](#P-EasyTravelWeb-Models-City-Id 'EasyTravelWeb.Models.City.Id')
  - [Name](#P-EasyTravelWeb-Models-City-Name 'EasyTravelWeb.Models.City.Name')
  - [PicturePath](#P-EasyTravelWeb-Models-City-PicturePath 'EasyTravelWeb.Models.City.PicturePath')
- [CityController](#T-EasyTravelWeb-Controllers-CityController 'EasyTravelWeb.Controllers.CityController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-CityController-#ctor 'EasyTravelWeb.Controllers.CityController.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Controllers-CityController-#ctor-EasyTravelWeb-Repositories-CityRepository- 'EasyTravelWeb.Controllers.CityController.#ctor(EasyTravelWeb.Repositories.CityRepository)')
  - [GetCities(page,pageSize)](#M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32- 'EasyTravelWeb.Controllers.CityController.GetCities(System.Int32,System.Int32)')
  - [GetCity(id)](#M-EasyTravelWeb-Controllers-CityController-GetCity-System-Int32- 'EasyTravelWeb.Controllers.CityController.GetCity(System.Int32)')
  - [GetCountCity()](#M-EasyTravelWeb-Controllers-CityController-GetCountCity 'EasyTravelWeb.Controllers.CityController.GetCountCity')
  - [GetTopCities()](#M-EasyTravelWeb-Controllers-CityController-GetTopCities-System-Int32- 'EasyTravelWeb.Controllers.CityController.GetTopCities(System.Int32)')
- [CityRepository](#T-EasyTravelWeb-Repositories-CityRepository 'EasyTravelWeb.Repositories.CityRepository')
  - [GetCitiesIdAndNames()](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesIdAndNames 'EasyTravelWeb.Repositories.CityRepository.GetCitiesIdAndNames')
  - [GetCitiesPage(page,pageSize)](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32- 'EasyTravelWeb.Repositories.CityRepository.GetCitiesPage(System.Int32,System.Int32)')
  - [GetCity(id)](#M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64- 'EasyTravelWeb.Repositories.CityRepository.GetCity(System.Int64)')
  - [GetCountCity()](#M-EasyTravelWeb-Repositories-CityRepository-GetCountCity 'EasyTravelWeb.Repositories.CityRepository.GetCountCity')
  - [GetTopCities(numberOfTopCities)](#M-EasyTravelWeb-Repositories-CityRepository-GetTopCities-System-Int32- 'EasyTravelWeb.Repositories.CityRepository.GetTopCities(System.Int32)')
- [CitySearchEntity](#T-EasyTravelWeb-Models-SearchEntities-CitySearchEntity 'EasyTravelWeb.Models.SearchEntities.CitySearchEntity')
  - [Id](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Id 'EasyTravelWeb.Models.SearchEntities.CitySearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Name 'EasyTravelWeb.Models.SearchEntities.CitySearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Type 'EasyTravelWeb.Models.SearchEntities.CitySearchEntity.Type')
- [ConfigurationConstants](#T-EasyTravelWeb-Constants-Constants-ConfigurationConstants 'EasyTravelWeb.Constants.Constants.ConfigurationConstants')
  - [ContextKey](#F-EasyTravelWeb-Constants-Constants-ConfigurationConstants-ContextKey 'EasyTravelWeb.Constants.Constants.ConfigurationConstants.ContextKey')
- [ConnectionStrings](#T-EasyTravelWeb-Constants-Constants-ConnectionStrings 'EasyTravelWeb.Constants.Constants.ConnectionStrings')
- [Constants](#T-EasyTravelWeb-Constants-Constants 'EasyTravelWeb.Constants.Constants')
- [CORSConfig](#T-EasyTravelWeb-CORSConfig 'EasyTravelWeb.CORSConfig')
  - [CorsPolicy](#F-EasyTravelWeb-CORSConfig-CorsPolicy 'EasyTravelWeb.CORSConfig.CorsPolicy')
- [CORSConstants](#T-EasyTravelWeb-Constants-Constants-CORSConstants 'EasyTravelWeb.Constants.Constants.CORSConstants')
  - [FrontEndUrl](#F-EasyTravelWeb-Constants-Constants-CORSConstants-FrontEndUrl 'EasyTravelWeb.Constants.Constants.CORSConstants.FrontEndUrl')
- [Credentials](#T-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials 'EasyTravelWeb.Constants.Constants.EmailServiceConstants.Credentials')
  - [Email](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Email 'EasyTravelWeb.Constants.Constants.EmailServiceConstants.Credentials.Email')
  - [Password](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Password 'EasyTravelWeb.Constants.Constants.EmailServiceConstants.Credentials.Password')
- [CustomRole](#T-EasyTravelWeb-Models-CustomRole 'EasyTravelWeb.Models.CustomRole')
  - [#ctor()](#M-EasyTravelWeb-Models-CustomRole-#ctor 'EasyTravelWeb.Models.CustomRole.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Models-CustomRole-#ctor-System-String- 'EasyTravelWeb.Models.CustomRole.#ctor(System.String)')
- [CustomRoleStore](#T-EasyTravelWeb-Models-CustomRoleStore 'EasyTravelWeb.Models.CustomRoleStore')
  - [#ctor()](#M-EasyTravelWeb-Models-CustomRoleStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext- 'EasyTravelWeb.Models.CustomRoleStore.#ctor(EasyTravelWeb.Models.ApplicationDbContext)')
- [CustomUserClaim](#T-EasyTravelWeb-Models-CustomUserClaim 'EasyTravelWeb.Models.CustomUserClaim')
- [CustomUserLogin](#T-EasyTravelWeb-Models-CustomUserLogin 'EasyTravelWeb.Models.CustomUserLogin')
- [CustomUserRole](#T-EasyTravelWeb-Models-CustomUserRole 'EasyTravelWeb.Models.CustomUserRole')
- [CustomUserStore](#T-EasyTravelWeb-Models-CustomUserStore 'EasyTravelWeb.Models.CustomUserStore')
  - [#ctor()](#M-EasyTravelWeb-Models-CustomUserStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext- 'EasyTravelWeb.Models.CustomUserStore.#ctor(EasyTravelWeb.Models.ApplicationDbContext)')
- [DataValidationConstants](#T-EasyTravelWeb-Constants-Constants-DataValidationConstants 'EasyTravelWeb.Constants.Constants.DataValidationConstants')
  - [EmailPattern](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-EmailPattern 'EasyTravelWeb.Constants.Constants.DataValidationConstants.EmailPattern')
  - [MinimumPasswordLength](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-MinimumPasswordLength 'EasyTravelWeb.Constants.Constants.DataValidationConstants.MinimumPasswordLength')
  - [NamePattern](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-NamePattern 'EasyTravelWeb.Constants.Constants.DataValidationConstants.NamePattern')
  - [PasswordPattern](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-PasswordPattern 'EasyTravelWeb.Constants.Constants.DataValidationConstants.PasswordPattern')
- [EmailService](#T-EasyTravelWeb-Services-EmailService 'EasyTravelWeb.Services.EmailService')
  - [SendAsync()](#M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage- 'EasyTravelWeb.Services.EmailService.SendAsync(Microsoft.AspNet.Identity.IdentityMessage)')
- [EmailServiceConstants](#T-EasyTravelWeb-Constants-Constants-EmailServiceConstants 'EasyTravelWeb.Constants.Constants.EmailServiceConstants')
  - [SmtpClientHost](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientHost 'EasyTravelWeb.Constants.Constants.EmailServiceConstants.SmtpClientHost')
  - [SmtpClientPort](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientPort 'EasyTravelWeb.Constants.Constants.EmailServiceConstants.SmtpClientPort')
- [EmailValidator](#T-EasyTravelWeb-Infrastructure-Validators-EmailValidator 'EasyTravelWeb.Infrastructure.Validators.EmailValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.#ctor')
  - [logger](#F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-logger 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.logger')
  - [validationRegister](#F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-validationRegister 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.validationRegister')
  - [emailIsValid(email)](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-emailIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.emailIsValid(System.String)')
  - [GetValidationData(name)](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-GetValidationData-System-String- 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.GetValidationData(System.String)')
  - [isEmailMetPatternRequirements(email)](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-isEmailMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.isEmailMetPatternRequirements(System.String)')
  - [IsValid(model)](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-IsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.EmailValidator.IsValid(System.String)')
- [ExternalLoginVerificator](#T-EasyTravelWeb-Services-ExternalLoginVerificator 'EasyTravelWeb.Services.ExternalLoginVerificator')
  - [VerifyFacebookAccessToken(accessToken)](#M-EasyTravelWeb-Services-ExternalLoginVerificator-VerifyFacebookAccessToken-System-String- 'EasyTravelWeb.Services.ExternalLoginVerificator.VerifyFacebookAccessToken(System.String)')
- [ExternalLoginViewModel](#T-EasyTravelWeb-Models-ExternalLoginViewModel 'EasyTravelWeb.Models.ExternalLoginViewModel')
  - [Name](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Name 'EasyTravelWeb.Models.ExternalLoginViewModel.Name')
  - [State](#P-EasyTravelWeb-Models-ExternalLoginViewModel-State 'EasyTravelWeb.Models.ExternalLoginViewModel.State')
  - [Url](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Url 'EasyTravelWeb.Models.ExternalLoginViewModel.Url')
- [FacebookUserViewModel](#T-EasyTravelWeb-Models-FacebookUserViewModel 'EasyTravelWeb.Models.FacebookUserViewModel')
  - [Email](#P-EasyTravelWeb-Models-FacebookUserViewModel-Email 'EasyTravelWeb.Models.FacebookUserViewModel.Email')
  - [FirstName](#P-EasyTravelWeb-Models-FacebookUserViewModel-FirstName 'EasyTravelWeb.Models.FacebookUserViewModel.FirstName')
  - [ID](#P-EasyTravelWeb-Models-FacebookUserViewModel-ID 'EasyTravelWeb.Models.FacebookUserViewModel.ID')
  - [LastName](#P-EasyTravelWeb-Models-FacebookUserViewModel-LastName 'EasyTravelWeb.Models.FacebookUserViewModel.LastName')
  - [Username](#P-EasyTravelWeb-Models-FacebookUserViewModel-Username 'EasyTravelWeb.Models.FacebookUserViewModel.Username')
- [FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace')
  - [PlaceId](#P-EasyTravelWeb-Models-FavoritePlace-PlaceId 'EasyTravelWeb.Models.FavoritePlace.PlaceId')
  - [UserId](#P-EasyTravelWeb-Models-FavoritePlace-UserId 'EasyTravelWeb.Models.FavoritePlace.UserId')
- [Filter](#T-EasyTravelWeb-Models-Filter 'EasyTravelWeb.Models.Filter')
- [FilterConfig](#T-EasyTravelWeb-FilterConfig 'EasyTravelWeb.FilterConfig')
  - [RegisterGlobalFilters()](#M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection- 'EasyTravelWeb.FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection)')
- [ISearchEntity](#T-EasyTravelWeb-Models-SearchEntities-ISearchEntity 'EasyTravelWeb.Models.SearchEntities.ISearchEntity')
  - [Id](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Id 'EasyTravelWeb.Models.SearchEntities.ISearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Name 'EasyTravelWeb.Models.SearchEntities.ISearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Type 'EasyTravelWeb.Models.SearchEntities.ISearchEntity.Type')
- [IValidator\`1](#T-EasyTravelWeb-Infrastructure-Validators-IValidator`1 'EasyTravelWeb.Infrastructure.Validators.IValidator`1')
  - [GetValidationData(obj)](#M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-GetValidationData-`0- 'EasyTravelWeb.Infrastructure.Validators.IValidator`1.GetValidationData(`0)')
  - [IsValid(obj)](#M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-IsValid-`0- 'EasyTravelWeb.Infrastructure.Validators.IValidator`1.IsValid(`0)')
- [Logger](#T-EasyTravelWeb-Infrastructure-Logger 'EasyTravelWeb.Infrastructure.Logger')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Logger-#ctor 'EasyTravelWeb.Infrastructure.Logger.#ctor')
  - [FileStream](#F-EasyTravelWeb-Infrastructure-Logger-FileStream 'EasyTravelWeb.Infrastructure.Logger.FileStream')
  - [logger](#F-EasyTravelWeb-Infrastructure-Logger-logger 'EasyTravelWeb.Infrastructure.Logger.logger')
  - [streamWriter](#F-EasyTravelWeb-Infrastructure-Logger-streamWriter 'EasyTravelWeb.Infrastructure.Logger.streamWriter')
  - [#cctor()](#M-EasyTravelWeb-Infrastructure-Logger-#cctor 'EasyTravelWeb.Infrastructure.Logger.#cctor')
  - [AsyncLogException(ex)](#M-EasyTravelWeb-Infrastructure-Logger-AsyncLogException-System-Exception- 'EasyTravelWeb.Infrastructure.Logger.AsyncLogException(System.Exception)')
  - [AsyncLogMessage(message)](#M-EasyTravelWeb-Infrastructure-Logger-AsyncLogMessage-System-String- 'EasyTravelWeb.Infrastructure.Logger.AsyncLogMessage(System.String)')
  - [Finalize()](#M-EasyTravelWeb-Infrastructure-Logger-Finalize 'EasyTravelWeb.Infrastructure.Logger.Finalize')
  - [GetInstance()](#M-EasyTravelWeb-Infrastructure-Logger-GetInstance 'EasyTravelWeb.Infrastructure.Logger.GetInstance')
- [LoggerConstants](#T-EasyTravelWeb-Constants-Constants-LoggerConstants 'EasyTravelWeb.Constants.Constants.LoggerConstants')
  - [PathForFileStream](#F-EasyTravelWeb-Constants-Constants-LoggerConstants-PathForFileStream 'EasyTravelWeb.Constants.Constants.LoggerConstants.PathForFileStream')
- [MainPageController](#T-EasyTravelWeb-Controllers-MainPageController 'EasyTravelWeb.Controllers.MainPageController')
  - [Index()](#M-EasyTravelWeb-Controllers-MainPageController-Index 'EasyTravelWeb.Controllers.MainPageController.Index')
- [ManageInfoViewModel](#T-EasyTravelWeb-Models-ManageInfoViewModel 'EasyTravelWeb.Models.ManageInfoViewModel')
  - [Email](#P-EasyTravelWeb-Models-ManageInfoViewModel-Email 'EasyTravelWeb.Models.ManageInfoViewModel.Email')
  - [ExternalLoginProviders](#P-EasyTravelWeb-Models-ManageInfoViewModel-ExternalLoginProviders 'EasyTravelWeb.Models.ManageInfoViewModel.ExternalLoginProviders')
  - [LocalLoginProvider](#P-EasyTravelWeb-Models-ManageInfoViewModel-LocalLoginProvider 'EasyTravelWeb.Models.ManageInfoViewModel.LocalLoginProvider')
  - [Logins](#P-EasyTravelWeb-Models-ManageInfoViewModel-Logins 'EasyTravelWeb.Models.ManageInfoViewModel.Logins')
- [MvcApplication](#T-EasyTravelWeb-MvcApplication 'EasyTravelWeb.MvcApplication')
  - [Application_Start()](#M-EasyTravelWeb-MvcApplication-Application_Start 'EasyTravelWeb.MvcApplication.Application_Start')
- [NameValidator](#T-EasyTravelWeb-Infrastructure-Validators-NameValidator 'EasyTravelWeb.Infrastructure.Validators.NameValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.NameValidator.#ctor')
  - [logger](#F-EasyTravelWeb-Infrastructure-Validators-NameValidator-logger 'EasyTravelWeb.Infrastructure.Validators.NameValidator.logger')
  - [validationRegister](#F-EasyTravelWeb-Infrastructure-Validators-NameValidator-validationRegister 'EasyTravelWeb.Infrastructure.Validators.NameValidator.validationRegister')
  - [GetValidationData(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-GetValidationData-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameValidator.GetValidationData(System.String)')
  - [isNameMetPatternRequirements(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-isNameMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameValidator.isNameMetPatternRequirements(System.String)')
  - [IsValid(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-IsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameValidator.IsValid(System.String)')
  - [nameIsValid(firstName)](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-nameIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameValidator.nameIsValid(System.String)')
- [OKResponse](#T-EasyTravelWeb-Models-BlaBlaCarResponse-OKResponse 'EasyTravelWeb.Models.BlaBlaCarResponse.OKResponse')
- [PasswordValidator](#T-EasyTravelWeb-Infrastructure-Validators-PasswordValidator 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.#ctor')
  - [logger](#F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-logger 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.logger')
  - [validationRegister](#F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-validationRegister 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.validationRegister')
  - [GetValidationData(name)](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-GetValidationData-System-String- 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.GetValidationData(System.String)')
  - [isPasswordMetPatternRequirements(password)](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.isPasswordMetPatternRequirements(System.String)')
  - [isPasswordValid(password)](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.isPasswordValid(System.String)')
  - [IsValid(name)](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-IsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.PasswordValidator.IsValid(System.String)')
- [Place](#T-EasyTravelWeb-Models-Place 'EasyTravelWeb.Models.Place')
  - [#ctor()](#M-EasyTravelWeb-Models-Place-#ctor 'EasyTravelWeb.Models.Place.#ctor')
  - [CityId](#P-EasyTravelWeb-Models-Place-CityId 'EasyTravelWeb.Models.Place.CityId')
  - [CityName](#P-EasyTravelWeb-Models-Place-CityName 'EasyTravelWeb.Models.Place.CityName')
  - [Description](#P-EasyTravelWeb-Models-Place-Description 'EasyTravelWeb.Models.Place.Description')
  - [Name](#P-EasyTravelWeb-Models-Place-Name 'EasyTravelWeb.Models.Place.Name')
  - [PicturePlace](#P-EasyTravelWeb-Models-Place-PicturePlace 'EasyTravelWeb.Models.Place.PicturePlace')
  - [PlaceId](#P-EasyTravelWeb-Models-Place-PlaceId 'EasyTravelWeb.Models.Place.PlaceId')
  - [PlaceRating](#P-EasyTravelWeb-Models-Place-PlaceRating 'EasyTravelWeb.Models.Place.PlaceRating')
- [PlaceController](#T-EasyTravelWeb-Controllers-PlaceController 'EasyTravelWeb.Controllers.PlaceController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-PlaceController-#ctor 'EasyTravelWeb.Controllers.PlaceController.#ctor')
  - [AddUserFavoritePlace(favoriteUserPlace)](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'EasyTravelWeb.Controllers.PlaceController.AddUserFavoritePlace(EasyTravelWeb.Models.FavoritePlace)')
  - [DeleteUserFavoritePlace(favoriteUserPlace)](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'EasyTravelWeb.Controllers.PlaceController.DeleteUserFavoritePlace(EasyTravelWeb.Models.FavoritePlace)')
  - [GetCountFromFilteredPlaces(filters)](#M-EasyTravelWeb-Controllers-PlaceController-GetCountFromFilteredPlaces-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Controllers.PlaceController.GetCountFromFilteredPlaces(System.Int64,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetFilteredPlacesByCityId(filters)](#M-EasyTravelWeb-Controllers-PlaceController-GetFilteredPlacesByCityId-System-Int64,System-Int32,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Controllers.PlaceController.GetFilteredPlacesByCityId(System.Int64,System.Int32,System.Int32,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetPlaceById(placeId)](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceById-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetPlaceById(System.Int64)')
  - [GetPlaceFilters()](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceFilters-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetPlaceFilters(System.Int64)')
  - [GetPlaceRating(placeId)](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceRating-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetPlaceRating(System.Int64)')
  - [GetPlacesPageByCityId(cityId,page,pageSize)](#M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32- 'EasyTravelWeb.Controllers.PlaceController.GetPlacesPageByCityId(System.Int64,System.Int32,System.Int32)')
  - [GetTopPlacesByCityId(cityId)](#M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64,System-Int32- 'EasyTravelWeb.Controllers.PlaceController.GetTopPlacesByCityId(System.Int64,System.Int32)')
- [PlaceRepository](#T-EasyTravelWeb-Repositories-PlaceRepository 'EasyTravelWeb.Repositories.PlaceRepository')
  - [noRowsAffected](#F-EasyTravelWeb-Repositories-PlaceRepository-noRowsAffected 'EasyTravelWeb.Repositories.PlaceRepository.noRowsAffected')
  - [AddFavoritePlace(userId,placeId)](#M-EasyTravelWeb-Repositories-PlaceRepository-AddFavoritePlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.AddFavoritePlace(System.Int32,System.Int64)')
  - [DeleteFavoritePlace(userId,placeId)](#M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.DeleteFavoritePlace(System.Int32,System.Int64)')
  - [GetCountPlace(cityId)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetCountPlace(System.Int64)')
  - [GetFavoritePlaces(id)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32- 'EasyTravelWeb.Repositories.PlaceRepository.GetFavoritePlaces(System.Int32)')
  - [GetFilteredCountPlace(filters)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredCountPlace-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Repositories.PlaceRepository.GetFilteredCountPlace(System.Int64,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetFilteredPlacesPage(filters)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredPlacesPage-System-Int32,System-Int64,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Repositories.PlaceRepository.GetFilteredPlacesPage(System.Int32,System.Int64,System.Int32,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetPlaceById(placeId)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceById-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlaceById(System.Int64)')
  - [GetPlaceFilters()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceFilters-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlaceFilters(System.Int64)')
  - [GetPlaceRating(placeId)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceRating-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlaceRating(System.Int64)')
  - [GetPlacesIdsAndNames()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames 'EasyTravelWeb.Repositories.PlaceRepository.GetPlacesIdsAndNames')
  - [GetPlacesPage(page,cityId,pageSize)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlacesPage(System.Int32,System.Int64,System.Int32)')
  - [GetTopPlacesByCityId(cityId,numberOfTopPlaces)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64,System-Int32- 'EasyTravelWeb.Repositories.PlaceRepository.GetTopPlacesByCityId(System.Int64,System.Int32)')
- [PlaceSearchEntity](#T-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity 'EasyTravelWeb.Models.SearchEntities.PlaceSearchEntity')
  - [CityId](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-CityId 'EasyTravelWeb.Models.SearchEntities.PlaceSearchEntity.CityId')
  - [Id](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Id 'EasyTravelWeb.Models.SearchEntities.PlaceSearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Name 'EasyTravelWeb.Models.SearchEntities.PlaceSearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Type 'EasyTravelWeb.Models.SearchEntities.PlaceSearchEntity.Type')
- [ProfileController](#T-EasyTravelWeb-Controllers-ProfileController 'EasyTravelWeb.Controllers.ProfileController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor 'EasyTravelWeb.Controllers.ProfileController.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-UserRepository- 'EasyTravelWeb.Controllers.ProfileController.#ctor(EasyTravelWeb.Repositories.UserRepository)')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-PlaceRepository- 'EasyTravelWeb.Controllers.ProfileController.#ctor(EasyTravelWeb.Repositories.PlaceRepository)')
  - [nameValidator](#F-EasyTravelWeb-Controllers-ProfileController-nameValidator 'EasyTravelWeb.Controllers.ProfileController.nameValidator')
  - [placeRepository](#F-EasyTravelWeb-Controllers-ProfileController-placeRepository 'EasyTravelWeb.Controllers.ProfileController.placeRepository')
  - [ratingRepository](#F-EasyTravelWeb-Controllers-ProfileController-ratingRepository 'EasyTravelWeb.Controllers.ProfileController.ratingRepository')
  - [userRepository](#F-EasyTravelWeb-Controllers-ProfileController-userRepository 'EasyTravelWeb.Controllers.ProfileController.userRepository')
  - [ChangeFirstName(id,firstName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeFirstName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeFirstName(System.Int32,System.String)')
  - [ChangeLastName(id,lastName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeLastName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeLastName(System.Int32,System.String)')
  - [DeleteUserRatingForPlace(userRating)](#M-EasyTravelWeb-Controllers-ProfileController-DeleteUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'EasyTravelWeb.Controllers.ProfileController.DeleteUserRatingForPlace(EasyTravelWeb.Models.UserPlaceRating)')
  - [GetFavoritePlaces(id)](#M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetFavoritePlaces(System.Int32)')
  - [GetUserInfo(id)](#M-EasyTravelWeb-Controllers-ProfileController-GetUserInfo-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetUserInfo(System.Int32)')
  - [GetUserRatingOfPlace(userId,placeId)](#M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64- 'EasyTravelWeb.Controllers.ProfileController.GetUserRatingOfPlace(System.Int32,System.Int64)')
  - [SetUserRatingForPlace(userRating)](#M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'EasyTravelWeb.Controllers.ProfileController.SetUserRatingForPlace(EasyTravelWeb.Models.UserPlaceRating)')
- [ProviderInfo](#T-EasyTravelWeb-Models-ProviderInfo 'EasyTravelWeb.Models.ProviderInfo')
  - [AccessToken](#P-EasyTravelWeb-Models-ProviderInfo-AccessToken 'EasyTravelWeb.Models.ProviderInfo.AccessToken')
  - [Provider](#P-EasyTravelWeb-Models-ProviderInfo-Provider 'EasyTravelWeb.Models.ProviderInfo.Provider')
- [RatingRepository](#T-EasyTravelWeb-Repositories-RatingRepository 'EasyTravelWeb.Repositories.RatingRepository')
  - [noRowsAffected](#F-EasyTravelWeb-Repositories-RatingRepository-noRowsAffected 'EasyTravelWeb.Repositories.RatingRepository.noRowsAffected')
  - [DeleteUserRatingForPlace(userId,placeId)](#M-EasyTravelWeb-Repositories-RatingRepository-DeleteUserRatingForPlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.RatingRepository.DeleteUserRatingForPlace(System.Int32,System.Int64)')
  - [GetUserRatingOfPlace(userId,placeId)](#M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.RatingRepository.GetUserRatingOfPlace(System.Int32,System.Int64)')
  - [SetUserRatingForPlace(userRating)](#M-EasyTravelWeb-Repositories-RatingRepository-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'EasyTravelWeb.Repositories.RatingRepository.SetUserRatingForPlace(EasyTravelWeb.Models.UserPlaceRating)')
- [RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel')
  - [ConfirmPassword](#P-EasyTravelWeb-Models-RegisterBindingModel-ConfirmPassword 'EasyTravelWeb.Models.RegisterBindingModel.ConfirmPassword')
  - [Email](#P-EasyTravelWeb-Models-RegisterBindingModel-Email 'EasyTravelWeb.Models.RegisterBindingModel.Email')
  - [FirstName](#P-EasyTravelWeb-Models-RegisterBindingModel-FirstName 'EasyTravelWeb.Models.RegisterBindingModel.FirstName')
  - [LastName](#P-EasyTravelWeb-Models-RegisterBindingModel-LastName 'EasyTravelWeb.Models.RegisterBindingModel.LastName')
  - [Password](#P-EasyTravelWeb-Models-RegisterBindingModel-Password 'EasyTravelWeb.Models.RegisterBindingModel.Password')
- [RegisterBindingModelValidator](#T-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.#ctor')
  - [emailValidator](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailValidator 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.emailValidator')
  - [logger](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.logger')
  - [nameValidator](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-nameValidator 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.nameValidator')
  - [passwordValidator](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordValidator 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.passwordValidator')
  - [validationRegister](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.validationRegister')
  - [GetValidationData(model)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.GetValidationData(EasyTravelWeb.Models.RegisterBindingModel)')
  - [IsValid(model)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.IsValid(EasyTravelWeb.Models.RegisterBindingModel)')
- [RegisterExternalBindingModel](#T-EasyTravelWeb-Models-RegisterExternalBindingModel 'EasyTravelWeb.Models.RegisterExternalBindingModel')
  - [Email](#P-EasyTravelWeb-Models-RegisterExternalBindingModel-Email 'EasyTravelWeb.Models.RegisterExternalBindingModel.Email')
- [RemoveLoginBindingModel](#T-EasyTravelWeb-Models-RemoveLoginBindingModel 'EasyTravelWeb.Models.RemoveLoginBindingModel')
  - [LoginProvider](#P-EasyTravelWeb-Models-RemoveLoginBindingModel-LoginProvider 'EasyTravelWeb.Models.RemoveLoginBindingModel.LoginProvider')
  - [ProviderKey](#P-EasyTravelWeb-Models-RemoveLoginBindingModel-ProviderKey 'EasyTravelWeb.Models.RemoveLoginBindingModel.ProviderKey')
- [RouteConfig](#T-EasyTravelWeb-RouteConfig 'EasyTravelWeb.RouteConfig')
  - [RegisterRoutes()](#M-EasyTravelWeb-RouteConfig-RegisterRoutes-System-Web-Routing-RouteCollection- 'EasyTravelWeb.RouteConfig.RegisterRoutes(System.Web.Routing.RouteCollection)')
- [SearchController](#T-EasyTravelWeb-Controllers-SearchController 'EasyTravelWeb.Controllers.SearchController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-SearchController-#ctor 'EasyTravelWeb.Controllers.SearchController.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Controllers-SearchController-#ctor-EasyTravelWeb-Repositories-CityRepository,EasyTravelWeb-Repositories-PlaceRepository- 'EasyTravelWeb.Controllers.SearchController.#ctor(EasyTravelWeb.Repositories.CityRepository,EasyTravelWeb.Repositories.PlaceRepository)')
  - [AddCitiesToSuggestions(searchWord,listOfSuggestions)](#M-EasyTravelWeb-Controllers-SearchController-AddCitiesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}- 'EasyTravelWeb.Controllers.SearchController.AddCitiesToSuggestions(System.String,System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity})')
  - [AddPlacesToSuggestions(searchWord,listOfSuggestions)](#M-EasyTravelWeb-Controllers-SearchController-AddPlacesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}- 'EasyTravelWeb.Controllers.SearchController.AddPlacesToSuggestions(System.String,System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity})')
  - [GetSuggestions(searchWord)](#M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String- 'EasyTravelWeb.Controllers.SearchController.GetSuggestions(System.String)')
  - [InitializeData()](#M-EasyTravelWeb-Controllers-SearchController-InitializeData 'EasyTravelWeb.Controllers.SearchController.InitializeData')
- [SearchControllerConstants](#T-EasyTravelWeb-Constants-Constants-SearchControllerConstants 'EasyTravelWeb.Constants.Constants.SearchControllerConstants')
  - [NumberOfSearchEntitiesToShow](#F-EasyTravelWeb-Constants-Constants-SearchControllerConstants-NumberOfSearchEntitiesToShow 'EasyTravelWeb.Constants.Constants.SearchControllerConstants.NumberOfSearchEntitiesToShow')
- [ServicesController](#T-EasyTravelWeb-Controllers-ServicesController 'EasyTravelWeb.Controllers.ServicesController')
  - [blaBlaCar](#F-EasyTravelWeb-Controllers-ServicesController-blaBlaCar 'EasyTravelWeb.Controllers.ServicesController.blaBlaCar')
  - [GetBlaBlaCarRequestResult(fromCity,toCity,dateOfTrip)](#M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String,System-DateTime- 'EasyTravelWeb.Controllers.ServicesController.GetBlaBlaCarRequestResult(System.String,System.String,System.DateTime)')
  - [GetBlaBlaCarRequestResult(fromCity,toCity,dateOfTrip)](#M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String- 'EasyTravelWeb.Controllers.ServicesController.GetBlaBlaCarRequestResult(System.String,System.String)')
- [SetPasswordBindingModel](#T-EasyTravelWeb-Models-SetPasswordBindingModel 'EasyTravelWeb.Models.SetPasswordBindingModel')
  - [ConfirmPassword](#P-EasyTravelWeb-Models-SetPasswordBindingModel-ConfirmPassword 'EasyTravelWeb.Models.SetPasswordBindingModel.ConfirmPassword')
  - [NewPassword](#P-EasyTravelWeb-Models-SetPasswordBindingModel-NewPassword 'EasyTravelWeb.Models.SetPasswordBindingModel.NewPassword')
- [Startup](#T-EasyTravelWeb-Startup 'EasyTravelWeb.Startup')
  - [OAuthOptions](#P-EasyTravelWeb-Startup-OAuthOptions 'EasyTravelWeb.Startup.OAuthOptions')
  - [PublicClientId](#P-EasyTravelWeb-Startup-PublicClientId 'EasyTravelWeb.Startup.PublicClientId')
  - [Configuration()](#M-EasyTravelWeb-Startup-Configuration-Owin-IAppBuilder- 'EasyTravelWeb.Startup.Configuration(Owin.IAppBuilder)')
  - [ConfigureAuth()](#M-EasyTravelWeb-Startup-ConfigureAuth-Owin-IAppBuilder- 'EasyTravelWeb.Startup.ConfigureAuth(Owin.IAppBuilder)')
- [StartupConstants](#T-EasyTravelWeb-Constants-Constants-StartupConstants 'EasyTravelWeb.Constants.Constants.StartupConstants')
  - [AuthorizeEndpointPath](#F-EasyTravelWeb-Constants-Constants-StartupConstants-AuthorizeEndpointPath 'EasyTravelWeb.Constants.Constants.StartupConstants.AuthorizeEndpointPath')
  - [TokenEndpointPath](#F-EasyTravelWeb-Constants-Constants-StartupConstants-TokenEndpointPath 'EasyTravelWeb.Constants.Constants.StartupConstants.TokenEndpointPath')
- [User](#T-EasyTravelWeb-Models-User 'EasyTravelWeb.Models.User')
  - [#ctor()](#M-EasyTravelWeb-Models-User-#ctor 'EasyTravelWeb.Models.User.#ctor')
  - [Email](#P-EasyTravelWeb-Models-User-Email 'EasyTravelWeb.Models.User.Email')
  - [FirstName](#P-EasyTravelWeb-Models-User-FirstName 'EasyTravelWeb.Models.User.FirstName')
  - [LastName](#P-EasyTravelWeb-Models-User-LastName 'EasyTravelWeb.Models.User.LastName')
  - [Password](#P-EasyTravelWeb-Models-User-Password 'EasyTravelWeb.Models.User.Password')
  - [UserId](#P-EasyTravelWeb-Models-User-UserId 'EasyTravelWeb.Models.User.UserId')
- [UserInfoViewModel](#T-EasyTravelWeb-Models-UserInfoViewModel 'EasyTravelWeb.Models.UserInfoViewModel')
  - [Email](#P-EasyTravelWeb-Models-UserInfoViewModel-Email 'EasyTravelWeb.Models.UserInfoViewModel.Email')
  - [HasRegistered](#P-EasyTravelWeb-Models-UserInfoViewModel-HasRegistered 'EasyTravelWeb.Models.UserInfoViewModel.HasRegistered')
  - [LoginProvider](#P-EasyTravelWeb-Models-UserInfoViewModel-LoginProvider 'EasyTravelWeb.Models.UserInfoViewModel.LoginProvider')
- [UserLoginInfoViewModel](#T-EasyTravelWeb-Models-UserLoginInfoViewModel 'EasyTravelWeb.Models.UserLoginInfoViewModel')
  - [LoginProvider](#P-EasyTravelWeb-Models-UserLoginInfoViewModel-LoginProvider 'EasyTravelWeb.Models.UserLoginInfoViewModel.LoginProvider')
  - [ProviderKey](#P-EasyTravelWeb-Models-UserLoginInfoViewModel-ProviderKey 'EasyTravelWeb.Models.UserLoginInfoViewModel.ProviderKey')
- [UserPlaceRating](#T-EasyTravelWeb-Models-UserPlaceRating 'EasyTravelWeb.Models.UserPlaceRating')
  - [PlaceId](#P-EasyTravelWeb-Models-UserPlaceRating-PlaceId 'EasyTravelWeb.Models.UserPlaceRating.PlaceId')
  - [Rating](#P-EasyTravelWeb-Models-UserPlaceRating-Rating 'EasyTravelWeb.Models.UserPlaceRating.Rating')
  - [UserId](#P-EasyTravelWeb-Models-UserPlaceRating-UserId 'EasyTravelWeb.Models.UserPlaceRating.UserId')
- [UserRepository](#T-EasyTravelWeb-Repositories-UserRepository 'EasyTravelWeb.Repositories.UserRepository')
  - [ChangeFirstName(id,firstName)](#M-EasyTravelWeb-Repositories-UserRepository-ChangeFirstName-System-Int32,System-String- 'EasyTravelWeb.Repositories.UserRepository.ChangeFirstName(System.Int32,System.String)')
  - [ChangeLastName(id,lastName)](#M-EasyTravelWeb-Repositories-UserRepository-ChangeLastName-System-Int32,System-String- 'EasyTravelWeb.Repositories.UserRepository.ChangeLastName(System.Int32,System.String)')
  - [GetUser(id)](#M-EasyTravelWeb-Repositories-UserRepository-GetUser-System-Int32- 'EasyTravelWeb.Repositories.UserRepository.GetUser(System.Int32)')
- [WebApiConfig](#T-EasyTravelWeb-WebApiConfig 'EasyTravelWeb.WebApiConfig')
  - [Register()](#M-EasyTravelWeb-WebApiConfig-Register-System-Web-Http-HttpConfiguration- 'EasyTravelWeb.WebApiConfig.Register(System.Web.Http.HttpConfiguration)')

<a name='assembly'></a>
# EasyTravelWeb [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-EasyTravelWeb-Controllers-AccountController'></a>
## AccountController [#](#T-EasyTravelWeb-Controllers-AccountController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for register, sign in or change User private info

<a name='M-EasyTravelWeb-Controllers-AccountController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-AccountController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}-'></a>
### #ctor(userManager,accessTokenFormat) `constructor` [#](#M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [EasyTravelWeb.ApplicationUserManager](#T-EasyTravelWeb-ApplicationUserManager 'EasyTravelWeb.ApplicationUserManager') | Identity User Manager |
| accessTokenFormat | [Microsoft.Owin.Security.ISecureDataFormat{Microsoft.Owin.Security.AuthenticationTicket}](#T-Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket} 'Microsoft.Owin.Security.ISecureDataFormat{Microsoft.Owin.Security.AuthenticationTicket}') | Token format |

<a name='F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator'></a>
### registerBindingModelValidator `constants` [#](#F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation model

<a name='F-EasyTravelWeb-Controllers-AccountController-userManager'></a>
### userManager `constants` [#](#F-EasyTravelWeb-Controllers-AccountController-userManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Aplication manager

<a name='P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat'></a>
### AccessTokenFormat `property` [#](#P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-AccountController-UserManager'></a>
### UserManager `property` [#](#P-EasyTravelWeb-Controllers-AccountController-UserManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-ProviderInfo-'></a>
### AddExternalLogin() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-ProviderInfo- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Authorization with External service (Facebook)

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel-'></a>
### ChangePassword(model) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Returns

Status code of result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.ChangePasswordBindingModel](#T-EasyTravelWeb-Models-ChangePasswordBindingModel 'EasyTravelWeb.Models.ChangePasswordBindingModel') | User Model for change password |

<a name='M-EasyTravelWeb-Controllers-AccountController-ConfirmEmail-System-Int32,System-String-'></a>
### ConfirmEmail() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-ConfirmEmail-System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User-'></a>
### ConfirmUser(user) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [EasyTravelWeb.Models.User](#T-EasyTravelWeb-Models-User 'EasyTravelWeb.Models.User') |  |

<a name='M-EasyTravelWeb-Controllers-AccountController-Dispose-System-Boolean-'></a>
### Dispose() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Dispose-System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-GetExternalLogin-System-String,System-String-'></a>
### GetExternalLogin() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-GetExternalLogin-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-GetExternalLogins-System-String,System-Boolean-'></a>
### GetExternalLogins() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-GetExternalLogins-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-GetManageInfo-System-String,System-Boolean-'></a>
### GetManageInfo() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-GetManageInfo-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-GetUserInfo'></a>
### GetUserInfo() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-GetUserInfo 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for get UserInfo

##### Returns

First, user information

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-Logout'></a>
### Logout() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Logout 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for logOut

##### Returns

Status code of request

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### Register(model) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers user in database

##### Returns

Http code according to success

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') | Object, which incapsulates user data, needed to register user(email, password, first name, last name) |

<a name='M-EasyTravelWeb-Controllers-AccountController-RegisterExternal-EasyTravelWeb-Models-RegisterExternalBindingModel-'></a>
### RegisterExternal() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-RegisterExternal-EasyTravelWeb-Models-RegisterExternalBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-RemoveLogin-EasyTravelWeb-Models-RemoveLoginBindingModel-'></a>
### RemoveLogin() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-RemoveLogin-EasyTravelWeb-Models-RemoveLoginBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-SetPassword-EasyTravelWeb-Models-SetPasswordBindingModel-'></a>
### SetPassword() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-SetPassword-EasyTravelWeb-Models-SetPasswordBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-AccountControllerConstants'></a>
## AccountControllerConstants [#](#T-EasyTravelWeb-Constants-Constants-AccountControllerConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for AccountController class.

<a name='F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-BitsPerByte'></a>
### BitsPerByte `constants` [#](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-BitsPerByte 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Number of bits per byte.

<a name='F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-LocalLoginProvider'></a>
### LocalLoginProvider `constants` [#](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-LocalLoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Name of local login provider.

<a name='F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-UrlForRedirectAfterEmailConfirmation'></a>
### UrlForRedirectAfterEmailConfirmation `constants` [#](#F-EasyTravelWeb-Constants-Constants-AccountControllerConstants-UrlForRedirectAfterEmailConfirmation 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

URL where user is redirected after email confirmation.

<a name='T-EasyTravelWeb-Models-AddExternalLoginBindingModel'></a>
## AddExternalLoginBindingModel [#](#T-EasyTravelWeb-Models-AddExternalLoginBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

Identity AddExternalLoginBindingModel

<a name='P-EasyTravelWeb-Models-AddExternalLoginBindingModel-ExternalAccessToken'></a>
### ExternalAccessToken `property` [#](#P-EasyTravelWeb-Models-AddExternalLoginBindingModel-ExternalAccessToken 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-ApplicationDbContext'></a>
## ApplicationDbContext [#](#T-EasyTravelWeb-Models-ApplicationDbContext 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='M-EasyTravelWeb-Models-ApplicationDbContext-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-ApplicationDbContext-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Models-ApplicationDbContext-Create'></a>
### Create() `method` [#](#M-EasyTravelWeb-Models-ApplicationDbContext-Create 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Providers-ApplicationOAuthProvider'></a>
## ApplicationOAuthProvider [#](#T-EasyTravelWeb-Providers-ApplicationOAuthProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Providers

##### Summary

App Configuration

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-#ctor-System-String-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-#ctor-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-CreateProperties-System-Int32,System-String,System-String-'></a>
### CreateProperties(idUser,userName,firstName) `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-CreateProperties-System-Int32,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Create properties, which are used later on frontend(localstorage)

##### Returns

Authentication properties

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| idUser | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id of user |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nickname of user |
| firstName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name of user |

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-DoesPasswordMatch-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext,EasyTravelWeb-ApplicationUserManager,EasyTravelWeb-Models-ApplicationUser-'></a>
### DoesPasswordMatch(context,userManager,userFoundByEmail) `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-DoesPasswordMatch-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext,EasyTravelWeb-ApplicationUserManager,EasyTravelWeb-Models-ApplicationUser- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext](#T-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext 'Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext') |  |
| userManager | [EasyTravelWeb.ApplicationUserManager](#T-EasyTravelWeb-ApplicationUserManager 'EasyTravelWeb.ApplicationUserManager') |  |
| userFoundByEmail | [EasyTravelWeb.Models.ApplicationUser](#T-EasyTravelWeb-Models-ApplicationUser 'EasyTravelWeb.Models.ApplicationUser') |  |

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext-'></a>
### GrantResourceOwnerCredentials(context) `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets a token for user, if user data is correct

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext](#T-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext 'Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext') | Contains information about user credentials |

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext-'></a>
### TokenEndpoint(context) `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Last point of authentication workflow. Sets response

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Owin.Security.OAuth.OAuthTokenEndpointContext](#T-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext 'Microsoft.Owin.Security.OAuth.OAuthTokenEndpointContext') | Contains information about user credentials |

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext-'></a>
### ValidateClientAuthentication(context) `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Entry point of authentication workflow

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Owin.Security.OAuth.OAuthValidateClientAuthenticationContext](#T-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext 'Microsoft.Owin.Security.OAuth.OAuthValidateClientAuthenticationContext') | Contains information about user credentials |

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientRedirectUri-Microsoft-Owin-Security-OAuth-OAuthValidateClientRedirectUriContext-'></a>
### ValidateClientRedirectUri() `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientRedirectUri-Microsoft-Owin-Security-OAuth-OAuthValidateClientRedirectUriContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Models-ApplicationUser'></a>
## ApplicationUser [#](#T-EasyTravelWeb-Models-ApplicationUser 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

IdentityUser

<a name='P-EasyTravelWeb-Models-ApplicationUser-FirstName'></a>
### FirstName `property` [#](#P-EasyTravelWeb-Models-ApplicationUser-FirstName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ApplicationUser-LastName'></a>
### LastName `property` [#](#P-EasyTravelWeb-Models-ApplicationUser-LastName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Models-ApplicationUser-GenerateUserIdentityAsync-Microsoft-AspNet-Identity-UserManager{EasyTravelWeb-Models-ApplicationUser,System-Int32},System-String-'></a>
### GenerateUserIdentityAsync() `method` [#](#M-EasyTravelWeb-Models-ApplicationUser-GenerateUserIdentityAsync-Microsoft-AspNet-Identity-UserManager{EasyTravelWeb-Models-ApplicationUser,System-Int32},System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-ApplicationUserManager'></a>
## ApplicationUserManager [#](#T-EasyTravelWeb-ApplicationUserManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Model of User in Identity

<a name='M-EasyTravelWeb-ApplicationUserManager-#ctor-Microsoft-AspNet-Identity-IUserStore{EasyTravelWeb-Models-ApplicationUser,System-Int32}-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-ApplicationUserManager-#ctor-Microsoft-AspNet-Identity-IUserStore{EasyTravelWeb-Models-ApplicationUser,System-Int32}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-ApplicationUserManager-Create-Microsoft-AspNet-Identity-Owin-IdentityFactoryOptions{EasyTravelWeb-ApplicationUserManager},Microsoft-Owin-IOwinContext-'></a>
### Create() `method` [#](#M-EasyTravelWeb-ApplicationUserManager-Create-Microsoft-AspNet-Identity-Owin-IdentityFactoryOptions{EasyTravelWeb-ApplicationUserManager},Microsoft-Owin-IOwinContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Models-BlaBlaCarResponse-BadResponse'></a>
## BadResponse [#](#T-EasyTravelWeb-Models-BlaBlaCarResponse-BadResponse 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models.BlaBlaCarResponse

##### Summary

model of error from request

<a name='T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser'></a>
## BlaBlaCarResultParser [#](#T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Services.BlaBlaCar

##### Summary

parse response from blablacar

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-BadResult-System-Net-Http-HttpResponseMessage-'></a>
### BadResult(response) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-BadResult-System-Net-Http-HttpResponseMessage- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

parse response from bad result

##### Returns

info about error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | response from blablacar |

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-SuccessResult-System-Net-Http-HttpResponseMessage-'></a>
### SuccessResult(response) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarResultParser-SuccessResult-System-Net-Http-HttpResponseMessage- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

parse response from success result

##### Returns

info about trips

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | response from blablacar |

<a name='T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService'></a>
## BlaBlaCarService [#](#T-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Services.BlaBlaCar

##### Summary



<a name='F-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-urlParameters'></a>
### urlParameters `constants` [#](#F-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-urlParameters 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

url with params

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddHeaders-System-Net-Http-HttpClient,System-String,System-String-'></a>
### AddHeaders(client,header,value) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddHeaders-System-Net-Http-HttpClient,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

add headers to request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') | http client |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | name of header |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | value of header |

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddParam-System-String,System-String-'></a>
### AddParam(name,value) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-AddParam-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

create request with params

##### Returns

new url with add params

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | name of param |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | value of param |

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String,System-DateTime-'></a>
### BlaBlaCarRequest(fromCity,toCity,travelDate) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String,System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

create request with params

##### Returns

info about trips

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | departure city |
| toCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | arrival city |
| travelDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Date of trip |

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String-'></a>
### BlaBlaCarRequest(fromCity,toCity) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-BlaBlaCarRequest-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

create request with params

##### Returns

info about trips

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | departure city |
| toCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | arrival city |

<a name='M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-SendRequest-System-String-'></a>
### SendRequest(urlParams) `method` [#](#M-EasyTravelWeb-Services-BlaBlaCar-BlaBlaCarService-SendRequest-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

send request with params

##### Returns

response from blablacar

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlParams | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | url for with params for request |

<a name='T-EasyTravelWeb-BundleConfig'></a>
## BundleConfig [#](#T-EasyTravelWeb-BundleConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Bundle logic

<a name='M-EasyTravelWeb-BundleConfig-RegisterBundles-System-Web-Optimization-BundleCollection-'></a>
### RegisterBundles() `method` [#](#M-EasyTravelWeb-BundleConfig-RegisterBundles-System-Web-Optimization-BundleCollection- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Register Bundles

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Results-ChallengeResult'></a>
## ChallengeResult [#](#T-EasyTravelWeb-Results-ChallengeResult 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Results

##### Summary



<a name='M-EasyTravelWeb-Results-ChallengeResult-#ctor-System-String,System-Web-Http-ApiController-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Results-ChallengeResult-#ctor-System-String,System-Web-Http-ApiController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='P-EasyTravelWeb-Results-ChallengeResult-LoginProvider'></a>
### LoginProvider `property` [#](#P-EasyTravelWeb-Results-ChallengeResult-LoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Results-ChallengeResult-Request'></a>
### Request `property` [#](#P-EasyTravelWeb-Results-ChallengeResult-Request 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Results-ChallengeResult-ExecuteAsync-System-Threading-CancellationToken-'></a>
### ExecuteAsync() `method` [#](#M-EasyTravelWeb-Results-ChallengeResult-ExecuteAsync-System-Threading-CancellationToken- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Models-ChangePasswordBindingModel'></a>
## ChangePasswordBindingModel [#](#T-EasyTravelWeb-Models-ChangePasswordBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-ChangePasswordBindingModel-ConfirmPassword'></a>
### ConfirmPassword `property` [#](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-ConfirmPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ChangePasswordBindingModel-NewPassword'></a>
### NewPassword `property` [#](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-NewPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ChangePasswordBindingModel-OldPassword'></a>
### OldPassword `property` [#](#P-EasyTravelWeb-Models-ChangePasswordBindingModel-OldPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-City'></a>
## City [#](#T-EasyTravelWeb-Models-City 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-City-CityRating'></a>
### CityRating `property` [#](#P-EasyTravelWeb-Models-City-CityRating 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-City-Description'></a>
### Description `property` [#](#P-EasyTravelWeb-Models-City-Description 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-City-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Models-City-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-City-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-City-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-City-PicturePath'></a>
### PicturePath `property` [#](#P-EasyTravelWeb-Models-City-PicturePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Controllers-CityController'></a>
## CityController [#](#T-EasyTravelWeb-Controllers-CityController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

*Inherit from parent.*

##### Summary

Controller for get and set info about cities

<a name='M-EasyTravelWeb-Controllers-CityController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-CityController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

*Inherit from parent.*

##### Summary

Default constructor

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-#ctor-EasyTravelWeb-Repositories-CityRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-CityController-#ctor-EasyTravelWeb-Repositories-CityRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

*Inherit from parent.*

##### Summary

Constructor with params

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32-'></a>
### GetCities(page,pageSize) `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for getting Cities

##### Returns

Status code with list of cities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of current page |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Count of cities on the page |

<a name='M-EasyTravelWeb-Controllers-CityController-GetCity-System-Int32-'></a>
### GetCity(id) `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetCity-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for getting City

##### Returns

Status code with city model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | City ID |

<a name='M-EasyTravelWeb-Controllers-CityController-GetCountCity'></a>
### GetCountCity() `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetCountCity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for getting count of Cities

##### Returns

Status code with count of cities

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-GetTopCities-System-Int32-'></a>
### GetTopCities() `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetTopCities-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for getting Top of Cities

##### Returns

Status code with top cities

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Repositories-CityRepository'></a>
## CityRepository [#](#T-EasyTravelWeb-Repositories-CityRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary

Repository for get data about City

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCitiesIdAndNames'></a>
### GetCitiesIdAndNames() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesIdAndNames 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get id and name of cities from DataBase

##### Returns

list of ids and names

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32-'></a>
### GetCitiesPage(page,pageSize) `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get a few cities from DataBase

##### Returns

list of cities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of page |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | count of cities on page |

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64-'></a>
### GetCity(id) `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get info about city from DataBase

##### Returns

Info about current city

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of city |

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCountCity'></a>
### GetCountCity() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCountCity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get info about count of cities in DataBase

##### Returns

Count of cities

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetTopCities-System-Int32-'></a>
### GetTopCities(numberOfTopCities) `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetTopCities-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns list of top cities according to their rating

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfTopCities | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of cities with higher rating to show |

<a name='T-EasyTravelWeb-Models-SearchEntities-CitySearchEntity'></a>
## CitySearchEntity [#](#T-EasyTravelWeb-Models-SearchEntities-CitySearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models.SearchEntities

##### Summary

Provides info about a city for searching.

<a name='P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of a city.

<a name='P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of a city.

<a name='P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Models-SearchEntities-CitySearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type is necessary for distinguishing SearchItems on Front-End.

<a name='T-EasyTravelWeb-Constants-Constants-ConfigurationConstants'></a>
## ConfigurationConstants [#](#T-EasyTravelWeb-Constants-Constants-ConfigurationConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for Configuration class.

<a name='F-EasyTravelWeb-Constants-Constants-ConfigurationConstants-ContextKey'></a>
### ContextKey `constants` [#](#F-EasyTravelWeb-Constants-Constants-ConfigurationConstants-ContextKey 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

String used to distinguish migrations.

<a name='T-EasyTravelWeb-Constants-Constants-ConnectionStrings'></a>
## ConnectionStrings [#](#T-EasyTravelWeb-Constants-Constants-ConnectionStrings 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides connection strings.

<a name='T-EasyTravelWeb-Constants-Constants'></a>
## Constants [#](#T-EasyTravelWeb-Constants-Constants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants

##### Summary

Provides constants for all classes of EasyTravelWeb project.

<a name='T-EasyTravelWeb-CORSConfig'></a>
## CORSConfig [#](#T-EasyTravelWeb-CORSConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Cors Configuration

<a name='F-EasyTravelWeb-CORSConfig-CorsPolicy'></a>
### CorsPolicy `constants` [#](#F-EasyTravelWeb-CORSConfig-CorsPolicy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

CORS Polisy for allow requests from FrontEnd

<a name='T-EasyTravelWeb-Constants-Constants-CORSConstants'></a>
## CORSConstants [#](#T-EasyTravelWeb-Constants-Constants-CORSConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for CORSConfig class

<a name='F-EasyTravelWeb-Constants-Constants-CORSConstants-FrontEndUrl'></a>
### FrontEndUrl `constants` [#](#F-EasyTravelWeb-Constants-Constants-CORSConstants-FrontEndUrl 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Origin of Cors Policy.

<a name='T-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials'></a>
## Credentials [#](#T-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants.EmailServiceConstants

##### Summary

Provides credentials for EmailService class.

<a name='F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Email'></a>
### Email `constants` [#](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Email that is used for sending requests for confirmation of user email.

<a name='F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Password'></a>
### Password `constants` [#](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-Credentials-Password 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-CustomRole'></a>
## CustomRole [#](#T-EasyTravelWeb-Models-CustomRole 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='M-EasyTravelWeb-Models-CustomRole-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-CustomRole-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Models-CustomRole-#ctor-System-String-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-CustomRole-#ctor-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='T-EasyTravelWeb-Models-CustomRoleStore'></a>
## CustomRoleStore [#](#T-EasyTravelWeb-Models-CustomRoleStore 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='M-EasyTravelWeb-Models-CustomRoleStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-CustomRoleStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='T-EasyTravelWeb-Models-CustomUserClaim'></a>
## CustomUserClaim [#](#T-EasyTravelWeb-Models-CustomUserClaim 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='T-EasyTravelWeb-Models-CustomUserLogin'></a>
## CustomUserLogin [#](#T-EasyTravelWeb-Models-CustomUserLogin 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='T-EasyTravelWeb-Models-CustomUserRole'></a>
## CustomUserRole [#](#T-EasyTravelWeb-Models-CustomUserRole 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='T-EasyTravelWeb-Models-CustomUserStore'></a>
## CustomUserStore [#](#T-EasyTravelWeb-Models-CustomUserStore 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='M-EasyTravelWeb-Models-CustomUserStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-CustomUserStore-#ctor-EasyTravelWeb-Models-ApplicationDbContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-DataValidationConstants'></a>
## DataValidationConstants [#](#T-EasyTravelWeb-Constants-Constants-DataValidationConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for data validation.

<a name='F-EasyTravelWeb-Constants-Constants-DataValidationConstants-EmailPattern'></a>
### EmailPattern `constants` [#](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-EmailPattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by an email.

##### Example

some@domain.com

<a name='F-EasyTravelWeb-Constants-Constants-DataValidationConstants-MinimumPasswordLength'></a>
### MinimumPasswordLength `constants` [#](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-MinimumPasswordLength 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Minimum amount of password characters.

<a name='F-EasyTravelWeb-Constants-Constants-DataValidationConstants-NamePattern'></a>
### NamePattern `constants` [#](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-NamePattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by first name or last name.

##### Example

Petro

<a name='F-EasyTravelWeb-Constants-Constants-DataValidationConstants-PasswordPattern'></a>
### PasswordPattern `constants` [#](#F-EasyTravelWeb-Constants-Constants-DataValidationConstants-PasswordPattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by a password.

##### Example

Aa1111!@

<a name='T-EasyTravelWeb-Services-EmailService'></a>
## EmailService [#](#T-EasyTravelWeb-Services-EmailService 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Services

##### Summary

Service for sending email

<a name='M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage-'></a>
### SendAsync() `method` [#](#M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sends email to user

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-EmailServiceConstants'></a>
## EmailServiceConstants [#](#T-EasyTravelWeb-Constants-Constants-EmailServiceConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for EmailService class

<a name='F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientHost'></a>
### SmtpClientHost `constants` [#](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientHost 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Host for SmtpClient.

<a name='F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientPort'></a>
### SmtpClientPort `constants` [#](#F-EasyTravelWeb-Constants-Constants-EmailServiceConstants-SmtpClientPort 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Port for SmtpClient.

<a name='T-EasyTravelWeb-Infrastructure-Validators-EmailValidator'></a>
## EmailValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-EmailValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary

Validates user's email

<a name='M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes instance of the EmailValidator class.

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Logger class for logging exceptions.

<a name='F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-validationRegister'></a>
### validationRegister `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-EmailValidator-validationRegister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation register.

<a name='M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-emailIsValid-System-String-'></a>
### emailIsValid(email) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-emailIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the email is valid.

##### Returns

True if the email is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | email |

<a name='M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-GetValidationData-System-String-'></a>
### GetValidationData(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-GetValidationData-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of User's email. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's email |

<a name='M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-isEmailMetPatternRequirements-System-String-'></a>
### isEmailMetPatternRequirements(email) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-isEmailMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the email is met pattern requirements.

##### Returns

True if the email is met pattern requirements, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | email |

<a name='M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-IsValid-System-String-'></a>
### IsValid(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-EmailValidator-IsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if user's emal is valid.

##### Returns

True if user's email is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's email. |

<a name='T-EasyTravelWeb-Services-ExternalLoginVerificator'></a>
## ExternalLoginVerificator [#](#T-EasyTravelWeb-Services-ExternalLoginVerificator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Services

<a name='M-EasyTravelWeb-Services-ExternalLoginVerificator-VerifyFacebookAccessToken-System-String-'></a>
### VerifyFacebookAccessToken(accessToken) `method` [#](#M-EasyTravelWeb-Services-ExternalLoginVerificator-VerifyFacebookAccessToken-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyTravelWeb-Models-ExternalLoginViewModel'></a>
## ExternalLoginViewModel [#](#T-EasyTravelWeb-Models-ExternalLoginViewModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

Models returned by AccountController actions.

<a name='P-EasyTravelWeb-Models-ExternalLoginViewModel-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ExternalLoginViewModel-State'></a>
### State `property` [#](#P-EasyTravelWeb-Models-ExternalLoginViewModel-State 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ExternalLoginViewModel-Url'></a>
### Url `property` [#](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Url 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-FacebookUserViewModel'></a>
## FacebookUserViewModel [#](#T-EasyTravelWeb-Models-FacebookUserViewModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

<a name='P-EasyTravelWeb-Models-FacebookUserViewModel-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-FacebookUserViewModel-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-FacebookUserViewModel-FirstName'></a>
### FirstName `property` [#](#P-EasyTravelWeb-Models-FacebookUserViewModel-FirstName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-FacebookUserViewModel-ID'></a>
### ID `property` [#](#P-EasyTravelWeb-Models-FacebookUserViewModel-ID 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-FacebookUserViewModel-LastName'></a>
### LastName `property` [#](#P-EasyTravelWeb-Models-FacebookUserViewModel-LastName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-FacebookUserViewModel-Username'></a>
### Username `property` [#](#P-EasyTravelWeb-Models-FacebookUserViewModel-Username 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-FavoritePlace'></a>
## FavoritePlace [#](#T-EasyTravelWeb-Models-FavoritePlace 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-FavoritePlace-PlaceId'></a>
### PlaceId `property` [#](#P-EasyTravelWeb-Models-FavoritePlace-PlaceId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-FavoritePlace-UserId'></a>
### UserId `property` [#](#P-EasyTravelWeb-Models-FavoritePlace-UserId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-Filter'></a>
## Filter [#](#T-EasyTravelWeb-Models-Filter 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

Filters for places

<a name='T-EasyTravelWeb-FilterConfig'></a>
## FilterConfig [#](#T-EasyTravelWeb-FilterConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Filter config

<a name='M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection-'></a>
### RegisterGlobalFilters() `method` [#](#M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Register Global Filters

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Models-SearchEntities-ISearchEntity'></a>
## ISearchEntity [#](#T-EasyTravelWeb-Models-SearchEntities-ISearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models.SearchEntities

##### Summary

Provides members for SearchEntities types.

<a name='P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of SearchEntity.

<a name='P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Name of SearchEntity.

<a name='P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Models-SearchEntities-ISearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of SearchEntity.

<a name='T-EasyTravelWeb-Infrastructure-Validators-IValidator`1'></a>
## IValidator\`1 [#](#T-EasyTravelWeb-Infrastructure-Validators-IValidator`1 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary

Defines methods for data validation

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type that contains data that must be validated |

<a name='M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-GetValidationData-`0-'></a>
### GetValidationData(obj) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-GetValidationData-`0- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns an information about a validation process

##### Returns

Information about validation process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`0](#T-`0 '`0') | Type that contains data that must be validated |

<a name='M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-IsValid-`0-'></a>
### IsValid(obj) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-IValidator`1-IsValid-`0- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if a data is valid

##### Returns

True when a data is valid. Otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`0](#T-`0 '`0') | Type that contains data that must be validated |

<a name='T-EasyTravelWeb-Infrastructure-Logger'></a>
## Logger [#](#T-EasyTravelWeb-Infrastructure-Logger 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure

##### Summary

Logs application exceptions and messages into EasyTravelLog.txt in C:\Users\current user's directory

<a name='M-EasyTravelWeb-Infrastructure-Logger-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Logger-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Prevents a default instance of the Logger class from being created

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Logger-FileStream'></a>
### FileStream `constants` [#](#F-EasyTravelWeb-Infrastructure-Logger-FileStream 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Stream class

<a name='F-EasyTravelWeb-Infrastructure-Logger-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Logger-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The only one instance of the Logger class

<a name='F-EasyTravelWeb-Infrastructure-Logger-streamWriter'></a>
### streamWriter `constants` [#](#F-EasyTravelWeb-Infrastructure-Logger-streamWriter 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the StreamWriter class

<a name='M-EasyTravelWeb-Infrastructure-Logger-#cctor'></a>
### #cctor() `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-#cctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. Given that check for the type being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Infrastructure-Logger-AsyncLogException-System-Exception-'></a>
### AsyncLogException(ex) `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-AsyncLogException-System-Exception- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Writes the exception details into the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Instence of the Exception class. |

<a name='M-EasyTravelWeb-Infrastructure-Logger-AsyncLogMessage-System-String-'></a>
### AsyncLogMessage(message) `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-AsyncLogMessage-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Writes the message into the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that should be logged. |

<a name='M-EasyTravelWeb-Infrastructure-Logger-Finalize'></a>
### Finalize() `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-Finalize 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Finalizes an instance of the Logger class

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Infrastructure-Logger-GetInstance'></a>
### GetInstance() `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-GetInstance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a new instance of the Logger class for exceptions logging.

##### Returns

Instance of the Logger class.

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-LoggerConstants'></a>
## LoggerConstants [#](#T-EasyTravelWeb-Constants-Constants-LoggerConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for Logger class.

<a name='F-EasyTravelWeb-Constants-Constants-LoggerConstants-PathForFileStream'></a>
### PathForFileStream `constants` [#](#F-EasyTravelWeb-Constants-Constants-LoggerConstants-PathForFileStream 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The path to the file in which exceptions are logged.

<a name='T-EasyTravelWeb-Controllers-MainPageController'></a>
## MainPageController [#](#T-EasyTravelWeb-Controllers-MainPageController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for the default page which informs about the app running

<a name='M-EasyTravelWeb-Controllers-MainPageController-Index'></a>
### Index() `method` [#](#M-EasyTravelWeb-Controllers-MainPageController-Index 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a ViewResult object that rensers a view to the MainPage

##### Returns

A ViewResult object that rensers a view to the MainPage

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Models-ManageInfoViewModel'></a>
## ManageInfoViewModel [#](#T-EasyTravelWeb-Models-ManageInfoViewModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-ManageInfoViewModel-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-ManageInfoViewModel-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ManageInfoViewModel-ExternalLoginProviders'></a>
### ExternalLoginProviders `property` [#](#P-EasyTravelWeb-Models-ManageInfoViewModel-ExternalLoginProviders 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ManageInfoViewModel-LocalLoginProvider'></a>
### LocalLoginProvider `property` [#](#P-EasyTravelWeb-Models-ManageInfoViewModel-LocalLoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ManageInfoViewModel-Logins'></a>
### Logins `property` [#](#P-EasyTravelWeb-Models-ManageInfoViewModel-Logins 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-MvcApplication'></a>
## MvcApplication [#](#T-EasyTravelWeb-MvcApplication 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Start App

<a name='M-EasyTravelWeb-MvcApplication-Application_Start'></a>
### Application_Start() `method` [#](#M-EasyTravelWeb-MvcApplication-Application_Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Infrastructure-Validators-NameValidator'></a>
## NameValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-NameValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary

Validates user's name

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes instance of the NameValidator class.

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Validators-NameValidator-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-NameValidator-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Logger class for logging exceptions.

<a name='F-EasyTravelWeb-Infrastructure-Validators-NameValidator-validationRegister'></a>
### validationRegister `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-NameValidator-validationRegister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation register.

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameValidator-GetValidationData-System-String-'></a>
### GetValidationData(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-GetValidationData-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of User's name. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's name |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameValidator-isNameMetPatternRequirements-System-String-'></a>
### isNameMetPatternRequirements(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-isNameMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if a name is met pattern requirements.

##### Returns

True if a name is met pattern requirements, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's name |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameValidator-IsValid-System-String-'></a>
### IsValid(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-IsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if user's name is valid.

##### Returns

True if user's name is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's name. |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameValidator-nameIsValid-System-String-'></a>
### nameIsValid(firstName) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameValidator-nameIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if a name is valid.

##### Returns

True if a name is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| firstName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name |

<a name='T-EasyTravelWeb-Models-BlaBlaCarResponse-OKResponse'></a>
## OKResponse [#](#T-EasyTravelWeb-Models-BlaBlaCarResponse-OKResponse 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models.BlaBlaCarResponse

##### Summary

info model from success request

<a name='T-EasyTravelWeb-Infrastructure-Validators-PasswordValidator'></a>
## PasswordValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-PasswordValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary

Validates user's password

<a name='M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes instance of the PasswordValidator class.

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Logger class for logging exceptions.

<a name='F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-validationRegister'></a>
### validationRegister `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-validationRegister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation register.

<a name='M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-GetValidationData-System-String-'></a>
### GetValidationData(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-GetValidationData-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of User's password. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's password |

<a name='M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordMetPatternRequirements-System-String-'></a>
### isPasswordMetPatternRequirements(password) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the password is met pattern requirements.

##### Returns

True if the password is met pattern requirements, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's assword |

<a name='M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordValid-System-String-'></a>
### isPasswordValid(password) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-isPasswordValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the password is valid.

##### Returns

True if the password is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's password |

<a name='M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-IsValid-System-String-'></a>
### IsValid(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-PasswordValidator-IsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if user's password is valid.

##### Returns

True if user's password is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User's password. |

<a name='T-EasyTravelWeb-Models-Place'></a>
## Place [#](#T-EasyTravelWeb-Models-Place 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

Place Model

<a name='M-EasyTravelWeb-Models-Place-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-Place-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='P-EasyTravelWeb-Models-Place-CityId'></a>
### CityId `property` [#](#P-EasyTravelWeb-Models-Place-CityId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-CityName'></a>
### CityName `property` [#](#P-EasyTravelWeb-Models-Place-CityName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-Description'></a>
### Description `property` [#](#P-EasyTravelWeb-Models-Place-Description 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-Place-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-PicturePlace'></a>
### PicturePlace `property` [#](#P-EasyTravelWeb-Models-Place-PicturePlace 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-PlaceId'></a>
### PlaceId `property` [#](#P-EasyTravelWeb-Models-Place-PlaceId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-Place-PlaceRating'></a>
### PlaceRating `property` [#](#P-EasyTravelWeb-Models-Place-PlaceRating 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Controllers-PlaceController'></a>
## PlaceController [#](#T-EasyTravelWeb-Controllers-PlaceController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller model for get info about places

<a name='M-EasyTravelWeb-Controllers-PlaceController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-PlaceController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Default constructor

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-AddUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace-'></a>
### AddUserFavoritePlace(favoriteUserPlace) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for add place to favorite by user

##### Returns

Result of request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| favoriteUserPlace | [EasyTravelWeb.Models.FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace') | Favorite User Model |

<a name='M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace-'></a>
### DeleteUserFavoritePlace(favoriteUserPlace) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for delete place from favorite by user

##### Returns

Result of request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| favoriteUserPlace | [EasyTravelWeb.Models.FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace') | Favorite User Model |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetCountFromFilteredPlaces-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}-'></a>
### GetCountFromFilteredPlaces(filters) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetCountFromFilteredPlaces-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller method for getting count of filtered places

##### Returns

Count of filtered places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filters | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Collection of filters, which you want to apply for search |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetFilteredPlacesByCityId-System-Int64,System-Int32,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}-'></a>
### GetFilteredPlacesByCityId(filters) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetFilteredPlacesByCityId-System-Int64,System-Int32,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller method for getting filtered places

##### Returns

Collection of filtered places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filters | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Collection of filters, which you want to apply for search |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlaceById-System-Int64-'></a>
### GetPlaceById(placeId) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceById-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller for get info about place

##### Returns

Status code with place model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current place |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlaceFilters-System-Int64-'></a>
### GetPlaceFilters() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceFilters-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller method for filters of specific city

##### Returns

List of filters for specific place

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlaceRating-System-Int64-'></a>
### GetPlaceRating(placeId) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceRating-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Contoller for get rating of place

##### Returns

Status code with place rating

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current place |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32-'></a>
### GetPlacesPageByCityId(cityId,page,pageSize) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Contoller for get places of some city for some page

##### Returns

Status code with places list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current city |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of the page |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Count of places on page |

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64,System-Int32-'></a>
### GetTopPlacesByCityId(cityId) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Contoller for get top places of current city

##### Returns

Status code with list of top places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current city |

<a name='T-EasyTravelWeb-Repositories-PlaceRepository'></a>
## PlaceRepository [#](#T-EasyTravelWeb-Repositories-PlaceRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary

Repository for get info about places

<a name='F-EasyTravelWeb-Repositories-PlaceRepository-noRowsAffected'></a>
### noRowsAffected `constants` [#](#F-EasyTravelWeb-Repositories-PlaceRepository-noRowsAffected 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Means that no rows were affected by SQL command.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-AddFavoritePlace-System-Int32,System-Int64-'></a>
### AddFavoritePlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-AddFavoritePlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

add place to user favorite in DataBase

##### Returns

bool value (true if success request, false if fail)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64-'></a>
### DeleteFavoritePlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

delete place from user favorite in DataBase

##### Returns

bool value (true if success request, false if fail)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64-'></a>
### GetCountPlace(cityId) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get count of places in city

##### Returns

count of places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of city |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32-'></a>
### GetFavoritePlaces(id) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get user favorite places from DataBase

##### Returns

list of user favorite places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredCountPlace-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}-'></a>
### GetFilteredCountPlace(filters) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredCountPlace-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method which takes count fo filtered places from databse

##### Returns

Count of places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filters | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Collection of filters, which you want to apply for search |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredPlacesPage-System-Int32,System-Int64,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}-'></a>
### GetFilteredPlacesPage(filters) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredPlacesPage-System-Int32,System-Int64,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets list of places accodring to setected filters

##### Returns

List of places according to list of filters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filters | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | List of filters |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceById-System-Int64-'></a>
### GetPlaceById(placeId) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceById-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get info about place from DataBase

##### Returns

Info about current place

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceFilters-System-Int64-'></a>
### GetPlaceFilters() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceFilters-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method which takes filter of specific place

##### Returns

list of place filters

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceRating-System-Int64-'></a>
### GetPlaceRating(placeId) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceRating-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get rating of place from DataBase

##### Returns

rating of place

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames'></a>
### GetPlacesIdsAndNames() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get id and name of places from DataBase

##### Returns

list of ids and names

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32-'></a>
### GetPlacesPage(page,cityId,pageSize) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get places for page from DataBase

##### Returns

list of places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of the page |
| cityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current city |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | count of place on the page |

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64,System-Int32-'></a>
### GetTopPlacesByCityId(cityId,numberOfTopPlaces) `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get top places from DataBase

##### Returns

list of top places by place rating

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cityId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current city |
| numberOfTopPlaces | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of places with higher rating to show |

<a name='T-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity'></a>
## PlaceSearchEntity [#](#T-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models.SearchEntities

##### Summary

Provides info about a place for searching.

<a name='P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-CityId'></a>
### CityId `property` [#](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-CityId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of a city.

<a name='P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of a place.

<a name='P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

ID of a place.

<a name='P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Models-SearchEntities-PlaceSearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type is necessary for distinguishing SearchItems on Front-End.

<a name='T-EasyTravelWeb-Controllers-ProfileController'></a>
## ProfileController [#](#T-EasyTravelWeb-Controllers-ProfileController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for Profile page

<a name='M-EasyTravelWeb-Controllers-ProfileController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-ProfileController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Default constructor

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-UserRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-UserRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-PlaceRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-PlaceRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Controllers-ProfileController-nameValidator'></a>
### nameValidator `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-nameValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validator for first and last name

<a name='F-EasyTravelWeb-Controllers-ProfileController-placeRepository'></a>
### placeRepository `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-placeRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of PlaceRepository, using method to get favourite places for user from database

<a name='F-EasyTravelWeb-Controllers-ProfileController-ratingRepository'></a>
### ratingRepository `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-ratingRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of RatingRepository, using methods to do actions with database

<a name='F-EasyTravelWeb-Controllers-ProfileController-userRepository'></a>
### userRepository `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-userRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of UserRepository, using methods to do actions with database

<a name='M-EasyTravelWeb-Controllers-ProfileController-ChangeFirstName-System-Int32,System-String-'></a>
### ChangeFirstName(id,firstName) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-ChangeFirstName-System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for changing first name of a user

##### Returns

result of chaning (Bad or Ok)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id of current user |
| firstName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name which will be updated in database |

<a name='M-EasyTravelWeb-Controllers-ProfileController-ChangeLastName-System-Int32,System-String-'></a>
### ChangeLastName(id,lastName) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-ChangeLastName-System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for changing first name of a user

##### Returns

result of chaning (Bad or Ok)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id of current user |
| lastName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Last name which will be updated in database |

<a name='M-EasyTravelWeb-Controllers-ProfileController-DeleteUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating-'></a>
### DeleteUserRatingForPlace(userRating) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-DeleteUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo delete rating of place of specific user

##### Returns

Status code for request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userRating | [EasyTravelWeb.Models.UserPlaceRating](#T-EasyTravelWeb-Models-UserPlaceRating 'EasyTravelWeb.Models.UserPlaceRating') | Model UserPlaceRating |

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32-'></a>
### GetFavoritePlaces(id) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo getting favorite places of specific user

##### Returns

List of favourite Places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetUserInfo-System-Int32-'></a>
### GetUserInfo(id) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetUserInfo-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for getting User from Db

##### Returns

First, last, email of user

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | id of current user |

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64-'></a>
### GetUserRatingOfPlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo getting rating place of specific user

##### Returns

Status code with user rating of place

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of current place |

<a name='M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating-'></a>
### SetUserRatingForPlace(userRating) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo setting rating of place of specific user

##### Returns

Status code for request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userRating | [EasyTravelWeb.Models.UserPlaceRating](#T-EasyTravelWeb-Models-UserPlaceRating 'EasyTravelWeb.Models.UserPlaceRating') | Model UserPlaceRating |

<a name='T-EasyTravelWeb-Models-ProviderInfo'></a>
## ProviderInfo [#](#T-EasyTravelWeb-Models-ProviderInfo 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

<a name='P-EasyTravelWeb-Models-ProviderInfo-AccessToken'></a>
### AccessToken `property` [#](#P-EasyTravelWeb-Models-ProviderInfo-AccessToken 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-ProviderInfo-Provider'></a>
### Provider `property` [#](#P-EasyTravelWeb-Models-ProviderInfo-Provider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Repositories-RatingRepository'></a>
## RatingRepository [#](#T-EasyTravelWeb-Repositories-RatingRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary

Repository for get info about user rating

<a name='F-EasyTravelWeb-Repositories-RatingRepository-noRowsAffected'></a>
### noRowsAffected `constants` [#](#F-EasyTravelWeb-Repositories-RatingRepository-noRowsAffected 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Means that no rows were affected by SQL command.

<a name='M-EasyTravelWeb-Repositories-RatingRepository-DeleteUserRatingForPlace-System-Int32,System-Int64-'></a>
### DeleteUserRatingForPlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Repositories-RatingRepository-DeleteUserRatingForPlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

delete user rating from DataBase

##### Returns

bool value(true if success request, false if fail)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64-'></a>
### GetUserRatingOfPlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get user rating of place from DataBase

##### Returns

user rating of place

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| placeId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | ID of place |

<a name='M-EasyTravelWeb-Repositories-RatingRepository-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating-'></a>
### SetUserRatingForPlace(userRating) `method` [#](#M-EasyTravelWeb-Repositories-RatingRepository-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

set user rating in DataBase

##### Returns

bool value(true if success request, false if fail)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userRating | [EasyTravelWeb.Models.UserPlaceRating](#T-EasyTravelWeb-Models-UserPlaceRating 'EasyTravelWeb.Models.UserPlaceRating') | User Place Rating model (user id, place id, rating) |

<a name='T-EasyTravelWeb-Models-RegisterBindingModel'></a>
## RegisterBindingModel [#](#T-EasyTravelWeb-Models-RegisterBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterBindingModel-ConfirmPassword'></a>
### ConfirmPassword `property` [#](#P-EasyTravelWeb-Models-RegisterBindingModel-ConfirmPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterBindingModel-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-RegisterBindingModel-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterBindingModel-FirstName'></a>
### FirstName `property` [#](#P-EasyTravelWeb-Models-RegisterBindingModel-FirstName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterBindingModel-LastName'></a>
### LastName `property` [#](#P-EasyTravelWeb-Models-RegisterBindingModel-LastName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterBindingModel-Password'></a>
### Password `property` [#](#P-EasyTravelWeb-Models-RegisterBindingModel-Password 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator'></a>
## RegisterBindingModelValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary

*Inherit from parent.*

##### Summary

RegisterBindingModelValidator logic

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes instance of the RegisterBindingModelValidator class.

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailValidator'></a>
### emailValidator `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the class that implements IValidator interface for email validation.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Logger class for logging exceptions.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-nameValidator'></a>
### nameValidator `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-nameValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the class that implements IValidator interface for name validation.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordValidator'></a>
### passwordValidator `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the class that implements IValidator interface for password validation.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister'></a>
### validationRegister `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation register.

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### GetValidationData(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of the instance of the RegisterBindingModel class. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') | Instance of the RegisterBindingModel class. |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### IsValid(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if data of the instance of the RegisterBindingModel class is valid.

##### Returns

True if a data of the instance of the RegisterBindingModel class is valid, otherwise - false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') | Instance of the RegisterBindingModel class. |

<a name='T-EasyTravelWeb-Models-RegisterExternalBindingModel'></a>
## RegisterExternalBindingModel [#](#T-EasyTravelWeb-Models-RegisterExternalBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-RegisterExternalBindingModel-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-RegisterExternalBindingModel-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-RemoveLoginBindingModel'></a>
## RemoveLoginBindingModel [#](#T-EasyTravelWeb-Models-RemoveLoginBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-RemoveLoginBindingModel-LoginProvider'></a>
### LoginProvider `property` [#](#P-EasyTravelWeb-Models-RemoveLoginBindingModel-LoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-RemoveLoginBindingModel-ProviderKey'></a>
### ProviderKey `property` [#](#P-EasyTravelWeb-Models-RemoveLoginBindingModel-ProviderKey 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-RouteConfig'></a>
## RouteConfig [#](#T-EasyTravelWeb-RouteConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

RouteConfig

<a name='M-EasyTravelWeb-RouteConfig-RegisterRoutes-System-Web-Routing-RouteCollection-'></a>
### RegisterRoutes() `method` [#](#M-EasyTravelWeb-RouteConfig-RegisterRoutes-System-Web-Routing-RouteCollection- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Route for requests

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Controllers-SearchController'></a>
## SearchController [#](#T-EasyTravelWeb-Controllers-SearchController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for search

<a name='M-EasyTravelWeb-Controllers-SearchController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-SearchController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Default constructor

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-SearchController-#ctor-EasyTravelWeb-Repositories-CityRepository,EasyTravelWeb-Repositories-PlaceRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-SearchController-#ctor-EasyTravelWeb-Repositories-CityRepository,EasyTravelWeb-Repositories-PlaceRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor with parameters for unit testing

##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-SearchController-AddCitiesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}-'></a>
### AddCitiesToSuggestions(searchWord,listOfSuggestions) `method` [#](#M-EasyTravelWeb-Controllers-SearchController-AddCitiesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds cities to suggestions

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchWord | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Key word, which is used to filter names of cities |
| listOfSuggestions | [System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity}') | List of suggestions according to searchWord |

<a name='M-EasyTravelWeb-Controllers-SearchController-AddPlacesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}-'></a>
### AddPlacesToSuggestions(searchWord,listOfSuggestions) `method` [#](#M-EasyTravelWeb-Controllers-SearchController-AddPlacesToSuggestions-System-String,System-Collections-Generic-IList{EasyTravelWeb-Models-SearchEntities-ISearchEntity}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds places to suggestions

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchWord | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Key word, which is used to filter names of places |
| listOfSuggestions | [System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{EasyTravelWeb.Models.SearchEntities.ISearchEntity}') | List of suggestions according to searchWord |

<a name='M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String-'></a>
### GetSuggestions(searchWord) `method` [#](#M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for getting suggestion according to searchWord

##### Returns

List of suggestions according to searchWord

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchWord | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Key word, which is used to filter names of cities and places |

<a name='M-EasyTravelWeb-Controllers-SearchController-InitializeData'></a>
### InitializeData() `method` [#](#M-EasyTravelWeb-Controllers-SearchController-InitializeData 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initialization of cities and places fields, if they are null

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-SearchControllerConstants'></a>
## SearchControllerConstants [#](#T-EasyTravelWeb-Constants-Constants-SearchControllerConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for SearchController class.

<a name='F-EasyTravelWeb-Constants-Constants-SearchControllerConstants-NumberOfSearchEntitiesToShow'></a>
### NumberOfSearchEntitiesToShow `constants` [#](#F-EasyTravelWeb-Constants-Constants-SearchControllerConstants-NumberOfSearchEntitiesToShow 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Optimal number of cities or places to show in search suggestions.

<a name='T-EasyTravelWeb-Controllers-ServicesController'></a>
## ServicesController [#](#T-EasyTravelWeb-Controllers-ServicesController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Send requests on different services

<a name='F-EasyTravelWeb-Controllers-ServicesController-blaBlaCar'></a>
### blaBlaCar `constants` [#](#F-EasyTravelWeb-Controllers-ServicesController-blaBlaCar 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

BlaBlaCar Service

<a name='M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String,System-DateTime-'></a>
### GetBlaBlaCarRequestResult(fromCity,toCity,dateOfTrip) `method` [#](#M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String,System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get info about trips from one city to other city in some date on BlaBlaCar

##### Returns

Status code with info about trips

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | departure city |
| toCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | arrival city |
| dateOfTrip | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Date of trip |

<a name='M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String-'></a>
### GetBlaBlaCarRequestResult(fromCity,toCity,dateOfTrip) `method` [#](#M-EasyTravelWeb-Controllers-ServicesController-GetBlaBlaCarRequestResult-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

get info about trips from one city to other city on BlaBlaCar

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | departure city |
| toCity | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | arrival city |

<a name='T-EasyTravelWeb-Models-SetPasswordBindingModel'></a>
## SetPasswordBindingModel [#](#T-EasyTravelWeb-Models-SetPasswordBindingModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-SetPasswordBindingModel-ConfirmPassword'></a>
### ConfirmPassword `property` [#](#P-EasyTravelWeb-Models-SetPasswordBindingModel-ConfirmPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-SetPasswordBindingModel-NewPassword'></a>
### NewPassword `property` [#](#P-EasyTravelWeb-Models-SetPasswordBindingModel-NewPassword 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Startup'></a>
## Startup [#](#T-EasyTravelWeb-Startup 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary



<a name='P-EasyTravelWeb-Startup-OAuthOptions'></a>
### OAuthOptions `property` [#](#P-EasyTravelWeb-Startup-OAuthOptions 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Startup-PublicClientId'></a>
### PublicClientId `property` [#](#P-EasyTravelWeb-Startup-PublicClientId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Startup-Configuration-Owin-IAppBuilder-'></a>
### Configuration() `method` [#](#M-EasyTravelWeb-Startup-Configuration-Owin-IAppBuilder- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Startup-ConfigureAuth-Owin-IAppBuilder-'></a>
### ConfigureAuth() `method` [#](#M-EasyTravelWeb-Startup-ConfigureAuth-Owin-IAppBuilder- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Constants-Constants-StartupConstants'></a>
## StartupConstants [#](#T-EasyTravelWeb-Constants-Constants-StartupConstants 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Constants.Constants

##### Summary

Provides constants for Startup class.

<a name='F-EasyTravelWeb-Constants-Constants-StartupConstants-AuthorizeEndpointPath'></a>
### AuthorizeEndpointPath `constants` [#](#F-EasyTravelWeb-Constants-Constants-StartupConstants-AuthorizeEndpointPath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Authorize endpoint path

<a name='F-EasyTravelWeb-Constants-Constants-StartupConstants-TokenEndpointPath'></a>
### TokenEndpointPath `constants` [#](#F-EasyTravelWeb-Constants-Constants-StartupConstants-TokenEndpointPath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Token endpoint path

<a name='T-EasyTravelWeb-Models-User'></a>
## User [#](#T-EasyTravelWeb-Models-User 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary

User Model

<a name='M-EasyTravelWeb-Models-User-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-User-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='P-EasyTravelWeb-Models-User-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-User-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-User-FirstName'></a>
### FirstName `property` [#](#P-EasyTravelWeb-Models-User-FirstName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-User-LastName'></a>
### LastName `property` [#](#P-EasyTravelWeb-Models-User-LastName 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-User-Password'></a>
### Password `property` [#](#P-EasyTravelWeb-Models-User-Password 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-User-UserId'></a>
### UserId `property` [#](#P-EasyTravelWeb-Models-User-UserId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-UserInfoViewModel'></a>
## UserInfoViewModel [#](#T-EasyTravelWeb-Models-UserInfoViewModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-UserInfoViewModel-Email'></a>
### Email `property` [#](#P-EasyTravelWeb-Models-UserInfoViewModel-Email 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-UserInfoViewModel-HasRegistered'></a>
### HasRegistered `property` [#](#P-EasyTravelWeb-Models-UserInfoViewModel-HasRegistered 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-UserInfoViewModel-LoginProvider'></a>
### LoginProvider `property` [#](#P-EasyTravelWeb-Models-UserInfoViewModel-LoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-UserLoginInfoViewModel'></a>
## UserLoginInfoViewModel [#](#T-EasyTravelWeb-Models-UserLoginInfoViewModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

##### Summary



<a name='P-EasyTravelWeb-Models-UserLoginInfoViewModel-LoginProvider'></a>
### LoginProvider `property` [#](#P-EasyTravelWeb-Models-UserLoginInfoViewModel-LoginProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-UserLoginInfoViewModel-ProviderKey'></a>
### ProviderKey `property` [#](#P-EasyTravelWeb-Models-UserLoginInfoViewModel-ProviderKey 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Models-UserPlaceRating'></a>
## UserPlaceRating [#](#T-EasyTravelWeb-Models-UserPlaceRating 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Models

<a name='P-EasyTravelWeb-Models-UserPlaceRating-PlaceId'></a>
### PlaceId `property` [#](#P-EasyTravelWeb-Models-UserPlaceRating-PlaceId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-UserPlaceRating-Rating'></a>
### Rating `property` [#](#P-EasyTravelWeb-Models-UserPlaceRating-Rating 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Models-UserPlaceRating-UserId'></a>
### UserId `property` [#](#P-EasyTravelWeb-Models-UserPlaceRating-UserId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Repositories-UserRepository'></a>
## UserRepository [#](#T-EasyTravelWeb-Repositories-UserRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary

Repository for get info about User

<a name='M-EasyTravelWeb-Repositories-UserRepository-ChangeFirstName-System-Int32,System-String-'></a>
### ChangeFirstName(id,firstName) `method` [#](#M-EasyTravelWeb-Repositories-UserRepository-ChangeFirstName-System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method For changing First Name of user in database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| firstName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | New first name of user |

<a name='M-EasyTravelWeb-Repositories-UserRepository-ChangeLastName-System-Int32,System-String-'></a>
### ChangeLastName(id,lastName) `method` [#](#M-EasyTravelWeb-Repositories-UserRepository-ChangeLastName-System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method For changing last Name of user in database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |
| lastName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | New last name of user |

<a name='M-EasyTravelWeb-Repositories-UserRepository-GetUser-System-Int32-'></a>
### GetUser(id) `method` [#](#M-EasyTravelWeb-Repositories-UserRepository-GetUser-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for getting information of specific user from Database

##### Returns

infromation of User(email, First and Last names)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of current user |

<a name='T-EasyTravelWeb-WebApiConfig'></a>
## WebApiConfig [#](#T-EasyTravelWeb-WebApiConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary



<a name='M-EasyTravelWeb-WebApiConfig-Register-System-Web-Http-HttpConfiguration-'></a>
### Register() `method` [#](#M-EasyTravelWeb-WebApiConfig-Register-System-Web-Http-HttpConfiguration- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.
