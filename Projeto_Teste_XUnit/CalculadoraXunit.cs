using Projeto_Teste;
using Xunit;

namespace Projeto_Teste_XUnit
{
    public class CalculadoraXunit
    {
        [Fact]
        public void MetodoTest1()
        {
            //Prepara��o (ARRANGE)
            double numero1 = 1;
            double numero2 = 1;
            double Total = 2;

            //A��o (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verifica��o (ASSERT)
            Assert.Equal(Total, resultado);
        }

        [Theory]
        [InlineData(1, 5, 9)]
        [InlineData(2, 8, 10)]
        [InlineData(4, 6, 10)]
        public void MetodoTest2(double numero1, double numero2, double numero3)
        {
            //A��o (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verifica��o (ASSERT)
            Assert.Equal(numero3, resultado);
        }
    }
}