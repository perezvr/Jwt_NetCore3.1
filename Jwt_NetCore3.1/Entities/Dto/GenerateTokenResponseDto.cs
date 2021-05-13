using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_NetCore3._1.Entities.Dto
{
    public class GenerateTokenResponseDto
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public string ExpiresIn { get; set; }

        public GenerateTokenResponseDto(User user, string token, DateTime expiresIn)
        {
            UserId = user.Id;
            Token = token;
            ExpiresIn = expiresIn.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
