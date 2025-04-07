# Entity Framework

## Rappels

- Framework for C# .NET
- Use of NET 9
- Entrypoint C# = Program.cs
- Class static -> static members
- 

## Install

```powershell
dotnet tool install --global dotnet-ef
```
![img.png](assets/img.png)

## TP 1

Project creation with locally trusted web API.

```powershell
dotnet new webapi --use-controllers -o MyWebApi
dotnet dev-certs https --trust
```

