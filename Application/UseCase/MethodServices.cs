using Application.Interface.PayingMethod;
using Application.Mapper.IMapper;
using Application.Response;

namespace Application.UseCase
{
    public class MethodServices : IFormaCobranzaServices
    {
        private readonly IFormaCobranzaQuery _query;
        private readonly IFormaCobranzaMapper _mapper;
        public MethodServices(IFormaCobranzaQuery query, IFormaCobranzaMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<MethodResponse>> GetAll()
        {
            var methods = await _query.GetAll();
            return await _mapper.GetMethods(methods);
        }

        public async Task<MethodResponse> GetById(int Id)
        {
            var method = await _query.GetById(Id);
            return await _mapper.GetOneMethod(method);
        }
    }
}
