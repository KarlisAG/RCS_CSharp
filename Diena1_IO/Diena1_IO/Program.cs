using System;

namespace Diena1_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            //komentāri

            Console.WriteLine("Hello World!");
            Console.WriteLine("Sveiki tauta!");

            //int [Integer] - vesels skaitlis
            //float, double - skaitļi ar komatu
            //char - viens simbols
            //String - simbolu virkne
            //bool - true vai false

            int a; //mainīgā deklarācija - piešķir tikai 1 reizi
            a = 7; // mainīgā definīcija - maina cik grib
            int c;
            c = 5;

            int result = a + c;
            Console.WriteLine(result);
            
            String b;
            b = "stringi";
            Console.WriteLine(b);

            // ReadLine -> cilvēku ievade -> vienmēr ir String
            Console.WriteLine("Ievadiet savu vārdu!");
            String ievade = Console.ReadLine();

           // Console.WriteLine("Jūs ievadījāt " + ievade + " !");
            String combined = ievade + ", hello world!";

            Console.WriteLine(combined);

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
