using School.Data.Entities;


namespace School.Data.Interfaces
{
    public interface IDaoDepartment
    {
        List<Department> GetDepartments();
        Department GetDepartment(int Id);
        void SaveDepartment(Department department);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Department department);
    }
}
