using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO.Request.User
{
    public class DeleteUserRequest : BaseRequest
    {
        public int ID { get; set; }
    }
}
