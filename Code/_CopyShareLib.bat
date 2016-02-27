@echo off

rd /s /q ..\Output\Bin\Debug\

xcopy /e /s /f /i /r /y /k .\ShareLib\Orleans\*.* ..\Output\Bin\Debug\

@echo Gf done

pause
echo on
