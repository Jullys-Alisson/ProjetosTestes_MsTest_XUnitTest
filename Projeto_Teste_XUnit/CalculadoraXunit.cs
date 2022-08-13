using Projeto_Teste;
using Xunit;

namespace Projeto_Teste_XUnit
{
    public class CalculadoraXunit
    {
        [Fact]
        public void MetodoTest1()
        {
            //Preparação (ARRANGE)
            double numero1 = 1;
            double numero2 = 1;
            double Total = 2;

            //Ação (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verificação (ASSERT)
            Assert.Equal(Total, resultado);
        }

        [Theory]
        [InlineData(1, 5, 9)]
        [InlineData(2, 8, 10)]
        [InlineData(4, 6, 10)]
        public void MetodoTest2(double numero1, double numero2, double numero3)
        {
            //Ação (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verificação (ASSERT)
            Assert.Equal(numero3, resultado);
        }
    }
}