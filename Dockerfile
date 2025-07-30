# Etapa base
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copia o .csproj e restaura dependências
COPY WEB_REST_PRO/WEB_REST_PRO.csproj ./WEB_REST_PRO/
RUN dotnet restore ./WEB_REST_PRO/WEB_REST_PRO.csproj

# Copia todo o código
COPY . .

# Define o diretório de trabalho correto
WORKDIR /src/WEB_REST_PRO
RUN dotnet build WEB_REST_PRO.csproj -c Release -o /app/build

# Etapa de publish
FROM build AS publish
RUN dotnet publish WEB_REST_PRO.csproj -c Release -o /app/publish /p:UseAppHost=false

# Final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WEB_REST_PRO.dll"]
