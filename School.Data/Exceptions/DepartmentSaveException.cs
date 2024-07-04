using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Exceptions
{
    public class DepartmentSaveException : Exception
    {
        public DepartmentSaveException(string message) : base(message)
        {

        }
    }
    public class DepartmentSaveNameException : Exception
    {
        public DepartmentSaveNameException(string message) : base(message)
        {

        }
    }
    public class DepartmentExistsException : Exception
    {
        public DepartmentExistsException(string message) : base(message)
        {

        }
    }
}

