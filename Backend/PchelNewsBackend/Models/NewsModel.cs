namespace PchelNewsBackend.Models
{
    public class NewsModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; } = DateTime.Now;

        public int readTime { get; set; }

        public int likes { get; set; }

        public int views { get; set; }
    }
}