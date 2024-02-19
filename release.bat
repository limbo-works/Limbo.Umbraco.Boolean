@echo off
dotnet build src/Limbo.Umbraco.Boolean --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget