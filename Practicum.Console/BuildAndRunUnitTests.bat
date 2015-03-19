@ECHO OFF

set FullPathBinSolution=C:\Projetos\Grosvenor\Practicum\Practicum\Practicum.sln
set FullPathBinUnitTest=C:\Projetos\Grosvenor\Practicum\Practicum\Practicum.Tests\bin\Release\Practicum.Tests.dll

set VSFolder=C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\
set DOTNETFX=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX%
set PATH=%PATH%;%VSFolder%

echo Start Build Process ...

msbuild %FullPathBinSolution% /p:Configuration=Release

echo Building phase Done...

echo Start UnitTest...

mstest /testcontainer:"%FullPathBinUnitTest%" /detail:stdout >> output.txt

echo Done.

pause