using System;

namespace market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас золота?");
            int gold = Convert.ToInt32(Console.ReadLine());
            int priceForCristal = 13;
            int possibleToBuy = gold / priceForCristal;
            Console.WriteLine($"Вы можете купить {possibleToBuy}") ;
            Console.WriteLine($"Сколько вы хотите купить?");
            int buy = Convert.ToInt32(Console.ReadLine());
            int goldRemains = gold - (buy * priceForCristal);
            Console.WriteLine($"Вы купили {buy} кристалов и у вас осталось {goldRemains} рублей"); 
        }
    }
}
