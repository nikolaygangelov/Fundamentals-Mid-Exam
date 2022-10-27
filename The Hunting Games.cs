

namespace Problem_1
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal groupsEnergy = decimal.Parse(Console.ReadLine());
            decimal waterPerDayForOnePerson = decimal.Parse(Console.ReadLine());
            decimal foodPerDayForOnePerson = decimal.Parse(Console.ReadLine());

            decimal totalWater = N * players * waterPerDayForOnePerson;
            decimal totalFood = N * players * foodPerDayForOnePerson;

            for (int i = 1; i <= N; i++)
            {
                decimal energyLost = decimal.Parse(Console.ReadLine());
                groupsEnergy -= energyLost;
                if (groupsEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    break;
                }

                if (i % 2 == 0)
                {
                    groupsEnergy *= 1.05m;
                    totalWater *= 0.7m;
                }

                if (i % 3 == 0)
                {
                    if(i % 2 == 0)
                    {
                        totalFood -= totalFood / players;
                        groupsEnergy *= 1.10m;
                    }
                    else
                    {
                        totalFood -= totalFood / players;
                        groupsEnergy *= 1.10m;
                    }
                    
                }


            }
            if (groupsEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:f2} energy!");  
            }

        }
    }
}
