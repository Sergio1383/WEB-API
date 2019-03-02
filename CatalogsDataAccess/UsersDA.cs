using CatalogsModel;

namespace CatalogsDataAccess
{
    public class UsersDA
    {
        public Definition GetUsers()
        {
            //throw new Exception("Ah no!, porque?");

            return new Definition()
            {
                Id = 1,
                Value = "Sergio2",
                Description = "Example2"
            };
        }
    }
}
