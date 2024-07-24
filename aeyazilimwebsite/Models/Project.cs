namespace aeyazilimwebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Partner { get; set; }
        public DateTime ProjectDate { get; set; }
        public string ProjectUrl { get; set; }
    }
}
