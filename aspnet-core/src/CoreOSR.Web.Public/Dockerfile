#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/CoreOSR.Web.Public/CoreOSR.Web.Public.csproj", "src/CoreOSR.Web.Public/"]
COPY ["src/CoreOSR.Web.Core/CoreOSR.Web.Core.csproj", "src/CoreOSR.Web.Core/"]
COPY ["src/CoreOSR.Application/CoreOSR.Application.csproj", "src/CoreOSR.Application/"]
COPY ["src/CoreOSR.Application.Shared/CoreOSR.Application.Shared.csproj", "src/CoreOSR.Application.Shared/"]
COPY ["src/CoreOSR.Core.Shared/CoreOSR.Core.Shared.csproj", "src/CoreOSR.Core.Shared/"]
COPY ["src/CoreOSR.Core/CoreOSR.Core.csproj", "src/CoreOSR.Core/"]
COPY ["src/CoreOSR.EntityFrameworkCore/CoreOSR.EntityFrameworkCore.csproj", "src/CoreOSR.EntityFrameworkCore/"]
COPY ["src/CoreOSR.GraphQL/CoreOSR.GraphQL.csproj", "src/CoreOSR.GraphQL/"]
RUN dotnet restore "src/CoreOSR.Web.Public/CoreOSR.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/CoreOSR.Web.Public"
RUN dotnet build "CoreOSR.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoreOSR.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoreOSR.Web.Public.dll"]
