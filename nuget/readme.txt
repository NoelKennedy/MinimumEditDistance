to build the nuget package: 
Compile the sln
Copy MinimumEditDistance.dll into the lib folder
Update MinimumEditDistance.dll.nuspec
run nuget.exe pack MinimumEditDistance.dll.nuspec
run nuget.exe Push MinimumEditDistance.dll[******* version number].nupkg
