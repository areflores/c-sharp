using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public string todo()
    {
        return Nombre + " " + Patas;

    }


    public Perro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() // <- Abstraccion
    {
        Console.WriteLine("Gua gua gua");
    }

    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un perro grande");
    }

    
}