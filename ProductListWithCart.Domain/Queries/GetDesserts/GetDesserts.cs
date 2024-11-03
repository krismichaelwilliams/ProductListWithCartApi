using ProductListWithCart.DataAccess.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListWithCart.Domain.Queries.GetDesserts
{
    internal class GetDesserts : IGetDesserts
    {
        private IMongoDriverWrapper _mongoDriverWrapper;

        public GetDesserts(IMongoDriverWrapper mongoDriverWrapper)
        {
            _mongoDriverWrapper = mongoDriverWrapper;
        }

        List<T> IGetDesserts.GetDesserts<T>(string table)
        {
            return _mongoDriverWrapper.GetDesserts<T>(table);
        }
    }
}
