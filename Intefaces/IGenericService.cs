using GenericController.Entities;

namespace GenericController.Intefaces
{
    public interface IGenericService<T> //where T : BaseEntity
    {
        Task<List<T>> List();
        Task<T> Item(Guid uid);
        Task Add(T model);
        Task Edit(T model);
        Task Delete(Guid uid);
    }
}
