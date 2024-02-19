@echo off
dotnet build src/Limbo.Umbraco.Boolean --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget\Umbraco13