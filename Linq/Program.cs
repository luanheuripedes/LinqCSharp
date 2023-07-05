﻿using Linq.Entities;
using Linq.Models;
using Linq.Persistence;

var dbContext = new WorkDbContext();

var employees = dbContext.Employees;

// Filtragem
var itEmployees = employees.Where(e => e.BusinessArea == "TI").ToList();
var over10000SalaryEmployees = employees.Where(e => e.Salary >= 10_000).ToList();
var nonInvoiceEmployees = employees.Where(e => !e.Invoices.Any()).ToList();

// Busca
//Lança exceção => var kaio = employees.Single(e => e.FullName == "Kaio");
var kaio = employees.SingleOrDefault(e => e.FullName == "Kaio");

if(kaio is null)
{
    Console.WriteLine("Caio é null");
}

var luis = employees.SingleOrDefault(e => e.FullName == "Luis");
var luisById = employees.SingleOrDefault(e => e.Id == 1);

var salaray10000 = employees.First(e => e.Salary == 10_000m);
// Lança exceção => var salarayOver20000 = employees.First(e => e.Salary == 20_000m);
var salarayOver20000 = employees.FirstOrDefault(e => e.Salary == 20_000m);

var salaryGreater20000Any = employees.Any(e => e.Salary > 20_000m); // return true or false
var salaryGreaterOrEqual15000Any = employees.Any(e => e.Salary >= 15_000m);

// Projeção
var names = employees.Select(e => e.FullName).ToList();
var employeesViewModel = employees.Select(e => new EmployeeViewModel(e.Id, e.FullName, e.BusinessArea)).ToList();

// Seleciona os elementos dentro de uma lista e agrega uma nova lista // listagem de uma listagem
var allInvoices = employees.SelectMany(e => e.Invoices).ToList();

//Melhor fazer com selectMany porque o resultado é o mesmo
//var invoices = new List<Invoice>();
//foreach (var employee in employees)
//{
//    invoices.AddRange(employee.Invoices);
//}


// Ordenação
var employeeOrderBySalary = employees.OrderBy(e => e.Salary).ToList();
var employeeOrderByDescendingSalary = employees.OrderByDescending(e => e.Salary).ToList();

var employeesOrderByAreaThenSalary = employees
    .OrderBy(e => e.BusinessArea)
    .ThenByDescending(e => e.Salary)
    .ToList();

//Agrupamento
var employeeCountByBusiness = employees
    .GroupBy(e => e.BusinessArea)
    .Select(g => new { Department = g.Key, Count = g.Count() })
    .ToList();

var employeesOver10_000CountByArea = employees
    .GroupBy(e => e.BusinessArea)
    .Select(g => new { Department = g.Key, Count = g.Count(e => e.Salary >= 10_000M) })
    .ToList();

var amountOfInvoices = employees
    .GroupBy(e => e.Invoices.Count)
    .Select(g => new { Count = g.Key, Employees = g.Select(e => e.FullName).ToList() })
    .ToList();

Console.ReadLine();
