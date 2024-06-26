# Use the .NET SDK 8.0 as a base image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY MyPortfolioApp.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Use Nginx as the base image for hosting the Blazor WebAssembly app
FROM nginx:alpine AS final

# Copy the published output from the build stage to the default Nginx public folder
COPY --from=build /app/out/wwwroot /usr/share/nginx/html

# Expose port 80
EXPOSE 80

# No need for an ENTRYPOINT as Nginx handles serving the static content
