
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
#RUN dotnet nuget add source H:\\Projects\\WAS\\WPH\\AspNet.Core -n Telerik.UI.for.AspNet.Core
COPY packages /root/.nuget/Nuget/packages
COPY src src
RUN ls /root/.nuget/packages
WORKDIR /app



# Copy csproj and restore as distinct layers
#RUN dotnet nuget add source H:\\Projects\\WAS\\WPH\\AspNet.Core -n Telerik.UI.for.AspNet.Core.2021.2.511
#RUN dotnet restore --source C:\\Users\\mehran\\.nuget\\packages\\
COPY *.csproj ./
RUN dotnet restore


# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "WPH.dll"]