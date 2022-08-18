﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class DiceRoller
    {
        public int[] results = new int[2];

        public int[] rollD100(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 100");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(101);
                results[i] = res;
            }
            return results;
        }

        public int[] rollD20(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 20");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(21);
                results[i] = res;
            }
            return results;
        }
        public int[] rollD12(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 12");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(13);
                results[i] = res;
            }
            return results;
        }
        public int[] rollD10(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 10");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(11);
                results[i] = res;
            }
            return results;
        }

        public int[] rollD6(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 6");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(7);
                results[i] = res;
            }
            return results;
        }
        public int[] rollD4(int numRolls)
        {
            int res;
            var rand = new Random();

            Console.WriteLine(" " + numRolls + " Random numbers between 1 and 4");

            for (int i = 0; i < numRolls; i++)
            {
                res = rand.Next(5);
                results[i] = res;
            }
            return results;

        }



        public int[] rollD20UserInput()
        {
            int userInput;
            var rand = new Random();
            userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userInput + " Random numbers between 1 and 20");

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("{0,8:N0}", rand.Next(21));
            }
            return results;
        }

        public override string ToString()
        {
            return ($"{0} Random numbers between 1 and 20");
        }
    }
}