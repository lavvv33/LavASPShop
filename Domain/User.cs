namespace Domain;

public class User : Entity
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }

    public virtual ICollection<UserUseCase> UseCases { get; set; } = new HashSet<UserUseCase>();
}