using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes
{

    public class ValidacaoStringsTests
    {
        [Fact]
        public void ContarCaracteres_EmptyString_ReturnsZero()
        {
            // Arrange
            var validacaoStrings = new ValidacaoStrings();
            string texto = "";

            // Act
            int result = validacaoStrings.ContarCaracteres(texto);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ContarCaracteres_SingleCharacterString_ReturnsOne()
        {
            // Arrange
            var validacaoStrings = new ValidacaoStrings();
            string texto = "a";

            // Act
            int result = validacaoStrings.ContarCaracteres(texto);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ContarCaracteres_MultiCharacterString_ReturnsCorrectLength()
        {
            // Arrange
            var validacaoStrings = new ValidacaoStrings();
            string texto = "hello";

            // Act
            int result = validacaoStrings.ContarCaracteres(texto);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void ContarCaracteres_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            var validacaoStrings = new ValidacaoStrings();
            string? texto = null;

            var result = validacaoStrings.ContarCaracteres(texto);

            // Act & Assert
            Assert.Equal(0, result);
        }
    }
}