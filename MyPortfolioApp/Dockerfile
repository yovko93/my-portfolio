# Use the official .NET SDK image as the base image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore

# Copy everything else and build the application
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use the official .NET runtime image as the base image for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Copy the published output from the build image
COPY --from=build /app/publish ./

# Expose the port that the application will listen on
EXPOSE 80

# Define the entry point for the container
ENTRYPOINT ["dotnet", "MyPortfolioApp.dll"]
