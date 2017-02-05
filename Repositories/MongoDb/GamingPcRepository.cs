using System;
using System.Collections.Generic;
using MongoDB.Driver;

using com.wendysa.apidemo.Models;
using System.Threading.Tasks;

namespace com.wendysa.apidemo.Repositories.MongoDb{
    public class GamingPcRepository : IGamingPcRepository {
        // TODO: Get it from configuration
        private readonly string mongoDbConnectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "api-research";
        private MongoClient mongoClient;
        private IMongoDatabase mongoDatabase;
        public GamingPcRepository() {
            mongoClient = new MongoClient(mongoDbConnectionString);
            mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public async Task<IEnumerable<GamingPc>> getAllAsync(int limit)
        {
            IEnumerable<GamingPc> result = null;
            try{
                result = await mongoDatabase.GetCollection<GamingPc>("gamingpc")
                                      .Find(_ => true)   
                                      .Limit(limit)                                   
                                      .ToListAsync();
            }
            catch(Exception exception){
                Console.WriteLine("Error: {0} \n\rStacktrace:{1}", exception.Message, exception.StackTrace);
            }            
            return result;
        }
    }
}