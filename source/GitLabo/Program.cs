using Figgle;
using Figgle.Fonts;

namespace GitLabo
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            // Generate ASCII banner for input
<<<<<<< HEAD
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string output = FiggleFonts.Digital.Render(input);
            

            
=======
            Console.ForegroundColor = ConsoleColor.Yellow;
            string output = FiggleFonts.Standard.Render(input);   
            string output2 = FiggleFonts.Speed.Render(input);
>>>>>>> 204d62a5085d0e450b939cc367af38484ae3668b
            // Print output
            Console.WriteLine();
            Console.WriteLine(output);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Beep();
        }
    }
}
