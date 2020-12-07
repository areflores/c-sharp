using System;

public class Aguila: Aves
{
    public string PresaFav { get; set; }

    public Aguila(string nombre, int patas, string colorPlumaje, string presaFav)
    {
        Nombre = nombre;
        Patas = patas;
        ColorPlumaje = colorPlumaje;
        PresaFav = presaFav;
    }

    public string todo()
    {
        return Nombre + " " + ColorPlumaje + " " + Patas + " " + PresaFav;

    }

    public void VolarAlto()
    {
        Console.WriteLine("Volando alto...");
    }

    public void Proporcion()
    {
        DescribirPeso();
    }

    private void DescribirPeso() 
    {
        Console.WriteLine("Aguila con peso de 7 kg");
    }


}

