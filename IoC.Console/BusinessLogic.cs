using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Console
{
    public class BusinessLogic
    {
        private DataAccessLayer _layer { get; set; }
        public BusinessLogic()
        {
            _layer = new DataAccessLayer();
        }
        public List<Product> GetProducts()
        {
            return _layer.GetProducts();
        }
    }
}
