using System;
using System.Threading.Tasks;
using Firebase.Auth.Unofficial;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;

namespace uSpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FirebaseConfig config = new FirebaseConfig();
            config.ApiKey = "";
            FirebaseAuthProvider fbProvider = new FirebaseAuthProvider(config);

            Task<FirebaseAuthLink> result =  fbProvider.SignInWithEmailAndPasswordAsync("iniside@live.com", "qwerty");

            result.Wait();

            FirebaseAuthLink authResult = result.Result;

            GoogleWebAuthorizationBroker.AuthorizeAsync

            Console.ReadLine();
        }
    }
}
