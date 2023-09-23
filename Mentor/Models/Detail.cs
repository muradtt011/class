namespace Mentor.Models
{
    public class Detail
    {
        public int Id { get; set; } 
        public string SocialMedia { get; set; }
        public int TrainersId { get; set; }

        public Trainers Trainers { get; set; }
    }
}
