using Lagash.NoSql.MongoDB.Repository.MongoDB;
using Lagash.NoSql.MongoDB.Models;

namespace Lagash.NoSql.MongoDB
{
    class Program
    {        
        static void Main(string[] args)
        {
            IMongoDB service = new MongoDb();

            var BillRepository = new BillRepository(service,"Bill");

            BillRepository.CreateOrUpdate(new Bill()
            {
                Id = 1,
                CustomerName = "Pepe",
                Total = 232
            });
        }
    }
}