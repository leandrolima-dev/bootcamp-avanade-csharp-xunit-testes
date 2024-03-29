using Calculadora.Services;

internal class Program
{
  private static void Main(string[] args)
  {
    CalculadoraImp calc = new();
    int num1 = 10;
    int num2 = 20;

    Console.WriteLine($"{num1} + {num2} = {calc.Somar(num1, num2)}");
  }
}