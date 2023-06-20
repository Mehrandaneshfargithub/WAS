#FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
#WORKDIR /app
#EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

WORKDIR /app

COPY NuGet.Config /


COPY . ./


# Copy csproj and restore as distinct layers
#COPY /Common/*.csproj ./
COPY *.csproj ./
#RUN dotnet restore
RUN dotnet restore WPH/WPH.csproj

# Copy everything else and build
COPY . ./
#RUN ls
RUN dotnet publish -c Release -o out
#RUN dotnet build

#COPY /pa/*.dll /app/out/
#COPY . ./
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app



COPY --from=build-env /app/out .


#COPY Stimulsoft.Base.dll .
#COPY Stimulsoft.Data.dll .
#COPY Stimulsoft.Map.dll .
#COPY Stimulsoft.Report.Check.dll .
#COPY Stimulsoft.Report.dll .
#COPY Stimulsoft.Report.Helper.dll .
#COPY Stimulsoft.Report.Mvc.NetCore.dll .
#COPY Stimulsoft.Report.Web.dll .
#COPY Stimulsoft.Report.WebDesign.dll .
#COPY Stimulsoft.System.dll .



ENTRYPOINT ["dotnet", "WPH.dll"]