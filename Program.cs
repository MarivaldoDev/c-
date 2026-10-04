namespace csharp
{

    class Person(string? name, int age)
    {
        public string name = name ?? string.Empty;
        public int age = age;

        public Dictionary<string, int> ToFormat(Person person)
        {
            Dictionary<string, int> person_formated = new(){
                {person.name, person.age}
            };

            return person_formated;
        }
    }

    class SystemRegister
    {
        static readonly List<Dictionary<string, int>> registers = [];
        public static void AddRegister(Dictionary<string, int> person)
        {
            registers.Add(person);
        }

        public static void ViewRegisters()
        {
            Console.WriteLine($"{"Name",-12}{"Age",-5}\n");

            foreach (var dicionario in registers)
            {
                foreach (var par in dicionario)
                {
                    Console.WriteLine($"{par.Key,-12}{par.Value,-5}");
                }
            }

            Console.WriteLine("-------------------\n");
        }

        public static int CountUsers()
        {
            return registers.Count;
        }
    }
}
