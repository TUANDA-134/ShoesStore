using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    public class DTO_KhachHang
    {
        public string IdKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public bool Gender{ get; set; }
        public DateTime Birthday { get; set; }
        public string SDT { get; set; }
    }
}
