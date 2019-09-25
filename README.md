# Getting started

API do Conciliador

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (Conciliador.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Conciliador library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

### 3. Add reference of the library project

In order to use the Conciliador library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Conciliador.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```Conciliador.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Conciliador-CSharp&workspaceName=Conciliador&projectName=Conciliador.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| accessToken | Token de Acesso |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string accessToken = "accessToken"; // Token de Acesso

ConciliadorClient client = new ConciliadorClient(accessToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [AcessoController](#acesso_controller)

## <a name="acesso_controller"></a>![Class: ](https://apidocs.io/img/class.png "Conciliador.Standard.Controllers.AcessoController") AcessoController

### Get singleton instance

The singleton instance of the ``` AcessoController ``` class can be accessed from the API Client.

```csharp
AcessoController acesso = client.Acesso;
```

### <a name="create_gerar_token_acesso"></a>![Method: ](https://apidocs.io/img/method.png "Conciliador.Standard.Controllers.AcessoController.CreateGerarTokenAcesso") CreateGerarTokenAcesso

> Todas as funcionalidades do sistema necessitam ter um token de autenticação para serem acessadas.
> 
> Este endpoint


```csharp
Task<string> CreateGerarTokenAcesso(
        string username,
        string password,
        string clientId,
        string clientSecret)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| username |  ``` Required ```  | Nome do usuário para acesso |
| password |  ``` Required ```  | Senha do seu usuário para acesso |
| clientId |  ``` Required ```  | Cliente Id recebido da Braspag na contratação do conciliador |
| clientSecret |  ``` Required ```  | Cliente Secret recebido da Braspag na contratação do conciliador |


#### Example Usage

```csharp
string username = "username";
string password = "password";
string clientId = "client_id";
string clientSecret = "client_secret";

string result = await acesso.CreateGerarTokenAcesso(username, password, clientId, clientSecret);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | The user credentials were incorrect |


[Back to List of Controllers](#list_of_controllers)



