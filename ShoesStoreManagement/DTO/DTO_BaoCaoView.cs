using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    public class DTO_BaoCaoView
    {
        public string IdBill { get; set; }
        public DateTime NgayXuat { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
        public float TongTien { get; set; }

    }
}
