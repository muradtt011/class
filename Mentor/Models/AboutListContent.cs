namespace Mentor.Models
{
    public class AboutListContent
    {
        public int Id { get; set; }
        public string ListIcon { get; set; }

        public string ListDesc { get; set; }

        public int AboutContentId { get; set; }
        public AboutContent AboutContent { get; set; }
    }
}
