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


            Console.WriteLine("Uzdevums ar lielākā skaitļa noteikšanu");

            Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
            string yourNumber5 = Console.ReadLine();
            int pirmais = int.Parse(yourNumber5);

            Console.WriteLine("Lūdzu, ievadiet otro skaitli");

            string yourNumber6 = Console.ReadLine();
            int otrais = int.Parse(yourNumber6);

            int Lielakais = Math.Max(pirmais, otrais);
            Console.WriteLine("Lielākais skaitlis no šiem ir " + (Lielakais));

            //-----------------------------------------------------


            Console.WriteLine("Uzdevums ar mazākā skaitļa noteikšanu");

            Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
            string yourNumber7 = Console.ReadLine();
            int tresais = int.Parse(yourNumber7);

            Console.WriteLine("Lūdzu, ievadiet otro skaitli");

            string yourNumber8 = Console.ReadLine();
            int ceturtais = int.Parse(yourNumber8);

            int Mazakais = Math.Min(tresais, ceturtais);
            Console.WriteLine("Mazākais skaitlis no šiem ir " + (Mazakais));

            //----------------------------------------------------
            Console.WriteLine("Uzdevums ar dalījuma atlikumu");
            Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
            string yourNumber9 = Console.ReadLine();
            int piektais = int.Parse(yourNumber9);

            Console.WriteLine("Lūdzu, ievadiet otro skaitli");

            string yourNumber10 = Console.ReadLine();
            int sestais = int.Parse(yourNumber10);
            int Dalijums = piektais % sestais;
            Console.WriteLine("Skaitļu dalījuma atlikums ir " + (Dalijums));

            //------------------------------------------------------

            Console.WriteLine("Taisnstūra laukuma aprēķināšana");
            Console.WriteLine("Lūdzu, ievadiet taisnstūra malu A centimetros");
            string yourNumber11 = Console.ReadLine();
            double septitais = double.Parse(yourNumber11);

            Console.WriteLine("Lūdzu, ievadiet taisnstūra malu B centimetros");

            string yourNumber12 = Console.ReadLine();
            double astotais = double.Parse(yourNumber12);
            double Laukums = septitais * astotais;
            Console.WriteLine("Taisnstūra laukums ir " + Math.Round(Laukums,2) + " kvadrātcentimetri") ;
            //-------------------------------------------------------------------------

            Console.WriteLine("Vienādsānu trijstūra laukuma aprēķināšana");
            Console.WriteLine("Lūdzu, ievadiet vienādsānu trijstūra katetes garumu centrimetros");
            string yourNumber13 = Console.ReadLine();
            double devitais = double.Parse(yourNumber13);

            double TrLaukums = (devitais*devitais)/2;
            Console.WriteLine("Trijstūra laukums ir " + Math.Round(TrLaukums, 2) + " kvadrātcentimetri");

            //-------------------------------------------



        }
    }
}
