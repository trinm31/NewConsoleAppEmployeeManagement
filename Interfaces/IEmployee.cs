using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMananagement.Interfaces
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Ten { get; set; }
        DateTime CreateDate { get; set; }
        string ChucVu { get; set; }
        
    }
}
