using System;
using System.IO;
using System.Text;

namespace Proyecto_Final_TDD.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la maquina de cafe, Cual desea que sea el tamaño de su vaso, pequeno,mediano o Grande (Porfavor escribir la opcion tal cual esta puesta en la sentencia.) ?");
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
            //Scanner ingreso = new Scanner("");
            var ingreso = new PacketReader("");

            string Recipiente = ingreso.ReadNext<string>();
            Console.WriteLine("Cuantos vasos desea?");
            int Cantidad = ingreso.ReadNext<int>();
            Console.WriteLine("Cuanta azucar desea?");
            int CantAzucar = ingreso.ReadNext<int>();
            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasoPequeno(vasosPequeno);
            maquinaDeCafe.setVasoMediano(vasosMediano);
            maquinaDeCafe.setVasoGrande(vasosGrande);
            maquinaDeCafe.setAzucar(azuquero);


            Vaso vaso = maquinaDeCafe.getTipoVaso(Recipiente);
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, Cantidad, CantAzucar);

            Console.WriteLine(resultado);
            Console.WriteLine(".... Usted ordeno: ");
            Console.WriteLine("Vasos de tamaño: ");
            Console.WriteLine(Recipiente);
            Console.WriteLine("Cantidad de vasos: ");
            Console.WriteLine(Cantidad);
            Console.WriteLine("y cantidad de azucar: ");
            Console.WriteLine(CantAzucar);
            Console.WriteLine("Que tenga un buen dia!");
        }
    }
}
