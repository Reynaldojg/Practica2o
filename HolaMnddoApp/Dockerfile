# Imagen base para ASP.NET (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Imagen para compilar la app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos todo el proyecto
COPY . .

# Restaurar dependencias
RUN dotnet restore

# Publicar en modo Release
RUN dotnet publish -c Release -o /app/publish

# Imagen final (runtime + app publicada)
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "HolaMnddoApp.dll"]
