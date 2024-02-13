
using System;

namespace Calculator
{
  class Program
  {
    static void Main(String[] args)
    {

      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Escolha uma opção para calcular os valores:");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("5 - Para Sair");
      Console.WriteLine("----------");
      Console.WriteLine("Opção selecionada foi:");
      short esc = short.Parse(Console.ReadLine());

      switch (esc)
      {
        case 1: Soma(); break;
        case 2: Subtrair(); break;
        case 3: Multiplicar(); break;
        case 4: Dividir(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }

    }
    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Digite o pirmeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      Console.WriteLine("O resultado desta Soma é: " + resultado + " !");
      // Console.WriteLine("O resultado da soma é " + (v1 + v2));
      // // Com o "$" temos a interpolação de string
      // Console.WriteLine($"O resultado da soma é {v1 + v2}");
      // Console.WriteLine($"O resultado da soma é {resultado}");
      Console.WriteLine("");
      Console.WriteLine("# Aperte Enter para voltar ao Menu.");
      Console.ReadKey();
      Menu();

    }
    static void Subtrair()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;

      Console.WriteLine($"O resultado da subtração é: {resultado} !");
      Console.WriteLine("");
      Console.WriteLine("# Aperte Enter para voltar ao Menu.");
      Console.ReadKey();
      Menu();
    }
    static void Multiplicar()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;
      Console.WriteLine($"O resultado é da Multiplicação: {resultado} !");
      Console.WriteLine("");
      Console.WriteLine("# Aperte Enter para voltar ao Menu.");

      Console.ReadKey();
      Menu();
    }
    static void Dividir()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 / v2;
      Console.WriteLine("O resultado da Divisão é: " + resultado + " !");
      Console.WriteLine("");
      Console.WriteLine("# Aperte Enter para voltar ao Menu.");

      Console.ReadKey();
      Menu();
    }
  }
}
