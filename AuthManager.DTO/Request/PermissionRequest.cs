using System;
using System.Collections.Generic;
using System.Text;

namespace AuthManager.DTO.Request
{
    public class PermissionRequest
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Path { get; set; }

    }
}
