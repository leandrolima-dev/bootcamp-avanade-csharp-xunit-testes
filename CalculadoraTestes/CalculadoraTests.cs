using Calculadora.Services;

namespace CalculadoraTestes

{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange - Organizar - Definir o cenário de teste aqui na forma de variáveis, objetos, métodos ou funções a serem usados no cenário de teste
            var calc = new CalculadoraImp();
            var num1 = 5;
            var num2 = 10;

            // Act - Executar o teste e obter o resultado a ser comparado com o esperado no teste Assert 
            var result = calc.Somar(num1, num2);

            // Assert - Verificar o resultado do teste com o esperado
            Assert.Equal(15, result);
        }

        [Fact]
        public void Somar_ShouldReturnZeroWhenBothNumbersAreZero()
        {
            // Arrange
            var calc = new CalculadoraImp();
            var num1 = 0;
            var num2 = 0;

            // Act
            var result = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Somar_ShouldReturnNegativeNumberWhenBothNumbersAreNegative()
        {
            // Arrange
            var calc = new CalculadoraImp();
            var num1 = -5;
            var num2 = -10;

            // Act
            var result = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(-15, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(5, 10)]
        [InlineData(-5, -10)]

        public void Somar_ShouldReturnSomarDiversos(int num1, int num2)
        {
            // Arrange
            //Act
            var calc = new CalculadoraImp();
            //Assert
            var result = calc.Somar(num1, num2);

            Assert.Equal(num1 + num2, result);
        }

        [Fact]
        public void NumeroPar_ShouldReturnNumberEven()
        {
            // Arrange
            var calc = new CalculadoraImp();
            var num = 4;

            // Act
            var result = calc.NumeroPar(num);

            // Assert
            Assert.True(result);
        }

        //Teste para verificar varios numeros são pares
        //Theory e usado para testar multiplos cenarios
        //InlineData é usado para passar os valores para o teste

        // [Theory]
        // [InlineData(2)]
        // [InlineData(4)]
        // [InlineData(6)]
        // [InlineData(8)]
        // public void NumeroPar_ShouldReturnNumbersEvens(int num)
        // {
        //     // Arrange
        //     var calc = new CalculadoraImp();

        //     // Act
        //     var result = calc.NumeroPar(num);

        //     // Assert
        //     Assert.True(result);
        // }

        //Refatorando o teste acima, utilizando uma lista de valores, Assert.All e expressão lambda
        [Theory]
        [InlineData(new int[] {2, 8, 6, 14})]
        public void NumeroPar_ShouldReturnNumbersEvens(int[] num)
        {   
            var calc = new CalculadoraImp();
            Assert.All(num, n => Assert.True(calc.NumeroPar(n)));
        }
    }
}



