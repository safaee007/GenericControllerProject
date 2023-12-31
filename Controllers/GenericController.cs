using AutoMapper;
using GenericController.Intefaces;
using GenericController.Models;
using GenericControllerProject.Enums;
using Microsoft.AspNetCore.Mvc;

namespace GenericController.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class GenericController<TEntity, TService, TDto> : ControllerBase
        where TEntity : class
        where TDto : class
        where TService : IGenericService<TEntity>
    {
        private readonly TService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<TEntity> _logger;

        public GenericController(TService service, IMapper mapper)
        {
            //_logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            ApiResponseModel response = new ApiResponseModel();

            var data = await _service.List();

            response.Code = data.Item1;
            response.Result = _mapper.Map<IEnumerable<TDto>>(data.Item2);

            return Ok(response);
        }

        [HttpGet]
        //[HttpGet("{uid}")]
        public async Task<IActionResult> Item(Guid uid)
        {
            ApiResponseModel response = new ApiResponseModel();

            var data = await _service.Item(uid);

            response.Code = data.Item1;
            response.Result = _mapper.Map<TDto>(data.Item2);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TEntity model)
        {
            ApiResponseModel response = new ApiResponseModel();

            response.Code = await _service.Add(model);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] TEntity model)
        {
            ApiResponseModel response = new ApiResponseModel();

            response.Code = await _service.Edit(model);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid uid)
        {
            return Ok(await _service.Delete(uid));
        }
    }
}