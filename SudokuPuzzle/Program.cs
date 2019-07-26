using System;

namespace SudokuPuzzle
{
    public class Program
    {
        public static void Main()
        {
            var pattern = "120098357764000000589000000120098357764000000589000000120098357764000000589000000";

            Console.WriteLine("|---|---|---|");
            Console.Write("|");
            var numberTracker = 0;
            for (int x = 0; x <= pattern.Length-1; x++)
            {
                numberTracker++;
                Console.Write(pattern[x]);
                if (numberTracker % 3 == 0) Console.Write("|");
                if (numberTracker % 9 == 0)
                {
                    Console.WriteLine();
                    Console.Write("|");
                }
            }

            Console.WriteLine("---|---|---|");

            Console.WriteLine();
            Console.WriteLine("Close!");
            Console.ReadLine();
        }

        
    }
}
