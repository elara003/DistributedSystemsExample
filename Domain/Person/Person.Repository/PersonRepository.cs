using MongoDB.Driver;
using Boilerplate.Mongo;
using Person.Repository.Contracts;

namespace Person.Repository
{
    public class PersonRepository : MongoRepository<Person.Model.Person>, IPersonRepository
    {
        public PersonRepository(IMongoClient mongoClient) : base(mongoClient){}
    }
}
