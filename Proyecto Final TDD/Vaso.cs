using System;

namespace Proyecto_Final_TDD
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

		public Vaso(int cantidadVasos, int contenido)
		{
			this.cantidadVasos = cantidadVasos;
			this.contenido = contenido;
		}

		public bool HasVasos(int cantidad)
		{
			return cantidad <= cantidadVasos ? true : false;
		}
		public void GiveVasos(int cantidad)
		{
			cantidadVasos -= cantidad;
		}

		public int GetCantidadDeVasos()
		{
			return cantidadVasos;
		}

		public int GetContenido()
		{
			return contenido;
		}

		public void SetCantidadVasos(int cantidad)
		{
			cantidadVasos = cantidad;
		}
	}
}
