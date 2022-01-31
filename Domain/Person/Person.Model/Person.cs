using Person.Model.Contracts;
using Boilerplate.DDD;

namespace Person.Model
{
    public class Person : AggregateRoot
    {
        public Person (Name name)
        {
            Name = name;
        }

        public Name Name { get; set; }

        public void SetName(Name name)
        {
            Name = name;
        }
        
        // public IEnumerable<Document> Documents { get; set; }
        // public IEnumerable<WorkHistory> WorkHistory { get; set; }
        // public IEnumerable<Skills> Skills { get; set; }
        // public IEnumerable<Competency> Competencies { get; set; }
        // public IEnumerable<Reference> References { get; set; }
        // public IEnumerable<Education> Education { get; set; }
        // public IEnumerable<string> Experience { get; set; }

        public class PersonFactory : IPersonFactory
        {
            public Person Create(Name name)
            {
                return new Person(name);
            }
        }
    }
}
