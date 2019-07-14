using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthManager.Contexts;
using AuthManager.DTO;
using AuthManager.DTO.Request;
using AuthManager.DTO.Request.User;
using AuthManager.DTO.Response;
using AuthManager.DTO.Response.User;
using AuthManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace AuthManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext context;
        private readonly IStringLocalizer localizer;
        public UserRepository(DatabaseContext context, IStringLocalizer localizer)
        {
            this.context = context;
            this.localizer = localizer;
        }

        public async Task<BaseResponse> AddUser(AddUserRequest request)
        {
            BaseResponse response = new BaseResponse();
            User user = null;

            if (request.ID > 0)
            {
                user = new User();
                user.ID = request.ID;
                user.Token = request.Token;
                context.Users.Add(user);
                await context.SaveChangesAsync();

                response.result.status = true;
                response.result.message = localizer.GetString("result_success");
            }
            else
            {
                response.result.message = localizer.GetString("result_failed");
            }

            return response;
        }

        public async Task<BaseResponse> DeleteUser(DeleteUserRequest request)
        {
            BaseResponse response = new BaseResponse();
            User user = null;
            if (request.ID > 0)
            {
                user = await context.Users.Where(a => a.ID.Equals(request.ID)).FirstOrDefaultAsync();
                // TODO DELETE USER ROLES AND USER PERMISSIONS
                context.Users.Remove(user);
                await context.SaveChangesAsync();
                response.result.status = true;
                response.result.message = localizer.GetString("result_success");
            }
            else
            {
                response.result.message = localizer.GetString("result_failed");

            }

            return response;
        }

        public async Task<BaseResponse> UpdateUser(UpdateUserRequest request)
        {
            BaseResponse response = new BaseResponse();
            User user = null;
            if (request.ID > 0)
            {
                user = await context.Users.Where(a => a.ID.Equals(request.ID)).FirstOrDefaultAsync();
                // TODO DELETE USER ROLES AND USER PERMISSIONS
                user.ID = request.ID;
                user.Token = request.Token;
                await context.SaveChangesAsync();

                response.result.status = true;
                response.result.message = localizer.GetString("result_success");
            }
            else
            {
                response.result.message = localizer.GetString("result_failed");
            }

            return response;
        }

        public async Task<GetAllUsersResponse> GetAllUsers(GetAllUsersRequest request)
        {
            GetAllUsersResponse response = new GetAllUsersResponse();

            if(request.ID > 0)
            {
                response.Users = await context.Users
                                    .Select(u => new DTO.Model.User {
                                        ID = u.ID,
                                        DateCreation = u.DateCreation,
                                        DateModified = u.DateModified
                                    })
                                    .ToListAsync();
                response.result.status = true;
                response.result.message = localizer.GetString("result_success");
            }
            else
            {
                response.result.message = localizer.GetString("result_failed");
            }

            return response;
        }

        public async Task<GetUserResponse> GetUser(GetUserRequest request)
        {
            GetUserResponse response = new GetUserResponse();

            if (request.ID > 0)
            {
                response.User = await context.Users
                                    .Where(a => a.ID.Equals(request.ID))
                                    .Select(u => new DTO.Model.User {
                                        ID = u.ID,
                                        DateCreation = u.DateCreation,
                                        DateModified = u.DateModified
                                    }).FirstOrDefaultAsync();

                response.result.status = true;
                response.result.message = localizer.GetString("result_success");
            }
            else
            {
                response.result.message = localizer.GetString("result_failed");
            }

            return response;
        }
    }
}
