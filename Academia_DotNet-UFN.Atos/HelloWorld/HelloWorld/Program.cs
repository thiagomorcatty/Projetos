using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, resultado;

            Console.Write("Informe um valor: ")
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe um outro valor: ")
            valor2 = int.Parse(Console.ReadLine());

            resultado = valor1 + valor2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
