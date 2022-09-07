using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Request
{
    internal class SendMessageDataRequest
    {
        public string rid { get; set; }
        public string msg { get; set; }
    }
}
