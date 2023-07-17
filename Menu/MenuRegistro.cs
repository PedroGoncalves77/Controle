﻿namespace ControleDeMaterial.Menu;

internal class MenuRegistro
{
    public void Iniciar() 
    {
        Console.Clear();
        Console.WriteLine("Lista de registro de materias:");
        Materiais materias = new();
        foreach(var m in materias.Registro()) 
        {
            Console.WriteLine(m);
        }
        Console.ReadKey();
    }
}
