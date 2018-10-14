using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to insert his name
            Console.WriteLine("Enter your name: ");
            //Reads user input
            string user = Console.ReadLine();
            //Displays "Hello user" through Placeholder syntax
            Console.WriteLine("Hello {0}", user); // This way is recommended
            //Displays "Hello user" through concatenation
            Console.WriteLine("Hello " + user);

            //Keeps the console Open
            Console.ReadKey();
        }
    }
}
