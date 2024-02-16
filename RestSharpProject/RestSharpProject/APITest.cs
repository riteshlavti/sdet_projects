using System.Net;
using RestSharp;

namespace RestSharpProject
{
    public class API_Test
    {
        RestClient restClient;
        [SetUp]
        public void SetUp()
        {
            restClient = new RestClient("https://jsonplaceholder.typicode.com/");
        }
        [Test]
        public void GetRequest()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Get);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
        }

        [Test]
        public void PostRequest()
        {
            RestRequest restRequest = new RestRequest("/posts/", Method.Post);
            restRequest.AddJsonBody(new { title = "post", body = "body", userId = 1 });
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.Created);
        }

        [Test]
        public void PutRequest()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Put);
            var data = new { id = 1, title = "post", body = "body", userId = 1 };
            restRequest.AddBody(data, ContentType.Json);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }

        [Test]
        public void PatchRequest()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Patch);
            restRequest.AddJsonBody(new { title = "put" });
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }

        [Test]
        public void DeleteRequest()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Delete);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }
    }
}