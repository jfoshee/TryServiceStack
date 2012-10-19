using System;
using ServiceStack.ServiceClient.Web;
using TryServiceStack;

namespace ConsoleServiceClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var client = new JsonServiceClient("http://127.0.0.1:8080");
            var response = client.Send<HelloResponse>(new Hello { Name = name });
            Console.WriteLine(response.Result);
        }
    }
}
