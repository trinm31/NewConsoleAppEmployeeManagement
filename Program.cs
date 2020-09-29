using EmployeeMananagement.Interfaces;
using System;
using System.Collections.Generic;

namespace EmployeeMananagement
{
    class Program
    {
        private static char ans;

        static void Main(string[] args)
        {
            CRUD cRUD = new CRUD();
            do
            {
                Console.Clear();
                Console.WriteLine("**************************EMPLOYEE MANAGEMENT SYSTEM MENU******************************");
                Console.WriteLine("1. Add  an Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Search Employee details");
                Console.WriteLine("4. Modify Employee details");
                Console.WriteLine("5. Remove Employee details");
                Console.WriteLine("6. Exit");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.Write("Enter Your Choice Here:-");
                int choose_number = Convert.ToInt32(Console.ReadLine());
                int search_Id;


                switch (choose_number)
                {
                    case 1:
                        Console.WriteLine("Add staff input 1");
                        Console.WriteLine("Add manager input 2");
                        Console.WriteLine("Add boss input 3");
                        int input = Convert.ToInt32(Console.ReadLine());
                        cRUD.Add(input);
                        break;
                    case 2:
                        cRUD.Show();
                        break;
                    case 3:
                        Console.WriteLine("Enter your search type:");
                        Console.WriteLine("Input 1 to search id");
                        Console.WriteLine("Input 2 to search name");
                        Console.WriteLine("Input 3 to search chucvu");
                        int search_type = Convert.ToInt32(Console.ReadLine());
                        switch (search_type)
                        {
                            case 1:
                                Console.WriteLine("Enter search ID");
                                var id = Convert.ToInt32(Console.ReadLine());
                                cRUD.FindID(id);
                                break;
                            case 2:
                                Console.WriteLine("Enter search name");
                                var name = Console.ReadLine();
                                cRUD.FindName(name);
                                break;

                            case 3:
                                Console.WriteLine("Enter search chuc vu");
                                var chucvu = Console.ReadLine();
                                cRUD.FindChucVu(chucvu);
                                break;

                        }
                        Console.WriteLine("No validated choice...!!!");
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());

                        if (search_Id != null)
                        {
                            cRUD.Update(search_Id);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Employee Id Which You Want To delete:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        if (search_Id != null)
                        {
                            cRUD.Delete(search_Id);
                        }

                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice....!!! Please Enter Correct Choice...!!!");
                        break;
                }
                Console.Write("Would You Like To Continue(Y/N):");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y' || ans == 'Y');
        }
    }
}
