using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Formatting
    {

        public void introText()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---Knot Pirate Colony Manager!----");
            Console.WriteLine("---------------------------------- \n");
        }

        public void spacerLines() {

            Console.WriteLine("\n ----------------------------- \n");
        }
        public void docksWaterHeaderText()
        {
            Console.WriteLine("~~Knot pirate Docks Monthly Income~~");
            Console.WriteLine(" ::25gp times 2d10 every 30 days:: \n");
        }

        public void marketStallsHeaderText()
        {
            Console.WriteLine("~~Knot pirate Market Stalls Monthly Income~~");
            Console.WriteLine(" ::30gp times 2d6 every 30 days:: \n");
        }

        public void tavernHeaderText()
        {
            Console.WriteLine("~~Knot pirate Tavern Monthly Income~~");
            Console.WriteLine(" ::This section lists the total income from kegs,");
            Console.WriteLine("   rumors, and rooms::");
            Console.WriteLine(" ::Kegs - 2d10 * 10 gp (30 days)::");
            Console.WriteLine(" ::Rooms - 1d10 * 10gp (30 days)::");
            Console.WriteLine(" ::Rumors - 1d4-1 (7 days)      :: \n");
        }
        
    }
}
