public class Employee
{
    public string name { get; set; }
    public decimal salary { get; set; }
    public string position { get; set; }
    public string department { get; set; }
    public string email { get; set; }
    public int age { get; set; }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.name} {this.salary:f2} {this.email} {this.age}";
    }
}

