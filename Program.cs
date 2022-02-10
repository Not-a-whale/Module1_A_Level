using System;

namespace ToDoList
{
    class Program
    {
        static string[,] task = { };
        static string[,] completedTask = { };
        static string[,] rejectedTask = { };
        static string[] possibleInputs = { "add-item", "remove-item", "mark-as", "show", "exit" };
        static void Main(string[] args)
        {
            AskQuestion();
        }

        // Asks questions to a user with possible options
        static void AskQuestion()
        {
            Console.WriteLine("This is your new To-Do list 3000");
            Console.WriteLine("Please tell me, what are you planing to do today. \n The options are: ");
            Console.WriteLine($"\"{possibleInputs[0]}\" - To add a new task");
            Console.WriteLine($"\"{possibleInputs[1]}\" - To remove an item");
            Console.WriteLine($"\"{possibleInputs[1]}\" - To mark some task as completed/rejected");
            Console.WriteLine($"\"{possibleInputs[2]}\" - To see some completed/rejected tasks or all the tasks!");
            Console.WriteLine($"\"{possibleInputs[3]}\" - To exit.");
            string input = Console.ReadLine();
            InputController(input);
        }
        // Handles basic user input
        static void InputController(string userInput)
        {
            if(Array.Exists(possibleInputs, x => x == userInput))
            {
                switch(userInput)
                {
                    case "add-item":
                        AddItem();
                        break;
                        
                }
            } else
            {
                Console.WriteLine("You've made a mistake, please try again");
                AskQuestion();
            }
        }

        // Adds an item
        static void AddItem()
        {

        }
        // Removes an item

        // Marks task as 

        // displays all the tasks
    }
}
