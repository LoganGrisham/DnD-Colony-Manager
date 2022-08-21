using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Utility
    {
        TextFormatting f = new TextFormatting();
        Dice d = new Dice();
        Buildings b = new Buildings();

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

        public void buildingTool()
        {
            int choice = 0;

            while (choice !=6) {
                Console.WriteLine("What building would you like to calculate?");
                f.buildingMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 6)
                {
                    Console.WriteLine("Wrong Choice! Try again.");
                }
                switch (choice)
                {
                    case 1: // docks water
                        b.docksWater();
                        Console.WriteLine("");
                        break;
                    case 2: //market stalls
                        b.MarketStalls();
                        Console.WriteLine("");
                        break;
                    case 3: //tavern
                        b.MarketStalls();
                        Console.WriteLine("");
                        break;
                    case 4: //bank
                        b.bank();
                        Console.WriteLine("");
                        break;
                    case 5:
                        b.docksWater();
                        b.MarketStalls();
                        b.Tavern();
                        b.bank();
                        Console.WriteLine("");
                        break;
                    case 6:
                        break;
                }
            }
        }
        public void saveBankInfo(BankAccount bank)
        {
            FileTools.WriteToBinaryFile<BankAccount>(@"F:\DND\bankAccount.txt", bank);
        }
        public void loadBankInfo(BankAccount bank)
        {
            bank = FileTools.ReadFromBinaryFile<BankAccount>(@"F:\DND\bankAccount.txt");
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
