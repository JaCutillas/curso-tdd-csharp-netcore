using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        public List<string> Lista { get; private set; }

        public FizzBuzzTest()
        {
            Lista = FizzBuzz.GenerarLista();
        }

        [Fact]
        public void Contiene_100_elementos()
        {
            Assert.Equal(100, Lista.Count);            
        }

        [Theory]
        [InlineData(1)]
        [InlineData(62)]
        [InlineData(98)]
        public void ContieneNumeros(int valor)
        {            
            Assert.Equal(valor.ToString(), GetContent(Lista, valor));            
        }

        [Theory]
        [InlineData(3)]
        [InlineData(48)]
        [InlineData(99)]
        public void Multiplos_3_Fizz(int valor)
        {
            Assert.Equal("Fizz", GetContent(Lista, valor));            
        }

        [Theory]
        [InlineData(5)]
        [InlineData(50)]
        [InlineData(80)]
        public void Multiplos_5_Buzz(int valor)
        {
            Assert.Equal("Buzz", GetContent(Lista, valor));
        }


        [Theory]
        [InlineData(15)]
        [InlineData(60)]
        [InlineData(90)]
        public void Multiplos_3y5_FizzBuzz(int valor)
        {
            Assert.Equal("FizzBuzz", GetContent(Lista, valor));
        }

        [Theory]
        [InlineData(13)]
        [InlineData(43)]
        [InlineData(83)]
        public void Contiene_3_Fizz(int valor)
        {
            Assert.Equal("Fizz", GetContent(Lista, valor));
        }

        [Theory]
        [InlineData(30)]
        [InlineData(35)]
        public void Contiene_3_Multiplo_5_FizzBuzz(int valor)
        {
            Assert.Equal("FizzBuzz", GetContent(Lista, valor));       
        }

        [Theory]
        [InlineData(25)]
        [InlineData(52)]
        [InlineData(85)]
        public void Contiene_5_Buzz(int valor)
        {
            Assert.Equal("Buzz", GetContent(Lista, valor));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(51)]
        [InlineData(75)]
        public void Contiene_5_Multiplo_3_FizzBuzz(int valor)
        {
            Assert.Equal("FizzBuzz", GetContent(Lista, valor));
        }

        [Theory]
        [InlineData(35)]
        [InlineData(53)]
        public void Contiene_3_Contiene_5_FizzBuzz(int valor)
        {
            Assert.Equal("FizzBuzz", GetContent(Lista, valor));    
        }

        private static string GetContent(List<string> lista, int Posicion)
        {
            return lista[Posicion - 1];
        }

        
    }
    
}