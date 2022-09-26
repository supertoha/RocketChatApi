using RocketChat.Api.Model.Request;
using RocketChat.Api.Model.Response;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace RocketChat.Api
{
    public class RocketChatClient
    {
        public RocketChatClient(string serverUrl)
        {
            this._client = new HttpClient();
            this._client.BaseAddress = new Uri(serverUrl);
        }

        private HttpClient _client;
        private string _authToken;
        //private string _email;

        public async Task<bool> Login(string login, string password)
        {
            var loginRequest = new LoginRequest { user = login, password = password };
            var response = await this._client.PostAsJsonAsync($"/api/v1/login", loginRequest);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<LoginResponse>();

            if (result.status == "success")
            {
                this._client.DefaultRequestHeaders.Add("X-Auth-Token", result.data.authToken);
                this._client.DefaultRequestHeaders.Add("X-User-Id", result.data.userId);
                this._authToken = result.data.authToken;
                //this._email = result.data.email;
                return true;
            }

            return false;
        }

        public async Task<bool> SendMessage(string message, string roomId = "GENERAL")
        {
            var mesageRequest = new SendMessageRequest { message = new SendMessageDataRequest { rid = roomId, msg = message } };

            var response = await this._client.PostAsJsonAsync($"/api/v1/chat.sendMessage", mesageRequest);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<SendMessageResponse>();

            if (result.success)
                return true;

            return false;
        }
    }
}
