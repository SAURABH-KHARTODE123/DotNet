namespace DAL;
using HRPortal.Models;
using System.Collections.Generic;

public static class HRDBManager{
    public static List<Employee> GetAllEmployees(){
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee{Id=23,Name="Sachin Tendulkar"});
        employees.Add(new Employee{Id=24,Name="Sunil Gavaskar"});
        employees.Add(new Employee{Id=56, Name="Sachin Patil"});
        employees.Add(new Employee{Id=33,Name="Jeevan Sharma"});
        employees.Add(new Employee{Id=99,Name="Raj Kumar"});
        return employees;

    }
}