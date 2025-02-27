using Dormo.Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dormo.Server.Controllers.Interfaces;

public interface ICrudController<TRequest, TKey, TFilter, TDto>
    where TFilter : BaseFilter
    where TDto : class
    where TRequest : class
{
    Task<IActionResult> GetAllAsync(TFilter filter);
    Task<IActionResult> GetByIdAsync(TKey id);
    Task<IActionResult> CreateAsync(TRequest request);
    Task<IActionResult> UpdateAsync(TDto dto);
    Task<IActionResult> DeleteAsync(TKey id, bool hard = false);
}