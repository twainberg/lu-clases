using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Lagash.NoSql.MongoDB.Repository.MongoDB
{
    public class BillRepository
    {
        private IMongoDB service;        
        private string collectionName;
        public BillRepository(IMongoDB service,string collectionName)
        {
            this.service = service;            
            this.collectionName = collectionName;
        }

        public void CreateOrUpdate<T>(T model) where T : class
        {
            service.CreateOrUpdate<T>(model, collectionName);
        }
    }
}
