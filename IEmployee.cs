using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface IEmployee
    {
        string GetName();
        double GetSalary();
        string GetJobTitle();
    }

    class FullTimeEmployee : IEmployee
    {
        private string name;
        private double salary;
        private string jobTitle;

        public FullTimeEmployee(string name, double salary, string jobTitle)
        {
            this.name = name;
            this.salary = salary;
            this.jobTitle = jobTitle;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public string GetJobTitle()
        {
            return this.jobTitle;
        }
    }

    class PartTimeEmployee : IEmployee
    {
        private string name;
        private double hourprice;
        private int workedhours;
        private string jobTitle;


        public PartTimeEmployee(string name, double hourprice, int workedhours,string jobtitle)
        {
            this.name = name;
            this.hourprice = hourprice;
            this.workedhours = workedhours;
            this.jobTitle = jobtitle;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetSalary()
        {
            return this.hourprice * this.workedhours;
        }

        public string GetJobTitle()
        {
            return this.jobTitle;
        }
    }


}
