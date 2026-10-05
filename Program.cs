namespace csharp
{

    class Person(string? name, int age){
        public string name = name ?? string.Empty;
        public int age = age;
    }

    class SystemRegister{
        private const string FilePath = "registers.txt";
        public static void AddRegister(Person person){

            File.AppendAllText(FilePath, $"{person.name},{person.age}{Environment.NewLine}");
        }

        public static void ViewRegisters()
        {
            
            Console.WriteLine($"{"Name",-12}{"Age",-5}");
            Console.WriteLine("-------------------");
            foreach (var l in File.ReadLines(FilePath))
            {
                var line = l.Split(",");
                Console.WriteLine($"{line[0],-12}{line[1],-5}");
            }
            
            Console.WriteLine("-------------------\n");
        }

        public static int CountUsers()
        {
            return File.ReadAllLines(FilePath).Length;
        }
    }
}
