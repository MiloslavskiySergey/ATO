using System.Collections.Generic;

namespace server.Schema.Types
{
    public class Payload
    {
        public bool? Success { get; }
        public IReadOnlyList<Error>? Errors { get; } = new List<Error>();

        public Payload(IReadOnlyList<Error> errors, bool success = true)
        {
            Success = success;
            Errors = errors;
        }

        public Payload(bool success = true)
        {
            Success = success;
        }
    }

    public record Error(string Field, string Info);

}