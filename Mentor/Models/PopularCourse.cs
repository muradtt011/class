namespace Mentor.Models
{
    public class PopularCourse
    {
        public int Id { get; set; }
        public string CoursName { get; set; }
        public string ImageUrl { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }

        public string PersonImg {get; set; }

        public  int Followers { get; set;}
        public int LikeCount { get; set; }

        public int PopularCategoryID { get; set; }
        public PopularCategory PopularCategory { get; set; }


}
}
