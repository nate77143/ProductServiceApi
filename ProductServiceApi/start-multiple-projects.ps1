# start-multiple-projects.ps1

# Start ProductService (API)
Write-Host "Starting ProductService API..."
Start-Process "dotnet" "run --project .\ProductServiceApi\ProductServiceApi.csproj" 

# Start IdentityServer
Write-Host "Starting IdentityServer..."
Start-Process "dotnet" "run --project .\IdentityServer\IdentityServer.csproj" 