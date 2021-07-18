using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface ILibraryCardService
    {
        Task<PaginationResult<LibraryCardDto>> GetPaginated(int page, int perPage);
        Task<LibraryCardDto> Get(int libraryCardId);
        Task<bool> Add(LibraryCardDto libraryCardDto);
    }
}
