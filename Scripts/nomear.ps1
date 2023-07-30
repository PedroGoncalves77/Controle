param($n)
$pathDir = "C:\Projetos\ControleDeMaterial\Anot"
$path = "C:\Projetos\ControleDeMaterial\Anot\.md"
$nome = "$n.md"
copy $path "$pathDir\$nome" 2>&1 > $null
dir -File $pathDir | 
? Name -Like "*.md~"| 
Remove-Item
Clear-Item $path





