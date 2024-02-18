using System.Net;
using RestSharp;

namespace RestSharpProject
{
    [TestFixture]
    public class API_Test
    {
        RestClient restClient;

        [SetUp]
        public void SetUp()
        {
            restClient = new RestClient("https://jsonplaceholder.typicode.com/");
        }

        [Test]
        public void GetRequest_SinglePost_OK()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Get);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GetRequest_AllPost_OK()
        {
            RestRequest restRequest = new RestRequest("/posts", Method.Get);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        
        [Test]
        public void PostRequest_OK()
        {
            RestRequest restRequest = new RestRequest("/posts/", Method.Post);
            restRequest.AddJsonBody(new { title = "post", body = "body", userId = 1 });
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        public void PutRequest_OK()
        {
            var data = new { id = 1, title = "post", body = "body", userId = 1 };
            RestRequest restRequest = new RestRequest("/posts/1", Method.Put);
            restRequest.AddBody(data, ContentType.Json);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PutRequest_InternalServerEror()
        {
            RestRequest restRequest = new RestRequest("/posts/101", Method.Put);
            var data = new { id = 1, title = "post", body = "body", userId = 1 };
            restRequest.AddBody(data, ContentType.Json);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.InternalServerError));
        }
        
        [Test]
        public void PatchRequest_OK()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Patch);
            restRequest.AddJsonBody(new { title = "put" });
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void DeleteRequest_OK()
        {
            RestRequest restRequest = new RestRequest("/posts/1", Method.Delete);
            RestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}