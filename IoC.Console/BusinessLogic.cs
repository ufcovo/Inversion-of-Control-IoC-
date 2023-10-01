using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Console
{
    public class BusinessLogic
    {
        private IDataAccessLayer _layer { get; set; }
        public BusinessLogic(IDataAccessLayer dataAccessLayer)
        {
            _layer = dataAccessLayer;
        }
        public List<Product> GetProducts()
        {
            return _layer.GetProducts();
        }
    }
}
