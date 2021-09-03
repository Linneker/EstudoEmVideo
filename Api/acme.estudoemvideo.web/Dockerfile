#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["acme.estudoemvideo.web/acme.estudoemvideo.web.csproj", "acme.estudoemvideo.web/"]
RUN dotnet restore "acme.estudoemvideo.web/acme.estudoemvideo.web.csproj"
COPY . .
WORKDIR "/src/acme.estudoemvideo.web"
RUN dotnet build "acme.estudoemvideo.web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "acme.estudoemvideo.web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "acme.estudoemvideo.web.dll"]