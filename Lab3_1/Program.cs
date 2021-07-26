using System;

namespace Lab3_1
{
    class Program
    {
        static bool KeepGoing()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("\nWould you like to know about another student? (enter \"yes\" or \"no\": ");
                string response = Console.ReadLine();
                response = response.ToLower();

                if (response == "yes" || response == "y")
                {
                    return true;
                }
                else if (response == "no" || response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("\nPlease enter yes or no.");
                }

            }
        }
        static void Main(string[] args)
        {
            string[] studentNames = {"Yolanda Farris", "Shelley Chubb", "Daniel Stevens", "Leah Scott", "Britiny Rasnick" };
            string[] favoriteFood = {"Pizza", "Hamburger", "Pasta", "Fried Chicken", "French Fries"};
            string[] previousTitle = {"Post Closing Auditor", "Document Specialist", "Team Leader", "Trainer", "Quailty Control Auditor" };

            string choice;

            Console.WriteLine("Welcome to our Dev.Build class.");
            do
            {
                Console.Write("\nWhich student would you like to learn more about? (enter a number 1-5): ");

                int studentNo = int.Parse(Console.ReadLine());


                while (studentNo > 5)
                {
                    Console.Write("\nThat student does not exist. Please try again. (enter a number 1-5): ");
                    studentNo = int.Parse(Console.ReadLine());
                }



                Console.Write($"\nStudent {studentNo} is {studentNames[studentNo - 1]}. What would you like to know about {studentNames[studentNo - 1]}? (enter \"favorite food\" or \"Previous title\")");
                choice = Console.ReadLine();
                choice = choice.ToLower();

                while (choice != "favorite food" && choice != "previous title")
                {
                    Console.Write("\nThat data does not exist. Please try again. (enter \"favorite food\" or \"previous title\"");
                    choice = Console.ReadLine();
                    choice = choice.ToLower();
                }

                if (choice == "favorite food")
                {
                    Console.WriteLine($"\n{studentNames[studentNo - 1]}'s favorite food is {favoriteFood[studentNo - 1]}.");
                }
                else if (choice == "previous title")
                {
                    Console.WriteLine($"\n{studentNames[studentNo - 1]}'s previous title is {previousTitle[studentNo - 1]}.");
                }
            } while (KeepGoing() == true);

            Console.WriteLine("\n Thanks!");

                
            



        }
    }
}
