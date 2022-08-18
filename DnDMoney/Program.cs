using System;

namespace DnDMoney
{
    public class DnDMoney
    {
      
        static void Main(string[] args)
        {
            Buildings buildings = new Buildings();
            Formatting f = new Formatting();
            Utility shouldI = new Utility();

            f.introText();

            f.docksWaterHeaderText();
            buildings.docksWater();

            f.spacerLines();

            f.marketStallsHeaderText();
            buildings.MarketStalls();

            f.spacerLines();

            f.tavernHeaderText();
            buildings.Tavern();


            shouldI.Kms();
            Console.ReadKey();


        }
        
    }
}
