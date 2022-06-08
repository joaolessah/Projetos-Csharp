namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue; // trocar cor de fundo

            Console.ForegroundColor = ConsoleColor.Black; // cor da letra

            /*Desenho de tela*/
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        /*Vai desenhar nossa tela*/
        public static void DrawScreen()
        {

            int numColunas = 30;
            int numLinhas = 10;

            Colunas(numColunas);
            Linhas(numLinhas, numColunas);
            Colunas(numColunas);


            static void Colunas(int numColunas)
            {
                Console.Write("+");

                for (int i = 0; i <= numColunas; i++)
                {
                    Console.Write("-");
                }

                Console.Write("+");
                Console.Write("\n");
            }

            static void Linhas(int numLinhas, int numColunas)
            {
                for (int lines = 0; lines <= numLinhas; lines++)
                {
                    Console.Write("|");
                    for (int i = 0; i <= numColunas; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.Write("\n");
                }
             

            }


        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor de HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");



        }    

        public static void HandleMenuOption(short option)
        {
            /*Função que manipula um clique no botão*/
            switch(option){
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("abrir");
                    break;
                case 0:{
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: 
                    Show();
                    break;
            }
        }    
    }


}