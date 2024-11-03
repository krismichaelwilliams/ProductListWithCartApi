using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListWithCart.Domain.Queries.GetDesserts
{
    public interface IGetDesserts
    {
        public List<T> GetDesserts<T>(string table);
    }
}
