using Linq.Persistence;

var dbContext = new WorkDbContext();

var employees = dbContext.Employees;

// Filtragem
var itEmployees = employees.Where(e => e.BusinessArea == "TI").ToList();
var over10000SalaryEmployees = employees.Where(e => e.Salary >= 10_000).ToList();
var nonInvoiceEmployees = employees.Where(e => !e.Invoices.Any()).ToList();

// Busca

// Projeção


Console.ReadLine();
