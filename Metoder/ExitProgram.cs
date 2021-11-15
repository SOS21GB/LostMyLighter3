using System;

namespace LighterGrp3.Metoder
{
    public class ExitProgram
    {
        // Metod som skriver ut THE END! om användaren väljer option 7 i MainMenu
        public static void EndMessage(string text = "THE END!", int delay = 200)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(delay);

                // För att hoppa över animationen och få texten utskriven direkt
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }

    }
}
