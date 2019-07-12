using AuthManager.DTO;
using AuthManager.DTO.Request;
using AuthManager.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    [ApiController]
    
    public class UserController 
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost("a")]
        public BaseResponse A([FromBody] BaseRequest b)
        {
            BaseResponse response = new BaseResponse();
            response.result.status = true;
            response.result.message = "sadsa";
            return response;
        }

        [HttpPost("add")]
        public async Task<BaseResponse> AddUser([FromBody] AddUserRequest request)
        {
            return await this.userRepository.AddUser(request);
        }
    }
}
