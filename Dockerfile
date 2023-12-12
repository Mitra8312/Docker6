FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/bin/Debug/netcoreapp3.1

FROM base AS final
WORKDIR /app
COPY --from=build /app/bin/Debug/netcoreapp3.1 .

ENTRYPOINT ["dotnet", "net.dll"]
