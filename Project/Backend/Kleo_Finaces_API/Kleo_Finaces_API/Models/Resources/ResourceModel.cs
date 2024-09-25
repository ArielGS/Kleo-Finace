namespace Kleo_Finaces.Models;

public abstract class ResourceBase
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int StyleId { get; set; }
    public StyleModel Style { get; set; } = new StyleModel();
    public DateTime CreationDate { get; set; }
    public int BalanceId { get; set; }
    public BalanceModel Balance { get; set; } = new BalanceModel();
    public int UserId { get; set; }
}
