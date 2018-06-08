FROM microsoft/dotnet:2.1-runtime AS base

ADD bin/Release/netcoreapp2.1/publish /app/

FROM base AS final
WORKDIR /app
ENTRYPOINT ["dotnet", "./Greeter.Backend.dll"]
