using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Console
{
    public class OracleDAL : IDataAccessLayer
    {
        // Oracle DB den geldiğini varsay
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {Id = 1, Name = "Oracle Pencil", Price = 100, Stock = 100},
                new Product() {Id = 2, Name = "Oracle Pencil2", Price = 200, Stock = 200},
                new Product() {Id = 3, Name = "Oracle Pencil3", Price = 300, Stock = 300},
                new Product() {Id = 4, Name = "Oracle Pencil4", Price = 400, Stock = 400}
            };
        }
    }
}
