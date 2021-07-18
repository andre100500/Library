using AutoMapper;
using Library.Data;
using Library.Data.Models;
using Library.Models;
using Library.Models.DTOs;
using Library.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Service.Patrons
{
    public class LibraryCardService : ILibraryCardService
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;

        public LibraryCardService(LibraryDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Add(LibraryCardDto libraryCardDto)
        {
            var newLibraryCard = _mapper.Map<LibraryCard>(libraryCardDto);
            await _context.AddAsync(newLibraryCard);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<LibraryCardDto> Get(int libraryCardId)
        {
             var libraryCard = await _context.LibraryCards.FirstAsync(p => p.Id == cardId);
            return _mapper.Map<LibraryCardDto>(libraryCard);
        }

        public async Task<PaginationResult<LibraryCardDto>> GetPaginated(int page, int perPage)
        {
            var libraryCards = _context.LibraryCards;
            var pageOfLibraryCards = await libraryCards.ToPaginatedResult(page, perPage);
            var pageOfLibraryCardsDto = _mapper.Map<List<LibraryCardDto>>(pageOfLibraryCards.Results);
            return new PaginationResult<LibraryCardDto>
            {
                NumberPage = pageOfLibraryCards.PageNumber,
                PerPages = pageOfLibraryCards.PerPage,
                Results = pageOfLibraryCardsDto
            };
        }
    }
}
