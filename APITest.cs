using System.Net;
using RestSharp;

namespace RestSharpProject
{
    [TestFixture]
    public class APITest
    {
        [Test]
        public void GetRequestSinglePostOK()
        {
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}/1", Method.Get)).StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GetRequestAllPostOK()
        {
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}", Method.Get)).StatusCode,
             Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PostRequestOK()
        {
            var data = new { title = "post", body = "body", userId = 1 };
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}", Method.Post).AddJsonBody(data)).StatusCode,
             Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PutRequestOK()
        {
            var data = new { id = "1", title = "post", body = "body", userId = 1 };
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}/1", Method.Put).AddJsonBody(data)).StatusCode,
             Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PutRequestInternalServerEror()
        {
            var data = new { id = "1", title = "post", body = "body", userId = 1 };
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}/101", Method.Put).AddJsonBody(data)).StatusCode,
             Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PatchRequestOK()
        {
            var data = new { title = "post" };
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}/1", Method.Patch).AddJsonBody(data)).StatusCode,
             Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void DeleteRequestOK()
        {
            Assert.That(WrapperMethodRestSharp.Execute(new RestRequest($"{APIRoute.route}/1", Method.Delete)).StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}