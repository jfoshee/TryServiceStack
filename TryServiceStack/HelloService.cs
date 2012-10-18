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

    public class AddRequest
    {
        public int Addend1 { get; set; }
        public int Addend2 { get; set; }
    }
    
    public class AdderResponse
    {
        public int Sum { get; private set; }
        public AddRequest Request { get; private set; }

        public AdderResponse(AddRequest addRequest)
        {
            Sum = addRequest.Addend1 + addRequest.Addend2;
            Request = addRequest;
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
