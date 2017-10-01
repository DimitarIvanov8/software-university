using System;
using System.Text;

namespace _3.Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHoursPerDay;
        
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkingHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHoursPerDay = value;
            }
        }

        public decimal SalaryPerHour()
        {
            var salaryPerHour = (weekSalary / 5m) / workingHoursPerDay;
            return salaryPerHour;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkingHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}
