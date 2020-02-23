namespace RCSS.AppServices.Dtos
{
    public class ModelService<T> : RetornoService where T : class 
    {
        public T Model { get; set; }
    }
}
