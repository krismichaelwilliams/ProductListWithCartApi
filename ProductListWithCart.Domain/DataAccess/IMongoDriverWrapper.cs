using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListWithCart.DataAccess.Wrappers
{
    public interface IMongoDriverWrapper
    {
        public List<T> GetDesserts<T>(string table);
    }
}
