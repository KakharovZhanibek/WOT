using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.Module
{


    public class Tank
    {

        private string Name { get; set; }
        private int Ammunition { get; set; }
        private int Armor { get; set; }
        private int Maneuverability { get; set; }

        public Tank()
        {
            Name = "None";
            Ammunition = 0;
            Armor = 0;
            Maneuverability = 0;
        }
        public Tank(string Name, int Ammunition, int Armor, int Maneuverability)
        {
            this.Name = Name;
            this.Ammunition = Ammunition;
            this.Armor = Armor;
            this.Maneuverability = Maneuverability;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Боекомплект: {0}", Ammunition);
            Console.WriteLine("Броня: {0}", Armor);
            Console.WriteLine("Маневренность: {0}", Maneuverability);
        }
        public static Tank operator *(Tank T34, Tank Panther)
        {
            int t1 = 0, t2 = 0;
            if (T34.Ammunition > Panther.Ammunition)
                t1++;
            else if (T34.Ammunition < Panther.Ammunition)
                t2++;
            else { }

            if (T34.Armor > Panther.Armor)
                t1++;
            else if (T34.Armor < Panther.Armor)
                t2++;
            else { }
            if (T34.Maneuverability > Panther.Maneuverability)
                t1++;
            else if (T34.Maneuverability < Panther.Maneuverability)
                t2++;
            else { }
            if (t1 > t2)
            {
                return T34;
            }
            else if (t1 < t2)
            {
                return Panther;
            }
            else
            {
                int sum1 = 0, sum2 = 0;
                sum1 = T34.Ammunition + T34.Armor + T34.Maneuverability;
                sum2 = Panther.Ammunition + Panther.Armor + Panther.Maneuverability;
                if (sum1 > sum2)
                {
                    return T34;
                }
                else
                {
                    return Panther;
                }
            }
        }
        public string GetTanksName()
        {
            return Name;
        }
    }
}
