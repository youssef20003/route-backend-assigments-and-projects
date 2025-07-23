using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment2.classes
{
    enum securityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    enum gender
    {
        M,
        F
    }
    internal class employees
    {
        int id;
        string name;
        double salary;
        HiringDate hd;
        securityLevel security;
        gender gender;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public HiringDate Hd
        {
            get
            {
                return hd;
            }
            set
            {
                hd = value;
            }
        }

        public gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public securityLevel Security
        {
            get
            {
                return security;
            }
            set
            {
                security = value;
            }
        }

        public employees(int id, string name, double salary, HiringDate hiringDate, gender gender, securityLevel security)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.hd = hiringDate; 
            this.gender = gender;
            this.security = security;
        }


        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Gender: {gender}, Security Level: {security}, " +
                   $"Salary: {string.Format("{0:C}", salary)}, Hiring Date: {hd}";
        }
    }
}
