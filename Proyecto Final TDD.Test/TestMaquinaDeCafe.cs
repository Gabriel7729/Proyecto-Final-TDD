using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Proyecto_Final_TDD.Test
{
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequeno;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azuquero;
        MaquinaDeCafe maquinaDeCafe;

        public TestMaquinaDeCafe()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azuquero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasoPequeno(vasosPequeno);
            maquinaDeCafe.setVasoMediano(vasosMediano);
            maquinaDeCafe.setVasoGrande(vasosGrande);
            maquinaDeCafe.setAzucar(azuquero);

        }

        [Fact]
        public void deberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("mediano");

            Assert.Equal(maquinaDeCafe.getVasoMediano(), vaso);
        }

        [Fact]
        public void deberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");

            Assert.Equal(maquinaDeCafe.getVasoPequeno(), vaso);
        }

        [Fact]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("grande");

            Assert.Equal(maquinaDeCafe.getVasoGrande(), vaso);
        }

        [Fact]
        public void deberiaDevolverNoHayVasos()
        {

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");

            String resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);

            Assert.Equal("No hay vasos", resultado);
        }

        [Fact]
        public void deberiaDevolverNoHayCafe()
        {

            Cafetera cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");

            String resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);

            Assert.Equal("No hay cafe", resultado);
        }

        [Fact]
        public void deberiaDevolverNoHayAzucar()
        {

            Azucarero azuquero = new Azucarero(2);
            maquinaDeCafe.setAzucar(azuquero);

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");

            String resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.Equal("No hay azucar", resultado);
        }

        [Fact]
        public void deberiaRestarCafe()
        {

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getCafetera().GetCantidadDeCafe();

            Assert.Equal(40, resultado);
        }

        [Fact]
        public void deberiaRestarVaso()
        {

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getVasoPequeno().GetCantidadDeVasos();

            Assert.Equal(4, resultado);
        }

        [Fact]
        public void deberiaRestarAzucar()
        {

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getAzucar().GetCantidadDeAzucar();

            Assert.Equal(17, resultado);
        }

        [Fact]
        public void deberiaDevolverFelicitaciones()
        {

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            String resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);


            Assert.Equal("Felicitaciones", resultado);
        }
    }
}
