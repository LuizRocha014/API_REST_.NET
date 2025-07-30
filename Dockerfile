# Imagem base do ASP.NET para execução
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Fase de build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SmartStorege/API_REST_.NET.csproj", "SmartStorege/"]
RUN dotnet restore "SmartStorege/API_REST_.NET.csproj"
COPY . .
WORKDIR "/src/SmartStorege"
RUN dotnet build "API_REST_.NET.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Fase de publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "API_REST_.NET.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Fase final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API_REST_.NET.dll"]
