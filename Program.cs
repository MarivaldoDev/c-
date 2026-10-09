static class SystemRegister{
    private const string FilePath = "registers.txt";
    
    public static void Menu(){
        Console.WriteLine("[1] Create user\n[2] View users\n[3] View total users\n[4] Search user\n[5] Delete all\n[6] Exit\n");
    }
    public static void AddRegister(Person person){

        File.AppendAllText(FilePath, $"{person.Id},{person.Name},{person.Age}\n");
    }

    public static void ViewRegisters(string? search = null){
        if (!File.Exists(FilePath)){
            Console.WriteLine("No record.\n");
            return;
        }

        bool found = false;
        Console.WriteLine($"{"Name",-12}{"Age",-5}");
        Console.WriteLine("-------------------");

        foreach (var register in File.ReadLines(FilePath)){
            if (!string.IsNullOrWhiteSpace(search) &&
                !register.Contains(search, StringComparison.OrdinalIgnoreCase)){
                continue;
            }

            string[] fields = register.Split(',');
            if (fields.Length < 3){
                continue;
            }

            Console.WriteLine($"{fields[1],-12}{fields[2],-5}");
            found = true;
        }

        if (!found && !string.IsNullOrWhiteSpace(search)){
            Console.WriteLine("No matching record.");
        }

        Console.WriteLine("-------------------\n");
    }

    public static int CountUsers(){
        if (!File.Exists(FilePath)){
            return 0;
        }
        return File.ReadAllLines(FilePath).Length;
    }

    public static void DeleteAll(){
        if (File.Exists(FilePath)){
            File.Delete(FilePath);
            Person.ResetIds();
            Console.WriteLine("Registers deleted with success!\n");
        }
    }

    public static int CurrentId(){
        if (!File.Exists(FilePath)){
            return 0;
        }

        string? lastLine = File.ReadLines(FilePath).LastOrDefault();
        if (string.IsNullOrWhiteSpace(lastLine)){
            return 0;
        }

        string[] fields = lastLine.Split(',');
        return fields.Length > 0 && int.TryParse(fields[0], out int id) ? id : 0;
    }
}
