namespace csharp;

class Person{
    private static int nextId = 1;
    public int Id { get; }
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age){
        Id = nextId;
        nextId++;
        Name = name;
        Age = age;
    }

    public static void InitializeNextId(int lastId){
        nextId = lastId + 1;
    }

    public static void ResetIds(){
        nextId = 1;
    }
}
