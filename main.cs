using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("\n Exercício E");

    Console.WriteLine ("Ler dois valores para as variáveis A e B e efetuar a troca dos valores de forma que a variável A possua o valor da variável B e a variável B possua o valor da variável A. Exibir os valores das variáveis.");

    double a, b, c;
  
  Console.WriteLine("O valor da variavel A:");
  a = double.Parse(Console.ReadLine());
  Console.WriteLine("O valor da variavel B:");
  b = double.Parse(Console.ReadLine());
  
 c = a;
 a = b;
 b = c;
  
Console.WriteLine("O valor da variavel A:" + a);
Console.WriteLine("O valor da variavel B:" + b);





  }
}