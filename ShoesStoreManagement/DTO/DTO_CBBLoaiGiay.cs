using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    class DTO_CBBLoaiGiay
    {
        public string ShoesTypeId { get; set; }
        public string ShoesType { get; set; }
        public override string ToString()
        {
            return ShoesType;
        }
    }
}
