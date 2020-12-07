using System;

public abstract class Aves: Animal
{
    public string ColorPlumaje { get; set; }
    public int Patas { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando..");
    }
}