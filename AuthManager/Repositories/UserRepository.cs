using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthManager.Contexts;
using AuthManager.DTO.Request;
using AuthManager.DTO.Response;
using AuthManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext context;
        public UserRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<AddUserResponse> AddUser(AddUserRequest request)
        {
            User user = null;
            AddUserResponse response = new AddUserResponse();

            user = (await context.Users.ToListAsync()).Where(a => a.ID.Equals(request.User.ID)).FirstOrDefault();

            if(user != null)
            {
                response.result.message = "User already there.";
            }
            else
            {
                user = new User();
                user.ID = request.User.ID;
                await context.SaveChangesAsync();
                response.result.status = true;
                response.result.message = "Successful.";
            }

            return response;
        }
    }
}
