using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class Outcome : IOutcome
{
    private ModelsDbContext _context;

    public Outcome(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<OutcomeModel> AddAsync(OutcomeModel model)
    {
        EntityEntry<OutcomeModel> result = await _context.Outcomes.AddAsync(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        OutcomeModel? outcome = await _context.Outcomes.FindAsync(id);

        if (outcome == null)
        {
            return false;
        }

        _context.Outcomes.Remove(outcome);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<OutcomeModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Outcomes
            .Where(outcome => outcome.UserId == userId)
            .ToListAsync();
    }

    public async Task<IEnumerable<OutcomeModel>> GetByCategoryIdAsync(int categoryId)
    {
        return await _context.Outcomes
            .Where(outcome => outcome.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<IEnumerable<OutcomeModel>> GetBySourceIdAsync(int sourceId)
    {
        return await _context.Outcomes
            .Where(outcome => outcome.SourceOriginId == sourceId)
            .ToListAsync();
    }
    public async Task<IEnumerable<OutcomeModel>> GetByBudgetIdAsync(int budgetId)
    {
        return await _context.Outcomes
            .Where(outcome => outcome.BudgetId == budgetId)
            .ToListAsync();
    }

    public async Task<OutcomeModel> UpdateAsync(OutcomeModel model)
    {
        EntityEntry<OutcomeModel> result = _context.Outcomes.Update(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }
}
