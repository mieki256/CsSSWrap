@echo off
echo # .exe をコピーして .scr を作成します。
echo.

setlocal
set BASENAME=CsSSWrap
set SRCFILE=CsSSWrap\bin\Release\net9.0-windows\publish\win-x64\%BASENAME%.exe
set DSTFILE=build\%BASENAME%.scr

if exist %DSTFILE% (
  echo Found  "%DSTFILE%
  echo Delete "%DSTFILE%
  del %DSTFILE%
)

if not exist %SRCFILE% (
  echo Error. Not Found "%SRCFILE%"
) else (
  echo Found "%SRCFILE%"
  echo Copy to "%DSTFILE%"
  echo.
  copy "%SRCFILE%" "%DSTFILE%"
)

endlocal

echo.
@rem timeout /T 4
pause
