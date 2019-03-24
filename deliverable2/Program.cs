using System;
using System.Collections.Generic;

namespace funRecommendations
{
    class Activity
    {
        public string activityType { get; set; }
        public string recommendation { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Activity> activities = new Dictionary<int, Activity>()
            {
                {1, new Activity {activityType = "action", recommendation = "stock car racing" } },
                {2, new Activity {activityType = "chilling", recommendation = "hiking" } },
                {3, new Activity {activityType = "danger", recommendation = "skydiving" } },
                {4, new Activity {activityType = "good food", recommendation = "to Taco Bell" } }
            };
            int choice1, choice2;
            bool allGood = false;
            string userInput = "", travelRecommendation = "";

            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");

            for (int i = 1; i <= activities.Count; ++i)
            {
                Console.WriteLine(i + ") " + char.ToUpper(activities[i].activityType[0]) + activities[i].activityType.Substring(1));
            }

            do
            {
                Console.Write("Please enter the number of your choice: ");
                userInput = Console.ReadLine();
                bool success = Int32.TryParse(userInput, out choice1);

                if (success && 1 <= choice1 && choice1 <= 4)
                {
                    allGood = true;

                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a number corresponding to one of the choices.");
                }

            } while (allGood == false);

            userInput = "";
            allGood = false;

            do
            {
                Console.WriteLine("\nHow many people are you bringing with you? ");
                Console.Write("Please enter the number of people: ");
                userInput = Console.ReadLine();

                bool success = Int32.TryParse(userInput, out choice2);
                if (success && choice2 >= 0)
                {
                    allGood = true;

                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a positive integer.");
                }

            } while (allGood == false);

            if (choice2 == 0)
            {
                travelRecommendation = "sneakers";
            }
            else if (choice2 <= 4)
            {
                travelRecommendation = "a sedan";
            }
            else if (choice2 <= 10)
            {
                travelRecommendation = "a Volkswagen bus";
            }
            else
            {
                travelRecommendation = "an airplane";
            }

            Console.WriteLine("\nOkay. If you're in the mood for " + activities[choice1].activityType +
                ", then you should go " + activities[choice1].recommendation + " and travel in " + travelRecommendation + "!");
            Console.WriteLine("Goodbye.");
        }
    }
}
