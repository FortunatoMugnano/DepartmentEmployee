using DepartmentEmployees.Data;
using DepartmentEmployees.Models;
using System;
using System.Collections.Generic;

namespace DepartmentEmployees
{
    class Program
    {
        static void Main(string[] args)
        {



            DepartmentRepository departmentRepo = new DepartmentRepository();

            Console.WriteLine("Getting All Departments:");
            Console.WriteLine("-------------------------");

            List<Department> allDepartments = departmentRepo.GetAllDepartments();

            foreach (Department dept in allDepartments)
            {
                Console.WriteLine($"{dept.Id} {dept.DeptName}");
            }

            EmployeeRepository employeeRepo = new EmployeeRepository();

            Console.WriteLine("Getting All Employees:");
            Console.WriteLine("-----------------------");

            List<Employee> allEmployees = employeeRepo.GetAllEmployees();

            foreach (Employee emp in allEmployees)
            {
                Console.WriteLine($"{emp.Id}: {emp.FirstName} {emp.LastName}");
            }

            EmployeeRepository employeeRepoWithDep = new EmployeeRepository();

            Console.WriteLine("Getting All Employees with Departments:");
            Console.WriteLine("-----------------------");

            List<Employee> allEmployeesWithDept = employeeRepoWithDep.GetAllEmployeesWithDepartment();

            foreach (Employee emp in allEmployeesWithDept)
            {
                Console.WriteLine($"{emp.Id}: {emp.FirstName} {emp.LastName} in {emp.Department.DeptName} department");
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Department with Id 1");

            Department singleDepartment = departmentRepo.GetDepartmentById(1);

            Console.WriteLine($"{singleDepartment.Id} {singleDepartment.DeptName}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Employee with Id 1");

            Employee singleEmployee = employeeRepo.GetEmployeeById(1);

            Console.WriteLine($"{singleEmployee.Id}: {singleEmployee.FirstName} {singleEmployee.LastName} in department {singleEmployee.Department.DeptName}");

            /*
            //ADDING NEW DEPARTMENTS

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var legal = new Department();
            Console.WriteLine("What Department would you like to make?");

            legal.DeptName = Console.ReadLine();

            departmentRepo.AddDepartment(legal);

            //UPDATE DEPARTMENTS

            Console.WriteLine("What department would you like to update?");
            var departmentToUpdate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What should the new department name be called?");
            var newDepartmentName = Console.ReadLine();

            departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DeptName = newDepartmentName });

            //DELETE DEPARTMENTS

            departmentRepo.DeleteDepartment(5);
            */
            
            
            //ADDING NEW EMPLOYEES

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var newEmployee = new Employee();
            Console.WriteLine("New Employee Name");
            Console.WriteLine(">");
            newEmployee.FirstName = Console.ReadLine();
            Console.WriteLine("New Employee Last Name");
            Console.WriteLine(">");
            newEmployee.LastName = Console.ReadLine();
            Console.WriteLine("New Employee Department Number");
            Console.WriteLine(">");
            newEmployee.DepartmentId = Int32.Parse(Console.ReadLine());

            employeeRepo.AddEmployee(newEmployee);

           
    
            /*
            //UPDATE EMPLOYEE

            Console.WriteLine("Which employee would you like to update?");
            var employeeToUpdate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What should the new employee name be?");
            var newEmployeeName = Console.ReadLine();

            Console.WriteLine("What should the new employee last name be?");
            var newEmployeeLastName = Console.ReadLine();

            Console.WriteLine("What should the new employee department number be?");
            var newEmployeeDepartmentId = Int32.Parse(Console.ReadLine());

            employeeRepo.UpdateEmployee(employeeToUpdate, new Employee { FirstName = newEmployeeName, LastName = newEmployeeLastName, 
            DepartmentId = newEmployeeDepartmentId});
            */
            //DELETE EMPLOYEE

           //employeeRepo.DeleteEmployee(4);

         

        }
    }
}
