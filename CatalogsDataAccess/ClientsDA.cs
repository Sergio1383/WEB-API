using CatalogsModel;

namespace CatalogsDataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientsDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Definition GetClients()
        {
            return new Definition()
            {
                Id = 1,
                Value = "Sergio",
                Description = "Example"
            };
        }
    }
}
