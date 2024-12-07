using Finance.Data;
using Finance.Exceptions;
using Finance.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Finance.Service.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsQueryable();
    }

    public async Task<T?> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T> Create(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }
}
