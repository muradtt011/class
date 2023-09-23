using Mentor.Models;

namespace Mentor.ViewModels
{
    public class HomeVM
    {

        public HeroContent HeroContent { get; set; }

        public AboutContent AboutContent { get; set; }

        public List<AboutListContent> AboutListContent { get; set;}

        public List<IconSection> IconSection { get; set; }

        public List<PopularCategory> PopularCategory { get; set; }

        public List<PopularCourse> PopularCourse { get; set; }

        public List<Trainers> Trainers { get; set; }

        public List<WhyChooseUs> WhyChooseUs { get; set; }  
    }
}
