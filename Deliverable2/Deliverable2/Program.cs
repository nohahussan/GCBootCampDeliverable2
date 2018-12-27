using System;

namespace Deliverable2
{
        class FunRecommendation
        {
            public static void Main(string[] args)
            {
                string userInput;

                int userChoice;

                Console.WriteLine("Hello user, what are you in the mood for ?");

                Console.WriteLine("Here are your options: \n" +
                    "1. Action\n" +
                    "2. Chill times\n" +
                    "3. Danger\n" +
                    "4. Good food\n");

                userInput = Console.ReadLine();

                userChoice = Convert.ToInt32(userInput);

                int numberOfPeople = 0;

                //check the user input

                if (userChoice >= 1 && userChoice <= 4)
                {

                    Console.WriteLine("How many people are you bringing with you ?");
                    string number = Console.ReadLine();
                    numberOfPeople = Convert.ToInt32(number);

                }
                else
                {

                    Console.WriteLine("Sorry you entered invalid option!!\n" +
                        "Goodbye");


                }

                //create method take number of travelling people and return suggestion of how they should travell

                string suggestion(int travelingPeople)
                {
                    if (travelingPeople == 0)
                    {
                        return "a sneakers";
                    }

                    else if (travelingPeople >= 1 && travelingPeople <= 4)
                    {

                        return "a sedan";
                    }

                    else if (travelingPeople >= 5 && travelingPeople <= 10)
                    {

                        return "a Volkswagen bus";
                    }
                    else if (travelingPeople >= 11)
                    {

                        return "an airplane";
                    }

                    else
                    {
                        return "";
                    }

                }

            //method take the number the user input and return what option the user entered and suggestion of how he should spend his time
                string userMood(int choice)
                {

                    switch (choice)
                    {
                        case 1:
                            return "an action, then you should go to Stock Car Racing ";

                        case 2:
                            return "chilling, then you should go for hikking ";

                        case 3:
                            return "danger, then you should go for sky diving ";
                        case 4:
                            return "good food , then you should go to Taco Bell ";

                        default:
                            return "";
                    }

                }


                Console.WriteLine("Ok if you are in the mood for " + userMood(userChoice) + "and travel in " + suggestion(numberOfPeople));



            }
        }
}
