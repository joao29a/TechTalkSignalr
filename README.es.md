## Cómo utilizar

Comenzar redis con docker:

```sh
docker run --name tech-redis -p 9090:6379 redis
```

Ejecutando el servidor:

```sh
dotnet run --urls=http://localhost:8001 --project SignalrServerWorker/SignalrServerWorker.csproj
```

Ejecutando el cliente:

```sh
dotnet run --project SignalrClient/SignalrClient.csproj 8001
```

## Docs

* [Introducción a ASP.NET Core SignalR](https://docs.microsoft.com/es/aspnet/core/signalr/introduction?view=aspnetcore-3.1)
* [Tutorial: Introducción a ASP.NET Core SignalR](https://docs.microsoft.com/es/aspnet/core/tutorials/signalr?view=aspnetcore-3.1&tabs=visual-studio)
* [ASP.NET Core host SignalR en los servicios en segundo plano](https://docs.microsoft.com/es/aspnet/core/signalr/background-services?view=aspnetcore-3.1)
* [Usar hubs en SignalR para ASP.net Core](https://docs.microsoft.com/es/aspnet/core/signalr/hubs?view=aspnetcore-3.1)
* [Administrar usuarios y grupos en SignalR](https://docs.microsoft.com/es/aspnet/core/signalr/groups?view=aspnetcore-3.1)
* [Autenticación y autorización en ASP.NET Core SignalR](https://docs.microsoft.com/es/aspnet/core/signalr/authn-and-authz?view=aspnetcore-3.1)
* [Configuración de un backplane de Redis para ASP.NET Core SignalR la escalabilidad horizontal](https://docs.microsoft.com/es/aspnet/core/signalr/redis-backplane?view=aspnetcore-3.1)
