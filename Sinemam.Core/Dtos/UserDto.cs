using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Dtos
{
    public class UserDto:BaseDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}
