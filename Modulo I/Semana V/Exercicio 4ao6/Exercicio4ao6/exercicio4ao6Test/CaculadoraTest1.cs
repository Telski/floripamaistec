using Exercicio04ao06.Classes;
using Xunit;

namespace Exercicio04ao06Test
{
    // exercicios 04 e 05
    public class CalculadoraTest
    {
        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestMetodoSomarInt()
        {
            int resultado = Calculadora.Somar(5, 5);

            int esperado = 10;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestMetodoSomarDouble()
        {
            double resultado = Calculadora.Somar(5.30, 5.38);

            double esperado = 10.68;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestMetodoSomarFloat()
        {
            float resultado = Calculadora.Somar(5.3f, 5.38f);

            float esperado = 10.68f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestMetodoSomarDecimal()
        {
            decimal resultado = Calculadora.Somar(5.3M, 5.38M);

            decimal esperado = 10.68M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(50000, 50000, 100000)]
        [InlineData(70000, 20000, 90000)]
        public void TestMetodoSomarLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Somar(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        // subtracao

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairInt()
        {
            int resultado = Calculadora.Subtracao(10, 5);

            int esperado = 5;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairDouble()
        {
            double resultado = Calculadora.Subtracao(5.3, 5.25);

            double esperado = 0.05;

            Assert.Equal(esperado, resultado, 4);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairFloat()
        {
            float resultado = Calculadora.Subtracao(5.3f, 5.25f);

            float esperado = 0.05f;

            Assert.Equal(esperado, resultado, 0.0001);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairDecimal()
        {
            decimal resultado = Calculadora.Subtracao(5.3M, 5.25M);

            decimal esperado = 0.05M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Subtrair")]
        [InlineData(120000, 50000, 70000)]
        [InlineData(70000, 20000, 50000)]
        public void TestMetodoSubtrairLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Subtracao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        // multiplicacao 

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoInt()
        {
            int resultado = Calculadora.Multiplicacao(10, 5);

            int esperado = 50;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDouble()
        {
            double resultado = Calculadora.Multiplicacao(5.3, 5.3);

            double esperado = 28.09;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoFloat()
        {
            float resultado = Calculadora.Multiplicacao(5.3f, 5.30f);

            float esperado = 28.09f;

            Assert.Equal(esperado, resultado, 0.0001);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDecimal()
        {
            decimal resultado = Calculadora.Multiplicacao(5.3M, 5.30M);

            decimal esperado = 28.09M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Multiplicacao")]
        [InlineData(120000, 50000, 6000000000)]
        [InlineData(70000, 20000, 1400000000)]
        public void TestMetodoMultiplicacaoLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Multiplicacao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        // Divisao 

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoInt()
        {
            int resultado = Calculadora.Divisao(10, 5);

            int esperado = 2;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDouble()
        {
            double resultado = Calculadora.Divisao(30.5, 2.00);

            double esperado = 15.25;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoFloat()
        {
            float resultado = Calculadora.Divisao(30.5f, 2.00f);

            float esperado = 15.25f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDecimal()
        {
            decimal resultado = Calculadora.Divisao(30.5M, 2.00M);

            decimal esperado = 15.25M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Divisao")]
        [InlineData(100000, 50000, 2)]
        [InlineData(80000, 20000, 4)]
        public void TestMetodoDivisaoLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Divisao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }
    }
}