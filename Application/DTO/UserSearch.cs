namespace Application.DTO;



    public class UserSearch : PagedSearch
    {
        public string Keyword { get; set; }
        public int? MinPosts { get; set; }
    }

