using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Operators_Overloading
{
    internal class Tank
    {
        #region FIELDS

        string mark;
        int ammo;
        int armor;
        int maneuverability;

        #endregion

        #region CTORS

        public Tank(string mark)
        {
            this.mark = mark;
            ammo = Randomer.Next(0, 100);
            armor = Randomer.Next(0, 100);
            maneuverability = Randomer.Next(0, 100);
        }

        #endregion

        #region PROPERTIES

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int Ammo
        {
            get
            {
                return ammo;
            }

            set
            {
                ammo = value;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }

            set
            {
                armor = value;
            }
        }

        public int Maneuverability
        {
            get
            {
                return maneuverability;
            }

            set
            {
                maneuverability = value;
            }
        }
        #endregion

        public static Tank operator ^(Tank tank1, Tank tank2)
        {
            int tank1Rate = 0;
            int tank2Rate = 0;

            if (tank1.ammo > tank2.ammo)
                tank1Rate++;
            else if (tank1.ammo < tank2.ammo)
                tank2Rate++;           
            if (tank1.armor > tank2.armor)
                tank1Rate++;
            else if (tank1.armor < tank2.armor)
                tank2Rate++;
            if (tank1.maneuverability > tank2.maneuverability)
                tank1Rate++;
            else if (tank1.maneuverability < tank2.maneuverability)
                tank2Rate++;

            if (tank1Rate == tank2Rate)
                throw new ExceptionDraw("It's draw.");

            return tank1Rate > tank2Rate ? tank1 : tank2;
        }
        public static void ShowTankStats(Tank tank)
        {
            Console.WriteLine("{0,-10}{1,10}{2,11}{3,11}", tank.Mark, tank.Ammo, tank.Armor, tank.Maneuverability);
        }
    }
}

