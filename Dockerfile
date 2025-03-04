# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Define build arguments at the top level
ARG VITE_API_VERSION="/api/v1.0"
ARG VITE_API_BASE_URL="https://dormo.azurewebsites.net"

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS with-node
RUN apt-get update
RUN apt-get install -y curl
RUN curl -sL https://deb.nodesource.com/setup_20.x | bash
RUN apt-get -y install nodejs
# Install TypeScript globally to make 'tsc' available
RUN npm install -g typescript

FROM with-node AS build
ARG BUILD_CONFIGURATION=Release
# Pass down the build arguments
ARG VITE_API_VERSION
ARG VITE_API_BASE_URL
# Set environment variables for the build process
ENV VITE_API_VERSION=${VITE_API_VERSION}
ENV VITE_API_BASE_URL=${VITE_API_BASE_URL}
# Set NODE_ENV for production build optimizations
ENV NODE_ENV=production

WORKDIR /src
COPY ["Dormo.Server/Dormo.Server.csproj", "Dormo.Server/"]
COPY ["dormo.client/dormo.client.esproj", "dormo.client/"]
# Copy package.json and package-lock.json to install dependencies
COPY ["dormo.client/package*.json", "dormo.client/"]

# Install client dependencies first
WORKDIR "/src/dormo.client"
RUN npm install

# Now continue with the rest of the files
WORKDIR "/src"
RUN dotnet restore "./Dormo.Server/Dormo.Server.csproj"
COPY . .

# Setup environment for client build
WORKDIR "/src/dormo.client"
RUN echo "VITE_API_VERSION=${VITE_API_VERSION}" > .env
RUN echo "VITE_API_BASE_URL=${VITE_API_BASE_URL}" >> .env
# Verify TypeScript is installed and available
RUN npm list typescript || npm install --save-dev typescript

WORKDIR "/src/Dormo.Server"
RUN dotnet build "./Dormo.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Dormo.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Dormo.Server.dll"]
