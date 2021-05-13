using Jwt_NetCore3._1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_NetCore3._1.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(User user);
        DateTime GetExpireTime(string token);
    }
}
