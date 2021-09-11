using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, kā Jūs sauc?");

            string userName = Console.ReadLine();
            Console.WriteLine("Labdien, " + userName);

            //-------------------------------------------------

            Console.WriteLine("Kāds ir Tavs vecums?");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int nextYearAge = age + 1;

            Console.WriteLine("Sveiks, nākamgad Tev paliks " + nextYearAge + " gadi");

            //-------------------------------------------------




        }
    }
}
