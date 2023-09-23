namespace Mentor.Models
{
    public class AboutContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string ShortDescription { get; set; }

        public List<AboutListContent> AboutListContent { get; set; }

    }
}
