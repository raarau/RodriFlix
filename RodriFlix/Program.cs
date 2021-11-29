using System;

namespace RodriFlix
{
    class Program
    {
        static SeriesRepositorio repoSerie = new SeriesRepositorio();
        static FilmeRepositorio repoFilme = new FilmeRepositorio();
        private static string resposta;

        static void Main(string[] args)
        {

            do
            {
                
                Console.WriteLine("Digite a midia que deseja cadastrar: ");
                Console.WriteLine("F - Filme ou S - Série");
                string tipoMidia = Console.ReadLine();

                if (tipoMidia.ToUpper() == "F")
                {
                    string opcaoUsuario = ObterOpcaoUsuario(tipoMidia);


                    while (opcaoUsuario.ToUpper() != "X")
                    {
                        switch (opcaoUsuario)
                        {
                            case "1":
                                ListarMidia(tipoMidia);
                                break;
                            case "2":
                                InserirMidia(tipoMidia);
                                break;
                            case "3":
                                AtualizarMidia(tipoMidia);
                                break;
                            case "4":
                                ExcluirMidia(tipoMidia);
                                break;
                            case "5":
                                VisualizarMidia(tipoMidia);
                                break;
                            case "C":
                                Console.Clear();
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        opcaoUsuario = ObterOpcaoUsuario(tipoMidia);
                    }

                }
                else
                {
                    string opcaoUsuario = ObterOpcaoUsuario(tipoMidia);


                    while (opcaoUsuario.ToUpper() != "X")
                    {
                        switch (opcaoUsuario)
                        {
                            case "1":
                                ListarMidia(tipoMidia);
                                break;
                            case "2":
                                InserirMidia(tipoMidia);
                                break;
                            case "3":
                                AtualizarMidia(tipoMidia);
                                break;
                            case "4":
                                ExcluirMidia(tipoMidia);
                                break;
                            case "5":
                                VisualizarMidia(tipoMidia);
                                break;
                            case "C":
                                Console.Clear();
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        opcaoUsuario = ObterOpcaoUsuario(tipoMidia);
                    }
                }

                Console.WriteLine("Deseja continuar com o cadastro? S / N");

                resposta = Console.ReadLine();

            } while (resposta.ToUpper() == "S");


        }

        private static void ListarMidia(string tipoMidia)
        {
            if (tipoMidia == "F")
            {
                Console.WriteLine("Listar Filmes");
                var listaFilmes = repoFilme.Lista();
                if (listaFilmes.Count == 0)
                {
                    Console.WriteLine("Nenhum filme encontrado.");

                    return;
                }

                foreach (var filme in listaFilmes)
                {
                    Console.WriteLine("#ID {0}: - {1}", filme.RetornaId(), filme.RetornaTitulo());
                }

            }
            else if (tipoMidia == "S")
            {
                Console.WriteLine("Listar Séries");
                var listaSeries = repoSerie.Lista();
                if (listaSeries.Count == 0)
                {
                    Console.WriteLine("Nenhuma série encontrada.");

                    return;
                }

                foreach (var serie in listaSeries)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }
            }

        }

        private static void InserirMidia(string tipoMidia)
        {

            if (tipoMidia == "F")
            {
                System.Console.WriteLine("Inserir novo filme: "); 
                Console.WriteLine();
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.WriteLine();
                System.Console.WriteLine("Digite o genêro entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o Título do filme: ");
                string entradaTitulo = Console.ReadLine();

                System.Console.WriteLine("Digite o Ano de início do filme: ");
                int entradaAno = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a Descrição da filme: ");
                string entradaDescricao = Console.ReadLine();

                Console.WriteLine("Digite a duração da filme: ");
                DateTime entradaDuracao = DateTime.Parse(Console.ReadLine());

                Filme novoFilme = new Filme(id: repoFilme.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao,
                                            duracao: entradaDuracao
                );

                repoFilme.Insere(novoFilme);

            } 
            else if (tipoMidia =="S")
            {
                System.Console.WriteLine("Inserir nova série: ");
                Console.WriteLine();
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.WriteLine();
                System.Console.WriteLine("Digite o genêro entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                System.Console.WriteLine("Digite o Ano de início da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Console.WriteLine("Digite a duração da Série: ");
                DateTime entradaDuracao = DateTime.Parse(Console.ReadLine());

                Serie novaSerie = new Serie(id: repoSerie.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao,
                                            duracao: entradaDuracao
                );

                repoSerie.Insere(novaSerie);
            }
            
        }

        private static void AtualizarMidia(string tipoMidia)
        {

            if (tipoMidia == "F")
            {
                var listaFilmes = repoFilme.Lista();

                Console.WriteLine("Digite o id do filme: ");

                foreach (var filme in listaFilmes)
                {
                    Console.WriteLine("#ID: {0} - {1}", filme.RetornaId(), filme.RetornaTitulo());
                }

                Console.WriteLine();

                int indiceFilme = int.Parse(Console.ReadLine());

                Console.WriteLine();

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.WriteLine();

                Console.WriteLine("Digite o genêro entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Título do filme: ");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("Digite o Ano de início do filme: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Descrição do filme: ");
                string entradaDescricao = Console.ReadLine();

                Console.WriteLine("Digite a duração do filme: ");
                DateTime entradaDuracao = DateTime.Parse(Console.ReadLine());

                Filme novoFilme = new Filme(id: indiceFilme,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao,
                                            duracao: entradaDuracao
                );

                repoFilme.Atualiza(indiceFilme, novoFilme);
            }
            else if (tipoMidia == "S")
            {
                var listaSeries = repoSerie.Lista();
                Console.WriteLine("Digite o id da série: ");

                foreach (var serie in listaSeries)
                {
                    Console.WriteLine("#ID: {0} - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }

                Console.WriteLine();

                int indiceSerie = int.Parse(Console.ReadLine());

                Console.WriteLine();

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.WriteLine();
                Console.WriteLine("Digite o genêro entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("Digite o Ano de início da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Console.WriteLine("Digite a duração da Série: ");
                DateTime entradaDuracao = DateTime.Parse(Console.ReadLine());

                Serie novaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao,
                                            duracao: entradaDuracao
                );

                repoSerie.Atualiza(indiceSerie, novaSerie);
            }
            
        }

        private static void ExcluirMidia(string tipoMidia)
        {

            if (tipoMidia == "F")
            {
                Console.WriteLine("Digite o id do filme: ");
                int indiceFilme = int.Parse(Console.ReadLine());

                repoFilme.Exclui(indiceFilme);
            }
            else if (tipoMidia == "S")
            {
                Console.WriteLine("Digite o id da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                repoSerie.Exclui(indiceSerie);
            }

        }

        private static void VisualizarMidia(string tipoMidia)
        {
            if (tipoMidia == "F")
            {
                Console.WriteLine("Digite o id do filme: ");
                var listaFilmes = repoFilme.Lista();
                foreach (var filmes in listaFilmes)
                {
                    Console.WriteLine("#ID: {0} - {1} ", filmes.RetornaId(), filmes.RetornaTitulo());
                }
                int indiceFilme = int.Parse(Console.ReadLine());
                var filme = repoFilme.RetornaPorId(indiceFilme);
                Console.WriteLine(filme);
            }
            else if(tipoMidia == "S")
            {
                Console.WriteLine("Digite o id da série: ");
                var listaSeries = repoSerie.Lista();
                foreach (var series in listaSeries)
                {
                    Console.WriteLine("#ID: {0} - {1} ", series.RetornaId(), series.RetornaTitulo());
                }
                int indiceSerie = int.Parse(Console.ReadLine());
                var serie = repoSerie.RetornaPorId(indiceSerie);
                Console.WriteLine(serie);
            }

        }

        private static string ObterOpcaoUsuario(string tipoMidia)
        {
            System.Console.WriteLine();
            if (tipoMidia == "F")
            {
                Console.WriteLine("RodFlix séries e filmes sem limites!");
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Listar filme");
                Console.WriteLine("2- Inserir novo filme");
                Console.WriteLine("3- Atualizar filme");
                Console.WriteLine("4- Excluir filme");
                Console.WriteLine("5- Visualizar filme");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine();
            }
            else if (tipoMidia == "S")
            {
                Console.WriteLine("RodFlix séries e filmes sem limites!");
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Listar séries");
                Console.WriteLine("2- Inserir nova série");
                Console.WriteLine("3- Atualizar série");
                Console.WriteLine("4- Excluir série");
                Console.WriteLine("5- Visualizar série");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine();
            }


            string opcaoUsuario = System.Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
