using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO.Request.User
{
    public class GetUserRequest : BaseRequest
    {
        public int ID { get; set; }
    }
}
