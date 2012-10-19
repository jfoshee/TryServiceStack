namespace HelloDto
{
    public class Hello
    {
        public string Name { get; set; }
    }
    
    public class HelloResponse
    {
        public string Result { get; set; }
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
}
