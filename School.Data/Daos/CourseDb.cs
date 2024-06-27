

using School.Data.Context;
using School.Data.Entities;
using School.Data.Interfaces;

namespace School.Data.Daos
{
    public class CourseDb : ICourseDb
    {
        private readonly SchoolContext context;

        public CourseDb(SchoolContext context)
        {
            this.context = context;
            this.CargarDatos();
        }
        public Course GetCourse(int Id)
        {
            return this.context.Courses.Find(Id);
        }

        public List<Course> GetCourses()
        {
            return this.context.Courses.ToList();
        }

        public void RemoveCourse(Course course)
        {
            if (course is null)
            {
                throw new ArgumentNullException("El curso no puede nulo.");
            }

            // ArgumentNullException.ThrowIfNull(course, "El curso no puede nulo.");


            this.context.Courses.Remove(course);
            this.context.SaveChanges();
        }

        public void SaveCourse(Course course)
        {

            ArgumentNullException.ThrowIfNull(nameof(course), "El curso no puede nulo.");

            ArgumentNullException.ThrowIfNullOrEmpty(course.Title, "El titulo es requerido.");

            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(course.Credits, "El credito no puede negativo ni cero.");

            this.context.Courses.Add(course);
            this.context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            ArgumentNullException.ThrowIfNull(nameof(course), "El curso no puede nulo.");

            ArgumentNullException.ThrowIfNullOrEmpty(course.Title, "El titulo es requerido.");

            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(course.Credits, "El credito no puede negativo ni cero.");

            this.context.Courses.Update(course);
            this.context.SaveChanges();
        }

        private void CargarDatos()
        {

            if (!this.context.Courses.Any())
            {
                List<Course> courses = new List<Course>()
            {
                new Course()
                {
                    Credits = 4, DepartmentId =1, Description ="Desc 1", Id = 1, Title ="DevOps"
                },
                  new Course()
                {
                    Credits = 3, DepartmentId =1, Description ="Desc 2", Id = 2, Title ="Big Data"
                },
                    new Course()
                {
                    Credits = 4, DepartmentId =1, Description ="Desc 3", Id = 3, Title ="Prog. II"
                },

            };


                this.context.Courses.AddRange(courses);
                this.context.SaveChanges();
            }



        }
    }
}
