# Installation
## Creating an Environment
```
sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=MyComplexPassword!234' -p 1433:1433 -d microsoft/mssql-server-linux
```
## Packages

1. Install Entity Framework Core and Microsoft Entity Framework sqlserver 
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

```
2. add in < project >.csproj
```xml
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
</ItemGroup>
```
3. The dotnet cli tool would have new command
* try command 
```bash
dotnet ef
```