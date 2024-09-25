using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class IncomeCategory : IIncomeCategory
{
    private ModelsDbContext _context;

    public IncomeCategory(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<IncomeCategoryModel> AddAsync(IncomeCategoryModel model)
    {
        EntityEntry<IncomeCategoryModel> result = await _context.IncomeCategories.AddAsync(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        IncomeCategoryModel? incomecategory = await _context.IncomeCategories.FindAsync(id);

        if (incomecategory == null)
        {
            return false;
        }

        _context.IncomeCategories.Remove(incomecategory);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<IncomeCategoryModel>> GetByUserIdAsync(int userId)
    {
        return await _context.IncomeCategories
            .Where(incomecategory => incomecategory.UserId == userId)
            .ToListAsync();
    }

    public async Task<IncomeCategoryModel> UpdateAsync(IncomeCategoryModel model)
    {
        EntityEntry<IncomeCategoryModel> result = _context.IncomeCategories.Update(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }
}
