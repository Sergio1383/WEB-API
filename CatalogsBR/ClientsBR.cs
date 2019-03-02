using CatalogsDataAccess;
using CatalogsModel.Interfaces;
using System;
using System.Threading.Tasks;

namespace CatalogsBusinessRules
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClientsBR<T> : ICatalogs<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetList()
        {
            return (T)Convert.ChangeType(new ClientsDA().GetClients(), typeof(T));
        }
    }
}
