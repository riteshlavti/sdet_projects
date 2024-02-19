using System.Reflection.Metadata.Ecma335;
using RestSharp;

namespace RestSharpProject
{
    public class WrapperMethodRestSharp
    {
        public static RestResponse Execute(RestRequest restRequest)
        {
            RestResponse restResponse = DataClass.restClient.Execute(restRequest);
            return restResponse;
        }
    }
}