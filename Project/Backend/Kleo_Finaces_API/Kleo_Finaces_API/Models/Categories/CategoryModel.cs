namespace Kleo_Finaces.Models;

public abstract class CategoryBase
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int StyleId { get; set; }
    public StyleModel Style { get; set; } = new StyleModel();
    public int UserId { get; set; }
}
