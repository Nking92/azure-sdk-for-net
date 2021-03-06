$RepoRoot = Resolve-Path $PSScriptRoot\..\..\..
$ObjDirectory = "$RepoRoot\artifacts\obj";
$TempPath = [System.IO.Path]::GetTempPath() + "\Azure.Core.All"
dotnet restore $RepoRoot\eng\data-plane.proj

$slnName = "Azure.Core.All.sln";
if (Test-Path $slnName)
{
    Remove-Item $slnName
}

dotnet new sln -o $TempPath
Move-Item $tempPath\$slnName .\$slnName
Remove-Item $TempPath -Force

foreach ($projectName in Get-ChildItem -Directory $ObjDirectory)
{
    Write-Host "Processing $projectName"
    $assets = Get-Content -Raw $ObjDirectory\$projectName\project.assets.json;

    if ($assets.Contains("Azure.Core"))
    {
        $assetsJson = ConvertFrom-Json $assets;
        $projectPath = $assetsJson.project.restore.projectPath;
        dotnet sln $slnName add $projectPath
    }
}