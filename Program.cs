using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Datetypengrößen
            //short a0 = short.MaxValue;
            //short a1 = short.MinValue;
            //ushort a2 = 2*short.MaxValue+1;
            //int b = int.MaxValue;
            //long c = long.MaxValue;

            ////Console.WriteLine("Short: " + a + " Int: " + b + " Long:" + c);
            //Console.WriteLine("Short.min: " + a1 + " Short.max:" +a0 + " ushort:" + a2);

            //Verzweigungen (if-else Anweisung)

            int x = 5;
            int y = 5;

            if (x + y > 10)
            {
                Console.WriteLine("Das Ergebnis ist größer als 10.");
            }
            else if (x + y == 10)
            {
                Console.WriteLine("Das Ergebnis ist genau 10.");
            }
            else
            {
                Console.WriteLine("Das Ergebnis ist kleiner als 10.");
            }

            //Schleifen
            //Wiederholte Abläufe

            int zähler = 0;

            //while Schleife
            while (zähler < 10)
            {
                Console.WriteLine("Der Zähler ist: " + zähler);
                //zähler = zähler + 1;
                //zähler += 1;
                zähler++;
            }

            int zähler2 = 0;
            do
            {
                Console.WriteLine("Der Zähler ist: " + zähler2);
                zähler2++;
            } while (zähler2 < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Beispiel:
            // Der Benutzer soll nach zwei ganzen zahlen befragt werden,
            // falls die Summe größer als 125 ist soll das Programm beendet werden
            // anonsten von vorn beginnen.
            int a, b;

            do
            {
                Console.WriteLine("Bitte nacheinander zwei ganze Zahlen eingeben");
                Console.Write("a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b=");
                b = Convert.ToInt32(Console.ReadLine());
            } while (a + b < 125);


            // Der Benutzer soll nach einer Jahreszahl gefragt werden und es
            // soll ausgegeben werden ob es sich um ein Schaltjahr handelt.
            // Schaltjahr: teilbar durch 4; nicht teilbar durch 100; teilbar durch 400

            int jahr;
            string wiederholung = "j";
            do
            {


                Console.WriteLine("Eine Jahreszahl soll auf Schaltjahr überprüft werden.");
                Console.Write("Jahrezahl eingeben:");

                jahr = Convert.ToInt32(Console.ReadLine());

                if(jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0))

                {
                    Console.WriteLine(jahr + " ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine(jahr + " ist kein Schaltjahr.");
                }



                //if (jahr % 4 == 0)
                //{
                //    if (jahr % 100 == 0)
                //    {
                //        if (jahr % 400 == 0)
                //        {
                //            Console.WriteLine(jahr + " ist ein Schaltjahr.");
                //        }
                //        else
                //        {
                //            Console.WriteLine(jahr + " ist kein Schaltjahr.");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine(jahr + " ist ein Schaltjahr.");
                //    }
                //}

                //else
                //{
                //    Console.WriteLine(jahr + " ist kein Schaltjahr.");
                //}


                Console.Write("Nochmal? (j/n):");
                wiederholung = Console.ReadLine();
                

            } while (wiederholung == "j" || wiederholung=="J");

            //oder: ||   und &&



            
            
        }
    }
    
}
