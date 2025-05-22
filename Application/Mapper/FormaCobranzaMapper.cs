using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;


namespace Application.Mapper
{
    internal class FormaCobranzaMapper : IFormaCobranzaMapper
    {
        public Task<List<MethodResponse>> GetMethods(List<FormaCobranza> methods)
        {
            List<MethodResponse> responses = new List<MethodResponse>();
            foreach (var method in methods)
            {
                var response = new MethodResponse
                {
                    Id = method.Id,
                    Description = method.Description
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<MethodResponse> GetOneMethod(FormaCobranza method)
        {
            var response = new MethodResponse
            {
                Id = method.Id,
                Description = method.Description
            };

            return Task.FromResult(response);
        }
    }
}
