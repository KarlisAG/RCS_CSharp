using System;

namespace Day3_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopTask3Extra();
            WhileLoopTask1();
        }

        static void ForLoopTask3Extra()
        {
            String maxZvaigznes = "*****";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 3; i > 0; i--)
            {
                maxZvaigznes = maxZvaigznes.Remove(i);
                
                Console.WriteLine(maxZvaigznes);
            }
        }
        static void WhileLoopTask1()
        {
            Console.WriteLine("Dotajā uzdevumā Jūs drīkstat ievadīd cik skaitļus vien vēlaties (vismaz divus), lai šo darbību beigtu un parādītu lielāko un mazāko ievadītos ciparus Jums ir jāuzraksta STOP");
            String ievadeStop;
            bool stopTrue = false;
            int lielākais = -2147483648;
            int mazākais = 2147483647;

            while (!stopTrue)
            {
                ievadeStop = Console.ReadLine();
                if (ievadeStop == "STOP")
                {
                    stopTrue = true;
                    break;
                }
                else
                {
                    stopTrue = false;

                }

                int ievadeC = Convert.ToInt32(ievadeStop);
                if (lielākais <= ievadeC)
                {
                    lielākais = ievadeC;
                }
                else if (mazākais >= ievadeC)
                {
                    mazākais = ievadeC;
                }


                /*while (!stopTrue) --> Šī versija nestrādāja.. kāpēc? Jo ir cits ReadLine un to nepiefiksē jeb neņem vērā bool gadījumā?
                {
                    String ievade = Console.ReadLine();
                    if (ievadeStop == "STOP")
                    {
                        stopTrue = true;
                        break;
                    }
                    else
                    {
                        stopTrue = false;
                        if (!stopTrue)
                        { 
                            int ievadeC = Convert.ToInt32(ievade);
                            if (lielākais <= ievadeC)
                            {
                                lielākais = ievadeC;
                            }
                            else if (mazākais >= ievadeC)
                            {
                                mazākais = ievadeC;
                            }
                        }
                    }
                  */
            }
            Console.WriteLine("Lielākais ievadītais cipars bija: " + lielākais);
            Console.WriteLine("Mazākais ievadītais cipars bija: " + mazākais);
        }

    }
}
