# dotnet-calc

A Java developers adventures in .NET.

Generated app skeleton + modifications; similar to this:
https://docs.asp.net/en/latest/client-side/yeoman.html

## Command line
Running using dotnet on Ubuntu.
* dotnet restore
* dotnet test test
* cd src/Calc && dotnet run

## Docker
Dockerfile is included to package the app as docker container.

* docker build -t sjostric/dotnet-calc:1.0.0 .
* docker images
* docker run -p 5000:5000 sjostric/dotnet-calc:1.0.0
* docker ps
* docker stop &lt;container_id&gt;

## Test the application
Do REST request to, e.g:
* http://localhost:5000/api/calc/add/5/3
* http://localhost:5000/api/calc/sub/7/4

## Kubernetes
* kubectl create -f calc-app-deployment.yaml,calc-app-service.json
* kubectl autoscale --max=3 --cpu-percent=50 -f calc-app-deployment.yaml 

## Yeoman generated docs

### This application consists of:

*   Sample pages using ASP.NET Core MVC
*   [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

### How to

*   [Add a Controller and View](https://go.microsoft.com/fwlink/?LinkID=398600)
*   [Add an appsetting in config and access it in app.](https://go.microsoft.com/fwlink/?LinkID=699562)
*   [Manage User Secrets using Secret Manager.](https://go.microsoft.com/fwlink/?LinkId=699315)
*   [Use logging to log a message.](https://go.microsoft.com/fwlink/?LinkId=699316)
*   [Add packages using NuGet.](https://go.microsoft.com/fwlink/?LinkId=699317)
*   [Add client packages using Bower.](https://go.microsoft.com/fwlink/?LinkId=699318)
*   [Target development, staging or production environment.](https://go.microsoft.com/fwlink/?LinkId=699319)

### Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

### Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

We would love to hear your [feedback](https://go.microsoft.com/fwlink/?LinkId=518015)
