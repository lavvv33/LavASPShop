namespace Application.DTO;

public class CategorySearch
{
    public int? ParentId { get; set; }
    public string Name { get; set; }
    public bool? WithChildren { get; set; }

}