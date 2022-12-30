namespace MovieMauiAPI.Models
{
    public class UserRatingsModel
    {
        // ratings matrix
        // user liked history
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public DateTime Createdate { get; set; }
    }
}
