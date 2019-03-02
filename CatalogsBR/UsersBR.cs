using CatalogsDataAccess;
using CatalogsModel.Interfaces;
using System;

namespace CatalogsBusinessRules
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UsersBR<T> : ICatalogs<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetList()
        {
            return (T)Convert.ChangeType(new UsersDA().GetUsers(), typeof(T));
        }
    }
}
