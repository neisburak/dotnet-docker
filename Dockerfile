# build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

COPY *.sln .

# COPY Business/Business.csproj ./Business/
# COPY DataAccess/DataAccess.csproj ./DataAccess/
# COPY Entities/Entities.csproj ./Entities/
# COPY Api/Api.csproj ./Api/

# Instead of copying every .csproj file just run the command below.
COPY **/*.csproj .
# This line then moves the project files to the correct folders
RUN for file in $(ls *.csproj); do mkdir -p ${file%.*}/ && mv $file ${file%.*}/; done
RUN dotnet restore

COPY . .
RUN dotnet publish -c release -o /app --no-restore

# serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS="http://*:80"
EXPOSE 80
ENTRYPOINT ["dotnet", "Api.dll"]