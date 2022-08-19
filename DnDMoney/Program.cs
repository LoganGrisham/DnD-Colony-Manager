using System;

namespace DnDMoney
{
    public class DnDMoney
    {
      
        static void Main(string[] args)
        {
            int choice = 0;
            Buildings buildings = new Buildings();
            Formatting f = new Formatting();
            Utility u = new Utility();
            Dice d = new Dice();

            while (choice != 4)
            {
                Console.Clear();
                f.introText();

                Console.WriteLine(" ");
                Console.WriteLine("1. Display Income for a specific Building");
                Console.WriteLine("2. Roll a Dice");
                Console.WriteLine("3. Determine your fate");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Choose an option from 1 to 4:");
                Console.WriteLine(" ");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Wrong Choice! Try again.");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Which building would you like to calculate?");
                        break;
                    case 2:
                        u.diceRollTool();                       
                        break;
                    case 3:
                        u.Kms();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                }



                /*f.docksWaterHeaderText();
                buildings.docksWater();

                f.spacerLines();

                f.marketStallsHeaderText();
                buildings.MarketStalls();

                f.spacerLines();

                f.tavernHeaderText();
                buildings.Tavern();

                f.spacerLines();
                */

                
                
            }
            Console.WriteLine("Press nay ket to continue");
            Console.ReadKey();
        }
        
    }
}
