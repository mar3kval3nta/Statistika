using System;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string povoleneZnaky = "0123456789";
            string text = "";
            int soucet = 0;
            int pocet = 0;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (povoleneZnaky.Contains(keyInfo.KeyChar))
                {
                    //zde se program dostane při stisku čísla
                    text += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar);
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if(text != "")
                    {
                        soucet += int.Parse(text);
                        pocet++;
                    }
                    Console.WriteLine();
                    text = "";
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    Console.Write("\b \b");
                    text = text.Substring(0, text.Length -1 );
                }
            } while (keyInfo.Key != ConsoleKey.Escape);


        }
    }
}
