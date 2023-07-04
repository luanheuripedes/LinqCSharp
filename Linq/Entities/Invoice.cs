using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Entities
{
    public class Invoice
    {
        public int Id { get; private set; }
        public string ReferenceMonthYear { get; private set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime GeneratedAt { get; private set; }
        public Invoice(int id, string referenceMonthYear, int employeeId, decimal amount)
        {
            Id = id;
            ReferenceMonthYear = referenceMonthYear;
            EmployeeId = employeeId;
            Amount = amount;

            GeneratedAt = DateTime.Now;
        }
    }
}
