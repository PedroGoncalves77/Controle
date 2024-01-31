$pathDir = "C:\Projetos\ControleDeMaterial\Anot"
dir -File $pathDir | 
? Name -Like "*.un~"| 
Remove-Item  2>&1 >> erro.log
