@echo off

color 0a
taskkill /f /im explorer.exe
cls

:re
echo 비밀번호를 입력해주세요. (힌트 : minecraft)
echo 참고로 이 창을 끄면 아무것도 할수 없습니다.

set /p password=암호 :
if %password%==minigold649 goto hp

:hs
cls
goto re

:hp
cls
echo minigold님 안녕하세요.
start explorer.exe
pause