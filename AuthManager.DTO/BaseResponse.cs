using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO
{
    public class BaseResponse
    {
        public Result result { get; set; }

        public BaseResponse()
        {
            this.result = new Result();
        }
    }
}
