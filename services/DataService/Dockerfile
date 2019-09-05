FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
COPY . .
RUN dotnet publish services/DataService/DataService.csproj -c release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build /app/services/DataService/out .
#ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT dotnet DataService.dll


