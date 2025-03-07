# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the solution file and project files
COPY eWellness.sln ./
COPY eWellness/eWellness.API.csproj eWellness/
COPY eWellness.BL/*.csproj ./eWellness.BL/
COPY eWellness.BL.Common/eWellness.BL.Common.csproj eWellness.BL.Common/
COPY eWellness.Core/eWellness.Core.csproj eWellness.Core/
COPY eWellness.Core.Common/eWellness.Core.Common.csproj eWellness.Core.Common/
COPY eWellness.DL/eWellness.DL.csproj eWellness.DL/
COPY eWellness.DL.Common/eWellness.DL.Common.csproj eWellness.DL.Common/
COPY eWellness.MQ/eWellness.MQ.csproj eWellness.MQ/

# Restore dependencies for the solution
RUN dotnet restore "eWellness.sln"

# Copy the entire source code
COPY . .

# Build the API project
WORKDIR "./eWellness"
RUN dotnet build "eWellness.API.csproj" -c Release -o /app/build

# Publish the API
FROM build AS publish
RUN dotnet publish "eWellness.API.csproj" -c Release -o /app/publish

# Final stage: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eWellness.API.dll"]
