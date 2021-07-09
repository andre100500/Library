using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface ILibraryAssetService
    {
        Task<PaginationResult<LibraryAssetDto>> GetPaginated(int page, int perPage);
        Task<LibraryAssetDto> Get(Guid assetId);
        Task<bool> Add(LibraryAssetDto newDto);
        Task<LibraryBranchDto> GetCurrentLocation(Guid assetId);
        Task<bool> MarkLost(Guid assetId);
        Task<bool> MarkFound(Guid assetId);
    }
}
