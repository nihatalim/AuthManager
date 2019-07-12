using AuthManager.DTO.Request;
using AuthManager.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Repositories
{
    public interface IUserRepository
    {
        Task<AddUserResponse> AddUser(AddUserRequest request);
    }
}
