<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [AccountController](#T-EasyTravelWeb-Controllers-AccountController 'EasyTravelWeb.Controllers.AccountController')
  - [ConfirmUser(user)](#M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User- 'EasyTravelWeb.Controllers.AccountController.ConfirmUser(EasyTravelWeb.Models.User)')
  - [Register(model)](#M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel- 'EasyTravelWeb.Controllers.AccountController.Register(EasyTravelWeb.Models.RegisterBindingModel)')
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
- [NameChangingValidator](#T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator')
  - [GetValidationData(model)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-GetValidationData-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.GetValidationData(System.String)')
  - [isNameMetPatternRequirements(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-isNameMetPatternRequirements-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.isNameMetPatternRequirements(System.String)')
  - [IsValid(model)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-IsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.IsValid(System.String)')
  - [NameIsValid(name)](#M-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator-NameIsValid-System-String- 'EasyTravelWeb.Infrastructure.Validators.NameChangingValidator.NameIsValid(System.String)')
- [PlaceController](#T-EasyTravelWeb-Controllers-PlaceController 'EasyTravelWeb.Controllers.PlaceController')
  - [AddUserFavouritePlace(favouritePlace)](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavouritePlace- 'EasyTravelWeb.Controllers.PlaceController.AddUserFavouritePlace(EasyTravelWeb.Models.FavouritePlace)')
  - [DeleteUserFavouritePlace(userId,placeId)](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavouritePlace-System-Int32,EasyTravelWeb-Models-Place- 'EasyTravelWeb.Controllers.PlaceController.DeleteUserFavouritePlace(System.Int32,EasyTravelWeb.Models.Place)')
- [ProfileController](#T-EasyTravelWeb-Controllers-ProfileController 'EasyTravelWeb.Controllers.ProfileController')
  - [logger](#F-EasyTravelWeb-Controllers-ProfileController-logger 'EasyTravelWeb.Controllers.ProfileController.logger')
  - [nameValidator](#F-EasyTravelWeb-Controllers-ProfileController-nameValidator 'EasyTravelWeb.Controllers.ProfileController.nameValidator')
  - [placeRepository](#F-EasyTravelWeb-Controllers-ProfileController-placeRepository 'EasyTravelWeb.Controllers.ProfileController.placeRepository')
  - [userRepository](#F-EasyTravelWeb-Controllers-ProfileController-userRepository 'EasyTravelWeb.Controllers.ProfileController.userRepository')
  - [ChangeFirstName(id,firstName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeFirstName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeFirstName(System.Int32,System.String)')
  - [ChangeLastName(id,lastName)](#M-EasyTravelWeb-Controllers-ProfileController-ChangeLastName-System-Int32,System-String- 'EasyTravelWeb.Controllers.ProfileController.ChangeLastName(System.Int32,System.String)')
  - [GetFavouritePlaces(id)](#M-EasyTravelWeb-Controllers-ProfileController-GetFavouritePlaces-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetFavouritePlaces(System.Int32)')
  - [GetUser(id)](#M-EasyTravelWeb-Controllers-ProfileController-GetUser-System-Int32- 'EasyTravelWeb.Controllers.ProfileController.GetUser(System.Int32)')
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
- [UserController](#T-EasyTravelWeb-Controllers-UserController 'EasyTravelWeb.Controllers.UserController')
  - [logger](#F-EasyTravelWeb-Controllers-UserController-logger 'EasyTravelWeb.Controllers.UserController.logger')
  - [userRepository](#F-EasyTravelWeb-Controllers-UserController-userRepository 'EasyTravelWeb.Controllers.UserController.userRepository')
  - [validationInfo](#F-EasyTravelWeb-Controllers-UserController-validationInfo 'EasyTravelWeb.Controllers.UserController.validationInfo')
  - [GetUser(user)](#M-EasyTravelWeb-Controllers-UserController-GetUser-EasyTravelWeb-Models-User- 'EasyTravelWeb.Controllers.UserController.GetUser(EasyTravelWeb.Models.User)')
- [UserRepository](#T-EasyTravelWeb-Repositories-UserRepository 'EasyTravelWeb.Repositories.UserRepository')
  - [ChangeFirstName(id,firstName)](#M-EasyTravelWeb-Repositories-UserRepository-ChangeFirstName-System-Int32,System-String- 'EasyTravelWeb.Repositories.UserRepository.ChangeFirstName(System.Int32,System.String)')
  - [ChangeLastName(id,lastName)](#M-EasyTravelWeb-Repositories-UserRepository-ChangeLastName-System-Int32,System-String- 'EasyTravelWeb.Repositories.UserRepository.ChangeLastName(System.Int32,System.String)')
  - [GetUser(id)](#M-EasyTravelWeb-Repositories-UserRepository-GetUser-System-Int32- 'EasyTravelWeb.Repositories.UserRepository.GetUser(System.Int32)')

<a name='assembly'></a>
# EasyTravelWeb [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-EasyTravelWeb-Controllers-AccountController'></a>
## AccountController [#](#T-EasyTravelWeb-Controllers-AccountController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

<a name='M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User-'></a>
### ConfirmUser(user) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-ConfirmUser-EasyTravelWeb-Models-User- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [EasyTravelWeb.Models.User](#T-EasyTravelWeb-Models-User 'EasyTravelWeb.Models.User') |  |

<a name='M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel-'></a>
### Register(model) `method` [#](#M-EasyTravelWeb-Controllers-AccountController-Register-EasyTravelWeb-Models-RegisterBindingModel- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [EasyTravelWeb.Models.RegisterBindingModel](#T-EasyTravelWeb-Models-RegisterBindingModel 'EasyTravelWeb.Models.RegisterBindingModel') |  |

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

<a name='T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator'></a>
## NameChangingValidator [#](#T-EasyTravelWeb-Infrastructure-Validators-NameChangingValidator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Infrastructure.Validators

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

<a name='T-EasyTravelWeb-Controllers-PlaceController'></a>
## PlaceController [#](#T-EasyTravelWeb-Controllers-PlaceController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

<a name='M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavouritePlace-'></a>
### AddUserFavouritePlace(favouritePlace) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-AddUserFavouritePlace-EasyTravelWeb-Models-FavouritePlace- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| favouritePlace | [EasyTravelWeb.Models.FavouritePlace](#T-EasyTravelWeb-Models-FavouritePlace 'EasyTravelWeb.Models.FavouritePlace') |  |

<a name='M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavouritePlace-System-Int32,EasyTravelWeb-Models-Place-'></a>
### DeleteUserFavouritePlace(userId,placeId) `method` [#](#M-EasyTravelWeb-Controllers-PlaceController-DeleteUserFavouritePlace-System-Int32,EasyTravelWeb-Models-Place- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| placeId | [EasyTravelWeb.Models.Place](#T-EasyTravelWeb-Models-Place 'EasyTravelWeb.Models.Place') |  |

<a name='T-EasyTravelWeb-Controllers-ProfileController'></a>
## ProfileController [#](#T-EasyTravelWeb-Controllers-ProfileController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary

Controller for Profile page

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

<a name='M-EasyTravelWeb-Controllers-ProfileController-GetFavouritePlaces-System-Int32-'></a>
### GetFavouritePlaces(id) `method` [#](#M-EasyTravelWeb-Controllers-ProfileController-GetFavouritePlaces-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cotroler fo getting favourite places of specific user

##### Returns

List of favourite Places

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID of a current user |

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

<a name='T-EasyTravelWeb-Controllers-UserController'></a>
## UserController [#](#T-EasyTravelWeb-Controllers-UserController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Controllers

##### Summary



<a name='F-EasyTravelWeb-Controllers-UserController-logger'></a>
### logger `constants` [#](#F-EasyTravelWeb-Controllers-UserController-logger 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='F-EasyTravelWeb-Controllers-UserController-userRepository'></a>
### userRepository `constants` [#](#F-EasyTravelWeb-Controllers-UserController-userRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='F-EasyTravelWeb-Controllers-UserController-validationInfo'></a>
### validationInfo `constants` [#](#F-EasyTravelWeb-Controllers-UserController-validationInfo 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



<a name='M-EasyTravelWeb-Controllers-UserController-GetUser-EasyTravelWeb-Models-User-'></a>
### GetUser(user) `method` [#](#M-EasyTravelWeb-Controllers-UserController-GetUser-EasyTravelWeb-Models-User- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [EasyTravelWeb.Models.User](#T-EasyTravelWeb-Models-User 'EasyTravelWeb.Models.User') |  |

<a name='T-EasyTravelWeb-Repositories-UserRepository'></a>
## UserRepository [#](#T-EasyTravelWeb-Repositories-UserRepository 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

EasyTravelWeb.Repositories

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
