using EmployeeMananagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMananagement.Employee
{
    public class Boss : IEmployee
    {
        public int ID { get; set; }

        public string Ten { get; set; }

        public DateTime CreateDate { get; set; }

        public string ChucVu { get; set; }
        
        public Boss(int id, string ten, DateTime createDate, string chucvu)
        {
            this.ID = id;
            this.Ten = ten;
            this.CreateDate = createDate;
            this.ChucVu = chucvu;
        }
    }
}
