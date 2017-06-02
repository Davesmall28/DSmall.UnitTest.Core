SET packageVersion=1.2.0

NuGet.exe pack ../Springboard365.UnitTest.Core.csproj -Build -symbols -Version %packageVersion%

NuGet.exe push Springboard365.UnitTest.Core.%packageVersion%.nupkg

pause