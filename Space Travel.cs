

namespace Problem_2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int startingFuel = int.Parse(Console.ReadLine());
            int startingAmmunition = int.Parse(Console.ReadLine());


            for (int i = 0; i < travelRoute.Length; i++)
            {
                string wholeCommand = travelRoute[i];
                if (wholeCommand != "Titan")
                {
                    string[] inputParameters = wholeCommand.Split();
                    string commandType = inputParameters[0];


                    if (commandType == "Travel")
                    {
                        int lightEars = int.Parse(inputParameters[1]);


                        if ((startingFuel - lightEars) >= 0)
                        {
                            startingFuel -= lightEars;
                            Console.WriteLine($"The spaceship travelled {lightEars} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }

                    }
                    else if (commandType == "Enemy")
                    {
                        int enemyArmour = int.Parse(inputParameters[1]);
                        if (startingAmmunition >= enemyArmour)
                        {
                            startingAmmunition -= enemyArmour;
                            Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                        }
                        else
                        {
                            if (2 * enemyArmour <= startingFuel)
                            {
                                startingFuel -= 2 * enemyArmour;
                                if (startingFuel < 0)
                                {
                                    Console.WriteLine("Mission failed.");
                                    break;
                                }
                                Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                break;
                            }

                        }
                    }
                    else if (commandType == "Repair")
                    {
                        int ammunitionOrFuelAdded = int.Parse(inputParameters[1]);

                        startingFuel += ammunitionOrFuelAdded;
                        int addedAmmunition = ammunitionOrFuelAdded * 2;
                        startingAmmunition += addedAmmunition;

                        Console.WriteLine($"Ammunitions added: {addedAmmunition}.");
                        Console.WriteLine($"Fuel added: {ammunitionOrFuelAdded}.");
                    }

                }
                else
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }

            }

        }
    }
}
