using System;
namespace SwithCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("I like math as well.");
                    break;
                case "science":
                    Console.WriteLine("Science is interesting.");
                    break;
                case "english":
                    Console.WriteLine("English is fundamental.");
                    break;
                case "Art":
                    Console.WriteLine("I enjoy art.");
                    break;
                case "music":
                    Console.WriteLine("Music means you are talented.");
                    break;
            }
        }
    }
}

