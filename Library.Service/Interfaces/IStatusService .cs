using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IStatusService
    {
        Task<PaginationResult<StatusDto>> GetPaginated(int page, int perPage);
        Task<StatusDto> Get(Guid statusId);
        Task<bool> Add(StatusDto status);
    }
}
