using System;


public class Loro: Aves
{
    public string Comportamiento { get; set; }

    public Loro(string nombre, int patas, string colorPlumaje, string comportamiento)
    {
        Nombre = nombre;
        Patas = patas;
        ColorPlumaje = colorPlumaje;
        Comportamiento = comportamiento;
    }

    public string todo()
    {
        return Nombre + " " + ColorPlumaje + " " + Patas + " " + Comportamiento;

    }

    public void Hablar()
    {
        Console.WriteLine("Hablando...");
    }
}