using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }

    public string todo()
    {
        return Nombre + " " + Patas;

    }

    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");
    }
}