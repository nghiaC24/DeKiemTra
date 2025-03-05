using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTra
{
    public class QUANLYNV
    {
        private List<NHANVIEN> DSNHANVIEN;
        public QUANLYNV()
        {
            DSNHANVIEN = new List<NHANVIEN>();
        }
        public void NhapDS()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin nhân viên thứ {0}", i + 1);
                Console.Write("Chọn loại nhân viên (1 - BC, 2 - HD): ");
                int chon = int.Parse(Console.ReadLine());
                NHANVIEN nv = null;
                if (chon == 1)
                {
                    nv = new NHANVIENBC();
                }
                else
                {
                    nv = new NHANVIENHD();
                }
                nv.Nhap();
                DSNHANVIEN.Add(nv);
            }

        }
        public void XuatDS()
        {
            foreach (var nv in DSNHANVIEN)
            {
                Console.WriteLine($"Mã số: {nv.MaSo}, Họ tên: {nv.HoTen}, Lương thực lãnh: {nv.TinhLuong()}");
            }
        }
        public int TinhTongLuong()
        {
            if (DSNHANVIEN == null) return 0;
            int TongLuong = 0;
            foreach (NHANVIEN nv in DSNHANVIEN)
            {
                TongLuong += nv.TinhLuong();
            }
            return TongLuong;
        }

        public double TinhLuongTrungBinh()
        {
            return DSNHANVIEN.Count > 0 ? (double)TinhTongLuong() / DSNHANVIEN.Count : 0;
        }
    }
}

