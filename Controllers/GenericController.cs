using GenericController.Intefaces;
using GenericController.Models;
using GenericControllerProject.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace GenericController.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class GenericController<TEntity, TService>
        where TEntity : class
        where TService : IGenericService<TEntity>
    {
        private readonly TService _service;
        private readonly ILogger<TEntity> _logger;

        public GenericController(TService service)
        {
            //_logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ApiResponseModel> List()
        {
            ApiResponseModel response = new ApiResponseModel();

            var data = await _service.List();

            response.Code = SharedVariables.ApiResultCode.Success;
            response.Result = data;

            return response;
        }

        [HttpGet]
        public async Task<ApiResponseModel> Item(Guid uid)
        {
            ApiResponseModel response = new ApiResponseModel();

            var data = await _service.Item(uid);

            response.Code = SharedVariables.ApiResultCode.Success;
            response.Result = data;

            return response;
        }
    }
}