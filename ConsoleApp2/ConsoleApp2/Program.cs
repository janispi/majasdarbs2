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


            int maxNumber1 = 12;
            int maxNumber2 = 25;

            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxResult);

            //------------------------------------------------


            int maxNumber3 = 40;
            int maxNumber4 = 11;

            int minResult = Math.Min(maxNumber3, maxNumber4);

            Console.WriteLine(minResult);

            //-----------------------------------------------





        }
    }
}
