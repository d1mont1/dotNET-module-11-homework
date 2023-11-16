using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct Employee : IEmployee
    {
        public string FullName { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {FullName}, Position: {Position}, Salary: {Salary}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }
}
