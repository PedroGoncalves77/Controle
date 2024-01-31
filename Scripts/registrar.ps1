param($n)
$younger = "$n.md"
$old = "$n.md~"
$pathOld = "C:\Projetos\ControleDeMaterial\Anot\$old"
$pathYoung = "C:\Projetos\ControleDeMaterial\Anot\$younger"
copy $pathYoung $PathOld  2>&1 >> error.log
rm $pathOld 2>&1 >> error.log
