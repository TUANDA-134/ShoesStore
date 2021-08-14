using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    class DTO_DangKyTaiKhoan
    {
        public string HoVaTen { get; set; }
        public string CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Gender { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayBatDauLamViec { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string XacThucMatKhau { get; set; }
    }
}
