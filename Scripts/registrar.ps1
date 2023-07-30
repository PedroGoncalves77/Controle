param($n)
$younger = "$n.md"
$old = "$n.md~"
$pathOld = "C:\Projetos\ControleDeMaterial\Anot\$old"
$pathYoun = "C:\Projetos\ControleDeMaterial\Anot\$younger"
copy $pathYoun $PathOld 2>&1 > $null
rm $pathOld