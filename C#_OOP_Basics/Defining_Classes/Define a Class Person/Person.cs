namespace Define_a_Class_Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
