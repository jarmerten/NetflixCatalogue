using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
   public class UserInput
    {
        int integeruserpicked;
        public int WhatWouldYouLikeToDo(int whichQuestionToAsk)
        {
            switch (whichQuestionToAsk)
            {
                case 1:
                    {
                        Console.WriteLine("Woud you like to 1: Add or Remove movie or show or 2: Search the Catalogue? ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Would you like to Add or Remove a 1:Movie or 2:Show? ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("What is the title of the new movie you are adding? ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Would you like to 1: Add a show or movie or 2: Remove a show or movie? ");
                        break;
                    }
            }
            if (Int32.TryParse(Console.ReadLine(), out integeruserpicked))
            {
                if (integeruserpicked <= 2)
                {

                    return integeruserpicked;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Number of 1 or 2. ");
                    return WhatWouldYouLikeToDo(whichQuestionToAsk);
                }
            }
            else
            {
                Console.WriteLine("Please enter a Valid Number of 1 or 2. ");
                return WhatWouldYouLikeToDo(whichQuestionToAsk);
            }
        }
    }
}
