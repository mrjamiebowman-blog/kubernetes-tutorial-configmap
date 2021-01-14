#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["KubernetesTutorial.csproj", ""]
RUN dotnet restore "./KubernetesTutorial.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "KubernetesTutorial.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KubernetesTutorial.csproj" -c Release -o /app/publish

FROM base AS final

# you won't be able to edit the appsettings.json file b/c it's a linked file
# but you should try so you can learn how this works.
RUN apt-get update && apt-get install -y vim

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KubernetesTutorial.dll"]