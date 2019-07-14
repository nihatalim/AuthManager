using System.Collections.Generic;

namespace AuthManager.DTO.Response.User
{
    public class GetAllUsersResponse : BaseResponse
    {
        public List<Model.User> Users { get; set; }
    }
}
