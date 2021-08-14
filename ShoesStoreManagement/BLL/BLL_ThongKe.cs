using ShoesStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreManagement.BLL
{
    class BLL_ThongKe
    {
        private static BLL_ThongKe _Instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_ThongKe();
                return _Instance;
            }
            set
            {

            }
        }
        public float[] thongke(DateTime tn, DateTime dn)
        {

            List<DTO_BaoCaoView> list = BLL_BaoCao.Instance.GetListBCView(tn, dn, "");
            int month;
            float[] arr = new float[50];
            foreach (DTO_BaoCaoView p in list)
            {
                month = (int)p.NgayXuat.Month;
                arr[month] += (float)p.TongTien;
            }

            return arr;
        }
        public List<DTO_GiayXuat> gettop(DateTime tn, DateTime dn)
        {

            ShoesStoreEntities db = new ShoesStoreEntities();
            List<DTO_DetailBill> listdtb = db.DetailedBills.Where(p => p.Bill.billEstablishedDate >= tn && p.Bill.billEstablishedDate <= dn).Select(p => new DTO_DetailBill
            {
                billID = p.billId,
                detailedillID = p.detailedBillId,
                detailedShoesID = p.detailedShoesId,
                shoesCost = (float)p.shoesCost,
                shoesOrderedAmount = (int)p.shoesOrderedAmount
            }).ToList();
            List<DTO_GiayXuat> listgxuat = new List<DTO_GiayXuat>();
            listgxuat = (from p in db.Shoes
                         select new DTO_GiayXuat
                         {
                             detailedShoesID = p.shoesId,
                             NameShoes = p.shoesName,
                             soluong = 0
                         }).ToList();
            foreach (DTO_GiayXuat shoe in listgxuat)
            {
                foreach (DTO_DetailBill p in listdtb)
                {
                    if (shoe.detailedShoesID == p.detailedShoesID.Substring(0, 6))
                        shoe.soluong += p.shoesOrderedAmount;
                }
            }


            return listgxuat.OrderByDescending(p => p.soluong).ToList();

        }
        // Lấy số lượng của các loại giày đã bán.
        public List<DTO_LoaiGiayBan> gettopLG(DateTime tn, DateTime dn)
        {
            List<DTO_LoaiGiayBan> listlgb = new List<DTO_LoaiGiayBan>();
            ShoesStoreEntities db = new ShoesStoreEntities();
            List<DTO_DetailBill> listdtb = db.DetailedBills.Where(p => p.Bill.billEstablishedDate >= tn && p.Bill.billEstablishedDate <= dn).Select(p => new DTO_DetailBill
            {
                billID = p.billId,
                detailedillID = p.detailedBillId,
                detailedShoesID = p.detailedShoesId,
                shoesCost = (float)p.shoesCost,
                shoesOrderedAmount = (int)p.shoesOrderedAmount
            }).ToList();
            listlgb = (from p in db.ShoesTypes
                       select new DTO_LoaiGiayBan
                       {
                           shoesTypeId = p.shoesTypeId,
                           shoesType = p.shoesType1,
                           quantity = 0
                       }).ToList();
            foreach (Sho sh in db.Shoes)
            {
                foreach (DTO_DetailBill p in listdtb)
                {
                    if (sh.shoesId.ToString() == p.detailedShoesID.Substring(0, 6))
                    {
                        foreach (DTO_LoaiGiayBan lgb in listlgb)
                        {
                            if (sh.shoesTypeId.ToString() == lgb.shoesTypeId)
                                lgb.quantity++;
                        }
                    }
                }
            }
            double total = 0;
            foreach (DTO_LoaiGiayBan p in listlgb)
            {
                total += p.quantity;
            }
            foreach (DTO_LoaiGiayBan p in listlgb)
            {
                p.quantity = (p.quantity / total) * 100;
                p.quantity /= 100;
            }

            return listlgb.OrderByDescending(p => p.quantity).ToList();
        }

        public int tongsanpham()
        {
            int t = 0;
            DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, 1);
            List<DTO_GiayXuat> list = gettop(tn, DateTime.Now);
            foreach (DTO_GiayXuat p in list)
            {
                t += p.soluong;
            }
            return t;
        }
        public int tongdonhang()
        {
            DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, 1);
            return BLL_BaoCao.Instance.GetListBCView(tn, DateTime.Now, "").Count();

        }
        public float tongdoanhthu()
        {
            float sum = 0;
            DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, 1);
            foreach (DTO_BaoCaoView p in BLL_BaoCao.Instance.GetListBCView(tn, DateTime.Now, ""))
            {
                sum += p.TongTien;
            }
            return sum;
        }
    }
}
