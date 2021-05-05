using System.Collections.Generic;

namespace server.Schema.Types
{
    public class Payload
    {
        public bool Success { get; }
        public IReadOnlyList<Error>? Errors { get; }

        public Payload(bool success = true, IReadOnlyList<Error>? errors = null)
        {
            Success = success;
            Errors = errors;
        }
    }

    public record Error(string Field, string Info);
}
