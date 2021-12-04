using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final_TDD
{
    public class MaquinaDeCafe
    {
		private Cafetera cafetera;
		private Vaso vasoPequeno;
		private Vaso vasoMediano;
		private Vaso vasoGrande;
		private Azucarero azucar;

		public Vaso getTipoVaso(string tipoDeVaso)
		{

			if (tipoDeVaso.Equals("pequeno"))
				return this.vasoPequeno;
			else if (tipoDeVaso.Equals("mediano"))
				return this.vasoMediano;
			else
				return this.vasoGrande;

		}

		public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
		{

			if (tipoDeVaso.GetCantidadDeVasos() <= cantidadDeVasos)
				return "No hay vasos";

			int cantidadTotalCafe = tipoDeVaso.GetContenido() * cantidadDeVasos;

			if (cantidadTotalCafe > this.cafetera.GetCantidadDeCafe())
				return "No hay cafe";

			if (cantidadDeAzucar > this.azucar.GetCantidadDeAzucar())
				return "No hay azucar";

			this.cafetera.SetCantidadDeCafe(this.cafetera.GetCantidadDeCafe() - cantidadTotalCafe);
			tipoDeVaso.SetCantidadVasos(tipoDeVaso.GetCantidadDeVasos() - cantidadDeVasos);
			this.azucar.SetCantidadDeAzucar(this.getAzucar().GetCantidadDeAzucar() - cantidadDeAzucar);

			return "Felicitaciones";

		}

		public Cafetera getCafetera()
		{
			return cafetera;
		}

		public void setCafetera(Cafetera cafetera)
		{
			this.cafetera = cafetera;
		}

		public Vaso getVasoPequeno()
		{
			return vasoPequeno;
		}

		public void setVasoPequeno(Vaso vasoPequeno)
		{
			this.vasoPequeno = vasoPequeno;
		}

		public Vaso getVasoMediano()
		{
			return vasoMediano;
		}

		public void setVasoMediano(Vaso vasoMediano)
		{
			this.vasoMediano = vasoMediano;
		}

		public Vaso getVasoGrande()
		{
			return vasoGrande;
		}

		public void setVasoGrande(Vaso vasoGrande)
		{
			this.vasoGrande = vasoGrande;
		}

		public Azucarero getAzucar()
		{
			return azucar;
		}

		public void setAzucar(Azucarero azucar)
		{
			this.azucar = azucar;
		}
	}
}
