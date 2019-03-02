namespace CatalogsModel
{
    public class ProcessResult<T>
    {
        private string _message;
        private bool _succes;
        private T _data;

        /// <summary>
        /// 
        /// </summary>
        public string Message { get => _message; set => _message = value; }
        /// <summary>
        /// 
        /// </summary>
        public bool Succes { get => _succes; set => _succes = value; }
        /// <summary>
        /// 
        /// </summary>
        public T Data { get => _data; set => _data = value; }
    }
}
