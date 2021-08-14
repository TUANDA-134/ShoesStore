using ShoesStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.BLL
{
    class BLL_BaoCao
    {
        private static BLL_BaoCao _Instance;
        public static BLL_BaoCao Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_BaoCao();
                return _Instance;
            }
            set
            {

            }
        }
        public List<DTO_DetailBill> GetAllDetailBill()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            List<DTO_DetailBill> listdbill = (from p in db.DetailedBills
                                              select new DTO_DetailBill
                                              {
                                                  billID = p.billId,
                                                  detailedillID = p.detailedBillId,
                                                  detailedShoesID = p.detailedShoesId,
                                                  shoesCost = (float)p.shoesCost,
                                                  shoesOrderedAmount = (int)p.shoesOrderedAmount
                                              }).ToList();
            return listdbill;
        }
        public List<DTO_DetailBillView> GetAllDetailBillView(string idbill)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            List<DTO_DetailBillView> list = new List<DTO_DetailBillView>();

            foreach (DTO_DetailBill p in GetAllDetailBill())
            {
                if (p.billID == idbill)
                {
                    DTO_DetailBillView temp = new DTO_DetailBillView();
                    temp.detailedShoesID = p.detailedShoesID;
                    temp.shoesCost = p.shoesCost;
                    temp.shoesOrderedAmount = p.shoesOrderedAmount;

                    foreach (Sho sh in db.Shoes.ToList())
                    {
                        if (p.detailedShoesID.Substring(0, 6) == sh.shoesId)
                        {
                            temp.shoesName = sh.shoesName;
                            break;
                        }
                    }
                    list.Add(temp);

                }
            }

            return list;


        }
        public DateTime getEstablish(string idBill)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            //DateTime extablish;
            var bill = db.Bills.Where(p => p.billId == idBill)
                .Select(p => new
                {
                    p.billEstablishedDate
                });

            return Convert.ToDateTime(bill.FirstOrDefault());
        }
        public float GetTT(string idbill)
        {
            float tongtien = 0;
            foreach (DTO_DetailBill p in GetAllDetailBill())
            {
                if (idbill == p.billID)
                    tongtien += p.shoesCost * p.shoesOrderedAmount;
            }
            return tongtien;
        }

        public List<DTO_BaoCaoView> GetListBCView(DateTime start, DateTime end, string txtSerach)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            List<DTO_BaoCaoView> list = db.Bills.Where(p => (p.billEstablishedDate >= start && p.billEstablishedDate <= end) && (p.Customer.customerName.Contains(txtSerach) || p.Staff.staffName.Contains(txtSerach) || p.billId == txtSerach)).Select(p => new DTO_BaoCaoView
            {
                IdBill = p.billId,
                NgayXuat = (DateTime)p.billEstablishedDate,
                TenKhachHang = p.Customer.customerName,
                TenNhanVien = p.Staff.staffName,
            }).ToList();
            foreach (DTO_BaoCaoView p in list)
            {
                p.TongTien = GetTT(p.IdBill);
            }
            return list;

        }
        public Customer getKhachhangByIdBill(string idBill)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var bill = db.Bills.Where(p => p.billId == idBill)
                .Select(p => new
                {
                    p.customerId
                }) ;
            var custom = db.Customers.Where(p => p.customerId == bill.FirstOrDefault().customerId);
            
            return custom.FirstOrDefault();
        }

        public List<DTO_BaoCaoView> Sort(List<DTO_BaoCaoView> listsort, string sortcase)
        {

            switch (sortcase)
            {
                case "Sắp xếp theo Tên Khách Hàng":
                    listsort.Sort((x, y) => {
                        string ten1 = BLL_BaoCao.Instance.daoten(x.TenKhachHang);
                        string ten2 = BLL_BaoCao.Instance.daoten(y.TenKhachHang);
                        return String.Compare(ten1, ten2);
                    });
                    break;
                case "Sắp xếp theo Tên Nhân Viên":
                    listsort.Sort((x, y) => {
                        string ten1 = BLL_BaoCao.Instance.daoten(x.TenNhanVien);
                        string ten2 = BLL_BaoCao.Instance.daoten(y.TenNhanVien);
                        return String.Compare(ten1, ten2);
                    });
                    break;
                case "Sắp xếp theo Ngày Xuất Hóa Đơn":
                    listsort = listsort.OrderBy(p => p.NgayXuat).ToList();
                    break;
                case "Sắp xếp theo Tổng tiền":
                    listsort = listsort.OrderBy(p => p.TongTien).ToList();
                    break;
                case "Sắp xếp theo Tổng tiền giảm":
                    listsort = listsort.OrderByDescending(p => p.TongTien).ToList();
                    break;
                case "Sắp xếp theo Ngày Xuất Hóa Đơn giảm":
                    listsort = listsort.OrderByDescending(p => p.NgayXuat).ToList();
                    break;
                default:
                    break;
            }
            return listsort;
        }
        public string daoten(string ten)
        {
            string[] spten = ten.Split(' ');
            ten = "";
            for (int i = spten.Length - 1; i >= 0; i--)
            {
                ten += spten[i] + " ";
            }
            return ten;
        }
        public string getTSLBan(string IdBill)
        {
            int tongsl = 0;
            foreach (DTO_DetailBillView p in BLL_BaoCao.Instance.GetAllDetailBillView(IdBill))
            {
                tongsl += p.shoesOrderedAmount;
            }
            return tongsl.ToString();
            List<string> t = new List<string>();
        }
    }
}
