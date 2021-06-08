
using System.Collections.Generic;
using server.Models;

namespace server.Schema.Types
{
    public class LoginPayload : Payload
    {
        public Token? Token { get; set; }

        public LoginPayload(IReadOnlyList<Error> errors,
            Token? token = null,
            bool success = true) : base(errors, success)
        {
            Token = token;
        }

        public LoginPayload(Token? token = null,
           bool success = true) : base(success)
        {
            Token = token;
        }
    }
}