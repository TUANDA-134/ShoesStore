using ShoesStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.BLL
{
    class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan _Instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TaiKhoan();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        internal string ChangePassword(DTO_ChangePasswordOfAccount cPOA)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            string accountId = "";
            if(db.Accounts.Where(p => p.accountUsername == cPOA.Username && p.accountPassword == cPOA.CurrentPassword).ToList().Count != 0)
            {
                accountId = db.Accounts.Where(p => p.accountUsername == cPOA.Username && p.accountPassword == cPOA.CurrentPassword).FirstOrDefault().accountId;
            }
            if(accountId == "")
            {
                return "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
            else
            {
                Account a = db.Accounts.Find(accountId);
                a.accountPassword = cPOA.NewPassword;
                db.SaveChanges();
                return "Đổi mật khẩu thành công!";
            }
        }
        internal string SetIDStaff(string ChucVu)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var l1 = db.Staffs.ToList();
            int count = 0;
            string iD = "";
            if(ChucVu == "Admin")
            {
                iD += "AD";
                foreach (Staff item in l1)
                {
                    if (item.staffId.Contains("AD"))
                    {
                        
                        count++;
                        
                    }
                }
            }
            else if(ChucVu == "Staff")
            {
                iD += "ST";
                foreach (Staff item in l1)
                {
                    if (item.staffId.Contains("ST"))
                    {
                        count++;
                    }
                }
            }
            else
            {

            }
            count++;
            int sochuso = count.ToString().ToCharArray().Count();
            while (3 - sochuso > 0)
            {
                iD += "0";
                sochuso++;
            }
            iD += count.ToString();
            return iD;
        }
        internal string SetIDAccount()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var l1 = db.Accounts.ToList();
            int count = l1.Count;
            count++;
            int sochuso = count.ToString().ToCharArray().Count();
            string iD = "AC";
            while (3 - sochuso > 0)
            {
                iD += "0";
                sochuso++;
            }
            iD += count.ToString();
            return iD;
        }
        internal string SignUpNewAccount(DTO_DangKyTaiKhoan dKTK, string pathAnh)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            int CountCMND = db.Staffs.Where(p => p.staffCMND == dKTK.CMND).ToList().Count;
            int CountSDT = db.Staffs.Where(p => p.staffTelephoneNumber == dKTK.SDT).ToList().Count;
            string accountId = SetIDAccount();
            int CountTDN = db.Accounts.Where(p => p.accountUsername == dKTK.TenDangNhap).ToList().Count;
            if (CountTDN > 0) return "Tên đăng nhập đã tồn tại!!!";
            if (CountCMND > 0)
            {
                return "Chứng minh nhân dân này đã được sử dụng bởi một nhân viên khác, vui lòng nhập đúng số chứng minh thư của bạn";
            }
            else if (CountSDT > 0)
            {
                return "Số điện thoại này đã được sử dụng bởi một nhân viên khác, vui lòng nhập đúng số điện thoại của bạn";
            }
            else
            {
                Account newAccount = new Account();
                newAccount.accountId = accountId;
                newAccount.accountUsername = dKTK.TenDangNhap;
                newAccount.accountPassword = dKTK.MatKhau;
                newAccount.accountTypeId = (dKTK.ChucVu == "Admin") ? "1" : "2";
                db.Accounts.Add(newAccount);
                db.SaveChanges();
                Staff newStaff = new Staff();
                newStaff.staffTelephoneNumber = dKTK.SDT;
                newStaff.staffStateId = 2;
                newStaff.staffStartDate = dKTK.NgayBatDauLamViec;
                newStaff.staffRole = dKTK.ChucVu;
                newStaff.staffName = dKTK.HoVaTen;
                newStaff.staffId = SetIDStaff(dKTK.ChucVu);
                newStaff.staffGender = dKTK.Gender;
                newStaff.staffEndDate = DateTime.MaxValue;
                newStaff.staffEmail = dKTK.Email;
                newStaff.staffCMND = dKTK.CMND;
                newStaff.staffBirthday = dKTK.NgaySinh;
                newStaff.staffAddress = dKTK.DiaChi;
                newStaff.accountId = accountId;
                db.Staffs.Add(newStaff);
                db.SaveChanges();
                File.Copy(pathAnh, BLL_DuongDan.Instance.StaffImagePath() + newStaff.staffId + ".png");
                return "Đăng ký thành công!";
            }


        }
    }
}
