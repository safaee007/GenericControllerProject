namespace GenericController.Models
{
    public class ApiResponseModel
    {
        public int Code { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }
}
