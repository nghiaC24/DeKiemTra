using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTra
{
    public class NHANVIENBC : NHANVIEN
    {
        public string MucXepLoai { get; set; }

        public NHANVIENBC() { }
        public NHANVIENBC(string maso, string hoten, int luongcung, string mucxeploai)
            : base(maso, hoten, luongcung)
        {
           this. MucXepLoai = mucxeploai;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập mức xếp loại (A/B/C): ");
            MucXepLoai = Console.ReadLine().ToUpper();
        }

        public override int TinhLuong()
        {
            double MucThuong = 0;
            switch (MucXepLoai)
            {
                case "A":
                    MucThuong = 1.5 * LUONGCUNG;
                    break;
                case "B":
                    MucThuong = 1.2 * LUONGCUNG;
                    break;
                case "C":
                    MucThuong = 1 * LUONGCUNG;
                    break;
                default:
                    MucThuong = 0; // Trả về mức lương mặc định là 0
                    break;
            }

            return (int)MucThuong;  // Chuyển giá trị MucThuong từ double sang int trước khi trả về

        }

    }
    
}

