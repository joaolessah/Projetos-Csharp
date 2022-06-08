using System.Text;

namespace EditorHtml
{
    public static class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();

        }

        public static void Start()
        {
            // CRIAÇÃO DO DOCUMENTO
            var file = new StringBuilder();

            do
            {

                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            var file2 = file.ToString();

            preSave(file2);

            // PRÉ-SAVE

            static void preSave(string file2)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("-----------");
                Console.WriteLine("  dDeseja salvar o arquivo? Sim ou não?");
                Console.WriteLine("-----------");

                string saveOption = Console.ReadLine().ToLower();

                switch (saveOption)
                {
                    case "sim":
                        Save(file2);
                        break;
                    case "não":
                        {
                            Console.WriteLine("Deseja visualizar o arquivo, voltar para o menu ou finalizar a aplicaçãow?");
                            Console.WriteLine("================");
                            Console.WriteLine("1 - Visualizar o arquivo.");
                            Console.WriteLine("");
                            Console.WriteLine("2 - Voltar para o menu");
                            Console.WriteLine("");
                            Console.WriteLine("3 - Encerrar o programa");
                            Console.WriteLine("");

                            int opcaoEnd = int.Parse(Console.ReadLine());

                            if (opcaoEnd == 1)
                            {
                                View.Show(file2);
                            }
                            else if(opcaoEnd == 2)
                            {
                                Menu.Show();
                            }
                            else{
                                System.Environment.Exit(0);
                            }
                        }
                        break;
                }
            }

            static void Save(string file2)
            {
                Console.Clear();

                Console.WriteLine("Qual cmainho para salvar o arquivo?");
                Console.WriteLine("");

                var path = Console.ReadLine();

                using (var text = new StreamWriter(path))
                {
                    text.Write(file2);
                }

                Console.WriteLine($"Arquivo {path} salvo com sucesso");

                Console.ReadLine();
                Console.WriteLine("Voltando para o menu...");
                Thread.Sleep(2000);
                Menu.Show();
            }
            /*Desafio: armazenar sim ou não, se ele digitar não ele perde, se sim a gente chama o visualizador*/
        }


    }


}