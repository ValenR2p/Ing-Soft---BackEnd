using Domain.Models;

namespace Application.Interface.Provider
{
    public interface IProveedorCommand
    {
        Task InsertProvider(Proveedor provider);
        Task UpdateProvider(Proveedor provider);
        Task DeleteProvider(int id);
    }
}
