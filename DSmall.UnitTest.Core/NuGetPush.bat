..\NuGet\Nuget.exe pack DSmall.UnitTest.Core.csproj -Build -symbol -Properties Configuration=Release

..\NuGet\NuGet push DSmall.UnitTest.Core.1.2.2.nupkg

pause