::https://docs.unity3d.com/2021.3/Documentation/Manual/EditorCommandLineArguments.html
@echo off

::set Editor=D:\Unity\Editor\2022.2.21f1\Editor
set Editor=C:\Program Files\Unity\Editor\2022.2.21f1\Editor
set ProjectPath=..\
set BuildTarget=Win64
::Win64,Android,iOS

cd %ProjectPath%
set ProjectPath=%cd%

pushd %1 & for %%i in (.) do set current=%%~ni
SET PackPath=%ProjectPath%\..\%current%_Build

if not exist %PackPath% md %PackPath%

if exist %PackPath%\.git (
git -C %PackPath% pull 
) else (
    if exist %PackPath% (
        rd /s /Q %PackPath%
    )
git clone %ProjectPath% %PackPath% 
)

cd /d %Editor%
echo Build Project.

echo on
Unity.exe -batchmode -quit -nographics -buildTarget %BuildTarget% -projectPath %PackPath% -executeMethod ProjectBuilder.Build -logFile %PackPath%\Output\logs.txt
@echo off

echo done.

explorer %PackPath%\Output