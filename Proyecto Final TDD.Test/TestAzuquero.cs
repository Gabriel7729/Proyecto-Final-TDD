using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Proyecto_Final_TDD.Test
{
    public class TestAzuquero
    {
        Azucarero azuquero;
        public TestAzuquero()
        {
            azuquero = new Azucarero(10);
        }

        [Fact]
        public void debeDevolverVsiHaySuficienteAzucar()
        {
            bool resultado = azuquero.HasAzucar(5);
            Assert.True(resultado);

            resultado = azuquero.HasAzucar(10);
            Assert.True(resultado);
        }

        [Fact]
        public void debeDevolverFsiNoHaySuficienteAzucar()
        {
            bool resultado = azuquero.HasAzucar(15);
            Assert.False(resultado);
        }

        [Fact]
        public void deberiaRestarAzucarAlazuquero()
        {
            azuquero.GiveAzucar(5);
            Assert.Equal(5, azuquero.GetCantidadDeAzucar());

            azuquero.GiveAzucar(2);
            Assert.Equal(3, azuquero.GetCantidadDeAzucar());
        }
    }
}

