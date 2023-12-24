using GenericController.Intefaces;
using GenericController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace GenericController.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class GenericController<TEntity, TService> : ControllerBase
        where TEntity : class
        where TService : IGenericService<TEntity>, new()
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

            return response;
        }

        [HttpGet]
        public async Task<ApiResponseModel> Item(Guid uid)
        {
            ApiResponseModel response = new ApiResponseModel();

            var data = await _service.Item(uid);

            return response;
        }
    }
}