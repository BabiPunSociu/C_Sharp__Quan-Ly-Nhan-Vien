using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class EmployeeModel
    {
        List<Employee> listEmployee;

        public EmployeeModel()
        {
                
            //khởi tạo danh sách sinh viên
                
            this.listEmployee = new List<Employee> {
    //       new Employee() { Id = 1,Name = "Dung",yearOfBirth = 2002, salaryLevel = 3.4, basicSalary = 5000000},
            };
        }

        public bool check_id(int id1)   // không tồn tại: true
        {
            for (int i = 0; i < listEmployee.Count; i++)
            {
                if (listEmployee[i].getId() == id1)
                    return false;
            }
            return true;
        }
        
        public void addEmployee()   // Chức năng 2: Thêm một nhân viên
        {
            Employee employee = new Employee();
            do
            {
                if (check_id(employee.getId()) == false)
                {
                    Console.WriteLine("Id: " + employee.getId()+" đã tồn tại.");
                }
                employee.setId();
            } while (check_id(employee.getId()) == false);
            
            employee.setName();
            employee.setYearOfBirth();
            employee.setSalaryLevel();
            employee.setBasicSalary();

            listEmployee.Add(employee);
            Console.WriteLine("\nĐã thêm thành công...");
        }

        public void EditEmployee()      // Chức năng 3: Sửa thông tin nhân viên theo id
        {
            Console.Write("\nNhập id nhân viên cần sửa thông tin: ");
            int id1 = Convert.ToInt32(Console.ReadLine());
            bool tonTaiId = false;
            for(int i = 0; i < listEmployee.Count; i++)
            {
                if (listEmployee[i].getId() == id1)
                {
                    listEmployee[i].setName();
                    listEmployee[i].setYearOfBirth();
                    listEmployee[i].setSalaryLevel();
                    listEmployee[i].setBasicSalary();
                    tonTaiId = true;
                    Console.WriteLine("\nEdit employee done...");
                    break;
                }
            }
            if (tonTaiId == false)
                Console.WriteLine("Không tồn tại id: " + id1);
        }

        public void RemoveEmployee()        // Chức năng 4: Xóa một nhân viên theo id
        {
            Console.Write("\nNhập id nhân viên cần sửa thông tin: ");
            int id1 = Convert.ToInt32(Console.ReadLine());
            bool tonTaiId = false;
            for (int i = 0; i < listEmployee.Count; i++)
            {
                if (listEmployee[i].getId() == id1)
                {
                    listEmployee.Remove(listEmployee[i]);   // Xóa phần tử

                    tonTaiId = true;
                    Console.WriteLine("\nRemove employee done...");
                    break;
                }
            }
            if (tonTaiId == false)
                Console.WriteLine("Không tồn tại id: " + id1);
        }

        public void FindEmployeeByName()  // Chức năng 5: Tìm kiếm theo tên
        {

            Console.Write("\nNhập tên nhân viên: ");
            string name1 = Console.ReadLine();

            foreach (Employee emp in listEmployee)
            {
                if(emp.getName() == name1)
                    emp.display();
            }    
        }

        public void inListEmployee()
        {
            foreach (Employee emp in listEmployee)
            {
                emp.display();
                Console.WriteLine("-------------------------------------");
            }    
        }
    }
}
