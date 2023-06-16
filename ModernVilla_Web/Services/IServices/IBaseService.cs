using ModernVilla_Web.Models;

namespace ModernVilla_Web.Services.IServices
{
    public class IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
