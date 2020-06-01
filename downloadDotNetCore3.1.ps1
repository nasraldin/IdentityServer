# Install .NET Core SDK 3.1 onto the appveyor build server.
# Workaround until they add it to the official image.
# src: https://github.com/appveyor/ci/issues/2746#issuecomment-444292816

Write-Host "Installing .NET Core 3.1 SDK..." -ForegroundColor Cyan
Write-Host "Downloading..."
$exePath = "$env:TEMP\dotnet-sdk-3.1.300-win-x64.exe"
(New-Object Net.WebClient).DownloadFile('https://download.visualstudio.microsoft.com/download/pr/73718445-e2bd-40b7-b698-e8a9ac65f4e5/0816570f697c4e8f1b53ecfb33eaed7f/dotnet-sdk-3.1.300-win-x64.exe', $exePath)
Write-Host "Installing..."
cmd /c start /wait "$exePath" /quiet /norestart
del $exePath
Write-Host "Installed" -ForegroundColor Green
