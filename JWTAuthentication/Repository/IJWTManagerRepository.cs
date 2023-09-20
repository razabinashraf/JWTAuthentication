using JWTAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }

}