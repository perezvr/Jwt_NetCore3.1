using Jwt_NetCore3._1.Entities;
using Jwt_NetCore3._1.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_NetCore3._1.Services.Interfaces
{
    public interface IUserService
    {
        GenerateTokenResponseDto Authenticate(GenerateTokenRequestDto model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
