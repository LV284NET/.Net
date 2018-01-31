<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [AccountController](#T-EasyTravelWeb-Controllers-AccountController 'EasyTravelWeb.Controllers.AccountController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-AccountController-#ctor 'EasyTravelWeb.Controllers.AccountController.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}- 'EasyTravelWeb.Controllers.AccountController.#ctor(EasyTravelWeb.ApplicationUserManager,Microsoft.Owin.Security.ISecureDataFormat{Microsoft.Owin.Security.AuthenticationTicket})')
  - [registerBindingModelValidator](#F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator 'EasyTravelWeb.Controllers.AccountController.registerBindingModelValidator')
  - [userManager](#F-EasyTravelWeb-Controllers-AccountController-userManager 'EasyTravelWeb.Controllers.AccountController.userManager')
  - [AccessTokenFormat](#P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat 'EasyTravelWeb.Controllers.AccountController.AccessTokenFormat')
  - [UserManager](#P-EasyTravelWeb-Controllers-AccountController-UserManager 'EasyTravelWeb.Controllers.AccountController.UserManager')
  - [AddExternalLogin()](#M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-AddExternalLoginBindingModel- 'EasyTravelWeb.Controllers.AccountController.AddExternalLogin(EasyTravelWeb.Models.AddExternalLoginBindingModel)')
  - [ChangePassword()](#M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel- 'EasyTravelWeb.Controllers.AccountController.ChangePassword(EasyTravelWeb.Models.ChangePasswordBindingModel)')
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
- [AddExternalLoginBindingModel](#T-EasyTravelWeb-Models-AddExternalLoginBindingModel 'EasyTravelWeb.Models.AddExternalLoginBindingModel')
  - [ExternalAccessToken](#P-EasyTravelWeb-Models-AddExternalLoginBindingModel-ExternalAccessToken 'EasyTravelWeb.Models.AddExternalLoginBindingModel.ExternalAccessToken')
- [ApplicationDbContext](#T-EasyTravelWeb-Models-ApplicationDbContext 'EasyTravelWeb.Models.ApplicationDbContext')
  - [#ctor()](#M-EasyTravelWeb-Models-ApplicationDbContext-#ctor 'EasyTravelWeb.Models.ApplicationDbContext.#ctor')
  - [Create()](#M-EasyTravelWeb-Models-ApplicationDbContext-Create 'EasyTravelWeb.Models.ApplicationDbContext.Create')
- [ApplicationOAuthProvider](#T-EasyTravelWeb-Providers-ApplicationOAuthProvider 'EasyTravelWeb.Providers.ApplicationOAuthProvider')
  - [#ctor()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-#ctor-System-String- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.#ctor(System.String)')
  - [CreateProperties()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-CreateProperties-System-Int32,System-String,System-String- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.CreateProperties(System.Int32,System.String,System.String)')
  - [GrantResourceOwnerCredentials()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.GrantResourceOwnerCredentials(Microsoft.Owin.Security.OAuth.OAuthGrantResourceOwnerCredentialsContext)')
  - [TokenEndpoint()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.TokenEndpoint(Microsoft.Owin.Security.OAuth.OAuthTokenEndpointContext)')
  - [ValidateClientAuthentication()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.ValidateClientAuthentication(Microsoft.Owin.Security.OAuth.OAuthValidateClientAuthenticationContext)')
  - [ValidateClientRedirectUri()](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientRedirectUri-Microsoft-Owin-Security-OAuth-OAuthValidateClientRedirectUriContext- 'EasyTravelWeb.Providers.ApplicationOAuthProvider.ValidateClientRedirectUri(Microsoft.Owin.Security.OAuth.OAuthValidateClientRedirectUriContext)')
- [ApplicationUser](#T-EasyTravelWeb-Models-ApplicationUser 'EasyTravelWeb.Models.ApplicationUser')
  - [FirstName](#P-EasyTravelWeb-Models-ApplicationUser-FirstName 'EasyTravelWeb.Models.ApplicationUser.FirstName')
  - [LastName](#P-EasyTravelWeb-Models-ApplicationUser-LastName 'EasyTravelWeb.Models.ApplicationUser.LastName')
  - [GenerateUserIdentityAsync()](#M-EasyTravelWeb-Models-ApplicationUser-GenerateUserIdentityAsync-Microsoft-AspNet-Identity-UserManager{EasyTravelWeb-Models-ApplicationUser,System-Int32},System-String- 'EasyTravelWeb.Models.ApplicationUser.GenerateUserIdentityAsync(Microsoft.AspNet.Identity.UserManager{EasyTravelWeb.Models.ApplicationUser,System.Int32},System.String)')
- [ApplicationUserManager](#T-EasyTravelWeb-ApplicationUserManager 'EasyTravelWeb.ApplicationUserManager')
  - [#ctor()](#M-EasyTravelWeb-ApplicationUserManager-#ctor-Microsoft-AspNet-Identity-IUserStore{EasyTravelWeb-Models-ApplicationUser,System-Int32}- 'EasyTravelWeb.ApplicationUserManager.#ctor(Microsoft.AspNet.Identity.IUserStore{EasyTravelWeb.Models.ApplicationUser,System.Int32})')
  - [Create()](#M-EasyTravelWeb-ApplicationUserManager-Create-Microsoft-AspNet-Identity-Owin-IdentityFactoryOptions{EasyTravelWeb-ApplicationUserManager},Microsoft-Owin-IOwinContext- 'EasyTravelWeb.ApplicationUserManager.Create(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions{EasyTravelWeb.ApplicationUserManager},Microsoft.Owin.IOwinContext)')
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
  - [Get()](#M-EasyTravelWeb-Controllers-CityController-Get-System-Int32- 'EasyTravelWeb.Controllers.CityController.Get(System.Int32)')
  - [GetCities()](#M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32- 'EasyTravelWeb.Controllers.CityController.GetCities(System.Int32,System.Int32)')
  - [GetCountCity()](#M-EasyTravelWeb-Controllers-CityController-GetCountCity 'EasyTravelWeb.Controllers.CityController.GetCountCity')
  - [GetTopCities()](#M-EasyTravelWeb-Controllers-CityController-GetTopCities 'EasyTravelWeb.Controllers.CityController.GetTopCities')
- [CityRepository](#T-EasyTravelWeb-Repositories-CityRepository 'EasyTravelWeb.Repositories.CityRepository')
  - [GetCitiesIdAndNames()](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesIdAndNames 'EasyTravelWeb.Repositories.CityRepository.GetCitiesIdAndNames')
  - [GetCitiesPage()](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32- 'EasyTravelWeb.Repositories.CityRepository.GetCitiesPage(System.Int32,System.Int32)')
  - [GetCity()](#M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64- 'EasyTravelWeb.Repositories.CityRepository.GetCity(System.Int64)')
  - [GetCountCity()](#M-EasyTravelWeb-Repositories-CityRepository-GetCountCity 'EasyTravelWeb.Repositories.CityRepository.GetCountCity')
  - [GetTopCities()](#M-EasyTravelWeb-Repositories-CityRepository-GetTopCities 'EasyTravelWeb.Repositories.CityRepository.GetTopCities')
- [CitySearchEntity](#T-EasyTravelWeb-Controllers-SearchController-CitySearchEntity 'EasyTravelWeb.Controllers.SearchController.CitySearchEntity')
  - [Id](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Id 'EasyTravelWeb.Controllers.SearchController.CitySearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Name 'EasyTravelWeb.Controllers.SearchController.CitySearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Type 'EasyTravelWeb.Controllers.SearchController.CitySearchEntity.Type')
- [CORSConfig](#T-EasyTravelWeb-App_Start-CORSConfig 'EasyTravelWeb.App_Start.CORSConfig')
  - [CorsPolicy](#F-EasyTravelWeb-App_Start-CORSConfig-CorsPolicy 'EasyTravelWeb.App_Start.CORSConfig.CorsPolicy')
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
- [EmailService](#T-EasyTravelWeb-Services-EmailService 'EasyTravelWeb.Services.EmailService')
  - [SendAsync()](#M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage- 'EasyTravelWeb.Services.EmailService.SendAsync(Microsoft.AspNet.Identity.IdentityMessage)')
- [ExternalLoginViewModel](#T-EasyTravelWeb-Models-ExternalLoginViewModel 'EasyTravelWeb.Models.ExternalLoginViewModel')
  - [Name](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Name 'EasyTravelWeb.Models.ExternalLoginViewModel.Name')
  - [State](#P-EasyTravelWeb-Models-ExternalLoginViewModel-State 'EasyTravelWeb.Models.ExternalLoginViewModel.State')
  - [Url](#P-EasyTravelWeb-Models-ExternalLoginViewModel-Url 'EasyTravelWeb.Models.ExternalLoginViewModel.Url')
- [FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace')
  - [PlaceId](#P-EasyTravelWeb-Models-FavoritePlace-PlaceId 'EasyTravelWeb.Models.FavoritePlace.PlaceId')
  - [UserId](#P-EasyTravelWeb-Models-FavoritePlace-UserId 'EasyTravelWeb.Models.FavoritePlace.UserId')
- [Filter](#T-EasyTravelWeb-Models-Filter 'EasyTravelWeb.Models.Filter')
- [FilterConfig](#T-EasyTravelWeb-FilterConfig 'EasyTravelWeb.FilterConfig')
  - [RegisterGlobalFilters()](#M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection- 'EasyTravelWeb.FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection)')
- [ISearchEntity](#T-EasyTravelWeb-Controllers-SearchController-ISearchEntity 'EasyTravelWeb.Controllers.SearchController.ISearchEntity')
  - [Id](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Id 'EasyTravelWeb.Controllers.SearchController.ISearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Name 'EasyTravelWeb.Controllers.SearchController.ISearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Type 'EasyTravelWeb.Controllers.SearchController.ISearchEntity.Type')
- [Logger](#T-EasyTravelWeb-Infrastructure-Logger 'EasyTravelWeb.Infrastructure.Logger')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Logger-#ctor 'EasyTravelWeb.Infrastructure.Logger.#ctor')
  - [FileStream](#F-EasyTravelWeb-Infrastructure-Logger-FileStream 'EasyTravelWeb.Infrastructure.Logger.FileStream')
  - [logger](#F-EasyTravelWeb-Infrastructure-Logger-logger 'EasyTravelWeb.Infrastructure.Logger.logger')
  - [streamWriter](#F-EasyTravelWeb-Infrastructure-Logger-streamWriter 'EasyTravelWeb.Infrastructure.Logger.streamWriter')
  - [Finalize()](#M-EasyTravelWeb-Infrastructure-Logger-Finalize 'EasyTravelWeb.Infrastructure.Logger.Finalize')
  - [GetInstance()](#M-EasyTravelWeb-Infrastructure-Logger-GetInstance 'EasyTravelWeb.Infrastructure.Logger.GetInstance')
  - [LogException(ex)](#M-EasyTravelWeb-Infrastructure-Logger-LogException-System-Exception- 'EasyTravelWeb.Infrastructure.Logger.LogException(System.Exception)')
  - [LogMessage(message)](#M-EasyTravelWeb-Infrastructure-Logger-LogMessage-System-String- 'EasyTravelWeb.Infrastructure.Logger.LogMessage(System.String)')
- [MainPageController](#T-EasyTravelWeb-Controllers-MainPageController 'EasyTravelWeb.Controllers.MainPageController')
  - [Index()](#M-EasyTravelWeb-Controllers-MainPageController-Index 'EasyTravelWeb.Controllers.MainPageController.Index')
- [ManageInfoViewModel](#T-EasyTravelWeb-Models-ManageInfoViewModel 'EasyTravelWeb.Models.ManageInfoViewModel')
  - [Email](#P-EasyTravelWeb-Models-ManageInfoViewModel-Email 'EasyTravelWeb.Models.ManageInfoViewModel.Email')
  - [ExternalLoginProviders](#P-EasyTravelWeb-Models-ManageInfoViewModel-ExternalLoginProviders 'EasyTravelWeb.Models.ManageInfoViewModel.ExternalLoginProviders')
  - [LocalLoginProvider](#P-EasyTravelWeb-Models-ManageInfoViewModel-LocalLoginProvider 'EasyTravelWeb.Models.ManageInfoViewModel.LocalLoginProvider')
  - [Logins](#P-EasyTravelWeb-Models-ManageInfoViewModel-Logins 'EasyTravelWeb.Models.ManageInfoViewModel.Logins')
- [MvcApplication](#T-EasyTravelWeb-MvcApplication 'EasyTravelWeb.MvcApplication')
  - [Application_Start()](#M-EasyTravelWeb-MvcApplication-Application_Start 'EasyTravelWeb.MvcApplication.Application_Start')
- [NameChangingValidator](#T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.#ctor')
  - [GetValidationData(model)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-GetValidationData-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.GetValidationData(System.String)')
  - [isNameMetPatternRequirements(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-isNameMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.isNameMetPatternRequirements(System.String)')
  - [IsValid(model)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-IsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.IsValid(System.String)')
  - [NameIsValid(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-NameIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.NameIsValid(System.String)')
- [Place](#T-EasyTravelWeb-Models-Place 'EasyTravelWeb.Models.Place')
  - [#ctor()](#M-EasyTravelWeb-Models-Place-#ctor 'EasyTravelWeb.Models.Place.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Models-Place-#ctor-System-String,System-String,System-String,System-String- 'EasyTravelWeb.Models.Place.#ctor(System.String,System.String,System.String,System.String)')
  - [CityId](#P-EasyTravelWeb-Models-Place-CityId 'EasyTravelWeb.Models.Place.CityId')
  - [CityName](#P-EasyTravelWeb-Models-Place-CityName 'EasyTravelWeb.Models.Place.CityName')
  - [Description](#P-EasyTravelWeb-Models-Place-Description 'EasyTravelWeb.Models.Place.Description')
  - [Name](#P-EasyTravelWeb-Models-Place-Name 'EasyTravelWeb.Models.Place.Name')
  - [PicturePlace](#P-EasyTravelWeb-Models-Place-PicturePlace 'EasyTravelWeb.Models.Place.PicturePlace')
  - [PlaceId](#P-EasyTravelWeb-Models-Place-PlaceId 'EasyTravelWeb.Models.Place.PlaceId')
  - [PlaceRating](#P-EasyTravelWeb-Models-Place-PlaceRating 'EasyTravelWeb.Models.Place.PlaceRating')
- [PlaceController](#T-EasyTravelWeb-Controllers-PlaceController 'EasyTravelWeb.Controllers.PlaceController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-PlaceController-#ctor 'EasyTravelWeb.Controllers.PlaceController.#ctor')
  - [AddUserFavouritePlace(favoriteUserPlace)](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavoritePlace- 'EasyTravelWeb.Controllers.PlaceController.AddUserFavouritePlace(EasyTravelWeb.Models.FavoritePlace)')
  - [DeleteUserFavoritePlace(favoritePlace)](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'EasyTravelWeb.Controllers.PlaceController.DeleteUserFavoritePlace(EasyTravelWeb.Models.FavoritePlace)')
  - [GetCountFromFilteredPlaces(filters)](#M-EasyTravelWeb-Controllers-PlaceController-GetCountFromFilteredPlaces-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Controllers.PlaceController.GetCountFromFilteredPlaces(System.Int64,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetCountPlaces()](#M-EasyTravelWeb-Controllers-PlaceController-GetCountPlaces-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetCountPlaces(System.Int64)')
  - [GetFilteredPlacesByCityId(filters)](#M-EasyTravelWeb-Controllers-PlaceController-GetFilteredPlacesByCityId-System-Int64,System-Int32,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Controllers.PlaceController.GetFilteredPlacesByCityId(System.Int64,System.Int32,System.Int32,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetPlaceById()](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceById-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetPlaceById(System.Int64)')
  - [GetPlacesPageByCityId()](#M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32- 'EasyTravelWeb.Controllers.PlaceController.GetPlacesPageByCityId(System.Int64,System.Int32,System.Int32)')
  - [GetTopPlacesByCityId()](#M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64- 'EasyTravelWeb.Controllers.PlaceController.GetTopPlacesByCityId(System.Int64)')
- [PlaceRepository](#T-EasyTravelWeb-Repositories-PlaceRepository 'EasyTravelWeb.Repositories.PlaceRepository')
  - [AddFavouritePlace()](#M-EasyTravelWeb-Repositories-PlaceRepository-AddFavouritePlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.AddFavouritePlace(System.Int32,System.Int64)')
  - [DeleteFavoritePlace()](#M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.DeleteFavoritePlace(System.Int32,System.Int64)')
  - [GetCountPlace()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetCountPlace(System.Int64)')
  - [GetFavoritePlaces()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32- 'EasyTravelWeb.Repositories.PlaceRepository.GetFavoritePlaces(System.Int32)')
  - [GetFilteredCountPlace(filters)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredCountPlace-System-Int64,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Repositories.PlaceRepository.GetFilteredCountPlace(System.Int64,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetFilteredPlacesPage(filters)](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFilteredPlacesPage-System-Int32,System-Int64,System-Int32,System-Collections-Generic-IList{EasyTravelWeb-Models-Filter}- 'EasyTravelWeb.Repositories.PlaceRepository.GetFilteredPlacesPage(System.Int32,System.Int64,System.Int32,System.Collections.Generic.IList{EasyTravelWeb.Models.Filter})')
  - [GetPlaceById()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceById-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlaceById(System.Int64)')
  - [GetPlaces()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaces 'EasyTravelWeb.Repositories.PlaceRepository.GetPlaces')
  - [GetPlacesByCityId()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesByCityId-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlacesByCityId(System.Int64)')
  - [GetPlacesIdsAndNames()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames 'EasyTravelWeb.Repositories.PlaceRepository.GetPlacesIdsAndNames')
  - [GetPlacesPage()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32- 'EasyTravelWeb.Repositories.PlaceRepository.GetPlacesPage(System.Int32,System.Int64,System.Int32)')
  - [GetTopPlacesByCityId()](#M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64- 'EasyTravelWeb.Repositories.PlaceRepository.GetTopPlacesByCityId(System.Int64)')
- [PlaceSearchEntity](#T-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity 'EasyTravelWeb.Controllers.SearchController.PlaceSearchEntity')
  - [CityId](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-CityId 'EasyTravelWeb.Controllers.SearchController.PlaceSearchEntity.CityId')
  - [Id](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Id 'EasyTravelWeb.Controllers.SearchController.PlaceSearchEntity.Id')
  - [Name](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Name 'EasyTravelWeb.Controllers.SearchController.PlaceSearchEntity.Name')
  - [Type](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Type 'EasyTravelWeb.Controllers.SearchController.PlaceSearchEntity.Type')
- [ProfileController](#T-EasyTravelWeb-Controllers-ProfileController 'EasyTravelWeb.Controllers.ProfileController')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor 'EasyTravelWeb.Controllers.ProfileController.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-UserRepository- 'EasyTravelWeb.Controllers.ProfileController.#ctor(EasyTravelWeb.Repositories.UserRepository)')
  - [#ctor()](#M-EasyTravelWeb-Controllers-ProfileController-#ctor-EasyTravelWeb-Repositories-PlaceRepository- 'EasyTravelWeb.Controllers.ProfileController.#ctor(EasyTravelWeb.Repositories.PlaceRepository)')
  - [logger](#F-EasyTravelWeb-Controllers-ProfileController-logger 'EasyTravelWeb.Controllers.ProfileController.logger')
  - [nameValidator](#F-EasyTravelWeb-Controllers-ProfileController-nameValidator 'EasyTravelWeb.Controllers.ProfileController.nameValidator')
  - [placeRepository](#F-EasyTravelWeb-Controllers-ProfileController-placeRepository 'EasyTravelWeb.Controllers.ProfileController.placeRepository')
  - [ratingRepository](#F-EasyTravelWeb-Controllers-ProfileController-ratingRepository 'EasyTravelWeb.Controllers.ProfileController.ratingRepository')
  - [userRepository](#F-EasyTravelWeb-Controllers-ProfileController-userRepository 'EasyTravelWeb.Controllers.ProfileController.userRepository')
  - [ChangeFirstName(id,firstName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeFirstName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeFirstName(System.Int32,System.String)')
  - [ChangeLastName(id,lastName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeLastName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeLastName(System.Int32,System.String)')
  - [DeleteUserRatingForPlace()](#M-EasyTravelWeb-Controllers-ProfileController-DeleteUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'EasyTravelWeb.Controllers.ProfileController.DeleteUserRatingForPlace(EasyTravelWeb.Models.UserPlaceRating)')
  - [GetFavoritePlaces()](#M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetFavoritePlaces(System.Int32)')
  - [GetUser(id)](#M-EasyTravelWeb-Controllers-ProfileController-GetUser-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetUser(System.Int32)')
  - [GetUserRatingOfPlace()](#M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64- 'EasyTravelWeb.Controllers.ProfileController.GetUserRatingOfPlace(System.Int32,System.Int64)')
  - [SetUserRatingForPlace()](#M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'EasyTravelWeb.Controllers.ProfileController.SetUserRatingForPlace(EasyTravelWeb.Models.UserPlaceRating)')
- [RatingRepository](#T-EasyTravelWeb-Repositories-RatingRepository 'EasyTravelWeb.Repositories.RatingRepository')
  - [GetUserRatingOfPlace()](#M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64- 'EasyTravelWeb.Repositories.RatingRepository.GetUserRatingOfPlace(System.Int32,System.Int64)')
- [RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel')
  - [ConfirmPassword](#P-EasyTravelWeb-Models-RegisterBindingModel-ConfirmPassword 'EasyTravelWeb.Models.RegisterBindingModel.ConfirmPassword')
  - [Email](#P-EasyTravelWeb-Models-RegisterBindingModel-Email 'EasyTravelWeb.Models.RegisterBindingModel.Email')
  - [FirstName](#P-EasyTravelWeb-Models-RegisterBindingModel-FirstName 'EasyTravelWeb.Models.RegisterBindingModel.FirstName')
  - [LastName](#P-EasyTravelWeb-Models-RegisterBindingModel-LastName 'EasyTravelWeb.Models.RegisterBindingModel.LastName')
  - [Password](#P-EasyTravelWeb-Models-RegisterBindingModel-Password 'EasyTravelWeb.Models.RegisterBindingModel.Password')
- [RegisterBindingModelValidator](#T-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator')
  - [#ctor()](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.#ctor')
  - [emailPattern](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailPattern 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.emailPattern')
  - [logger](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.logger')
  - [namePattern](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-namePattern 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.namePattern')
  - [PasswordLength](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-PasswordLength 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.PasswordLength')
  - [passwordPattern](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordPattern 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.passwordPattern')
  - [validationRegister](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.validationRegister')
  - [emailIsValid(email)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.emailIsValid(System.String)')
  - [firstNameIsValid(firstName)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-firstNameIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.firstNameIsValid(System.String)')
  - [GetValidationData(model)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.GetValidationData(EasyTravelWeb.Models.RegisterBindingModel)')
  - [isEmailMetPatternRequirements(email)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isEmailMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.isEmailMetPatternRequirements(System.String)')
  - [isNameMetPatternRequirements(name)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isNameMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.isNameMetPatternRequirements(System.String)')
  - [isPasswordMetPatternRequirements(password)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.isPasswordMetPatternRequirements(System.String)')
  - [isPasswordValid(password)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.isPasswordValid(System.String)')
  - [IsValid(model)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.IsValid(EasyTravelWeb.Models.RegisterBindingModel)')
  - [lastNameIsValid(lastName)](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-lastNameIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.RegisterBindingModelValidator.lastNameIsValid(System.String)')
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
  - [GetSuggestions()](#M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String- 'EasyTravelWeb.Controllers.SearchController.GetSuggestions(System.String)')
- [SetPasswordBindingModel](#T-EasyTravelWeb-Models-SetPasswordBindingModel 'EasyTravelWeb.Models.SetPasswordBindingModel')
  - [ConfirmPassword](#P-EasyTravelWeb-Models-SetPasswordBindingModel-ConfirmPassword 'EasyTravelWeb.Models.SetPasswordBindingModel.ConfirmPassword')
  - [NewPassword](#P-EasyTravelWeb-Models-SetPasswordBindingModel-NewPassword 'EasyTravelWeb.Models.SetPasswordBindingModel.NewPassword')
- [Startup](#T-EasyTravelWeb-Startup 'EasyTravelWeb.Startup')
  - [OAuthOptions](#P-EasyTravelWeb-Startup-OAuthOptions 'EasyTravelWeb.Startup.OAuthOptions')
  - [PublicClientId](#P-EasyTravelWeb-Startup-PublicClientId 'EasyTravelWeb.Startup.PublicClientId')
  - [Configuration()](#M-EasyTravelWeb-Startup-Configuration-Owin-IAppBuilder- 'EasyTravelWeb.Startup.Configuration(Owin.IAppBuilder)')
  - [ConfigureAuth()](#M-EasyTravelWeb-Startup-ConfigureAuth-Owin-IAppBuilder- 'EasyTravelWeb.Startup.ConfigureAuth(Owin.IAppBuilder)')
- [User](#T-EasyTravelWeb-Models-User 'EasyTravelWeb.Models.User')
  - [#ctor()](#M-EasyTravelWeb-Models-User-#ctor 'EasyTravelWeb.Models.User.#ctor')
  - [#ctor()](#M-EasyTravelWeb-Models-User-#ctor-System-Int32,System-String,System-String,System-String,System-String- 'EasyTravelWeb.Models.User.#ctor(System.Int32,System.String,System.String,System.String,System.String)')
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



<a name='M-EasyTravelWeb-Controllers-AccountController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-AccountController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-AccountController-#ctor-EasyTravelWeb-ApplicationUserManager,Microsoft-Owin-Security-ISecureDataFormat{Microsoft-Owin-Security-AuthenticationTicket}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator'></a>
### registerBindingModelValidator `constants` [#](#F-EasyTravelWeb-Controllers-AccountController-registerBindingModelValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='F-EasyTravelWeb-Controllers-AccountController-userManager'></a>
### userManager `constants` [#](#F-EasyTravelWeb-Controllers-AccountController-userManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat'></a>
### AccessTokenFormat `property` [#](#P-EasyTravelWeb-Controllers-AccountController-AccessTokenFormat 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-AccountController-UserManager'></a>
### UserManager `property` [#](#P-EasyTravelWeb-Controllers-AccountController-UserManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-AddExternalLoginBindingModel-'></a>
### AddExternalLogin() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-AddExternalLogin-EasyTravelWeb-Models-AddExternalLoginBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel-'></a>
### ChangePassword() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-ChangePassword-EasyTravelWeb-Models-ChangePasswordBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-Logout'></a>
### Logout() `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Logout 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### Register(model) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') |  |

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
### CreateProperties() `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-CreateProperties-System-Int32,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext-'></a>
### GrantResourceOwnerCredentials() `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-GrantResourceOwnerCredentials-Microsoft-Owin-Security-OAuth-OAuthGrantResourceOwnerCredentialsContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext-'></a>
### TokenEndpoint() `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-TokenEndpoint-Microsoft-Owin-Security-OAuth-OAuthTokenEndpointContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext-'></a>
### ValidateClientAuthentication() `method` [#](#M-EasyTravelWeb-Providers-ApplicationOAuthProvider-ValidateClientAuthentication-Microsoft-Owin-Security-OAuth-OAuthValidateClientAuthenticationContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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

<a name='T-EasyTravelWeb-BundleConfig'></a>
## BundleConfig [#](#T-EasyTravelWeb-BundleConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Bundle logic

<a name='M-EasyTravelWeb-BundleConfig-RegisterBundles-System-Web-Optimization-BundleCollection-'></a>
### RegisterBundles() `method` [#](#M-EasyTravelWeb-BundleConfig-RegisterBundles-System-Web-Optimization-BundleCollection- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



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



<a name='M-EasyTravelWeb-Controllers-CityController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-CityController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-#ctor-EasyTravelWeb-Repositories-CityRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-CityController-#ctor-EasyTravelWeb-Repositories-CityRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-Get-System-Int32-'></a>
### Get() `method` [#](#M-EasyTravelWeb-Controllers-CityController-Get-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32-'></a>
### GetCities() `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetCities-System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-GetCountCity'></a>
### GetCountCity() `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetCountCity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-CityController-GetTopCities'></a>
### GetTopCities() `method` [#](#M-EasyTravelWeb-Controllers-CityController-GetTopCities 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



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



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32-'></a>
### GetCitiesPage() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCitiesPage-System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64-'></a>
### GetCity() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCity-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetCountCity'></a>
### GetCountCity() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetCountCity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-CityRepository-GetTopCities'></a>
### GetTopCities() `method` [#](#M-EasyTravelWeb-Repositories-CityRepository-GetTopCities 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Controllers-SearchController-CitySearchEntity'></a>
## CitySearchEntity [#](#T-EasyTravelWeb-Controllers-SearchController-CitySearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers.SearchController

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Controllers-SearchController-CitySearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-App_Start-CORSConfig'></a>
## CORSConfig [#](#T-EasyTravelWeb-App_Start-CORSConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.App_Start

##### Summary

Cors Configuration

<a name='F-EasyTravelWeb-App_Start-CORSConfig-CorsPolicy'></a>
### CorsPolicy `constants` [#](#F-EasyTravelWeb-App_Start-CORSConfig-CorsPolicy 'Go To Here') [=](#contents 'Back To Contents')

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

<a name='T-EasyTravelWeb-Services-EmailService'></a>
## EmailService [#](#T-EasyTravelWeb-Services-EmailService 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Services

##### Summary

Service for send mail

<a name='M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage-'></a>
### SendAsync() `method` [#](#M-EasyTravelWeb-Services-EmailService-SendAsync-Microsoft-AspNet-Identity-IdentityMessage- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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

Available filters in app

<a name='T-EasyTravelWeb-FilterConfig'></a>
## FilterConfig [#](#T-EasyTravelWeb-FilterConfig 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb

##### Summary

Filter config

<a name='M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection-'></a>
### RegisterGlobalFilters() `method` [#](#M-EasyTravelWeb-FilterConfig-RegisterGlobalFilters-System-Web-Mvc-GlobalFilterCollection- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Controllers-SearchController-ISearchEntity'></a>
## ISearchEntity [#](#T-EasyTravelWeb-Controllers-SearchController-ISearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers.SearchController

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Controllers-SearchController-ISearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='T-EasyTravelWeb-Infrastructure-Logger'></a>
## Logger [#](#T-EasyTravelWeb-Infrastructure-Logger 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure

##### Summary

Logs applicatuon exceptions into EasyTravelLog.txt in C:\Users\Public directory

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

<a name='M-EasyTravelWeb-Infrastructure-Logger-Finalize'></a>
### Finalize() `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-Finalize 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Finalizes an instance of the Logger class

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Infrastructure-Logger-GetInstance'></a>
### GetInstance() `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-GetInstance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a new instance of the Logger class for exceptions logging

##### Returns

Instance of the Logger class

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Infrastructure-Logger-LogException-System-Exception-'></a>
### LogException(ex) `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-LogException-System-Exception- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Writes the exception details into the file

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Instence of the Exception class |

<a name='M-EasyTravelWeb-Infrastructure-Logger-LogMessage-System-String-'></a>
### LogMessage(message) `method` [#](#M-EasyTravelWeb-Infrastructure-Logger-LogMessage-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Writes the message into the file

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that should be logged |

<a name='T-EasyTravelWeb-Controllers-MainPageController'></a>
## MainPageController [#](#T-EasyTravelWeb-Controllers-MainPageController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for the default page which informs about the app running

<a name='M-EasyTravelWeb-Controllers-MainPageController-Index'></a>
### Index() `method` [#](#M-EasyTravelWeb-Controllers-MainPageController-Index 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



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

<a name='T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator'></a>
## NameChangingValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

##### Summary



<a name='M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-GetValidationData-System-String-'></a>
### GetValidationData(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-GetValidationData-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of the instance of the string class. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instance of the string class |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-isNameMetPatternRequirements-System-String-'></a>
### isNameMetPatternRequirements(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-isNameMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the first name or the last name are met pattern requirements

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name or last name |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-IsValid-System-String-'></a>
### IsValid(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-IsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if data of the instance of the RegisterBindingModel class is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instance of the RegisterBindingModel class |

<a name='M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-NameIsValid-System-String-'></a>
### NameIsValid(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-NameIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the first name is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First or Last name |

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

<a name='M-EasyTravelWeb-Models-Place-#ctor-System-String,System-String,System-String,System-String-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-Place-#ctor-System-String,System-String,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

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



<a name='M-EasyTravelWeb-Controllers-PlaceController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-PlaceController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavoritePlace-'></a>
### AddUserFavouritePlace(favoriteUserPlace) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavoritePlace- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| favoriteUserPlace | [EasyTravelWeb.Models.FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace') |  |

<a name='M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace-'></a>
### DeleteUserFavoritePlace(favoritePlace) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavoritePlace-EasyTravelWeb-Models-FavoritePlace- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| favoritePlace | [EasyTravelWeb.Models.FavoritePlace](#T-EasyTravelWeb-Models-FavoritePlace 'EasyTravelWeb.Models.FavoritePlace') |  |

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

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetCountPlaces-System-Int64-'></a>
### GetCountPlaces() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetCountPlaces-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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
### GetPlaceById() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceById-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlaceFilters-System-Int64-'></a>
### GetPlaceFilters() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceFilters-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controller method for filters of specific city

##### Returns

List of filters for specific place

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlaceRating-System-Int64-'></a>
### GetPlaceRating() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlaceRating-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32-'></a>
### GetPlacesPageByCityId() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetPlacesPageByCityId-System-Int64,System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64-'></a>
### GetTopPlacesByCityId() `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-GetTopPlacesByCityId-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Repositories-PlaceRepository'></a>
## PlaceRepository [#](#T-EasyTravelWeb-Repositories-PlaceRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary



<a name='M-EasyTravelWeb-Repositories-PlaceRepository-AddFavouritePlace-System-Int32,System-Int64-'></a>
### AddFavouritePlace() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-AddFavouritePlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64-'></a>
### DeleteFavoritePlace() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-DeleteFavoritePlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64-'></a>
### GetCountPlace() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetCountPlace-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32-'></a>
### GetFavoritePlaces() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetFavoritePlaces-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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
### GetPlaceById() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceById-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceFilters-System-Int64-'></a>
### GetPlaceFilters() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceFilters-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method which takes filter of specific place

##### Returns

list of place filters

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceRating-System-Int64-'></a>
### GetPlaceRating() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlaceRating-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames'></a>
### GetPlacesIdsAndNames() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesIdsAndNames 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32-'></a>
### GetPlacesPage() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetPlacesPage-System-Int32,System-Int64,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64-'></a>
### GetTopPlacesByCityId() `method` [#](#M-EasyTravelWeb-Repositories-PlaceRepository-GetTopPlacesByCityId-System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity'></a>
## PlaceSearchEntity [#](#T-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers.SearchController

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-CityId'></a>
### CityId `property` [#](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-CityId 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Id'></a>
### Id `property` [#](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Id 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Name'></a>
### Name `property` [#](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Name 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Type'></a>
### Type `property` [#](#P-EasyTravelWeb-Controllers-SearchController-PlaceSearchEntity-Type 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



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

<a name='F-EasyTravelWeb-Controllers-ProfileController-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance for stroring exceptions in file

<a name='F-EasyTravelWeb-Controllers-ProfileController-nameValidator'></a>
### nameValidator `constants` [#](#F-EasyTravelWeb-Controllers-ProfileController-nameValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validator fro first and lastn name

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
### DeleteUserRatingForPlace() `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-DeleteUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo delete rating place of specific user

##### Returns

List of favourite Places

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32-'></a>
### GetFavoritePlaces() `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetFavoritePlaces-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroler fo getting favorite places of specific user

##### Returns

List of favourite Places

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetUser-System-Int32-'></a>
### GetUser(id) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetUser-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Method for getting User from Db

##### Returns

First, last, email of user

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | id of current user |

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64-'></a>
### GetUserRatingOfPlace() `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetUserRatingOfPlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo getting rating place of specific user

##### Returns

List of favourite Places

##### Parameters

This method has no parameters.

<a name='M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating-'></a>
### SetUserRatingForPlace() `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-SetUserRatingForPlace-EasyTravelWeb-Models-UserPlaceRating- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroller fo setting rating place of specific user

##### Returns

List of favourite Places

##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Repositories-RatingRepository'></a>
## RatingRepository [#](#T-EasyTravelWeb-Repositories-RatingRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

##### Summary



<a name='M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64-'></a>
### GetUserRatingOfPlace() `method` [#](#M-EasyTravelWeb-Repositories-RatingRepository-GetUserRatingOfPlace-System-Int32,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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

RegisterBindingModelValidator logic

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes instance of the RegisterBindingModelValidator class

##### Parameters

This constructor has no parameters.

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailPattern'></a>
### emailPattern `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailPattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by an email (i.e. some@domain.com)

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Instance of the Logger class for logging exceptions

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-namePattern'></a>
### namePattern `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-namePattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by first name or last name (i.e. Pavlo)

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-PasswordLength'></a>
### PasswordLength `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-PasswordLength 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Minimum amount of password characters

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordPattern'></a>
### passwordPattern `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-passwordPattern 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pattern that must be met by a password (i.e. Aa1111!@)

<a name='F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister'></a>
### validationRegister `constants` [#](#F-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-validationRegister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Validation register

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailIsValid-System-String-'></a>
### emailIsValid(email) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-emailIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the email is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | email |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-firstNameIsValid-System-String-'></a>
### firstNameIsValid(firstName) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-firstNameIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the first name is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| firstName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### GetValidationData(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-GetValidationData-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets data about validation process of the instance of the RegisterBindingModel class. Useful in cases of necessary to watch problems concerning the validation process.

##### Returns

List of information messages about validation process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') | Instance of the RegisterBindingModel class |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isEmailMetPatternRequirements-System-String-'></a>
### isEmailMetPatternRequirements(email) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isEmailMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the email is met pattern requirements

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | email |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isNameMetPatternRequirements-System-String-'></a>
### isNameMetPatternRequirements(name) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isNameMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the first name or the last name are met pattern requirements

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First name or last name |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordMetPatternRequirements-System-String-'></a>
### isPasswordMetPatternRequirements(password) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordMetPatternRequirements-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the password is met pattern requirements

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Password |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordValid-System-String-'></a>
### isPasswordValid(password) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-isPasswordValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the password is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | password |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### IsValid(model) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-IsValid-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if data of the instance of the RegisterBindingModel class is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') | Instance of the RegisterBindingModel class |

<a name='M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-lastNameIsValid-System-String-'></a>
### lastNameIsValid(lastName) `method` [#](#M-EasyTravelWeb-Infrastructure-Validators-RegisterBindingModelValidator-lastNameIsValid-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks if the last name is valid

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lastName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Last name |

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



##### Parameters

This method has no parameters.

<a name='T-EasyTravelWeb-Controllers-SearchController'></a>
## SearchController [#](#T-EasyTravelWeb-Controllers-SearchController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for seach

<a name='M-EasyTravelWeb-Controllers-SearchController-#ctor'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-SearchController-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-SearchController-#ctor-EasyTravelWeb-Repositories-CityRepository,EasyTravelWeb-Repositories-PlaceRepository-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Controllers-SearchController-#ctor-EasyTravelWeb-Repositories-CityRepository,EasyTravelWeb-Repositories-PlaceRepository- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This constructor has no parameters.

<a name='M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String-'></a>
### GetSuggestions() `method` [#](#M-EasyTravelWeb-Controllers-SearchController-GetSuggestions-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Parameters

This method has no parameters.

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

<a name='M-EasyTravelWeb-Models-User-#ctor-System-Int32,System-String,System-String,System-String,System-String-'></a>
### #ctor() `constructor` [#](#M-EasyTravelWeb-Models-User-#ctor-System-Int32,System-String,System-String,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

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
