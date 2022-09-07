using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat.Api.Model.Request
{
    internal class SendMessageRequest
    {
        public SendMessageDataRequest message { get; set; }
    }
}
