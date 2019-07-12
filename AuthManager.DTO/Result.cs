using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO
{
    public class Result
    {
        public bool status { get; set; }
        public string message { get; set; }

        public Result()
        {
            this.status = false;
        }
    }
}
