using System;

namespace HelloGit
{
    class Program
    {
        /// <summary>
        /// This is the summary of your method
        /// Helps you and other programmers to understand a specific method
        /// </summary>
        /// <param name="args">Does something...</param>

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Keeps the console open
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // This is a single line comment

            /* This
             * is
             * a 
             * multiline
             * comment
             * */

            #region This is a region
            // Regions are useful to sort your code, helps you to work faster and more
            #endregion
        }
    }
}
