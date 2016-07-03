using System;
using CoreFn;

namespace Functions
{
    public class Example
    {
        [ExportedFunction]
        public string HelloWorld() =>
            "Hello world!";

        [ExportedFunction]
        public string SayHello(string name) =>
            $"Hello, {name}!";

        [ExportedFunction]
        public string Now() =>
            DateTime.UtcNow.ToString("o");

        public class AddRequest { public int A { get; set; } public int B { get; set; } }
        public class AddResponse { public int Result { get; set; } }

        [ExportedFunction]
        public AddResponse Add(AddRequest request) =>
            new AddResponse { Result = request.A + request.B };

        [ExportedFunction]
        public AddResponse Multiply(AddRequest request) =>
            new AddResponse { Result = request.A * request.B };
    }
}
