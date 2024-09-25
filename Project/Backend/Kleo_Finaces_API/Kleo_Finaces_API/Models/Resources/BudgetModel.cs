namespace Kleo_Finaces.Models;

public class BudgetModel : ResourceBase
{
    public float NotifyUnder { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
}
