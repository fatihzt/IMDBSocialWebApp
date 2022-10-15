#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IMDBSWA.Api/IMDBSWA.Api.csproj", "IMDBSWA.Api/"]
COPY ["IMDBSWA.Business/IMDBSWA.Business.csproj", "IMDBSWA.Business/"]
COPY ["IMDBSWA.Core/IMDBSWA.Core.csproj", "IMDBSWA.Core/"]
COPY ["IMDBSWA/IMDBSWA.Entities.csproj", "IMDBSWA/"]
RUN dotnet restore "IMDBSWA.Api/IMDBSWA.Api.csproj"
COPY . .
WORKDIR "/src/IMDBSWA.Api"
RUN dotnet build "IMDBSWA.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IMDBSWA.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IMDBSWA.Api.dll"]