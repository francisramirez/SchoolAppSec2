using School.Data.Context;
using School.Data.Daos;
using School.Data.Entities;

namespace School.Data.Test
{
    public class CourseUnitTest
    {
        [Fact]
        public void GetCourse_ReturnCourseEntity()
        {
            // Arrange //
            var context = new SchoolContext();
            var cursoDb = new CourseDb(context);

            // Act
            int courseId = 1;
            var cursoFound = cursoDb.GetCourse(courseId);

            // Assert //
            Assert.NotNull(cursoFound);
            Assert.IsType<Course>(cursoFound);
        }
        [Fact]
        public void GetCourses_ValidCount()
        {
            // Arrange //
            var context = new SchoolContext();
            var cursoDb = new CourseDb(context);

            // Act
           
            var courses = cursoDb.GetCourses();
            var count_Course = 3;

            // Assert //
            Assert.NotNull(courses);
            Assert.IsType<List<Course>>(courses);
            Assert.Equal(count_Course, courses.Count());
        }
        [Fact]
        public void SaveCourse_CourseIsNull()
        {
            // Arrange //
            var context = new SchoolContext();
            var cursoDb = new CourseDb(context);

            // Act

            Course? course = null;
            string message = "El curso no puede nulo.";

            // Assert //
           Assert.Throws<ArgumentNullException>(() => cursoDb.SaveCourse(course));

         
            
        }
    }
}