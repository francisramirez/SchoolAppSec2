
namespace School.Data.Entities
{
    /// <summary>
    /// Entidad de cursos.
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int DepartmentId { get; set; }
        public string? Description { get; set; }
        public int Credits { get; set; }
    }
}
