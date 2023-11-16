using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IEmployee
    {
        string FullName { get; set; }
        DateTime HireDate { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }
        string Gender { get; set; }
    }
}
