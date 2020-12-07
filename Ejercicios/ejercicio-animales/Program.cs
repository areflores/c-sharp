using System;

namespace ejercicio_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERRO");
            Console.WriteLine("*****");

             Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.todo());
            Console.WriteLine(" ");

            Console.WriteLine("GATO");
            Console.WriteLine("****");
            
            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.todo());
            Console.WriteLine(" ");

            Console.WriteLine("MONO");
            Console.WriteLine("****");

            Mono m = new Mono("Luna", 4, "Afectivo");
            m.Comer();
            m.Caminar();
            m.Gritos();

            Console.WriteLine(m.todo());

            Console.WriteLine(" ");
            Console.WriteLine("AGUILA");
            Console.WriteLine("******");

            Aguila a = new Aguila("Pichi", 2, "MarronOscuro", "lagartijas");
            a.VolarAlto();
            a.Comer();
            a.Volar();
            a.Proporcion();

            Console.WriteLine(a.todo());
            Console.WriteLine(" ");

            Console.WriteLine("LORO");
            Console.WriteLine("****");

            Loro l = new Loro("Paco", 2, "Verde", "Sociable");
            l.Comer();
            l.Volar();
            l.Hablar();

            Console.WriteLine(l.todo());

            Console.WriteLine(" ");
            
            Console.WriteLine("PEZGLOBO");
            Console.WriteLine("********");

            PezGlobo pe = new PezGlobo("Dori", 2, 4);
            pe.Comer();
            pe.Nadar();
            pe.Inflarse();
            pe.Descripcion();

            Console.WriteLine(pe.todo());

        }
    }
}
