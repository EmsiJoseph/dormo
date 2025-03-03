using System.Linq.Expressions;
using Dormo.Server.Data.DTOs;

namespace Dormo.Server.Services.Interfaces;

/// <summary>
/// Generic interface for CRUD operations with soft and hard delete support.
/// </summary>
/// <typeparam name="TRequest">The request type to perform CRUD operations on.</typeparam>
/// <typeparam name="TKey">The type of the request's primary key.</typeparam>
/// <typeparam name="TFilter">The type of the filter used for querying entities.</typeparam>
/// <typeparam name="TPaginatedDto"></typeparam>
/// <typeparam name="TDto"></typeparam>
public interface ICrudService<TRequest, TKey, TFilter, TDto, TPaginatedDto>
    where TRequest : class
    where TDto : class
    where TFilter : BaseFilter
    where TPaginatedDto : class
{
    /// <summary>
    /// Creates a new request in the data store.
    /// </summary>
    /// <param name="request">The request to create.</param>
    /// <returns>The created request.</returns>
    Task<TDto?> CreateAsync(TRequest request);

    /// <summary>
    /// Retrieves an request by its primary key.
    /// </summary>
    /// <param name="id">The primary key of the request.</param>
    /// <param name="includeDeleted">Whether to include soft-deleted entities.</param>
    /// <returns>The request, or null if not found.</returns>
    Task<TDto?> GetByIdAsync(TKey id, bool includeDeleted = false);

    /// <summary>
    /// Retrieves all entities with optional filtering, pagination, and sorting.
    /// </summary>
    /// <param name="filter">An optional filter expression.</param>
    /// <returns>A collection of entities.</returns>
    Task<TPaginatedDto> GetAllAsync(TFilter filter);

    /// <summary>
    /// Updates an existing request.
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>True if the update succeeds, false otherwise (e.g., request not found).</returns>
    Task<bool> UpdateAsync(TDto dto);

    /// <summary>
    /// Soft deletes an request by marking it as deleted without removing it from the data store.
    /// </summary>
    /// <param name="id">The primary key of the request to soft delete.</param>
    /// <returns>True if the soft delete succeeds, false otherwise (e.g., request not found).</returns>
    Task<bool> SoftDeleteAsync(TKey id);

    /// <summary>
    /// Hard deletes an request, permanently removing it from the data store.
    /// </summary>
    /// <param name="id">The primary key of the request to hard delete.</param>
    /// <returns>True if the hard delete succeeds, false otherwise (e.g., request not found).</returns>
    Task<bool> HardDeleteAsync(TKey id);

    /// <summary>
    /// Restores a soft-deleted request.
    /// </summary>
    /// <param name="id">The primary key of the request to restore.</param>
    /// <returns>True if the restore succeeds, false otherwise (e.g., request not found or not deleted).</returns>
    Task<bool> RestoreAsync(TKey id);
}