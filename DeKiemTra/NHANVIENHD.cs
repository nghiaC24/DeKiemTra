using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTra
{
    internal class NHANVIENHD : NHANVIEN
    {
        public int DoanhThu { get; set; }

        public NHANVIENHD() { }
        public NHANVIENHD(string maso, string hoten, int luongcung, int doanhthu)
            : base(maso, hoten, luongcung)
        {
           this. DoanhThu = doanhthu;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập doanh thu: ");
            DoanhThu = int.Parse(Console.ReadLine());
        }

        public override int TinhLuong()
        {
            return LuongCung + (int)(DoanhThu * 0.1);
        }
    }
}
