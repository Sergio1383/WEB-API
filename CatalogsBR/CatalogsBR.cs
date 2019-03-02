using CatalogsModel.Catalogs;
using CatalogsModel.Interfaces;
using System.Threading.Tasks;

namespace CatalogsBusinessRules
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CatalogsBR<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        /// <returns></returns>
        public T CatalogManagerAsync(Catalog catalog)
        {
            switch (catalog)
            {
                case Catalog.Clients:
                   return new ClientsBR<T>().GetList();
                case Catalog.Users:
                    return new UsersBR<T>().GetList();
            }

            return default(T);
        }
    }
}
