using System;
public class Mono: Mamifero
{
    public string Comportamiento { get; set; }

    public Mono(string nombre, int patas, string comportamiento)
    {
        Nombre = nombre;
        Patas = patas;
        Comportamiento = comportamiento;
    }

    public string todo()
    {
        return Nombre + " " + Patas;

    }
    
    public void Gritos()
    {
        Console.WriteLine("UU uu aa aa");
    }

}