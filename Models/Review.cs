﻿namespace CourseProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }

}
