using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Proyecto_Final_TDD.Test
{
    public class TestCafetera
    {
        [Fact]
        public void deberiaDevolverVSiExisteCafe()
        {

            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);
            Assert.True(resultado);
        }

        [Fact]
        public void deberiaDevolverFalsoSinoExisteCafe()
        {

            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);
            Assert.False(resultado);
        }

        [Fact]
        public void deberiaRestarCafeACafetera()
        {

            Cafetera cafetera = new Cafetera(10);

            cafetera.GiveCafe(7);
            Assert.Equal(3, cafetera.GetCantidadDeCafe());

        }
    }
}
