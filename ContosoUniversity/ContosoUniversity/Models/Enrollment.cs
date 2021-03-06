﻿namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }


        //Enrollment is going to reference the course and student classes.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}