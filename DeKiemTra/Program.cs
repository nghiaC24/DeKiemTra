using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chuyển kiểu sang tiếng việt 
            Console.OutputEncoding = Encoding.UTF8;
            QUANLYNV qlnv = new QUANLYNV();
            while (true)
            {
                Console.WriteLine("\n===== MENU QUẢN LÝ NHÂN VIÊN =====");
                Console.WriteLine("1. Nhập danh sách nhân viên");
                Console.WriteLine("2. Hiển thị danh sách nhân viên");
                Console.WriteLine("3. Tính tổng lương công ty phải trả");
                Console.WriteLine("4. Tính lương trung bình");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng (1-5): ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.Write("Lựa chọn không hợp lệ! Vui lòng nhập số từ 1 đến 5: ");
                }

                switch (choice)
                {
                    case 1:
                        qlnv.NhapDS();
                        break;
                    case 2:
                        qlnv.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"\nTổng lương công ty phải trả: {qlnv.TinhTongLuong():N0} VND");
                        break;
                    case 4:
                        Console.WriteLine($"\nLương trung bình của nhân viên: {qlnv.TinhLuongTrungBinh():N0} VND");
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình.");
                        return; // Thoát chương trình
                }
            }

        }
    }
}
