FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /src
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS run
WORKDIR /app
EXPOSE 80 443
COPY --from=build /app/publish .
ENTRYPOINT [ "dotnet", "YesNo.Api.dll" ]
