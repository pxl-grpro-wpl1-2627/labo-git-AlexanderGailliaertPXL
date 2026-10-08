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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string output = FiggleFonts.Digital.Render(input);
            

            
            // Print output
            Console.WriteLine();
            Console.WriteLine(output);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Beep();
        }
    }
}
