using CatalogsBusinessRules.Response;
using CatalogsModel;
using CatalogsModel.Catalogs;
using System;
using System.Net;

namespace CatalogsBusinessRules.Request
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Request<T> : Response<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        public Request(Catalog catalog)
        {
            try
            {
                var data = new CatalogsBR<T>().CatalogManagerAsync(catalog);

                _httpStatus = data == null ? HttpStatusCode.NoContent : HttpStatusCode.OK;
                _response = new ProcessResult<T>()
                {
                    Data = data,
                    Message = "La operación se realizó con éxito",
                    Succes = true
                };
            }
            catch (Exception ex)
            {
                _httpStatus = HttpStatusCode.InternalServerError;
                _response = new ProcessResult<T>()
                {
                    Message = $"Hubo un error al tratar de obtener el catalogo {Enum.GetName(typeof(Catalog), catalog)}, detalle: {ex.Message}"
                };
            }
        }
    }
}
