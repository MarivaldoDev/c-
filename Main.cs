Person.InitializeNextId(SystemRegister.CurrentId());

bool loop = true;
while (loop)
{
    SystemRegister.Menu();
    Console.Write("Make your choice: ");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.Write("Type your name: ");
                string? name = Console.ReadLine();

                Console.Write("Type your age: ");
                string? entry = Console.ReadLine();

                if (int.TryParse(entry, out int age) && age > 0)
                {
                    Person person = new(name ?? string.Empty, age);
                    SystemRegister.AddRegister(person);

                    Console.WriteLine("Your data has been saved.\n");
                }
                else
                {
                    Console.WriteLine("Enter a valid integer.\n");
                }
                break;
            case 2:
                Console.Clear();
                SystemRegister.ViewRegisters();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine($"Total users: {SystemRegister.CountUsers()}\n");
                break;
            case 4:
                Console.Clear();
                Console.Write("Name of the person: ");
                string? user = Console.ReadLine();

                SystemRegister.ViewRegisters(user);
                break;
            case 5:
                SystemRegister.DeleteAll();
                break;
            case 6:
                loop = false;
                break;
            default:
                Console.WriteLine("This option not exists!\n");
                break;
        }
    }
    else
    {
        Console.WriteLine("Error: You did not enter a valid number.");
    }
}
