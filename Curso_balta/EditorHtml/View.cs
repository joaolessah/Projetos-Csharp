using System.Text.RegularExpressions;

namespace EditorHtml
{

    public static class View
    {

        public static void Show(string text)
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Replace(text);

            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            // regex é uma string que substitui outra string, ele converte em uma função que vai fazer algo
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(

                            words[i].IndexOf('>') + 1,
                            (

                                (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')

                            )
                        ).ToUpper()
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i].ToUpper());
                    Console.Write(" ");
                }
            }

            

        }

       /*  Console.Clear();
            Console.WriteLine("Deseja ver o texto em maiúsculo? Sim ou não");
            string opcao = Console.ReadLine().ToLower();
            switch (opcao)
            {
                case "sim":
                    Upper(text);
                    break;
                case "não":
                    Console.WriteLine("Aperte uma tecla para sair");
                    Console.ReadKey();
                    Menu.Show();
                    break;
            }

            static void Upper(string words)
            {

                Console.Clear();
                Console.WriteLine("Texto em maiúsculo");
                Console.WriteLine("------------");

                var palavras = words.Split(' ');
                for (var i = 0; i < palavras.Length; i++)
                {
                    Console.WriteLine(palavras[i].ToUpper());
                }
            } */

    }


}