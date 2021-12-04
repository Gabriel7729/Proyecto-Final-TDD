using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final_TDD
{
    public class Azucarero
    {
		private int cantidadDeAzucar;

		public Azucarero(int cantidadDeAzucar)
		{
			this.cantidadDeAzucar = cantidadDeAzucar;
		}

		public void SetCantidadDeAzucar(int cantidad)
		{
			cantidadDeAzucar = cantidad;
		}

		public int GetCantidadDeAzucar()
		{
			return this.cantidadDeAzucar;
		}

		public bool HasAzucar(int cantidadDeAzucar)
		{
			if (cantidadDeAzucar <= this.cantidadDeAzucar)
				return true;
			return
				false;
		}

		public void GiveAzucar(int cantidadDeAzucar)
		{

			this.cantidadDeAzucar -= cantidadDeAzucar;
		}
	}
}
