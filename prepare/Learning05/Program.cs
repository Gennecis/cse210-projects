class Program
{
    static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();

        // Sample usage
        program.AddGoal(new SimpleGoal { _name = "Run a marathon", _value = 1000 });
        program.AddGoal(new EternalGoal { _name = "Read scriptures", _value = 0 });
        program.AddGoal(new ChecklistGoal(10) { _name = "Attend temple", _value = 0 });
         Console.WriteLine();
        Console.WriteLine("Choose 'Display goals' to see all goals");
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Select an action:");
            Console.WriteLine();
            Console.WriteLine("1. Record event");
            Console.WriteLine("2. Add new goal");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RecordEvent(program);
                    break;
                case "2":
                    AddNewGoal(program);
                    break;
                case "3":
                    program.DisplayGoals();
                    break;
                case "4":
                    SaveGoals(program);
                    break;
                case "5":
                    LoadGoals(program);
                    break;
                case "6":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    static void RecordEvent(EternalQuestProgram program)
    {
        Console.WriteLine("Enter the index of the goal you want to record an event for:");
        int index = int.Parse(Console.ReadLine()) - 1;
        program.RecordEvent(index);
        Console.WriteLine("Event recorded.");
    }

    static void AddNewGoal(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("Enter the name of the new goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the type of the new goal (1: Simple, 2: Eternal, 3: Checklist):");
        int type = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case 1:
                goal = new SimpleGoal();
                break;
            case 2:
                goal = new EternalGoal();
                break;
            case 3:
                Console.WriteLine("Enter the target times for the checklist goal:");
                int targetTimes = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(targetTimes);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goal._name = name;
        program.AddGoal(goal);
        Console.WriteLine("New goal added.");
    }

    static void SaveGoals(EternalQuestProgram program)
    {
        Console.WriteLine();
        Console.WriteLine("Enter the file name to save goals:");
        string fileName = Console.ReadLine();
        program.SaveGoals(fileName);
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals(EternalQuestProgram program)
    {
        Console.WriteLine("Enter the file name to load goals:");
        string fileName = Console.ReadLine();
        program.LoadGoals(fileName);
        Console.WriteLine("Goals loaded successfully.");
    }
}
