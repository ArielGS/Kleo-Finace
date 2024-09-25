using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class OutcomeCategory : IOutcomeCategory
{
    private ModelsDbContext _context;

    public OutcomeCategory(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<OutcomeCategoryModel> AddAsync(OutcomeCategoryModel model)
    {
        EntityEntry<OutcomeCategoryModel> result = await _context.OutcomeCategories.AddAsync(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        OutcomeCategoryModel? outcomecategory = await _context.OutcomeCategories.FindAsync(id);

        if (outcomecategory == null)
        {
            return false;
        }

        _context.OutcomeCategories.Remove(outcomecategory);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<OutcomeCategoryModel>> GetByUserIdAsync(int userId)
    {
        return await _context.OutcomeCategories
            .Where(outcomecategory => outcomecategory.UserId == userId)
            .ToListAsync();
    }

    public async Task<OutcomeCategoryModel> UpdateAsync(OutcomeCategoryModel model)
    {
        EntityEntry<OutcomeCategoryModel> result = _context.OutcomeCategories.Update(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }
}
