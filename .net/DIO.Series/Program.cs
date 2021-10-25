using System;
using Dio.Series;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X"){

                switch (opcaoUsuario){

                    case "1":
                        ListarSerie();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                       ExcluirSerie();
                        break;

                    case "5":
                       VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por nos visitar!!!");
            Console.ReadLine();
        }
        private static void ListarSerie(){
            Console.WriteLine("Listar Série");
            var lista = repositorio.Lista();

            if (lista.Count == 0){
                Console.WriteLine("Nenhuma Série Cadastrada");
                return;
            }
            foreach (var serie in lista) {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluido" : "")  );
            }
        }
        private static void InserirSerie(){
            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine(" {0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o número do gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a Descrição da Série: ");
            string entradaDescricao =Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(),
                                         genero: (Genero) entradaGenero,
                                         titulo: entradaTitulo,
                                         descricao: entradaDescricao,
                                         ano: entradaAno);

            repositorio.Insere(novaSerie);
        }
        private static void AtualizarSerie(){
            Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine(" {0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o número do gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a Descrição da Série: ");
            string entradaDescricao =Console.ReadLine();

            Serie atualizaSerie = new Serie (id: indiceSerie,
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         descricao: entradaDescricao,
                                         ano: entradaAno);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
    private static void ExcluirSerie(){
            Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
    }

    private static void VisualizarSerie(){
            Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
    }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Seja Bem vindo ao Mundo das Séries!!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar as Séries.");
            Console.WriteLine("2 - Inserir nova série.");
            Console.WriteLine("3 - Atualizar Série.");
            Console.WriteLine("4 - Excluir Série.");
            Console.WriteLine("5 - Visuzalizar Série.");
            Console.WriteLine("C - Limpar Tela (Clear).");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
