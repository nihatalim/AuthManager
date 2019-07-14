using AuthManager.DTO;
using AuthManager.DTO.Request;
using AuthManager.DTO.Request.User;
using AuthManager.DTO.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Repositories
{
    public interface IUserRepository
    {
        Task<BaseResponse> AddUser(AddUserRequest request);
        Task<BaseResponse> UpdateUser(UpdateUserRequest request);
        Task<BaseResponse> DeleteUser(DeleteUserRequest request);
        Task<GetAllUsersResponse> GetAllUsers(GetAllUsersRequest request);
        Task<GetUserResponse> GetUser(GetUserRequest request);
    }
}
