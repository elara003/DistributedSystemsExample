using Boilerplate.Repository;

namespace Person.Repository.Contracts
{
    public interface IPersonRepository : IRepository<Person.Model.Person>
    {
    }
}