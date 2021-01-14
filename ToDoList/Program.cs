using System;
using System.Collections.Generic;

namespace ToDoList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("To Do List Application");

            List<string> ToDos = new List<string>();

            //menu
            while (true)
            {
                Console.WriteLine("Option 1 for Enter a new item");
                Console.WriteLine("Option 2 for View all items");
                switch (Console.ReadLine()[0])
                {
                    case '1':
                        AddItem(ref ToDos);
                        break;
                    case '2':
                        ViewItems(ToDos);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again");
                        break;
                }
            }
        }
        public static void AddItem(ref List<string> ToDos)
        {
            Console.WriteLine("Add item");
            Console.WriteLine("---");
            Console.WriteLine("Enter item to add to list");
            ToDos.Add(Console.ReadLine());
            Console.WriteLine("Item added!");
        }
        public static void ViewItems(List<string> ToDos)
        {
            Console.WriteLine("View all items");
            Console.WriteLine("---");
            foreach(string s in ToDos)
            {
                Console.WriteLine($"- {s}");
            }
        }
    }
}
