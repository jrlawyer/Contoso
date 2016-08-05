﻿using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{                                   //What's this?      Remove/recreate database if model(SchoolContext) changes.
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student {FirstMidName="Carson", LastName="Alexander", EnrollmentDate=DateTime.Parse("2005-09-01") },
                new Student {FirstMidName="Meredith", LastName="Alonso", EnrollmentDate=DateTime.Parse("2002-09-01") },
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var course = new List<Course>
            {
                new Course {CourseID=1050, Title="Chemisty", Credits=3, },
                new Course {CourseID=4022, Title="Microeconomics", Credits=3, },
                 new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            course.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
        }
    }
}