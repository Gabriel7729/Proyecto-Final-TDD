using System;
using System.IO;
using System.Text;

namespace Proyecto_Final_TDD.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera;
            Vaso vasosPequeno;
            Vaso vasosMediano;
            Vaso vasosGrande;
            Azucarero azuquero;
            MaquinaDeCafe maquinaDeCafe;

            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azuquero = new Azucarero(20);

            Console.WriteLine("Bienvenido a la maquina de cafe, Cual desea que sea el tamaño de su vaso, pequeno,mediano o Grande (Porfavor escribir la opcion tal cual esta puesta en la sentencia.) ?");
            string recipiente = "";

            while (recipiente != "pequeno" && recipiente != "mediano" && recipiente != "Grande")
            {
                recipiente = Console.ReadLine();
            }

            Console.WriteLine("Cuantos vasos desea?");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuanta azucar desea?");
            int cantAzucar = Convert.ToInt32(Console.ReadLine());

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasoPequeno(vasosPequeno);
            maquinaDeCafe.setVasoMediano(vasosMediano);
            maquinaDeCafe.setVasoGrande(vasosGrande);
            maquinaDeCafe.setAzucar(azuquero);


            Vaso vaso = maquinaDeCafe.getTipoVaso(recipiente);
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, cantidad, cantAzucar);

            Console.WriteLine(resultado);
            Console.WriteLine(".... Usted ordeno: ");
            Console.WriteLine("Vasos de tamaño: ");
            Console.WriteLine(recipiente);
            Console.WriteLine("Cantidad de vasos: ");
            Console.WriteLine(cantidad);
            Console.WriteLine("y cantidad de azucar: ");
            Console.WriteLine(cantAzucar);
            Console.WriteLine("Que tenga un buen dia!");

            Console.ReadKey();
        }
    }
}
