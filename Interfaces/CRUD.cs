using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EmployeeMananagement.Employee;

namespace EmployeeMananagement.Interfaces
{
    public class CRUD
    {
        public static List<IEmployee> Employeelist = new List<IEmployee>();
        public void Show()
        {
            Console.WriteLine("List nhân viên:");
            foreach (var employee in Employeelist)
            {
                Console.WriteLine($"ID của nhân viên là: {employee.ID}");
                Console.WriteLine($"Ten của nhân viên là: {employee.Ten}");
                Console.WriteLine($"Create date của nhân viên là: {employee.CreateDate.ToString()}");
                Console.WriteLine($"Chức vụ của nhân viên là: {employee.ChucVu}");
            }
        }

        public void FindID(int id)
        {
            var employees = from s in Employeelist where s.ID == id select s;
            Console.WriteLine("List nhân viên:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID của nhân viên là: {employee.ID}");
                Console.WriteLine($"Ten của nhân viên là: {employee.Ten}");
                Console.WriteLine($"Create date của nhân viên là: {employee.CreateDate.ToString()}");
                Console.WriteLine($"Chức vụ của nhân viên là: {employee.ChucVu}");
            }
        }
        public void FindName(String name)
        {
            var _name = name.ToLower();
            var employees = from s in Employeelist where s.Ten.ToLower() == _name select s;
            Console.WriteLine("List nhân viên:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID của nhân viên là: {employee.ID}");
                Console.WriteLine($"Ten của nhân viên là: {employee.Ten}");
                Console.WriteLine($"Create date của nhân viên là: {employee.CreateDate.ToString()}");
                Console.WriteLine($"Chức vụ của nhân viên là: {employee.ChucVu}");
            }
        }
        public void FindChucVu(String chucvu)
        {
            var _chucvu = chucvu.ToLower();
            var employees = from s in Employeelist where s.ChucVu.ToLower() == _chucvu select s;
            Console.WriteLine("List nhân viên:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID của nhân viên là: {employee.ID}");
                Console.WriteLine($"Ten của nhân viên là: {employee.Ten}");
                Console.WriteLine($"Create date của nhân viên là: {employee.CreateDate.ToString()}");
                Console.WriteLine($"Chức vụ của nhân viên là: {employee.ChucVu}");
            }
        }
        public void Add(int input)
        {
            switch (input)
            {
                case 1:
                    Console.Write("Enter Employee Id:");
                    var id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Employee Name:");
                    var name = Console.ReadLine();
                    Console.Write("Enter Employee Create Date:");
                    var creatDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Employee Chuc vu:");
                    var chucVu = "Staff";
                    Staff staff = new Staff(id, name, creatDate, chucVu);

                    Employeelist.Add(staff);
                    break;

                case 2:
                    Console.Write("Enter Employee Id:");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Employee Name:");
                    name = Console.ReadLine();
                    Console.Write("Enter Employee Create Date:");
                    creatDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Employee Chuc vu:");
                    chucVu = "Manager";
                    Manager manager = new Manager(id, name, creatDate, chucVu);

                    Employeelist.Add(manager);
                    break;
                case 3:
                    Console.Write("Enter Employee Id:");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Employee Name:");
                    name = Console.ReadLine();
                    Console.Write("Enter Employee Create Date:");
                    creatDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Employee Chuc vu:");
                    chucVu = "Boss";
                    Boss boss = new Boss(id, name, creatDate, chucVu);

                    Employeelist.Add(boss);
                    break;
            }

        }
        public void Update(int id)
        {
            Console.WriteLine("Nhập tên cần sửa");
            Employeelist.FirstOrDefault(e => e.ID == id).Ten = Console.ReadLine();
            Console.WriteLine("Nhập create cần sửa");
            Employeelist.FirstOrDefault(e => e.ID == id).CreateDate = Convert.ToDateTime(Console.ReadLine());
        }
        public void Delete(int id)
        {
            Employeelist.Remove(Employeelist.Where(e => e.ID == id).First());
        }
    }
}
