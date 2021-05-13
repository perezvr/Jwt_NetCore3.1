using Jwt_NetCore3._1.Entities;
using System.Collections.Generic;

namespace Jwt_NetCore3._1.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
