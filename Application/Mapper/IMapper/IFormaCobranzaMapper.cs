using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IFormaCobranzaMapper
    {
        Task<List<MethodResponse>> GetMethods(List<FormaCobranza> methods);
        Task<MethodResponse> GetOneMethod(FormaCobranza method);
    }
}
