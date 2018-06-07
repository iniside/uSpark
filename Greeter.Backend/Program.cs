using System.Threading.Tasks;
using Backend.Helloworld;
using Grpc.Core;
using System;


namespace Greeter.Backend
{

    class GreeterBackendImpl : GreeterBackend.GreeterBackendBase
    {
        public override Task<BackendHelloReply> SayHelloFromBackend(BackendHelloRequest request, ServerCallContext context)
        {
            return Task.FromResult<BackendHelloReply>(new BackendHelloReply { Message = "Hello " + request.Name + " From Backend"});
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Server server = new Server
            {
                Services = { GreeterBackend.BindService(new GreeterBackendImpl()) },
                Ports = { new ServerPort("127.0.0.1", 9000, ServerCredentials.Insecure) }
            };

            server.Start();

            Console.WriteLine("Gretter server is linstening on port 50051");
            Console.WriteLine("Press any key to stop server");

            int read = Console.Read();
            while (read < 0)
            {

            }
        }
    }
}
