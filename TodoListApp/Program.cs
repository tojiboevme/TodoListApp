internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to App that can help your To Do");

        List<string> list = new List<string>();

        string option = "";

        while (option != "x")
        {
            Console.WriteLine("What would you like to do in list ");
            Console.WriteLine("Enter 1 to add a task to the list. ");
            Console.WriteLine("Enter 2 to remove a task from the list. ");
            Console.WriteLine("Enter 3 to view the list. ");
            Console.WriteLine("Enter x to exit the program ");

            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Please enter the name of Task: ");
                string Task = Console.ReadLine();
                list.Add(Task);
                Console.WriteLine("Task added Succesfully");
            }
            else if (option == "2")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(i + ":" + list[i]);
                }
                Console.WriteLine("Enter the number of task to remove from List");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                list.RemoveAt(taskNumber);
            }
            else if (option == "3")
            {
                Console.WriteLine("Current tasks in the List");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            else if (option == "x")
                {
                Console.WriteLine("Exit Program");
            }
            else
            {
                Console.WriteLine("Invalit type of option !!!!");
            }

        }
    }
}