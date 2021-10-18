using System;
//Exercicio de C#
namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Inserir um novo aluno.
                        Console.WriteLine("Informe o nome do Aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno:");
                        var nota = float.Parse(Console.ReadLine());
                        aluno.Nota = nota;

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        //Listar alunos
                        foreach (var a in alunos){
                            if (!a.Nota.Equals(0))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota} ");
                            }
                            
                        }

                        break;

                    case "3":
                        float notaTotal = 0;
                        int nrAlunos = 0;
                        for (int i=0; i<alunos.Length; i++)
                        {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos = nrAlunos+1;
                        }
                        float mediaGeral = (notaTotal / nrAlunos);
                        Console.WriteLine("A média dos alunos será "+ mediaGeral);
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        Console.WriteLine( );
                        break;
                }

                opcaoUsuario = obterOpcaoUsuario();
            }



        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir um novo aluno: ");
            Console.WriteLine("2 - Lista Alunos: ");
            Console.WriteLine("3 - Calcular Média Geral ");
            Console.WriteLine("X - Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
