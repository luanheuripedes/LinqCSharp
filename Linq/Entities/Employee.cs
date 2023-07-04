using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string BusinessArea { get; private set; }
        public decimal Salary { get; private set; }
        public List<Invoice> Invoices { get; set; }

        public Employee(int id, string fullName, string businessArea, decimal salary, List<Invoice> invoices)
        {
            Id = id;
            FullName = fullName;
            BusinessArea = businessArea;
            Salary = salary;
            Invoices = invoices;
        }
    }
}
