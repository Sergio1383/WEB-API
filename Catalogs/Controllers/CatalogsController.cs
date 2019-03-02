using CatalogsBusinessRules.Request;
using CatalogsModel;
using CatalogsModel.Catalogs;
using System.Web.Http;

namespace Catalogs.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/catalogs")]
    public class CatalogsController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public IHttpActionResult GetCatalogs([FromUri]Catalog catalog = Catalog.Default)
        {
            return new Request<Definition>(catalog);
        }
    }
}
