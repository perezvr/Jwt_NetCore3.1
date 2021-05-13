using Jwt_NetCore3._1.Entities;
using Jwt_NetCore3._1.Entities.Dto;
using Jwt_NetCore3._1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_NetCore3._1.Services
{
    public class UserService : IUserService
    {
        private readonly ITokenService _tokenService;

        public UserService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public IEnumerable<User> GetAll()
            => _users;

        public User GetById(int id)
            => _users.FirstOrDefault(x => x.Id == id);

        //Representação do repositório de Usuários
        private List<User> _users = 
            new List<User>
            {
                new User { Id = 1, FirstName = "Renan", LastName = "Perez", Username = "userName", Password = "passWord" }
            };

        public GenerateTokenResponseDto Authenticate(GenerateTokenRequestDto model)
        {
            //Auntenticando usuário
            var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (user == null)
                return null;

            //Carregando as informações para o response
            var token = _tokenService.GenerateJwtToken(user);
            var validTo = _tokenService.GetExpireTime(token);

            return new GenerateTokenResponseDto(user, token, validTo);
        }
    }
}
