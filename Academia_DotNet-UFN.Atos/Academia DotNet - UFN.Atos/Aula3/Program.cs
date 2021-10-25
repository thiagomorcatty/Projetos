using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch e Case - Exercicio de desconto
            int codigo;
            float valor, pagamento;

            Console.WriteLine("Digite o valor total da compra: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o codigo de cliente, \n (1)Cliente, (2)Cliente VIP ou (3)Funcionário: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    pagamento = valor;
                    Console.WriteLine("O valor a pagar será de R$" + pagamento);
                    break;
                case 2:
                    pagamento = valor - (valor * 10 / 100);
                    Console.WriteLine("O valor a pagar será de R$" + pagamento + ", pois tem 10% de desconto.");
                    break;
                case 3:
                    pagamento = valor - (valor * 5 / 100);
                    Console.WriteLine("O valor a pagar será de R$" + pagamento + ", pois tem 5% de desconto.");
                    break;

                default:
                    Console.WriteLine("Digite um código de cliente válido");
                    break;
            }

        }
    }
}
