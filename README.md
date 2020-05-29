 <img align="left"  height="116" src="https://neelbhatt40.files.wordpress.com/2018/02/id21.jpg" />
 
 # Open-source Identity as a Microservice
[![Twitter Follow](https://img.shields.io/twitter/follow/nasraldin_.svg?style=social&label=Follow)](https://twitter.com/_nasraldin)


<br/>


## About IdentityService
IdentityService is a free, open source build on [ASP.NET Core Identity](https://github.com/dotnet/aspnetcore) and [IdentityServer4](https://github.com/IdentityServer/IdentityServer4) framework for centralized identity system. IdentityService incorporates all the protocol implementations and extensibility points needed to integrate token-based authentication, SSO single-sign-on and API access control in your applications.


## Give a Star! :star:
If you like or are using this project to learn or start your solution, please give it a star. Thanks!


## Project Status
IdentityService is in development and not ready yet to use. please follow up on this repo to get the latest info when we ready to release.


## Technologies
* .NET Core 3.1
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* IdentityServer4
* MediatR
* Autofac
* AutoMapper
* FluentValidation
* XUnit, ReportGenerator, Moq & Shouldly


# Goals
The goal of this project is to provide an open-source IdentityService as a Clean Architecture solution, DDD, SOLID, TDD as well as a containerized microservice as a ready solution to help developers and companies to use in production and focus on other business parts in development.


# Overview

### Core

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer. No dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.


### Infrastructure

This layer contains all application logic and classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the core layer. It is dependent on the core layer, but has no dependencies on any other layer or project.

### WebApi

This layer is a RestApi application based and ASP.NET Core API 3.1. This layer depends on the Infrastructure layer.


## Branch structure
Active development happens on the dev branch. This always contains the latest version. The master branch contains the latest versions of the stable codebase. The prod branch contains a codebase for production release.


## Contributors and Using the GitHub Repository
You can contributor to the project and enhance the solution or add new futuer. just clon and make a PR to dev branch.

To get started based on this repository, you need to get a copy locally. You have three options: fork, clone, or download. Most of the time, you probably just want to download.

You should **download the repository**, unblock the zip file, and extract it to a new folder if you just want to play with the project or you wish to use it as the starting point for an application.

You should **fork this repository** only if you plan on submitting a pull request. Or if you'd like to keep a copy of a snapshot of the repository in your own GitHub account.

You should **clone this repository** if you're one of the contributors and you have commit access to it. Otherwise you probably want one of the other options.


## Acknowledgements
IdentityService is built using the following great open source projects and free services:

* [ASP.NET Core](https://github.com/dotnet/aspnetcore)
* [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)


## Support
If you are having problems, please let us know by use the [issue tracker](https://github.com/nasraldin/IdentityServer/issues) for that. fill free to support us to request a feature or enhance code or bug report.


## License

This project is licensed with the [MIT license](LICENSE).
