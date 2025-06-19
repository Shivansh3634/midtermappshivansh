FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /src

# Disable fallback folders
ENV DOTNET_DISABLE_FALLBACK_FOLDERS=true

# Copy custom NuGet config
COPY NuGet.Config ./

# Copy csproj and restore
COPY MidtermApp/MidtermApp.csproj MidtermApp/
COPY MidtermApp.Tests/MidtermApp.Tests.csproj MidtermApp.Tests/

RUN dotnet nuget locals all --clear
RUN dotnet restore MidtermApp.Tests/MidtermApp.Tests.csproj
COPY . .

RUN dotnet build MidtermApp.Tests/MidtermApp.Tests.csproj -c Release --no-restore
RUN dotnet test MidtermApp.Tests/MidtermApp.Tests.csproj -c Release --no-build --verbosity normal

