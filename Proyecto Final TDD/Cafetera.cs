using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final_TDD
{
    public class Cafetera
    {
		private int cantidadCafe;

		public Cafetera(int cantidadCafe)
		{
			this.cantidadCafe = cantidadCafe;
		}

		public void SetCantidadDeCafe(int cantidad)
		{
			cantidadCafe = cantidad;
		}

		public int GetCantidadDeCafe()
		{
			return cantidadCafe;
		}

		public bool HasCafe(int cantidad)
		{

			if (cantidadCafe >= cantidad)
				return true;
			else
				return false;
		}

		public void GiveCafe(int cantidad)
		{
			cantidadCafe -= cantidad;
		}
    }
}
