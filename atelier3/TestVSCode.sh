# Installer .Net Core Test Explorer Jun Han

mkdir MonProjet
cd MonProjet

# Si le projet à tester n'existe pas
dotnet new console MonProjet

dotnet new mstest MonProjetTest

cd MonProjetTest

dotnet add reference ../MonProjet/MonProjet.csproj

# Ajouter dans settings.json : "dotnet-test-explorer.testProjectPath": "**/*Test.@(csproj|vbproj|fsproj)"

dotnet build 

# Ajouter le using