using CatalogsModel;
using CatalogsModel.Interfaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace CatalogsBusinessRules.Response
{
    public class Response<T> : IHttpActionResult
    {
        public HttpStatusCode _httpStatus;
        public ProcessResult<T> _response;

        /// <summary>
        /// Function that defines a command and asynchronously creates an HttpResponseMessage
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Response in json format</returns>
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage response = new HttpResponseMessage(_httpStatus);
            response.Content = new StringContent(new JavaScriptSerializer().Serialize(_response), Encoding.UTF8, "application/json");

            return Task.FromResult(response);
        }
    }
}
