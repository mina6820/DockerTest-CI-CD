# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project file and restore dependencies
COPY *.csproj .
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/out .

# Run the console app
ENTRYPOINT ["dotnet", "Practice2.dll"]
