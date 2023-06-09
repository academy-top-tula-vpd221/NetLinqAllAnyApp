﻿using NetLinqAllAnyApp;

List<Employee> employees = new List<Employee>()
{
    new() { Name = "Bob", Age = 29 },
    new() { Name = "Joe", Age = 37 },
    new() { Name = "Tom", Age = 23 },
    new() { Name = "Sam", Age = 19 },
    new() { Name = "Leo", Age = 43 },
    new() { Name = "Ann", Age = 38 },
};

var employee30 = employees.Where(e => e.Age > 30);

employees.Add(new() { Name = "Jim", Age = 35 });

foreach (var e in employee30)
    Console.WriteLine($"{e.Name} {e.Age}");



//var all18 = employees.All(e => e.Age >= 20);
//Console.WriteLine($"{all18}");

//var any40 = employees.Any(e => e.Age >= 50);
//Console.WriteLine(any40);

//Employee employee = new() { Name = "Bob", Age = 39 };
//var cont = employees.Contains(employee, new EmployeNameAgeComparer());
//Console.WriteLine(cont);

//var first = employees.FirstOrDefault(e => e.Age > 50);
//if(first != null)
//    Console.WriteLine(first.Name);

//var last = employees.LastOrDefault(e => e.Age > 50);