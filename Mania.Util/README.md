# Monogame Util

Build with this command

```ps1
dotnet pack
```

Add local sources

```dotnet
dotnet nuget add source "Mania.Util/bin/Release/" --name LocalSource
```

Add local tool to project

```dotnet
dotnet tool install Mania.Util
```

Use tool in project

```dotnet
dotnet mgcp
```

Update tool, set new version in Mania.Util.csproj

```dotnet
dotnet tool install Mania.Util
```
