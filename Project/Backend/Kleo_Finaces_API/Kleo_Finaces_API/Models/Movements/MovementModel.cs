namespace Kleo_Finaces.Models;

public abstract class MovementBase
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public int BalanceId { get; set; }
    public BalanceModel Balance { get; set; } = new BalanceModel();
    public int UserId { get; set; }
}
