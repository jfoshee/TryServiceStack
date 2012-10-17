using ServiceStack.ServiceHost;

namespace TryServiceStack
{
    // 1. Create the name of your Web Service (i.e. the Request DTO)
    public class Hello
    {
        public string Name { get; set; }
    }

    // 2. Define what your Web Service will return (i.e. Response DTO)
    public class HelloResponse
    {
        public string Result { get; set; }
    }

    // 3. Create your Web Service implementation
    public class HelloService : IService<Hello>
    {
        public object Execute(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}

