public class Person
{
    public string name { get; set; }
    public int age { get; set; }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
        : this()
    {
        this.age = age;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.name} - {this.age}"; 
    }
}

