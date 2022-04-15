chcp 65001

echo '请输入备注' 

set /p remark=请输入备注： 

echo %remark%

git add .

git commit -m '%remark%'

git push
pause
