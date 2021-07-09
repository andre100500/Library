using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IHoldService
    {
        Task<PaginationResult<HoldDto>> GetCurrentHoldsPaginated(Guid assetId, int page, int perPage);
        Task<bool> PlaceHold(Guid assetId, int libraryCardId);
        Task<string> GetCurrentHoldPatron(int holdId);
        Task<string> GetCurrentHoldPlaced(int holdId);
        Task<HoldDto> GetEarliestHold(Guid assetId);
    }
}
