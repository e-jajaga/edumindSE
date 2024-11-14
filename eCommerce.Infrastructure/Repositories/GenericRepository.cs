using eCommerce.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace eCommerce.Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task<int> CountAsync()
    {
        return await _dbSet.CountAsync();
    }

    public virtual async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}

