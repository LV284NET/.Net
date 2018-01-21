# EasyTravelWeb #

## Type Controllers.MainPageController

 Controller for the default page which informs about the app running 



---
## Type Controllers.UserController





---
#### Field Controllers.UserController.userRepository





---
#### Field Controllers.UserController.logger





---
#### Field Controllers.UserController.validationInfo





---
#### Method Controllers.UserController.GetUser(EasyTravelWeb.Models.User)



|Name | Description |
|-----|------|
|user: ||
**Returns**: 



---
#### Method Controllers.UserController.AddUser(EasyTravelWeb.Models.User)



|Name | Description |
|-----|------|
|object: ||
**Returns**: 



---
## Type Infrastructure.Logger

 Logs applicatuon exceptions into EasyTravelLog.txt in C:\Users\Public directory 



---
#### Method Infrastructure.Logger.#ctor

 Prevents a default instance of the Logger class from being created 



---
#### Method Infrastructure.Logger.Finalize

 Finalizes an instance of the Logger class 



---
#### Field Infrastructure.Logger.logger

 The only one instance of the Logger class 



---
#### Field Infrastructure.Logger.FileStream

 Instance of the Stream class 



---
#### Field Infrastructure.Logger.streamWriter

 Instance of the StreamWriter class 



---
#### Method Infrastructure.Logger.GetInstance

 Returns a new instance of the Logger class for exceptions logging 

**Returns**: Instance of the Logger class



---
#### Method Infrastructure.Logger.LogException(System.Exception)

 Writes the exception details into the file 

|Name | Description |
|-----|------|
|ex: |Instence of the Exception class|


---
#### Method Infrastructure.Logger.LogMessage(System.String)

 Writes the message into the file 

|Name | Description |
|-----|------|
|message: |Message that should be logged|


---
## Type Infrastructure.Validators.RegisterBindingModelValidator

 RegisterBindingModelValidator logic 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.PasswordLength

 Minimum amount of password characters 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.validationRegister

 Validation register 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.logger

 Instance of the Logger class for logging exceptions 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.emailPattern

 Pattern that must be met by an email (i.e. some@domain.com) 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.passwordPattern

 Pattern that must be met by a password (i.e. Aa1111!@) 



---
#### Field Infrastructure.Validators.RegisterBindingModelValidator.namePattern

 Pattern that must be met by first name or last name (i.e. Pavlo) 



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.#ctor

 Initializes instance of the UserDataValidator class 



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.GetValidationData(EasyTravelWeb.Models.RegisterBindingModel)

 Gets data about validation process of the instance of the RegisterBindingModel class. Useful in cases of necessary to watch problems concerning the validation process. 

|Name | Description |
|-----|------|
|model: |Instance of the RegisterBindingModel class|
**Returns**: List of information messages about validation process



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.IsValid(EasyTravelWeb.Models.RegisterBindingModel)

 Checks if data of the instance of the RegisterBindingModel class is valid 

|Name | Description |
|-----|------|
|model: |Instance of the RegisterBindingModel class|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.emailIsValid(System.String)

 Checks if the email is valid 

|Name | Description |
|-----|------|
|email: |email|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.isEmailMetPatternRequirements(System.String)

 Checks if the email is met pattern requirements 

|Name | Description |
|-----|------|
|email: |email|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.passwordIsValid(System.String)

 Checks if the password is valid 

|Name | Description |
|-----|------|
|password: |password|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.isPasswordMetPatternRequirements(System.String)

 Checks if the password is met pattern requirements 

|Name | Description |
|-----|------|
|password: |Password|
**Returns**: 



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.firstNameIsValid(System.String)

 Checks if the first name is valid 

|Name | Description |
|-----|------|
|firstName: |First name|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.lastNameIsValid(System.String)

 Checks if the last name is valid 

|Name | Description |
|-----|------|
|lastName: |Last name|
**Returns**: bool



---
#### Method Infrastructure.Validators.RegisterBindingModelValidator.isNameMetPatternRequirements(System.String)

 Checks if the first name or the last name are met pattern requirements 

|Name | Description |
|-----|------|
|name: |First name or last name|
**Returns**: bool



---


