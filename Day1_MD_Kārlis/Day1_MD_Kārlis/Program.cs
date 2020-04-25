using System;

namespace Day1_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.uzdevums
            Console.WriteLine("Lūdzu, ievadiet savu vārdu!");
            String ievadVārds = Console.ReadLine();
            Console.WriteLine("Esiet sveiks, " + ievadVārds + "!");

            //2.uzdevums
            Console.WriteLine("Lūdzu, ievadiet 3 simbolu virknes!");
            String simbVirkne1 = Console.ReadLine();
            String simbVirkne2 = Console.ReadLine();
            String simbVirkne3 = Console.ReadLine();
            String simboluVirkne = simbVirkne1 + simbVirkne2 + simbVirkne3;
            Console.WriteLine("Jūsu ievadītās simbolu virknes bija: " + simboluVirkne);

            //3.uzcevums

            Console.WriteLine("Lūdzu, ievadiet trīs dažādus ciparus!");
            String ievad1 = Console.ReadLine();
            String ievad2 = Console.ReadLine();
            String ievad3 = Console.ReadLine();

            int ievad1c = System.Convert.ToInt16(ievad1);
            int ievad2c = System.Convert.ToInt16(ievad2);
            int ievad3c = System.Convert.ToInt16(ievad3);

            
            
           
            /* if (ievad1c > ievad2c && ievad1c > ievad3c)
             {
                 Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad1c);
             }
             else if (ievad2c > ievad1c && ievad2c > ievad3c)
             {
                 Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad2c);
             }
             else if (ievad3c > ievad1c && ievad3c > ievad2c)
             {
                 Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad3c);
             }
             else
             {
                 Console.WriteLine("Kāds no Jūsu ievadītajiem cipariem ir vienāds! Lūdzu, ierakstiet dažādus ciparus!");
             }*/
             
        //[sākotnēji taisīju šādi, bet nestrādāja pareizi ar dažādiem varintiem. Nesapratu kāpēc..] 
          if (ievad1c > ievad2c)
            {
                if (ievad1c > ievad3c)
                {
                    Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad1c);
                }
            }
            else if (ievad2c > ievad1c)
            {
                if (ievad2c > ievad3c)
                { 
                    Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad2c); 
                }
            }
            else if (ievad3c > ievad1c)
            {
                if (ievad3c > ievad2c)
                {
                    Console.WriteLine("Lielākais ievadītais cipars bija: " + ievad3c);
                }
            }
            else
            {
                Console.WriteLine("Kāds no Jūsu ievadītajiem cipariem ir vienāds! Lūdzu, ierakstiet dažādus ciparus!");
            }
           

            //4.uzdevums
            int a = 3;
            int b = 9;
            Console.WriteLine("Sākotnējais a = " + a);
            Console.WriteLine("Sākotnējais b = " + b);

            int jaunsMainīgais = b - a;
            //Console.WriteLine(jaunsMainīgais);
            a = a + jaunsMainīgais;
            b = b - jaunsMainīgais;
            Console.WriteLine("Jaunais a = " + a);
            Console.WriteLine("Jaunais b = " + b);
            
            /* viens atrisinājums
            int a = 3;
            int b = 9

            int temp = a;
            a = b;
            b = temp;
            
             OTRS
             a = a + b;
             b = a - b;
             a = a - b;
             */
        }
    }
}
