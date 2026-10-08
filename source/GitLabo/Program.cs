using Figgle;
using Figgle.Fonts;

namespace GitLabo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            // Generate ASCII banner for input
            Console.ForegroundColor = ConsoleColor.Yellow;
            string output = FiggleFonts.Standard.Render(input);

            
            // Print output
            Console.WriteLine();
            Console.WriteLine(output);
            Console.ResetColor();
            Thread.Sleep(1000);
        }
    }
}
