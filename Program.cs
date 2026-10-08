static class SystemRegister{
    private const string FilePath = "registers.txt";
    
    public static void Menu(){
        Console.WriteLine("[1] Create user\n[2] View users\n[3] View total users\n[4] Delete all\n[5] Exit");
    }
    public static void AddRegister(Person person){

        File.AppendAllText(FilePath, $"{person.Id},{person.Name},{person.Age}\n");
    }

    public static void ViewRegisters(){
        if (!File.Exists(FilePath)){
            Console.WriteLine("No record.\n");
        }
        else{
            Console.WriteLine($"{"Name",-12}{"Age",-5}");
            Console.WriteLine("-------------------");
            foreach (var l in File.ReadLines(FilePath))
            {
                string[] line = l.Split(",");
                Console.WriteLine($"{line[1],-12}{line[2],-5}");
            }
            
            Console.WriteLine("-------------------\n");  
        } 
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
