using System;
using System.Collections.Generic;
using BOL;
using DAL;
Console.WriteLine("Welcome to Microlearning :Transflower");

IDBManager dbm = new DBManager();

bool status = true;
// Console based Menu driven User Interface
while (status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Get existing record by Id");
    Console.WriteLine("6. Exit");

    switch (int.Parse(Console.ReadLine()))
    {
        // Display Departments
        case 1:
            {
                List<Department> allDepartments = dbm.GetAll();

                foreach (var dept in allDepartments)
                {
                    Console.WriteLine(" Id: {0}, Name: {1}, Location: {2}",
                                        dept.Id, dept.Name, dept.Location);
                }
            }
            break;

        //Insert new  Department
        case 2:

            Console.WriteLine("Enter the Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the Location:");
            string? location = Console.ReadLine();
            var newDept = new Department()
            {
                Id = id,
                Name = name,
                Location = location
            };
            // var newDept = new Department()
            // {
            //     Id = 23,
            //     Name = "Research",
            //     Location = "Chennai"

            // };
            dbm.Insert(newDept);
            break;

        // Update existing Department
        case 3:
            {
                Console.WriteLine("Enter the Id to update:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the location:");
                location = Console.ReadLine();
                var updateDepartment = new Department()
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
                // var updateDepartment = dbm.GetById(id);
                dbm.Update(updateDepartment);
            }
            break;

        // Delete existing Department
        case 4:
            Console.WriteLine("Enter the Department to delete:");
            id = int.Parse(Console.ReadLine().ToString());

            dbm.Delete(id);
            break;
        // display department by id
        case 5:
            Console.WriteLine("Enter the Id");
            id = int.Parse(Console.ReadLine());
            newDept = dbm.GetById(id);
            Console.WriteLine("Id: {0}, Name: {1}, Location: {2}", newDept.Id, newDept.Name, newDept.Location);
            break;
        //Exit from loop
        case 6:
            status = false;
            break;
    }
}
