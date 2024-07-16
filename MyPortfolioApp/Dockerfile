# Use the .NET SDK 8.0 as a base image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /src

# Copy the project file(s) and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o /app/publish

# Use Nginx as the base image for hosting the Blazor WebAssembly app
FROM nginx:alpine AS final

# Remove default Nginx website
RUN rm -rf /usr/share/nginx/html/*

# Copy the published output from the build stage to the default Nginx public folder
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html

# Copy custom Nginx configuration
COPY nginx.conf /etc/nginx/nginx.conf

# Expose port 80
EXPOSE 80

# No need for an ENTRYPOINT as Nginx handles serving the static content
