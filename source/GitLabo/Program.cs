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
            Console.ForegroundColor = ConsoleColor.Yellow;
<<<<<<< HEAD
            string output = FiggleFonts.Standard.Render(input);
            
=======
            string output2 = FiggleFonts.Speed.Render(input);
>>>>>>> feature-font-speed

            
            // Print output
            Console.WriteLine();
            Console.WriteLine(output);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Beep();
        }
    }
}
