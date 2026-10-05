using csharp;


bool loop = true;
while (loop){
    Console.WriteLine("[1] Create user\n[2] View users\n[3] View total users\n[4] Exit");
    Console.Write("Make your choice: ");
    string? input = Console.ReadLine();
    
    if (int.TryParse(input, out int choice)){
        switch (choice){
            case 1:
                Console.Clear();
                Console.Write("Type your name: ");
                string? name = Console.ReadLine();

                Console.Write("Type your age: ");
                string? entry = Console.ReadLine();

                if (int.TryParse(entry, out int age)){
                    Person person = new(name, age);
                    SystemRegister.AddRegister(person);
                    Console.WriteLine("Seus dados foram salvos.\n");
                }
                else{
                    Console.WriteLine("Digite um número inteiro válido.");
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
                loop = false;
                break;
            default:
                Console.WriteLine("This option not exists!\n");
                break;
        }
    }
    else{
        Console.WriteLine("Erro: Você não digitou um número válido.");
    }
}
