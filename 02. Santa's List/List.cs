namespace _02._Santa_s_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class List
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split('&')
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Finished!")
            {
                string[] command = input.Split();

                if (command[0] == "Bad" && !list.Contains(command[1]))
                {
                    list.Insert(0, command[1]);
                }
                else if (command[0] == "Good" && list.Contains(command[1]))
                {
                    list.Remove(command[1]);
                }
                else if (command[0] == "Rename" && list.Contains(command[1]))
                {
                    list[list.IndexOf(command[1])] = command[2];
                }
                else if (command[0] == "Rearrange" && list.Contains(command[1]))
                {
                    list.Remove(command[1]);
                    list.Add(command[1]);
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
