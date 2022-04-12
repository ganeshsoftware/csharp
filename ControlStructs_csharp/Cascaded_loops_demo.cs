using System;

class BreakInNestedLoops
{
    static void Main(string[] args)
    {

        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

        // Outer loop
        for (int x = 0; x < numbers.Length; x++)
        {
            Console.WriteLine("num = {0}", numbers[x]);

            // Inner loop
            for (int y = 0; y < letters.Length; y++)
            {
                if (y == x)
                {
                    // Return control to outer loop
                    break;
                }
                Console.Write(" {0} ", letters[y]);
            }
            Console.WriteLine();
        }

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}