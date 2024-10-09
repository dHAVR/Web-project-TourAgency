namespace CourseProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Tour> SelectedTours { get; set; }
    }

}
