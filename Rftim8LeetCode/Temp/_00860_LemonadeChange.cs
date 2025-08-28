﻿namespace Rftim8LeetCode.Temp
{
    public class _00860_LemonadeChange
    {
        /// <summary>
        /// At a lemonade stand, each lemonade costs $5. Customers are standing in a queue to buy from you and order one at a time (in the order specified by bills). 
        /// Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill. 
        /// You must provide the correct change to each customer so that the net transaction is that the customer pays $5.
        /// Note that you do not have any change in hand at first.
        /// Given an integer array bills where bills[i] is the bill the ith customer pays, return true if you can provide every customer with the correct change, or false otherwise.
        /// </summary>
        public _00860_LemonadeChange()
        {
            Console.WriteLine(LemonadeChange([5, 5, 5, 10, 20]));
            Console.WriteLine(LemonadeChange([5, 5, 10, 10, 20]));
        }

        private static bool LemonadeChange(int[] bills)
        {
            int five = 0, ten = 0;
            foreach (int bill in bills)
            {
                if (bill == 5) five++;
                else if (bill == 10)
                {
                    if (five == 0) return false;
                    five--;
                    ten++;
                }
                else
                {
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                    }
                    else if (five >= 3) five -= 3;
                    else return false;
                }
            }

            return true;
        }
    }
}
