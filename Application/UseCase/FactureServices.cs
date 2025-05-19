using Application.Interface.Facture;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;

namespace Application.UseCase
{
    public class FactureServices : IFacturaServices
    {
        private readonly IFacturaQuery _query;
        private readonly IFacturaCommand _command;
        private readonly IFacturaMapper _mapper;
        public FactureServices(IFacturaQuery query, IFacturaCommand command, IFacturaMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }
        public async Task<FactureResponse> CreateFacture(FactureRequest request)
        {
            var newFacture = new Factura
            {
                EmisionDate = request.EmisionDate,
                ClientId = request.ClientId,
                Amount = request.Amount,
                PaymentMethod = request.PaymentMethod,
            };

            await _command.InsertFacture(newFacture);
            return await _mapper.GetOneFacture(newFacture);
        }

        public async Task<FactureResponse> UpdateFacture(FactureRequest request, int FactureId)
        {
            var facture = await _query.GetById(FactureId);
            if (facture != null)
            {
                facture.EmisionDate = request.EmisionDate;
                facture.ClientId = request.ClientId;
                facture.Amount = request.Amount;
                facture.PaymentMethod = request.PaymentMethod;
            }
            else
            {
                throw new Exception("This facture doesn´t exist");
            }
            await _command.UpdateFacture(facture);
            return await _mapper.GetOneFacture(facture);
        }

        public async Task<List<FactureResponse>> GetAll()
        {
            var factures = await _query.GetAll();
            return await _mapper.GetFactures(factures);
        }

        public async Task<FactureResponse> GetById(int Id)
        {
            var facture = await _query.GetById(Id);
            return await _mapper.GetOneFacture(facture);
        }
    }
}
