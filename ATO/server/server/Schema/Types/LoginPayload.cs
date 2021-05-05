using System.Collections.Generic;
using server.Models;

namespace server.Schema.Types
{
    public class LoginPayload : Payload
    {
        public Token? Token { get; set; }

        public LoginPayload(Token? token = null, 
            bool success = true, 
            IReadOnlyList<Error>? errors = null) : base(success, errors)
        {
            Token = token;
        }
    }
}