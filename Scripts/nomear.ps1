param($n)
$pathDir = "C:\Projetos\ControleDeMaterial\Anot"
$path = "C:\Projetos\ControleDeMaterial\Anot\.md"
$nome = "$n.md"
copy $path "$pathDir\$nome"
dir -File $pathDir | 
? Name -Like "*.md~"| 
rm  2>&1 >> error.log
Clear-Content $path 2>&1 >> error.log





