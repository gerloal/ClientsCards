namespace ClientsCards.Shared
{
    public class Post
    {
        public int? userId { get; set; }
        public int id { get; set; }
        public string? title { get; set; }
        public string? body { get; set; }
         
    }

    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? username { get; set; }        
       
    }
}
