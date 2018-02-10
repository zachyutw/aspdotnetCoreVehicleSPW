# Installation

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