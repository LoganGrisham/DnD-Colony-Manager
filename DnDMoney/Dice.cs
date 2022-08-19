using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Dice
    {
        public int[] results = new int[100];

        public int[] rollD100(int numRolls)
        {
            int res;
            var rand = new Random();

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

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("{0,8:N0}", rand.Next(21));
            }
            return results;
        }

        
    }
}
