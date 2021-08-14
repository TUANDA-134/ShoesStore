using ShoesStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.BLL
{
    class BLL_Login
    {
        private static BLL_Login _Instance;

        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;

            }

            private set => _Instance = value;
        }
        internal static DTO_HienHanh HienHanh()
        {
            return acc;
        }
        static DTO_HienHanh acc = null;
        internal bool GetAccount(string username, string password)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var sql = from a in db.Staffs
                      join b in db.Accounts
                      on a.accountId equals b.accountId
                      where (b.accountUsername.Equals(username) && b.accountPassword.Equals(password))
                      select a.staffId;
            //var l1 = db.Staffs.Where(p => (p.Account.accountUsername == username && p.Account.accountPassword == password)).FirstOrDefault();
            if (sql.FirstOrDefault() != null)
            {
                DTO_HienHanh Acc = GetAcc(sql.FirstOrDefault().ToString());
                if (Acc == null)
                {
                    return false;
                }
                acc = Acc;
            }
            else
            {
                return false;
            }
            return true;
        }
        internal DTO_HienHanh GetAcc(string ID)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                DTO_HienHanh acc = new DTO_HienHanh();
                var l1 = from a in db.Staffs
                         join b in db.Accounts on
                         a.accountId equals b.accountId
                         join c in db.AccountTypes on
                         b.accountTypeId equals c.accountTypeId
                         join d in db.StaffStates on
                         a.staffStateId equals d.staffStateId
                         where (a.staffId.Equals(ID))
                         select new DTO_HienHanh()
                         {
                             AccountID = a.accountId,
                             ChucVu = c.accountTypeName,
                             SDT = a.staffTelephoneNumber,
                             StaffID = a.staffId,
                             Ten = a.staffName,
                             TrangThai = d.staffState1
                         };
                acc = l1.FirstOrDefault();
                Staff l2 = db.Staffs.Where(p => p.staffId.Equals(ID)).FirstOrDefault();
                l2.staffStateId = 1;
                db.SaveChanges();
                return acc;
            }
        }
        public void SetTrangThai()
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                Staff l1 = db.Staffs.Where(p => p.staffId.Equals(acc.StaffID)).FirstOrDefault();
                l1.staffStateId = 2;
                db.SaveChanges();
            }
        }
    }
}
