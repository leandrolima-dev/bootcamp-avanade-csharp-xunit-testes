using Calculadora.Services;

namespace CalculadoraTestes;

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

    [Fact]
    public void NumeroPar_ShouldReturnNumberPare()
    {
        // Arrange
        var calc = new CalculadoraImp();
        var num = 4;

        // Act
        var result = calc.NumeroPar(num);

        // Assert
        Assert.True(result);
    }
}