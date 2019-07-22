namespace _03._Present_Delivery
{
using System;
using System.Linq;

    public class Present
    {
        public static void Main()
        {
            int[] houses = Console.ReadLine().Split('@')
                .Select(int.Parse)
                .ToArray();

            int position = 0;
            string input;

            while ((input = Console.ReadLine()) != "Merry Xmas!")
            {
                string[] command = input.Split();
                int jump = int.Parse(command[1]);

                if (position + jump < houses.Length)
                {
                    position = SantaDelivery(houses, position, jump);
                }
                else
                {
                    position = (position + jump) % houses.Length;
                    if (houses[position] == 0)
                    {
                        Console.WriteLine($"House {position} will have a Merry Christmas.");
                        houses[position] = 0;
                    }
                    houses[position] -= 2;
                }
            }
            int housesCounter = 0;

            foreach (var item in houses)
            {
                if (item > 0)
                {
                    housesCounter++;
                }
            }
            Console.WriteLine($"Santa's last position was {position}.");

            if (housesCounter == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {housesCounter} houses.");
            }
        }
        private static int SantaDelivery(int[] houses, int position, int jump)
        {
            position += jump;

            if (houses[position] == 0)
            {
                Console.WriteLine($"House {position} will have a Merry Christmas.");
                houses[position] = 0;
            }

            houses[position] -= 2;
            return position;
        }
    }
}
