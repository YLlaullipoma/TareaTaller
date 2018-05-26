using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusLlaullipoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string targetUsuario = Console.ReadLine();
            Console.WriteLine("Bienvenido"+ " " + targetUsuario);

            List<Consumibles> consumibles = new List<Consumibles>();
            consumibles.Add(new Consumibles("Huevo",10f,8f));
            consumibles.Add(new Consumibles("Pollo",2f,1f));
            consumibles.Add(new Consumibles("Pescado", 2f, 1f));
            consumibles.Add(new Consumibles("Arroz", 1000f, 1000f));
            consumibles.Add(new Consumibles("Zanahoria", 15f, 25f));
            consumibles.Add(new Consumibles("Cebolla", 10f, 25f));
            consumibles.Add(new Consumibles("Tomate", 20f, 25f));
            consumibles.Add(new Consumibles("Aji", 5f, 2f));
            consumibles.Add(new Consumibles("CremaPicante", 150f, 150f));
            consumibles.Add(new Consumibles("Rocoto", 5f, 1f));
            consumibles.Add(new Consumibles("Comino", 60f, 60f));
            consumibles.Add(new Consumibles("Pimenton", 60f, 60f));
            consumibles.Add(new Consumibles("Pimienta", 60f, 60f));
            consumibles.Add(new Consumibles("Sal", 100f, 100f));
            consumibles.Add(new Consumibles("Azucar", 100f, 80f));
            consumibles.Add(new Consumibles("Deliarroz", 10f, 10f));
            consumibles.Add(new Consumibles("Ajinomoto", 10f, 8f));

            List<Comida> comidas = new List<Comida>();
            comidas.Add(new Comida("Huevo Frito", "huevo-arroz-sal-deliarroz-agua-aceite", 15f, "Sartén-OllaArrocera"));

            Console.WriteLine("Preparando huevo frito");
            Console.WriteLine("¿Cuantos deseas?");
            Console.WriteLine("Escriba la cantidad....");
            string targetCantidad = Console.ReadLine();
            Console.WriteLine("Preparando" + " " + targetCantidad + " "+ "porciones");
            Console.WriteLine("Usando..");
            Console.WriteLine(consumibles[0]);
        }
    }
}
