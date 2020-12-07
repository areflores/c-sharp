using System;

public class PezGlobo: Peces
{
    public int Dientes { get; set; }

    public PezGlobo(string nombre, int numeroAletas, int dientes)
    {
        Nombre = nombre;
        NumeroAletas = numeroAletas;
        Dientes = dientes;
    }

    public string todo()
    {
        return Nombre + " " + NumeroAletas + " " + Dientes;

    }

    public void Inflarse()
    {
        Console.WriteLine("Inflando...");
    }

    public void Descripcion()
    {
        DescribirPez();
    }

     private void DescribirPez() 
    {
        Console.WriteLine("Cuerpo largo afilado");
    }

}