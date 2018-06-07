FROM microsoft/dotnet:2.1-runtime-deps-alpine3.7 AS base

ADD bin/Release/netcoreapp2.1/publish /app/

FROM base AS final
WORKDIR /app
ENTRYPOINT ["dotnet", "Greeter.Backend.dll"]
