using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._1._5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Låt oss göra en saga!");
            Console.Write("Då behöver jag ett namn: ");
            string aName = Console.ReadLine();

            Console.Write("... och ett till namn: ");
            string bName = Console.ReadLine();

            Console.WriteLine("Det var en gång en vacker dag då {0} och {1} var ute och gick.", aName, bName);
            Console.WriteLine("Dom levde lyckliga i alla sina dar. Slut.");
            Console.ReadLine();
        }
    }
}
