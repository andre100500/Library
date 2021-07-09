using Library.Models;
using Library.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface ICheckoutService
    {
        Task<bool> Add(CheckoutDto new_checkout);
        Task<CheckoutDto> Get(int checkoutId);
        Task<bool> CheckInItem(Guid assetId);
        Task<bool> CheckOutItem(Guid assetId, int libraryCardId);
        Task<CheckoutDto> GetLatestCheckout(Guid assetId);
        Task<bool> IsCheckedOut(Guid assetId);
        Task<string> GetCurrentPatron(Guid assetId);
        Task<PaginationResult<CheckoutDto>> GetPaginated(int page, int per_page);
        Task<PaginationResult<CheckoutHistoryDto>> GetCheckoutHistory(Guid assetId, int page, int per_page);
    }
}
