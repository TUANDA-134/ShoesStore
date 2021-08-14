using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    class DTO_DetailBillView
    {
        public string detailedShoesID { get; set; }
        public string shoesName { get; set; }
        public float shoesCost { get; set; }
        public int shoesOrderedAmount { get; set; }

    }
}
