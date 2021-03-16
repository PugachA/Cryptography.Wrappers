### Публикация пакета в GitHub Packages
1. Добавить креденшиалы в nuget.config

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
    <add key="Microsoft Visual Studio Offline Packages" value="C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\" />
    <add key="github" value="https://nuget.pkg.github.com/PugachA/index.json" />
  </packageSources>
  <packageSourceCredentials>
        <github>
            <add key="Username" value="PugachA" />
            <add key="ClearTextPassword" value="TOKEN" />
        </github>
  </packageSourceCredentials>
</configuration> 
```
2. Указать адрес репозитория для публикации

```xml
<PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <PackageId>Cryptography.Wrappers</PackageId>
    <Version>1.0.0</Version>
    <Authors>PugachA</Authors>
    <PackageDescription>Cryptography</PackageDescription>
    <RepositoryUrl>https://github.com/PugachA/Cryptography.Wrappers</RepositoryUrl>
</PropertyGroup>
```
3. Публикация

```
dotnet pack --configuration Release
```
```
dotnet nuget push "Cryptography.Wrappers/bin/Release/Cryptography.Wrappers.1.0.0.nupkg" --source "github"
```