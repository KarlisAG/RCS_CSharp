using System;

namespace Day2_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. uzdevums
           Console.WriteLine("Lūdzu, ierakstiet divus dažādus skaitļus!");
            String ievad1 = Console.ReadLine();
            String ievad2 = Console.ReadLine();
            int ievad1c = Convert.ToInt32(ievad1);
            int ievad2c = Convert.ToInt32(ievad2);
            // int sk2 = Convert.ToInt32(Console.ReadLine()); 2 līnijas saliktas 1

            ReturnBiggest(ievad1c, ievad2c);
            
            //2. uzdevums
            Console.WriteLine("Lūdzu, ievadiet vienu ciparu!");
            bool irTrue = PāraNepāra();
            Console.WriteLine(irTrue ? "Ievadītais cipars ir pāra!" : "Ievadītais cipars ir nepāra!");
        }
        static int ReturnBiggest(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Lielākais ievadītais cipars bija " + a);
                return a;
                
            }
            else if (b > a)
            {
                Console.WriteLine("Lielākais ievadītais cipars bija " + b);
                return b;
            }
            else Console.WriteLine("Jūs esat ievadījuši divus vienādus ciparus!");     

            return 0;

            /* pasniedzēja variants
             * int biggest = 0;
             * if (a >= b){
             * biggest = a;
             * }
             * esle
             * {
             * biggest = b;
             * }
             * return biggest;
             */
        }
    
        static bool PāraNepāra(//int sk
            )
            //Console.WriteLine(OddOrEven(5)); - pats arī uz teksta parādīs, ka tas ir nepāra, nekas lieks nav jāraksta!!!!!
        {


            String ievadA = Console.ReadLine();
            int ievadAA = Convert.ToInt32(ievadA);

            if (ievadAA % 2 == 0)
            {
                bool irParis = true; //nevajag šo, var vnk true
                return irParis;
            }
            else 
            {
                bool irParis = false;
                return irParis;
            }
            //ja nepāra skaitli dala ar 2, tad atlikums vienmēr ir 1

            /*būtu jāliek augšā, ārpus šīs metodes
             * if (IsEven)5__ //if(IsEven(5) == true) -tas pats
             * {
             * Console.WriteLine("Pāra");
             * }
             * else
             * {
             * Console.WrtiteLine("Nepāra");
             * }
             */
        }
    
    }

    
}


