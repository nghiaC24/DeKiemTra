using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTra
{
    // Lớp Cha NHANVIEN
    public class NHANVIEN
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int LuongCung { get; set; }

        public NHANVIEN() { }
        public NHANVIEN(string maso, string hoten, int luongcung)
        {
           this. MaSo = maso;
            this.HoTen = hoten;
           this. LuongCung = luongcung;
        }
        public string MASO
        {
            get { return MaSo; }
            set { MaSo = value; }
        }
        public string HOTEN
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public int LUONGCUNG
        {
            get { return LuongCung; }
            set { LuongCung = value; }
        }
        // Phương thức nhập thông tin nhân viên
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số nhân viên ");
            MaSo = Console.ReadLine();
            Console.Write("Nhập họ tên nhân viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập lương cứng: ");
            LuongCung = int.Parse(Console.ReadLine());

        }
        public virtual int TinhLuong()
        {
            return LuongCung;
        }
        public void Xuat()
        {
            Console.WriteLine($"Mã Số: {MaSo}, Họ Tên: {HoTen}, Lương được lãnh:, {TinhLuong()}");
        }

    }
}
