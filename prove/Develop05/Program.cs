using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal App!");
        Console.Write("Please enter a username before starting");
        string username = Console.ReadLine();
        Account UserAccount = new Account(username);// creates instance of Account to use throughout program
//
// starts main menu loop that continues until quit is selected
//
        Console.WriteLine("Please select which option you would like to do");
        while (true)
        {
            Console.WriteLine("1. Create a goal\n2. List current goals\n3. Save goals\n4. Load goals\n5. Record event\n6. Quit");
            Console.Write("Enter a number to choose: ");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            if (menuChoice == 1)
            {
                Console.Write("Please choose which goal to create\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n: ");
                int goalTypeChoice = Convert.ToInt32(Console.ReadLine());
                if (goalTypeChoice == 1)
                {//create a simple Goal
                    Console.WriteLine("Please Enter the following information: ");
                    Console.Write("Goal name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Goal description: ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("Goal value: ");
                    int goalValue = Convert.ToInt32(Console.ReadLine());

                    SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalValue);
                    UserAccount.AddGoal(newSimpleGoal);
                }
                else if (goalTypeChoice == 2)
                {// creates eternal goal
                    Console.WriteLine("Please Enter the following information: ");
                    Console.Write("Goal name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Goal description: ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("Goal value: ");
                    int goalValue = Convert.ToInt32(Console.ReadLine());

                    EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalValue);
                    UserAccount.AddGoal(newEternalGoal);
                }
                else if (goalTypeChoice == 3)
                {// creates check list goal
                    Console.WriteLine("Please Enter the following information: ");
                    Console.Write("Goal name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Goal description: ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("Goal value: ");
                    int goalValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("How many times till it's completed?: ");
                    int timesToComplete = Convert.ToInt32(Console.ReadLine());

                    ChecklistGoal newChecklistGoal = new ChecklistGoal(timesToComplete, goalName, goalDescription, goalValue);
                    UserAccount.AddGoal(newChecklistGoal);
                }
                UserAccount.DisplayGoalsList();
            }
            else if (menuChoice == 2)
            {// displays all goals 
                UserAccount.DisplayGoalsList();
            }
            else if (menuChoice == 3)
            {//saves goals to save file
                Console.Write("Please enter the file name to save goals to (use a txt file): ");
                UserAccount.SetSaveFileName(Console.ReadLine());
                UserAccount.CreateAccountFile();
                UserAccount.SaveFile();
            }
            else if (menuChoice == 4)
            {// load goals and user account from the file
               Console.Write("Please enter the file name to load goals from (use a txt file): ");
               UserAccount.LoadAccountFromFile(Console.ReadLine());
            }
            else if (menuChoice == 5)
            {// record Event
                UserAccount.RecordEvent();
            }
            else if (menuChoice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }

        
    }
}