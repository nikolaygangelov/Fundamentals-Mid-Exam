

namespace Problem_3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();


            int index = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            int sumOfPriceRatingssLeft = 0;
            int sumOfPriceRatingssRight = 0;
            string position = string.Empty;
            



            if (typeOfItems == "cheap")
            {
                for (int i = 0; i < index; i++)
                {
                    if (priceRatings[i] < priceRatings[index])
                    {
                        sumOfPriceRatingssLeft += priceRatings[i];
                    }

                }

                for (int i = index + 1; i < priceRatings.Count; i++)
                {
                    if (priceRatings[i] < priceRatings[index])
                    {
                        sumOfPriceRatingssRight += priceRatings[i];
                    }
                }

                if (sumOfPriceRatingssLeft > sumOfPriceRatingssRight)
                {
                    position = "Left";
                }else if (sumOfPriceRatingssRight > sumOfPriceRatingssLeft)
                {
                    position = "Right"; 
                }
                else
                {
                    position = "Left";
                }

            }
            else if(typeOfItems == "expensive")
            {
                for (int i = 0; i < index; i++)
                {
                    if (priceRatings[i] >= priceRatings[index])
                    {
                        sumOfPriceRatingssLeft += priceRatings[i];
                    }

                }

                for (int i = index + 1 ; i < priceRatings.Count; i++)
                {
                    if (priceRatings[i] >= priceRatings[index])
                    {
                        sumOfPriceRatingssRight += priceRatings[i];
                    }
                }

                if (sumOfPriceRatingssLeft > sumOfPriceRatingssRight)
                {
                    position = "Left";
                }
                else if (sumOfPriceRatingssRight > sumOfPriceRatingssLeft)
                {
                    position = "Right";
                }
                else
                {
                    position = "Left";
                }
            }

            if(position == "Left")
            {
                Console.WriteLine($"{position} - {sumOfPriceRatingssLeft}");
            }
            else if(position == "Right")
            {
                Console.WriteLine($"{position} - {sumOfPriceRatingssRight}");
            }
            

        }
    }
}
