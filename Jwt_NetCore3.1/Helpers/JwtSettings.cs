using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_NetCore3._1.Helpers
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public string Audience { get; set; }
    }
}
