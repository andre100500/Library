using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IPatronService
    {
        Task<PaginationResult<PatronDto>> GetPaginated(int page, int perPage);
        Task<PaginationResult<CheckoutHistoryDto>> GetPaginatedCheckoutHistory(Guid patronId, int page, int perPage);
        Task<PaginationResult<HoldDto>> GetPaginatedHolds(Guid patronId, int page, int perPage);
        Task<PaginationResult<CheckoutDto>> GetPaginatedCheckouts(Guid patronId, int page, int perPage);
        Task<PatronDto> Get(Guid patronId);
        Task<bool> Add(PatronDto newPatron);
    }
}
