using RestSharp;

namespace RestSharpProject
{
    public class DataClass
    {
        public static RestClient restClient = new RestClient("https://jsonplaceholder.typicode.com/");
    }
}