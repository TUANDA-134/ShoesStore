using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.DTO
{
    public class DTO_NhanVien
    {
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffCMND { get; set; }
        public bool Gender { get; set; }
        public int StaffAge { get; set; }
        public string StaffTelephoneNumber { get; set; }
        public string StaffAddress { get; set; }
        public string StaffEmail { get; set; }
        public DateTime StaffBirthday { get; set; }
        public string StaffRole { get; set; }
        public DateTime StartWorkingDate { get; set; }
        public DateTime EndWorkingDate { get; set; }
        public string StaffState { get; set; }

    }
}
