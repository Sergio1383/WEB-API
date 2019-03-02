namespace CatalogsModel
{
    public class Definition
    {
        private int _id;
        private string _value;
        private string _description;

        /// <summary>
        /// 
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Value { get => _value; set => _value = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get => _description; set => _description = value; }
    }
}
