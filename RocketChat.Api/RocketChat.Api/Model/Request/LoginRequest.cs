using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Request
{
    internal class LoginRequest
    {
        public string user { get; set; }
        public string password { get; set; }
    }
}
