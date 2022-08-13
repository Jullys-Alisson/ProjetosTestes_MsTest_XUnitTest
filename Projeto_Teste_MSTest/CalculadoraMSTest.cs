using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_Teste;

namespace Projeto_Teste_MSTest
{
    [TestClass]
    public class CalculadoraMSTest
    {
        [TestMethod]
        public void MetodoTest1()
        {
            //Preparação (ARRANGE)
            double numero1 = 1;
            double numero2 = 1;
            double Total = 2;

            //Ação (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verificação (ASSERT)
            Assert.AreEqual(Total, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 5, 6)]
        [DataRow(2, 8, 7)]
        [DataRow(4, 6, 10)]
        public void MetodoTest2(double numero1, double numero2, double numero3)
        {
            //Ação (ACT)
            var resultado = Calculadora.somar(numero1, numero2);

            //Verificação (ASSERT)
            Assert.AreEqual(numero3, resultado);
        }
    }
}