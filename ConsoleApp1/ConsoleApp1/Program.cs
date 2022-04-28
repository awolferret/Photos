using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = 52;
            int rowNumber = 3;
            int row = photos / rowNumber;
            int photosTooMuch = photos % rowNumber;
            Console.WriteLine($"полных рядов{row}");
            Console.WriteLine($"сверх меры{photosTooMuch}");
        }
    }
}
