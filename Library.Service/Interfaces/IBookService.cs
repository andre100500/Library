using Library.Models;
using Library.Models.DTOs.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IBookService
    {
        Task<PaginationResult<BookDto>> GetAll(int page, int page_number);
        Task<PaginationResult<BookDto>> GetByAuthor(string author, int page, int per_page);
        Task<BookDto> GetByIsbn(string isbn);
        Task<BookDto> GetId(Guid Id);
        Task<bool> Add(BookDto new_book); 
    }
}
