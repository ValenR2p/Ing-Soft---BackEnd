using Application.Interface.FactureDetail;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;

namespace Application.UseCase
{
    public class FactureDetailServices : IFacturaDetalleServices
    {
        private readonly IFacturaDetalleQuery _query;
        private readonly IFacturaDetalleCommand _command;
        private readonly IDetalleFacturaMapper _mapper;
        public FactureDetailServices(IFacturaDetalleQuery query, IFacturaDetalleCommand command, IDetalleFacturaMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }

        public async Task<FactureDetailResponse> CreateFactureDetail(FactureDetailRequest request)
        {
            var newFactureDetail = new DetalleFactura
            {
                FactureId = request.FactureId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                UnitCost = request.UnitCost,
                TotalCost = request.TotalCost,
            };

            await _command.InsertFactureDetail(newFactureDetail);
            return await _mapper.GetOneFactureDetail(newFactureDetail);
        }

        public async Task<List<FactureDetailResponse>> GetAll()
        {
            var factureDetails = await _query.GetAll();
            return await _mapper.GetFactureDetails(factureDetails);
        }

        public async Task<FactureDetailResponse> GetById(int Id)
        {
            var factureDetail = await _query.GetById(Id);
            return await _mapper.GetOneFactureDetail(factureDetail);
        }
    }
}
