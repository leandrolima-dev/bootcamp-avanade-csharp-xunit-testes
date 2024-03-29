using Calculadora.Services;

internal class Program
{
  private static void Main(string[] args)
  {
    CalculadoraImp calc = new();
    int num1 = 5;
    int num2 = 10;

    Console.WriteLine($"{num1} + {num2} = {calc.Somar(num1, num2)}");
  }
}