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

# Remove default nginx static assets
RUN rm -rf /usr/share/nginx/html/*

# Copy NGINX configuration
COPY default.conf /etc/nginx/conf.d/default.conf

# Copy the published output from the build stage to the default Nginx public folder
COPY --from=build /app/out/wwwroot /usr/share/nginx/html

## Ensure the _redirects file is copied as well
#COPY _redirects /usr/share/nginx/html/_redirects

# Expose port 80
EXPOSE 8080

# Containers run nginx with global directives and daemon off
CMD ["nginx", "-g", "daemon off;"]

# No need for an ENTRYPOINT as Nginx handles serving the static content