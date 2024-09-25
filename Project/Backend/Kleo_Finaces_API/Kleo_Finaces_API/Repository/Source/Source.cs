using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class Source : ISource
{
    private ModelsDbContext _context;

    public Source(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<SourceModel> AddAsync(SourceModel model)
    {
        EntityEntry<SourceModel> result = await _context.Sources.AddAsync(model);

        await _context.SaveChangesAsync(); 

        return result.Entity; 
    }

    public async Task<bool> DeleteAsync(int id)
    {
        SourceModel? source = await _context.Sources.FindAsync(id);

        if (source == null)
        {
            return false; 
        }

        _context.Sources.Remove(source);

        await _context.SaveChangesAsync();

        return true; 
    }

    public async Task<IEnumerable<SourceModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Sources
            .Where(source => source.UserId == userId) 
            .ToListAsync();
    }

    public async Task<SourceModel> UpdateAsync(SourceModel model)
    {
        EntityEntry<SourceModel> result = _context.Sources.Update(model);

        await _context.SaveChangesAsync(); 

        return result.Entity;
    }
}
