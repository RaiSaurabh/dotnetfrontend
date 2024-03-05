#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ASP_NET_Core_App/ASP_NET_Core_App.csproj", "ASP_NET_Core_App/"]
RUN dotnet restore "./ASP_NET_Core_App/./ASP_NET_Core_App.csproj"
COPY . .
WORKDIR "/src/ASP_NET_Core_App"
RUN dotnet build "./ASP_NET_Core_App.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ASP_NET_Core_App.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASP_NET_Core_App.dll"]