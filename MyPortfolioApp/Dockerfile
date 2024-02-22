# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project files into the container
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Create a new image based on the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Copy the published output from the build image
COPY --from=build /app/out ./

# Expose the port that the application will listen on
EXPOSE 80

# Define the entry point for the container
ENTRYPOINT ["dotnet", "MyPortfolioApp.dll"]
