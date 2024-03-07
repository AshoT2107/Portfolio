#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PortfolioWeb/PortfolioWeb.csproj", "PortfolioWeb/"]
COPY ["PortfolioWeb/appsettings.json", "PortfolioWeb/"]
RUN dotnet restore "PortfolioWeb/PortfolioWeb.csproj"
COPY . .
WORKDIR "/src/PortfolioWeb"
RUN dotnet build "PortfolioWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./PortfolioWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortfolioWeb.dll"]