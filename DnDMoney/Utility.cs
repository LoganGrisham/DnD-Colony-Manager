using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Utility
    {
        Formatting f = new Formatting();
        Dice d = new Dice();

        public void diceRollTool()
        {
            int diceChoice = 0;
            int diceRollChoice = 0;
            int[] rollRes = new int[100];

            Console.WriteLine("What dice would you like to roll?");
            f.diceMenu();
            diceChoice = Convert.ToInt32(Console.ReadLine());
            if (diceChoice < 1 || diceChoice > 6)
            {
                Console.WriteLine("Wrong Choice! Try again.");
            }
            Console.WriteLine("How many times would you like to roll? (up to 100)");
            diceRollChoice = Convert.ToInt32(Console.ReadLine());
            switch (diceChoice)
            {
                case 1:
                    rollRes = d.rollD100(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for(int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;
                case 2:
                    rollRes = d.rollD20(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for (int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;
                case 3:
                    rollRes = d.rollD12(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for (int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;
                case 4:
                    rollRes = d.rollD10(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for (int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;
                case 5:
                    rollRes = d.rollD6(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for (int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;
                case 6:
                    rollRes = d.rollD4(diceRollChoice);
                    Console.WriteLine("Rolls: ");
                    for (int i = 0; i < diceRollChoice; i++)
                    {
                        Console.WriteLine("   " + rollRes[i]);
                    }
                    break;

            }
        }

        public void Kms()
        {
            Random r = new Random();

            int kms = r.Next(2);
            if (kms == 1)
            {
                Console.WriteLine("uh huh\n");
            }
            else
            {
                Console.WriteLine("nah g.\n");
            }
        }
    }
}
