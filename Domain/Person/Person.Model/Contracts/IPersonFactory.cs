using Person.Model;

namespace Person.Model.Contracts
{
    public interface IPersonFactory
    {
        Person Create(Name name);
    }

}