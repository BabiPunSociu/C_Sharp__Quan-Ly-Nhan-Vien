using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Program
    {
        public static void showMenu()
        {
            Console.WriteLine("\nVui lòng lựa chọn 1 trong các chức năng sau:" +
                "\n 1. Hiển thị thông tin toàn bộ nhân viên." +
                "\n 2. Thêm một nhân viên." +
                "\n 3. Sửa thông tin nhân viên theo id." +
                "\n 4. Xóa toàn bộ thông tin một nhân viên theo id." +
                "\n 5. Tìm thông tin nhân viên theo tên." +
                "\n 0.Thoát.");
        }

        public static int nhapChucNang()
        {
            int chucNang;
            do
            {
                showMenu();
                Console.Write("\nNhập chức năng: ");
                chucNang = Convert.ToInt32(Console.ReadLine());
            } while(chucNang < 0 || chucNang > 5);
            return chucNang;
        }

        public static bool nhapLuaChon()
        {
            int luaChon;
            do
            {
                Console.Write("\nNhập lựa chọn:\n 1. Tiếp tục. \n 0. Thoát");
                Console.Write("\nLựa chọn của bạn là: ");
                luaChon = Convert.ToInt32(Console.ReadLine());
            }while(luaChon < 0 || luaChon > 1);
            return (luaChon == 1)?true:false;
        }

        public static void Main()
        {
            EmployeeModel employeeModel = new EmployeeModel();

            int chucNang;
            bool luaChon = true;     // true = tiếp tục,     false = Dừng lại
            while(luaChon == true)
            {
                chucNang = nhapChucNang();

                if(chucNang == 0)
                {
                    luaChon = false;
                    Console.WriteLine("\nGoodbye. See you again!");
                }    
                else if(chucNang == 1)
                {
                    Console.WriteLine("Bạn đã chọn \"1. Hiển thị thông tin toàn bộ nhân viên.\"");

                    employeeModel.inListEmployee();

                    Console.Write("-----------------------------------------------");
                    luaChon = nhapLuaChon();
                }    
                else if(chucNang == 2)
                {
                    Console.WriteLine("Bạn đã chọn \"2. Thêm một nhân viên.\"");

                    employeeModel.addEmployee();

                    Console.Write("-----------------------------------------------");
                    luaChon = nhapLuaChon();
                }    
                else if(chucNang == 3)
                {
                    Console.WriteLine("Bạn đã chọn \"3. Sửa thông tin nhân viên theo id.\"");

                    employeeModel.EditEmployee();

                    Console.Write("-----------------------------------------------");
                    luaChon = nhapLuaChon();
                }    
                else if(chucNang == 4)
                {
                    Console.WriteLine("Bạn đã chọn \"4. Xóa toàn bộ thông tin một nhân viên theo id.\"");

                    employeeModel.RemoveEmployee();

                    Console.Write("-----------------------------------------------");
                    luaChon = nhapLuaChon();
                }
                else
                {
                    Console.WriteLine("Bạn đã chọn \"5. Tìm thông tin nhân viên theo tên.\"");
                    
                    employeeModel.FindEmployeeByName();
                    
                    Console.Write("\n-----------------------------------------------");
                    luaChon = nhapLuaChon();
                }
            }; 
        }
    }
}
