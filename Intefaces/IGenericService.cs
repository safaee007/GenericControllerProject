using GenericController.Entities;
using GenericControllerProject.Enums;

namespace GenericController.Intefaces
{
    public interface IGenericService<T> //where T : BaseEntity
    {
        Task<(SharedVariables.ApiResultStatusCode, List<T>)> List(); 
        Task<(SharedVariables.ApiResultStatusCode, T)> Item(Guid uid);
        Task<SharedVariables.ApiResultStatusCode> Add(T model);
        Task<SharedVariables.ApiResultStatusCode> Edit(T model);
        Task<SharedVariables.ApiResultStatusCode> Delete(Guid uid);
    }
}
