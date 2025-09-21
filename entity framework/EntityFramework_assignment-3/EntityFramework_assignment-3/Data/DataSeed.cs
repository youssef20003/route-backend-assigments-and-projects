using EntityFramework_assignment_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EntityFramework_assignment_3.Context;

namespace EntityFramework_assignment_3.Data
{
    public class DataSeed
    {
        public static int InitializeDeptsData( CompanyContext context)
        {
            if (!context.Departments.Any())
            {
                var deptsData = File.ReadAllText("data\\departments.json");
                var depts = JsonSerializer.Deserialize<List<Department>>(deptsData);

                if (depts != null && depts.Any())
                {
                    context.Departments.AddRange(depts);
                    return context.SaveChanges(); 
                }
            }

            return 0; 
        }

        public static int InitializeEmpsData(CompanyContext context)
        {
            if (!context.Employees.Any())
            {
                var EmpsData = File.ReadAllText("data\\employees.json");
                var Emps = JsonSerializer.Deserialize<List<Employee>>(EmpsData);

                if (Emps != null && Emps.Any())
                {
                    context.Employees.AddRange(Emps);
                    return context.SaveChanges();
                }
            }

            return 0;
        }
    }
}
