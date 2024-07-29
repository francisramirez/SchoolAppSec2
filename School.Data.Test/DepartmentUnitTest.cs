

using School.Data.Context;
using School.Data.Entities;
using School.Data.Exceptions;

namespace School.Data.Test
{
    public class DepartmentUnitTest
    {
        [Fact]
        public void GetDepartment_ReturnDepartmentEntity_WhenExists()
        {
            //Arrange
            var context = new SchoolContext();
            var deptoDb = new Daos.DaoDepartment(context);
           

            //Act
            int deptoId = 1;
            Department department = deptoDb.GetDepartment(deptoId);



            Assert.NotNull(department);
            Assert.IsType<Department>(department);


        }

        [Fact]
        public void GetDepartment_ThRowDepartmentGetExeptionId_WhenDepartmentIdIgualCero()
        {
            //Arrange
            var context = new SchoolContext();
            var deptoDb = new Daos.DaoDepartment(context);

            //Act
            int deptoId = 0;

            string message = "El codigo del departamento es requerido.";


            //Assert
            var exeptionDepto = Assert.Throws<DepartmentGetExeptionId>(() => deptoDb.GetDepartment(deptoId));

            Assert.Equal(message, exeptionDepto.Message);

        }

        [Fact]
        public void SaveDepartment_DepartmentEntityIsNull()
        {
            //Arrange
            var context = new SchoolContext();
            var deptoDb = new Daos.DaoDepartment(context);


            // Act 
            Department department = null;
            string message = "El objeto departamento no puede ser nulo.";

            //Assert

            var exceptionDepto = Assert.Throws<DepartmentSaveException>(() => deptoDb.SaveDepartment(department));
            Assert.Equal(message, exceptionDepto.Message);

        }
        [Fact]
        public void SaveDepartment_Department_Name_Is_Required ()
        {
            //Arrange
            var context = new SchoolContext();
            var deptoDb = new Daos.DaoDepartment(context);


            // Act 
            Department department = new Department() 
            { 
                 Name = null,
            };

            string message = "El nombre del departamento es requerido.";

            //Assert

            var exceptionDepto = Assert.Throws<DepartmentSaveNameException>(() => deptoDb.SaveDepartment(department));
            Assert.Equal(message, exceptionDepto.Message);

        }
        [Fact]
        public void SaveDepartment_Department_Name_Exists()
        {
            //Arrange
            var context = new SchoolContext();
            var deptoDb = new Daos.DaoDepartment(context);


            // Act 
            Department department = new Department()
            {
                Name = "Depto 1",
            };
           
            string message = "El departamento se encuentra registrado.";

            //Assert

            var exceptionDepto = Assert.Throws<DepartmentExistsException>(() => deptoDb.SaveDepartment(department));
            Assert.Equal(message, exceptionDepto.Message);

        }
    }
}
