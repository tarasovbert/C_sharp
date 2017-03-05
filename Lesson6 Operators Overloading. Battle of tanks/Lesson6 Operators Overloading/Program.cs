using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Operators_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 5;
            Tank[] PanteraTanks = new Tank[quantity];
            Tank[] T_34 = new Tank[quantity];
            for (int i = 0; i < quantity; i++)
            {
                PanteraTanks[i] = new Tank("Pantera");
                T_34[i] = new Tank("T-34");
            }

            Tank VictorianTank;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Composition | Ammunition | Armor | Maneuverability" + Environment.NewLine +
                              "--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green ;
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Duel {0} --------------------------------------------", i + 1);
                Tank.ShowTankStats(PanteraTanks[i]);
                Tank.ShowTankStats(T_34[i]);
                Console.WriteLine();
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Victorian Tanks are: ");                        
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine(Environment.NewLine + "Duel {0}  ------------------------------------------ ", i + 1);
               try
                {
                    VictorianTank = PanteraTanks[i] ^ T_34[i];                                           
                }
                catch (ExceptionDraw ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Tank.ShowTankStats(VictorianTank);
                Console.WriteLine();
            }            


                Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
