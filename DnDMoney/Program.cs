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

            while (choice != 5)
            {
                f.introText();

                Console.WriteLine(" ");
                Console.WriteLine("1. Display Income for a specific Building");
                Console.WriteLine("2. Roll a Dice");
                Console.WriteLine("3. Determine your fate");
                Console.WriteLine("4. Clear Screen");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Choose an option from 1 to 5:");
                Console.WriteLine(" ");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Wrong Choice! Try again.");
                }
                switch (choice)
                {
                    case 1:
                        u.buildingTool();
                        break;
                    case 2:
                        u.diceRollTool();
                        break;
                    case 3:
                        u.Kms();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                }
                
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        
    }
}
