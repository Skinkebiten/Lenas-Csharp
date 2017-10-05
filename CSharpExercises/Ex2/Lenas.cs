using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2


{
    public class LenasNightMare
    {
        public static void LetTheSunShine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let the sun shine in!");
            Console.ResetColor();
            return;
        }

        public static void MarkItRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Redrum");
            Console.ResetColor();
        }
    }
}
