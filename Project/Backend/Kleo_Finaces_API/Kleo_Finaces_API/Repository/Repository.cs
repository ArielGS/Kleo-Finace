namespace Kleo_Finaces.Repository;

public class Repository : IRepository
{
    public IBudget budget { get; }
    public ISource source { get; }
    public IIncome income { get; }
    public IOutcome outcome { get; }
    public ITransfer transfer { get; }
    public IIncomeCategory incomeCategory { get; }
    public IOutcomeCategory outcomeCategory { get; }
    public IUser user { get; }

    public Repository(
        IBudget budget,
        ISource source,
        IIncome income,
        IOutcome outcome,
        ITransfer transfer,
        IIncomeCategory incomeCategory,
        IOutcomeCategory outcomeCategory,
        IUser user)
    {
        this.budget = budget;
        this.source = source;
        this.income = income;
        this.outcome = outcome;
        this.transfer = transfer;
        this.incomeCategory = incomeCategory;
        this.outcomeCategory = outcomeCategory;
        this.user = user;
    }
}
