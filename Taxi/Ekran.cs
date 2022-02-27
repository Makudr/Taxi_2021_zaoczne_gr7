using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Ekran
    {

        public static void PokazEkranPowitalny()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                       WITAJ W APLIKACJI TAXI                    *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*           Wykorzystaj ją do wycenienia swojej pracy             *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                          _____________                          *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                  Programowanie: Bartosz Makowski                *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
            Console.Write("Naciśnij klawisz ENTER / RETURN, aby przejść do aplikacji...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void PokazEkranWyboru()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                           Wybierz Opcję:                        *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*             1 => Lista Wszystkich Dzielnic i Taksówek           *");
            Console.WriteLine("*             2 => Zamow Taksówkę                                 *");
            Console.WriteLine("*             3 => Zakończ program                                *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                  Wybierz 1, 2, lub 3:                           *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
