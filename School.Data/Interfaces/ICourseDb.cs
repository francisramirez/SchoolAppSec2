

using School.Data.Entities;

namespace School.Data.Interfaces
{
    public interface  ICourseDb
    {
        List<Course> GetCourses();
        Course GetCourse(int Id);
        void SaveCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
    }
}
