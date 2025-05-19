using Domain.Models;

namespace Application.Interface.Provider
{
    public interface IProveedorQuery
    {
        Task<List<Proveedor>> GetAll();
        Task<Proveedor> GetById(int id);       
    }
}
