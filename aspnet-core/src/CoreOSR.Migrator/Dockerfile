#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/CoreOSR.Migrator/CoreOSR.Migrator.csproj", "src/CoreOSR.Migrator/"]
COPY ["src/CoreOSR.EntityFrameworkCore/CoreOSR.EntityFrameworkCore.csproj", "src/CoreOSR.EntityFrameworkCore/"]
COPY ["src/CoreOSR.Core/CoreOSR.Core.csproj", "src/CoreOSR.Core/"]
COPY ["src/CoreOSR.Core.Shared/CoreOSR.Core.Shared.csproj", "src/CoreOSR.Core.Shared/"]
RUN dotnet restore "src/CoreOSR.Migrator/CoreOSR.Migrator.csproj"
COPY . .
WORKDIR "/src/src/CoreOSR.Migrator"
RUN dotnet build "CoreOSR.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoreOSR.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoreOSR.Migrator.dll", "-s"]
