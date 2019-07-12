using AuthManager.DTO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO.Request
{
    public class AddUserRequest : BaseRequest
    {
        public User User { get; set; }
        public AddUserRequest()
        {
            this.User = new User();
        }
    }
}
