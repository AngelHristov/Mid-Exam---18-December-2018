namespace _01._Christmas_Spirit
{
    using System;

    public class Spirit
    {
        public static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int budget = 0;
            int spirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    budget += 2 * quantity;
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    budget += 8 * quantity;
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    budget += 15 * quantity;
                    spirit += 17;
                    if (i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    budget += 23;
                    if (i == days)
                    {
                        spirit -= 30;
                    }
                }
            }

            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
