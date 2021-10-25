using System;

namespace Exercicios_Aula2_19._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 - Calculadora
            Console.WriteLine("Exercício 1 - Calculadora: ");
            float num1, num2, soma, subt, multip;
            float div;

            Console.WriteLine("Insira um valor1: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor2: ");
            num2 = float.Parse(Console.ReadLine());

            soma = num1 + num2;
            subt = num1 - num2;
            div = (num1 / num2);
            multip = num1 * num2;

            Console.WriteLine("Os números escolhidos foram " + num1 + " e " + num2 + ", e temos os cálculos: ");
            Console.WriteLine("A soma é " + soma + ", a subtração é " + subt + ", a divisão é {0:f2}", div + " e a multiplicação é " + multip);


            // Exercício 2 - Celsius para Farehnreit
            Console.WriteLine("");
            Console.WriteLine("Exercício 2 - Transformação de Graus");

            int grausC, grausF;
            Console.WriteLine("Informe qual a temperatura em graus Celsius: ");
            grausC = int.Parse(Console.ReadLine());
            grausF = ((9 * grausC) + 160) / 5;

            Console.WriteLine("A temperatura em graus Farehnreit é: " + grausF + "F.");

            // Exercicio 3 - Salário
            Console.WriteLine("");
            Console.WriteLine("Exercício 3 - Calculo de Salario");

            string nome;
            float horas, valorHora, salario;

            Console.WriteLine("Informe o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor hora: ");
            valorHora = float.Parse(Console.ReadLine());

            salario = horas * valorHora;

            Console.WriteLine("O salário de " + nome + " é de R${0:f2}", salario);


            //Exercício 4: Inversão de valores:
            Console.WriteLine("");
            Console.WriteLine("Exercício 3 - Inversão de valores");
            int x = 5, y = 7, invA;

            invA = x;
            x = y;
            y = invA;


            Console.WriteLine(x);
            Console.WriteLine(y);


            //Exercício 5: Calculo de dias:
            Console.WriteLine("");
            Console.WriteLine("Exercício 5 - Calculo de dias");
            int ano, mes, dia, total;

            Console.WriteLine("Inseri a quantidade de anos:");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Inseri a quantidade de meses:");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Inseri a quantidade de dias:");
            dia = int.Parse(Console.ReadLine());

            total = dia + (mes * 30) + (ano * 365);

            //Poderia ter usado:  dia += (mes*30) + (ano*365)

            Console.WriteLine("A Quantidade de dias percorridos foram: " + total + " dias!!!");

            //Exercício 6: Aumento de salário:
            Console.WriteLine("");
            Console.WriteLine("Exercício 6 - Aumento de Salário:");

            float salario2, aumento, salario3;

            Console.WriteLine("Informe o salario atual do funcionário: ");
            salario2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe qual o percentual de aumento do salario: ");
            aumento = float.Parse(Console.ReadLine());

            salario3 = salario2 + (salario2 * (aumento / 100));

            Console.WriteLine("O novo salário será R$ {0:f2}", salario3);


            //Exercício 7: Comissão de vendas:
            Console.WriteLine("");
            Console.WriteLine("Exercício 7 - Comissão de vendas");

            float salario4, salario5;
            int carrosVendidos;
            float valorVeiculo = 30000;
            float percentuaComissão = 15;
            string nome2;

            Console.WriteLine("Informe o nome do funcionário: ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Informe o salario atual do funcionário: ");
            salario4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de carros vendidos: ");
            carrosVendidos = int.Parse(Console.ReadLine());

            salario5 = salario4 + (((valorVeiculo * (percentuaComissão / 100)) * carrosVendidos));

            Console.WriteLine("O salario mais a comissão de carros vendidos será de R$ {0:f2}", salario5);


            //Exercício 8: Resultados de uma eleição:
            Console.WriteLine("");
            Console.WriteLine("Exercício 8 - Resultados de uma eleição:");

            int eleitores, votosBr, votosNull, votosValidos;

            Console.WriteLine("Informe a quantidade de eleitores: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de votos brancos: ");
            votosBr = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de votos Nulos: ");
            votosNull = int.Parse(Console.ReadLine());

            votosValidos = eleitores - votosBr - votosNull;

            Console.WriteLine("Temos" + eleitores + " eleitores em nossa zona eleitoral.");
            Console.WriteLine("Tivemos: ");
            Console.WriteLine(votosValidos + " Votos válidos, sendo o " + (votosValidos * 100 / eleitores) + "% do total");
            Console.WriteLine(votosBr + " Votos brancos, sendo o " + (votosBr * 100 / eleitores) + "% do total");
            Console.WriteLine(votosNull + " Votos nulos, sendo o " + (votosNull * 100 / eleitores) + "% do total");


            //Exercício 9: Antecessor e Sucessor:
            Console.WriteLine("");
            Console.WriteLine("Exercício 9: Antecessor e Sucessor:");

            int numeroInteiro, antecessor, sucessor;

            Console.WriteLine("Informe um número inteiro: ");
            numeroInteiro = int.Parse(Console.ReadLine());

            antecessor = numeroInteiro-1;
            sucessor = numeroInteiro+1;

            Console.WriteLine("O numero informado foi " + numeroInteiro);
            Console.WriteLine("O seu antecessor é " + antecessor);
            Console.WriteLine("O seu sucessor é " + sucessor);


            //Exercício 10: Media de Notas:
            Console.WriteLine("");
            Console.WriteLine("Exercício 10: Media de Notas");

            float nota1, nota2, nota3, media;

            Console.WriteLine("Informe a Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Temos as notas "+nota1+", "+nota2+", "+nota3+". Então sua média será "+media);

        }
    }
}
