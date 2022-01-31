using System;
using Boilerplate.Repository;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Boilerplate.DDD;

namespace Boilerplate.Mongo
{
    public class MongoRepository<T> : IRepository<T> where T : AggregateRoot
    {
        private IMongoCollection<T> mongoCollection;
        public MongoRepository(IMongoClient mongoClient)
        {
            mongoCollection = mongoClient.GetDatabase("MongoBoilerplate").GetCollection<T>(typeof(T).Name);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> query)
        {
            return mongoCollection.AsQueryable().Where(query).ToList();
        }

        public void Insert(T item)
        {
            mongoCollection.InsertOne(item);
        }
    }
}
