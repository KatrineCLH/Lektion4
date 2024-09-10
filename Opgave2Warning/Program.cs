using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2Warning
{
    internal class Program
    {
        List<Warning> warnings = new List<Warning>();
        static void Main(string[] args)
        {
            PowerPlant plant = new PowerPlant();
            plant.SetWarning(WarningToConsole);
            plant.SetWarning(WarningAgain);

            for (int i = 0; i < 10; i++)
            {
                plant.HeatUp();
            }
            Console.ReadLine();
        }

        static void WarningToConsole() {
            Console.WriteLine("Advarsel");
        }
        static void WarningAgain()
        {
            Console.WriteLine("Hovsa");
        }
    }

    public delegate void Warning();

    public class PowerPlant
    {
        Warning w;
        Random r = new Random();

        public PowerPlant() { }

        public void SetWarning(Warning w)
        {
            //this.w = w;
            this.w += w;
        }

        public void HeatUp()
        {
            if (r.Next(0,100) > 50) {
                w.Invoke();
            }
        }
    }
}
