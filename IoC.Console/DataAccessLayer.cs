using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Console
{
    public class DataAccessLayer : IDataAccessLayer
    {
        // Sql Serverdan geldiğini varsay.
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {Id = 1, Name = "Pencil", Price = 100, Stock = 100},
                new Product() {Id = 2, Name = "Pencil2", Price = 200, Stock = 200},
                new Product() {Id = 3, Name = "Pencil3", Price = 300, Stock = 300},
                new Product() {Id = 4, Name = "Pencil4", Price = 400, Stock = 400}
            };
        }

        // Şu anda business logic buna erişemez. Ne zamanki IDataAccessLayer a bu method eklenir o zaman erişir.
        public int Hesapla()
        {
            return 0;
        }
    }
}
