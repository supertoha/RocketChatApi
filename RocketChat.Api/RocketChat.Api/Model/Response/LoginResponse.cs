using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Response
{
    internal class LoginResponse
    {
        public string status { get; set; }
        public LoginResponseData data { get; set; }
    }
}
