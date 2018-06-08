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

            Channel channel = new Channel("35.205.34.141:80", ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            String user = "iniside";
            var reply = client.SayHelloAgain(new HelloRequest { Name = user });

            Console.WriteLine("Response message: " + reply.Message);

            Console.ReadKey();

            channel.ShutdownAsync().Wait();
        }
    }
}
