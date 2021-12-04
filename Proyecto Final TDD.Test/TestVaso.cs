using System;
using Xunit;

namespace Proyecto_Final_TDD.Test
{
    public class TestVaso
    {
        [Fact]
		public void deberiaDevolverVerdaderoSiExistenVasos()
		{

			Vaso vasosPequenos = new Vaso(2, 10);

			bool resultado = vasosPequenos.HasVasos(1);

			Assert.True(resultado);

		}
		[Fact]
		public void deberiaDevolverFalseSiNoExistenVasos()
		{

			Vaso vasosPequenos = new Vaso(1, 3);

			bool resultado = vasosPequenos.HasVasos(2);

			Assert.False(resultado);

		}
		[Fact]
		public void deberiaRestarCantidadDeVasos()
		{

			Vaso vasosPequenos = new Vaso(5, 10);

			vasosPequenos.GiveVasos(1);

			Assert.Equal(4, vasosPequenos.GetCantidadDeVasos());

		}
	}
}
