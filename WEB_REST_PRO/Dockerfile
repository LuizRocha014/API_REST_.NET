# Etapa base com ASP.NET Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build com SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY API_REST_.NET/API_REST_.NET.csproj ./API_REST_.NET/
RUN dotnet restore ./API_REST_.NET/API_REST_.NET.csproj
COPY . .
WORKDIR /app/API_REST_.NET
RUN dotnet build API_REST_.NET.csproj -c Release -o /app/build

# Etapa de publicação
FROM build AS publish
RUN dotnet publish API_REST_.NET.csproj -c Release -o /app/publish /p:UseAppHost=false

# Final: runtime apenas com arquivos publicados
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API_REST_.NET.dll"]
