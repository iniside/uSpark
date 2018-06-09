FROM microsoft/dotnet:2.1-runtime

ADD bin/Release/netcoreapp2.1/publish /app/

WORKDIR /app
ENTRYPOINT ["/usr/bin/dotnet", "./Greeter.Backend.dll"]
