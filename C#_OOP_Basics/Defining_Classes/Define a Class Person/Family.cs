using System.Collections.Generic;
using System.Linq;

namespace Define_a_Class_Person
{
    public class Family
    {
        private List<Person> members;

        public Family() //constructor
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
