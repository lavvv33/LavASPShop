namespace Domain;

public class Product : Entity
{
    public string Name { get; set; }
    
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int VisibilityTypeId { get; set; }

    public virtual Category Category { get; set; }

}

