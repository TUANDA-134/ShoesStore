using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.DTO;
namespace ShoesStoreManagement.BLL
{
    class BLL_NhanVien
    {
        private static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhanVien();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        internal List<DTO_ShowDGV_NhanVien> GetAllNhanVien()
        {
        List<DTO_ShowDGV_NhanVien> listNhanVien = new List<DTO_ShowDGV_NhanVien>();
            ShoesStoreEntities db = new ShoesStoreEntities();
            foreach(Staff nV in db.Staffs.ToList())
            {
                DTO_ShowDGV_NhanVien s = new DTO_ShowDGV_NhanVien();
                s.StaffName = nV.staffName;
                s.StaffAge = DateTime.Now.Year - nV.staffBirthday.Value.Year;
                s.StaffTelephoneNumber = nV.staffTelephoneNumber;
                s.StaffEmail = nV.staffEmail;
                s.StaffCMND = nV.staffCMND;
                s.StartWorkingDate = nV.staffStartDate.Value;
                listNhanVien.Add(s);
            }
            return listNhanVien;
        }

        internal List<DTO_ShowDGV_NhanVien> SapXep(string v,List<DTO_ShowDGV_NhanVien> list)
        {

            switch (v)
            {
                case "NgayBatDau": 
                    list = list.OrderBy(nV => nV.StartWorkingDate).ToList();
                    break;
                case "Tuoi":
                    list = list.OrderBy(nV => nV.StaffAge).ToList();
                    break;
                case "Ten":
                    list = list.OrderBy(nV => nV.StaffName).ToList();
                    break;
                case "CMND":
                    list = list.OrderBy(nV => nV.StaffCMND).ToList();
                    break;
            }
            return list;
        }

        internal DTO_NhanVien GetNVByTenAndSDT(string ten, string sdt)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            DTO_NhanVien s = new DTO_NhanVien();
            var temp = db.Staffs.Where(p => p.staffName == ten && p.staffTelephoneNumber == sdt).FirstOrDefault();
            if(temp == null)
            {
                return null;
            }
            else
            {
                s.StaffName = temp.staffName;
                s.StaffCMND = temp.staffCMND;
                s.StaffEmail = temp.staffEmail;
                s.StaffAddress = temp.staffAddress;
                s.StaffAge = DateTime.Now.Year - ((DateTime)temp.staffBirthday).Year;
                s.StaffId = temp.staffId;
                s.StaffRole = temp.staffRole;
                s.StaffTelephoneNumber = temp.staffTelephoneNumber;
                s.StartWorkingDate = (DateTime)temp.staffStartDate;
                if(((DateTime?)temp.staffEndDate).HasValue)
                {
                    s.EndWorkingDate = (DateTime)temp.staffEndDate;
                }
                else
                {
                    s.EndWorkingDate = DateTime.MaxValue;
                }
                s.StaffBirthday = (DateTime)temp.staffBirthday;
                s.StaffState = db.StaffStates.Where(p => p.staffStateId == temp.staffStateId).Select(p => p.staffState1).FirstOrDefault();
                s.Gender = (bool)temp.staffGender;
            }
            return s;
        }
        internal void UpdateStaff(Staff nV)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            nV.staffId = db.Staffs.Where(p => p.staffCMND == nV.staffCMND).FirstOrDefault().staffId;
            Staff s = db.Staffs.Find(nV.staffId);
            s.staffGender = nV.staffGender;
            s.staffBirthday = nV.staffBirthday;
            s.staffTelephoneNumber = nV.staffTelephoneNumber;
            s.staffEmail = nV.staffEmail;
            s.staffAddress = nV.staffAddress;
            s.staffRole = nV.staffRole;
            db.SaveChanges();
        }
    }
}
