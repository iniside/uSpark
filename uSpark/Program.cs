using System;
using System.Threading.Tasks;
using Endpoints.Hellohorld.Sraka;
using Firebase.Auth.Unofficial;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Grpc.Core;

namespace uSpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Channel channel = new Channel("35.189.231.210:80", ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            String user = "iniside"; //10.27.241.124
            //grpc-greeter-backend.default.svc.cluster.local
            var reply = client.SayHelloAgain(new HelloRequest { Name = user, Address = "grpc-greeter-backend" });

            Console.WriteLine("Response message: " + reply.Message);

            Console.ReadKey();

            channel.ShutdownAsync().Wait();
        }
    }
}
