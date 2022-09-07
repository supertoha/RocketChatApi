using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Response
{
    internal class SendMessageResponse
    {
        public string status { get; set; }
        public object message { get; set; }
        public bool success { get; set; }
    }
}
