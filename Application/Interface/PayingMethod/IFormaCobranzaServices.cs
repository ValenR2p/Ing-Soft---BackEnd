using Application.Response;

namespace Application.Interface.PayingMethod
{
    public interface IFormaCobranzaServices
    {
        Task<List<MethodResponse>> GetAll();
        Task<MethodResponse> GetById(int id);
    }
}
