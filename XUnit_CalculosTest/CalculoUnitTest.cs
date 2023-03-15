using Xunit;
using XUnit_Calculos;

namespace XUnit_CalculosTest
{
	public class CalculoUnitTest
	{
		[Fact]
		public void Somar_DoisDouble_RetornaDouble()
		{
			// Arrange
			var num1 = 2.9;
			var num2 = 3.1;
			var valorEsperado = 6;

			// Act
			var soma = Calculo.Somar(num1, num2);

			// Assert
			Assert.Equal(valorEsperado, soma);
		}

		[Fact]
		public void Subtrair_DoisDouble_RetornaDouble()
		{
			// Arrange
			var num1 = 2.9;
			var num2 = 3.1;
			var valorEsperado = -0.2;

			// Act
			var subtracao = Calculo.Subtrair(num1, num2);

			// Assert
			Assert.Equal(valorEsperado, subtracao, 1);
		}

		[Fact]
		public void Multiplicar_DoisDouble_RetornaDouble()
		{
			// Arrange
			var num1 = 2.9;
			var num2 = 3.1;
			var valorEsperado = 8.99;

			// Act
			var multiplicacao = Calculo.Multiplicar(num1, num2);

			// Assert
			Assert.Equal(valorEsperado, multiplicacao, 2);
		}

		[Fact]
		public void Dividir_DoisDouble_RetornaDouble()
		{
			// Arrange
			var num1 = 2.9;
			var num2 = 3.1;
			var valorEsperado = 0.94; // Rounded value

			// Act
			var divisao = Calculo.Dividir(num1, num2);

			// Assert
			// O terceiro parâmetro no método .Equal (2) no final
			// do código ajusta o valor da precisão do retorno.
			// Retornará duas casas decimais neste caso.
			Assert.Equal(valorEsperado, divisao, 2);
		}

		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(-4, -6, -10)]
		[InlineData(-2, 2, 0)]
		[InlineData(int.MinValue, +1, int.MinValue + 1)]
		public void Somar_DoisNumerosRelativos_RetornaNumeroRelativo(int num1, int num2, int valorEsperado)
		{
			// Act
			var resultado = Calculo.Somar(num1, num2);

			// Assert
			Assert.Equal(valorEsperado, resultado);
		}
	}
}
