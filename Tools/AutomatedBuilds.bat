@echo off

:: 设置编辑器路径，不设置自动寻找最高版本的编辑器
::set Editor=D:\Unity\Editor\2022.3.2f1

:: 工程项目路径
set ProjectPath=..\

:: 目标打包平台(Win64,Android,iOS)
set BuildTarget=Win64

REM 进入项目路径
cd %ProjectPath%
set ProjectPath=%cd%

REM 寻找最高版本的编辑器
setlocal enabledelayedexpansion
if not defined Editor (
    for /f "skip=1 tokens=*" %%a in ('reg query "HKEY_CURRENT_USER\Software\Unity Technologies\Installer"') do set lastkey=%%a
    for /f "skip=2 tokens=3*" %%a in ('reg query "!lastkey!" /v "Location x64"') do set Editor=%%b
)

echo AutomatedBuild Start...
echo EditorPath: "%Editor%"
echo BuildTarget: "%BuildTarget%"

REM 获取项目文件夹名，并在项目上级目录下创建一个“文件名__Build的文件夹”
pushd %1 & for %%i in (.) do set current=%%~ni
set ClonePath=%ProjectPath%\..\%current%_Build
if not exist %ClonePath% (
    echo CreateFolder:%ClonePath%
    md %ClonePath% >nul
)
cd /d %ClonePath%
set ClonePath=%cd%

REM 如果存在git文件夹就重置(防止上次打包修改某些文件)然后拉取
if exist %ClonePath%\.git (
    <nul set /p=Git Reset...
    git reset --hard >nul
    echo Done.
    git config core.sparsecheckout true
    echo "!/Tools" >> .git/info/sparse-checkout
    echo "!/Docs" >> .git/info/sparse-checkout
    <nul set /p=Git Pull...
    git -C %ClonePath% pull >nul
    echo Done.
) else (
    REM 如果不存在就克隆项目,考虑已经复制项目但是没有git文件夹的情况
    if exist %ClonePath% (
        rd /s /Q %ClonePath%
    )
    <nul set /p=Git Clone...
    git clone %ProjectPath% %ClonePath% >nul
    echo Done.
)

REM 启动Unity命令行打包
cd /d %Editor%\Editor
echo on
Unity.exe ^
-batchmode ^
-quit ^
-nographics ^
-buildTarget %BuildTarget% ^
-projectPath %ClonePath% ^
-executeMethod ProjectBuilder.Build ^
-logFile %ClonePath%\Output\logs.txt
@echo off

REM 打包完成后打开文件夹
explorer %ClonePath%\Output

echo Success.

pause