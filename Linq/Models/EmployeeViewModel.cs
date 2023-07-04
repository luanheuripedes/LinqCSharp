using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(int id, string fullName, string businessArea)
        {
            Id = id;
            FullName = fullName;
            BusinessArea = businessArea;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string BusinessArea { get; private set; }
    }
}
