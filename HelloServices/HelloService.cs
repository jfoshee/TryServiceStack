using HelloDto;
using ServiceStack.ServiceHost;

namespace HelloServices
{
    public class HelloService : IService<Hello>
    {
        public object Execute(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }

    public class AddService : IService<AddRequest>
    {
        public object Execute(AddRequest request)
        {
            return new AdderResponse(request);
        }
    }
}
