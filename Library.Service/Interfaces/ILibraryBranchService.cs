using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface ILibraryBranchService
    {
        Task<PaginationResult<LibraryBranchDto>> GetPaginated(int page, int perPage);
        Task<PaginationResult<PatronDto>> GetPatrons(Guid branchId, int page, int perPage);
        Task<PaginationResult<LibraryAssetDto>> GetAssets(int branchId, int page, int perPage);
        Task<List<string>> GetBranchHours(int branchId);
        Task<LibraryBranchDto> Get(Guid branchId);
        Task<bool> Add(LibraryBranchDto newBranchDto);
        Task<bool> IsBranchOpen(Guid branchId);
        Task<int> GetAssetCount(Guid branchId);
        Task<int> GetPatronCount(Guid branchId);
        Task<decimal> GetAssetsValue(Guid branchId);
    }
}
