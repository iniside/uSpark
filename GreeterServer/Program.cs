using Backend.Helloworld;
using Endpoints.Hellohorld.Sraka;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace GreeterServer
{
    class GreeterImpl : Greeter.GreeterBase
    {
        

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult<HelloReply>(new HelloReply { Message = "Hello " + request.Name });
        }

        public override Task<HelloReply> SayHelloAgain(HelloRequest request, ServerCallContext context)
        {
            Channel channel = new Channel("grcp://grpc-greeter-backend", 8080, ChannelCredentials.Insecure);
            var backendClient = new GreeterBackend.GreeterBackendClient(channel);

            var reply = backendClient.SayHelloFromBackend(new BackendHelloRequest { Name = "iniside" });
            channel.ShutdownAsync().Wait(); //not neeed to wait, but easier to debug now.
            return Task.FromResult<HelloReply>(new HelloReply { Message = "Hello Again " + request.Name + " " + reply.Message });
        }

        public override Task<HelloReply> SayHelloAuth(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult<HelloReply>(new HelloReply { Message = "Hello Authenticated " + request.Name });
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Server server = new Server
            {
                Services = { Greeter.BindService(new GreeterImpl()) },
                Ports = { new ServerPort("127.0.0.1", 9000, ServerCredentials.Insecure)}
            };

            server.Start();

            Console.WriteLine("Gretter server is linstening on port 50051");
            Console.WriteLine("Press any key to stop server");

            int read = Console.Read();
            while(read < 0)
            {

            }
        }
    }
}
