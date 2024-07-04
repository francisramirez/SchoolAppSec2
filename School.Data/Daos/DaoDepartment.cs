using School.Data.Context;
using School.Data.Entities;
using School.Data.Exceptions;
using School.Data.Interfaces;

namespace School.Data.Daos
{
    public class DaoDepartment : IDaoDepartment
    {
        private readonly SchoolContext context;

        public DaoDepartment(SchoolContext context)
        {
            this.context = context;
            CargarDatos();
        }
        public Department GetDepartment(int Id)
        {
            if (Id == 0)
                throw new DepartmentGetExeptionId("El codigo del departamento es requerido.");


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
            if (department is null)
                throw new DepartmentSaveException("El objeto departamento no puede ser nulo.");

            if (string.IsNullOrEmpty(department.Name))
                throw new DepartmentSaveNameException("El nombre del departamento es requerido.");

            if (this.context.Departments.Any(cd => cd.Name == department.Name))
                throw new DepartmentExistsException("El departamento se encuentra registrado.");
            
            this.context.Departments.Add(department);
            this.context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {


            if (department is null)
            {
                throw new ArgumentNullException("El departamento no puede ser nulo.");
            }

            ArgumentNullException.ThrowIfNullOrEmpty(department.Name, "El nombre del departamento es requerido.");


            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(department.Budget, "El Budget no puede ser negativo o cero");


            this.context.Departments.Update(department);
            this.context.SaveChanges();
        }

        private void CargarDatos()
        {

            if (!this.context.Departments.Any())
            {
                List<Department> asientos = new List<Department>()
            {
                new Department()
                {
                     Administrator= 1, Budget = 200, Id= 1,  Name ="Depto 1", StartDate = DateTime.Now
                },
                 new Department()
                {
                     Administrator= 1, Budget = 300, Id= 2,  Name ="Depto 2", StartDate = DateTime.Now
                },
                 new Department()
                {
                     Administrator= 1, Budget = 400, Id= 3,  Name ="Depto 3", StartDate = DateTime.Now
                },
                new Department()
                {
                     Administrator= 1, Budget = 300, Id= 4,  Name ="Depto 4", StartDate = DateTime.Now
                },
            };


                this.context.Departments.AddRange(asientos);
                this.context.SaveChanges();
            }



        }

    }
}
