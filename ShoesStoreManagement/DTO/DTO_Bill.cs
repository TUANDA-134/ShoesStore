using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    class DTO_Bill
    {
        public string IdBill { get; set; }
        public string IdKhachHang { get; set; }
        public string staffId { get; set; }
        public DateTime NgayXuat { get; set; }
    }
}
