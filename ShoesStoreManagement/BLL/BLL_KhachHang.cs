using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI;

namespace ShoesStoreManagement.BLL
{
    class BLL_KhachHang
    {
        public Mainform mF = (Mainform)Mainform.ActiveForm;// lay mainform dang ton tai
        private static BLL_KhachHang _Instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set
            {
                
            }
        }
        internal string SetIDKhachHangAddForm()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var l1 = db.Customers.ToList();
            int count = l1.Count;
            count++;
            int sochuso = count.ToString().ToCharArray().Count();
            string iD = "CM";
            while(7 - sochuso > 0)
            {
                iD += "0";
                sochuso++;
            }
            iD += count.ToString();
            return iD;
        }

        public BLL_KhachHang()
        {
            
        }
        public List<DTO_KhachHang> GetAllKhachHang()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var listCustomer = db.Customers.Select(p => new DTO_KhachHang {
                IdKhachHang = p.customerId,
                TenKhachHang = p.customerName,
                SDT = p.customerTelephoneNumber,
                Gender = (bool)p.customerGender,
                Birthday = (DateTime)p.customerBirthday}).ToList();
            return listCustomer;
        }

        internal void EditKhachHang(Customer customer)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            Customer cus = db.Customers.Find(customer.customerId);
            cus.customerName = customer.customerName;
            cus.customerTelephoneNumber = customer.customerTelephoneNumber;
            cus.customerGender = customer.customerGender;
            cus.customerBirthday = customer.customerBirthday;
            db.SaveChanges();
        }

        public void DeleteKhachHang(List<string> customerIds)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            foreach(string customerId in customerIds)
            {
                Customer c = db.Customers.Where(p => p.customerId == customerId).FirstOrDefault();
                db.Customers.Remove(c);
                db.SaveChanges();
            }
        }
        public string GetInfoKhachHangByIdOrNameOrSDTForSearch(string sSearch)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            string s = "";
            Customer c;
            if (db.Customers.Where(p => p.customerId == sSearch).Count()== 1)
            {
                c = db.Customers.Where(p => p.customerId == sSearch).FirstOrDefault();
                s += "Họ và tên: " + c.customerName + "\n";
                s += "Ngày sinh: " + ((DateTime)c.customerBirthday).ToShortDateString() + "\n";
                s += "Số điện thoại: " + c.customerTelephoneNumber + "\n";
                s += "Giới tính: " + (c.customerGender == true ? "Nam" : "Nữ") + "\n";
                return s;
            }
            else if (db.Customers.Where(p => p.customerTelephoneNumber == sSearch).Count() == 1)
            {
                c = db.Customers.Where(p => p.customerTelephoneNumber == sSearch).FirstOrDefault();
                s += "Họ và tên: " + c.customerName + "\n";
                s += "Ngày sinh: " + ((DateTime)c.customerBirthday).ToShortDateString() + "\n";
                s += "Số điện thoại: " + c.customerTelephoneNumber + "\n";
                s += "Giới tính: " + (c.customerGender == true ? "Nam" : "Nữ") + "\n";
                return s;
            }
            else if (db.Customers.Where(p => p.customerName == sSearch).Count() > 0)
            {
                foreach(var customer in db.Customers.Where(p => p.customerName == sSearch).ToList())
                {
                    s += "Họ và tên: " + customer.customerName + "\n";
                    s += "Ngày sinh: " + ((DateTime)customer.customerBirthday).ToShortDateString() + "\n";
                    s += "Số điện thoại: " + customer.customerTelephoneNumber + "\n";
                    s += "Giới tính: " + (customer.customerGender == true ? "Nam" : "Nữ") + "\n";
                }
                return s;
            }else
            {
                return "Không tồn tại thông tin";
            }
            
        }

        internal List<DTO_KhachHang> SapXep(string text,List<DTO_KhachHang> lKH)
        {

            switch (text)
            {
                case "Sắp xếp theo mã khách hàng":
                    lKH = lKH.OrderBy(kh => kh.IdKhachHang).ToList();
                    break;
                case "Sắp xếp theo tên khách hàng":
                    lKH = lKH.OrderBy(kh => kh.TenKhachHang).ToList();
                    break;
                case "Sắp xếp theo giới tính":
                    lKH = lKH.OrderBy(kh => kh.Gender).ToList();
                    break;
                case "Sắp xếp theo ngày sinh":
                    lKH = lKH.OrderBy(kh => kh.Birthday).ToList();
                    break;
                case "Sắp xếp theo số điện thoại":
                    lKH = lKH.OrderBy(kh => kh.SDT).ToList();
                    break;
            }
            return lKH;
                


        }

        internal List<string> GetCustomerProperties()
        {
            List<string> items = new List<string>();
            foreach (var i in typeof(DTO_KhachHang).GetProperties())
            {
                items.Add(i.Name.ToString());
            }
            return items;
        }

        internal Customer GetInfoKhachHangByIdOrNameOrSDTForEdit(string text)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var listTheoId = db.Customers.Where(p => p.customerId == text).ToList();
            var listTheoName = db.Customers.Where(p => p.customerName == text).ToList();
            var listTheoSDT = db.Customers.Where(p => p.customerTelephoneNumber == text).ToList();
            Customer cus = new Customer();
            if (listTheoId.Count == 1)
            {
                cus.customerName = listTheoId.FirstOrDefault().customerName;
                cus.customerTelephoneNumber = listTheoId.FirstOrDefault().customerTelephoneNumber;
                cus.customerBirthday = listTheoId.FirstOrDefault().customerBirthday;
                cus.customerGender = listTheoId.FirstOrDefault().customerGender;
                cus.customerId = text;
                return cus;
            }
            else if(listTheoName.Count == 1)
            {
                cus.customerName = text;
                cus.customerTelephoneNumber = listTheoName.FirstOrDefault().customerTelephoneNumber;
                cus.customerBirthday = listTheoName.FirstOrDefault().customerBirthday;
                cus.customerGender = listTheoName.FirstOrDefault().customerGender;
                cus.customerId = listTheoName.FirstOrDefault().customerId;
                return cus;
            }
            else if(listTheoSDT.Count == 1)
            {
                cus.customerName = listTheoSDT.FirstOrDefault().customerName;
                cus.customerTelephoneNumber = listTheoSDT.FirstOrDefault().customerTelephoneNumber;
                cus.customerBirthday = listTheoSDT.FirstOrDefault().customerBirthday;
                cus.customerGender = listTheoSDT.FirstOrDefault().customerGender;
                cus.customerId = listTheoSDT.FirstOrDefault().customerId;
                return cus;
            }
            else
            {
                return null;
            }
            
        }
        public Customer getKhachHangBySDT(string sdt)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();

            //caubang
            var listTheoId = db.Customers.Where(p => p.customerTelephoneNumber == sdt).ToList();
            return listTheoId.FirstOrDefault();
        }
        public bool kiemtraSDT(string sdt)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();

            //caubang
            var listTheoId = db.Customers.Where(p => p.customerTelephoneNumber == sdt).ToList();
            if (listTheoId.Count >= 1)
            {
                return true;
            }
            return false;
        }

        public void AddKhachHang(Customer customer)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var listTheoId = db.Customers.Where(p =>p.customerTelephoneNumber == customer.customerTelephoneNumber).ToList();
            if (listTheoId.Count == 1)
            {
                
            }
            else
            {
               
                db.Customers.Add(customer);

            }
            db.SaveChanges();
        }
        public Customer getCustomer(Customer customer)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();

            //caubang
            var listTheoId = db.Customers.Where(p => p.customerName == customer.customerName && p.customerTelephoneNumber == customer.customerTelephoneNumber).ToList();

            return listTheoId.FirstOrDefault();
        }
        public int CheckSDT(string sdt)
        {
            using(ShoesStoreEntities db = new ShoesStoreEntities())
            {
                var l1 = db.Customers.Where(p => p.customerTelephoneNumber.Equals(sdt)).Count();
                return l1;
            }
        }
    }
}
