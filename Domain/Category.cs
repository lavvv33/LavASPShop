namespace Domain;

public class Category : Entity
{
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public ICollection<Category> Children { get; set; } = new HashSet<Category>();
    public ICollection<Product> Posts { get; set; } = new HashSet<Product>();
    public Category Parent { get; set; }
}