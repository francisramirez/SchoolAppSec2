using School.Data.Context;
using School.Data.Entities;
using School.Data.Interfaces;

namespace School.Data.Daos
{
    public class DaoDepartment : IDaoDepartment
    {
        private readonly SchoolContext context;

        public DaoDepartment(SchoolContext context)
        {
            this.context = context;
        }
        public Department GetDepartment(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void SaveDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
