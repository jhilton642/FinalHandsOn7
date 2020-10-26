using System;

namespace FinalHandsOn7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what do you need to know about? (switch, if, int, case, float): ");
            string keyword = Console.ReadLine();
            Program.CSharpFlashCard(keyword);
        }
        public static void CSharpFlashCard(string keyword)
        {
            switch (keyword)
            {
                case "switch":
                    Console.WriteLine("a statement that tests a variable against a list of values and then exicutes an action");
                    break;
                case "if":
                    Console.WriteLine("a statement that exicutes if the conditions are met");
                    break;
                case "int":
                    Console.WriteLine("a primitive type that represents numbes and can hold 4 bytes");
                    break;
                case "case":
                    Console.WriteLine("the part of a switch statement that holds the value the variable will be tested against");
                    break;
                case "float":
                    Console.WriteLine("a prymative type that can hold decimals and can hold 4 bytes");
                    break;
            }
        }
    }
}
