using System.Reflection.Metadata.Ecma335;
using RestSharp;

namespace RestSharpProject
{
    public class WrapperClass
    {
        public static RestResponse Execute(RestRequest restRequest)
        {
            RestResponse restResponse = DataClass.restClient.Execute(restRequest);
            return restResponse;
        }
    }
}