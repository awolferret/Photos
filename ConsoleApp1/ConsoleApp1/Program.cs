using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = 52;
            int photosInRow = 3;
            int photosIncude = photos / photosInRow;
            int photosTooMuch = photos % photosInRow;
            Console.WriteLine($"полных рядов{photosIncude}");
            Console.WriteLine($"сверх меры{photosTooMuch}");
        }
    }
}
