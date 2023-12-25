using GenericControllerProject.Enums;

namespace GenericController.Models
{
    public class ApiResponseModel
    {
        public SharedVariables.ApiResultCode Code { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }
}
