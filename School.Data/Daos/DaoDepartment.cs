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
            return this.context.Departments.Find(Id);
        }

        public List<Department> GetDepartments()
        {
           return this.context.Departments.ToList();
        }

        public void RemoveDepartment(Department department)
        {
            //if (department is null) 
            //{
            //    throw new ArgumentNullException("El departamento no puede ser nulo.");
            //}

            ArgumentNullException.ThrowIfNull(department, "El departamento no puede ser nulo.");

            this.context.Departments.Remove(department);
            this.context.SaveChanges();
        }

        public void SaveDepartment(Department department)
        {
            //if (string.IsNullOrEmpty(department.Name))
            //{
            //    throw new ArgumentNullException("");
            //}

            ArgumentNullException.ThrowIfNullOrEmpty(department.Name, "El nombre del departamento es requerido.");

           this.context.Departments.Add(department);
            this.context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(department.Name, "El nombre del departamento es requerido.");


            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(department.Budget, "El Budget no puede ser negativo o cero");


            this.context.Departments.Update(department);
            this.context.SaveChanges();
        }
    }
}
