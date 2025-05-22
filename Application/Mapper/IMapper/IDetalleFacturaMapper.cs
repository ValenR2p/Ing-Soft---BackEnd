using Application.Request;
using Application.Response;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper.IMapper
{
    public interface IDetalleFacturaMapper
    {
        Task<List<FactureDetailResponse>> GetFactureDetails(List<DetalleFactura> factureDetails);
        Task<FactureDetailResponse> GetOneFactureDetail(DetalleFactura factureDetail);
    }
}
