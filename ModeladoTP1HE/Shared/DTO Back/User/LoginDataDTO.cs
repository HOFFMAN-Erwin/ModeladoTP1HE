using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoTP1HE.Shared.DTO_Back.User
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string NameCompleted { get; set; }
        public string Id { get; set; }

    }
    public class LoginDataDTO
    {
        public User user { get; set; }

    }

}
