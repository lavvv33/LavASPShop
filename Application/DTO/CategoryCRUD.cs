namespace Application.DTO;

public class CreateCategoryDto
{
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public List<int> ChildIds { get; set; }
}

public class UpdateCategoryDto : CreateCategoryDto
{
    public int Id { get; set; }
}

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<CategoryDto> Children { get; set; }

}