FROM microsoft/dotnet:2.0-runtime-nanoserver-1709 AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY *.sln ./
COPY TestDocker/TestDocker.csproj TestDocker/
RUN dotnet restore
COPY . .
WORKDIR /src/TestDocker
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestDocker.dll", $arg1, $arg2]
CMD ["arg1", "arg2"]
