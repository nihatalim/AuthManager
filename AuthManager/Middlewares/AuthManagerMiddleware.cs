using AuthManager.Contexts;
using AuthManager.DTO;
using AuthManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthManager.Middlewares
{
    public class AuthManagerMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthManagerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, DatabaseContext databaseContext)
        {
            string Key = context.Request.Headers["Key"];

            if (Key.Equals(Program.token))
            {

                Claim[] claims = new Claim[]
                {
                    new Claim("Key", Program.token)
                };

                context.User.AddIdentity(new ClaimsIdentity(claims));

                await _next.Invoke(context);
            }
        }
    }

}
