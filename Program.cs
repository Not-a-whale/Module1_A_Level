using System;

namespace ToDoList
{
    class Program
    {
        static string[,] tasksArray = { };
        static string[,] completedTaskArray = { };
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

                    case "remove-item":
                        RemoveItem();
                        break;
                    case "mark-as":
                        MarkItem();
                        break;
                    case "show":
                        DisplayAll();
                        break;
                    case "exit":
                        return;
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
            Console.WriteLine("Please enter a name of the task");
            string taskName = Console.ReadLine();
            Console.WriteLine("Please enter it's due time");
            string dueTime = Console.ReadLine().Length > 0 ? Console.ReadLine() : DateTime.Now.ToString();
            for(int i = 0; i < completedTaskArray.Length; i++)
            {
                if (tasksArray[i, 0] == taskName)
                {
                    AskQuestion();
                } else
                {
                    Resize<string[]>(ref tasksArray, 1);
                }
            }
            
        }
        // Removes an item

        static void RemoveItem()
        {

        }

        // Marks task as 
        static void MarkItem()
        {

        }


        // displays all the tasks

        static void DisplayAll()
        {

        }

        public static void Resize<T>(ref T[] array, int value)
        {
            Array.Resize(ref array, array.Length + 1);
        }

        public static void Push<T>(ref T[] array, object value)
        {
            Resize(ref array, 1);
            array.SetValue(value, array.Length - 1);
        }
    }
}
