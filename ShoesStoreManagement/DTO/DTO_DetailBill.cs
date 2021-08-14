using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    class DTO_DetailBill
    {
        public string detailedillID { get; set; }
        public string billID { get; set; }
        public string detailedShoesID { get; set; }
        public float shoesCost { get; set; }
        public int shoesOrderedAmount { get; set; }
    }
}
