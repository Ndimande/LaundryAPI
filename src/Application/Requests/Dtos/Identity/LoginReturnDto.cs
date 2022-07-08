using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Requests.Dtos.Identity;

public class LoginReturnDto
{
    public string Token { get; set; }
    //public DateTime TokenExpiration { get; set; }
}
