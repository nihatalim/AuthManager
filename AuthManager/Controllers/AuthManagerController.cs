using AuthManager.Contexts;
using AuthManager.DTO.Request;
using AuthManager.DTO.Response;
using AuthManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthManager.Controllers
{
    [Route("auth")]
    [Produces("application/json")]
    [ApiController]
    public class AuthManagerController : ControllerBase
    {
        private readonly DatabaseContext context;
        public AuthManagerController(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<PermissionResponse> IsPermitted([FromBody] PermissionRequest request){
            PermissionResponse response = new PermissionResponse();
            User user = null;

            Claim claim = HttpContext.User.Claims.Where(a => a.Type.Equals("id")).FirstOrDefault();
            if (claim == null) return null;

            user = await context.Users.Where(a => a.ID.Equals(claim.Value))
                .Include(a => a.Permissions)
                    .ThenInclude(b => b.Permission)
                .Include(a => a.Roles)
                    .ThenInclude(b => b.Role)
                        .ThenInclude(c => c.Permissions)
                            .ThenInclude(d => d.Permission)
                .FirstOrDefaultAsync();




            return null;
        }
    }
}
