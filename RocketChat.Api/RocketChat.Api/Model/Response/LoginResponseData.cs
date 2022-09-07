using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Response
{
    internal class LoginResponseData
    {
        public string authToken { get; set; }

        public string userId { get; set; }
    }
}
