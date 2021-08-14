using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongBao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.BLL
{
    class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        public List<DTO_Shoes> listShoe;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private BLL_HoaDon()
        {
            listShoe = new List<DTO_Shoes>();
        }
        public DTO_Shoes getShoesbyId(string id)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var shoe = db.DetailedShoes.Where(p => p.detailedShoesId == id)
                .Select(p => new DTO_Shoes
                {
                    detailShoeId = p.detailedShoesId,
                    TenGiay = p.Sho.shoesName,
                    kieuGiay = p.Sho.shoesTypeId,
                    HangGiay = p.Sho.shoesBrand,
                    color = p.shoesColor,
                    size = (float)p.shoesSize,
                    soluong = (int)p.shoesQuantity,
                    gia = (float)p.Sho.shoesCost
                });
            return shoe.FirstOrDefault();
        }
        public DTO_Shoes kiemTraSoLuong(string id_detailed)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();


            var shoe = db.DetailedShoes.Where(p => p.detailedShoesId == id_detailed)
             .Select(p => new DTO_Shoes
             {
                 soluong = (int)p.shoesQuantity,
             });

            return shoe.FirstOrDefault();
        }
        public void GetDetailShoesID(string id_detailed, int sl)
        {

            ShoesStoreEntities db = new ShoesStoreEntities();
            var shoe = db.DetailedShoes.Where(p => p.detailedShoesId == id_detailed)
                .Select(p => new DTO_Shoes
                {
                    detailShoeId = p.detailedShoesId,
                    TenGiay = p.Sho.shoesName,
                    kieuGiay = p.Sho.shoesTypeId,
                    HangGiay = p.Sho.shoesBrand,
                    color = p.shoesColor,
                    size = (float)p.shoesSize,
                    soluong = sl,
                    gia =  (float)p.Sho.shoesCost
                });
            if (listShoe.Count == 0)
            {
                listShoe.Add(shoe.FirstOrDefault());
            }
            else
            {
                for (int i = 0; i < listShoe.Count; i++)
                {
                    if (listShoe[i].detailShoeId == id_detailed)
                    {
                        listShoe[i].soluong += sl;
                        break;
                    }
                    else
                    {
                        listShoe.Add(shoe.FirstOrDefault());
                        break;
                    }
                }
            }
        }
        public void setSLSanPham(bool t, int sl, string id)
        {
            for (int i = 0; i < listShoe.Count; i++)
            {
                if (listShoe[i].detailShoeId == id)
                {
                    listShoe[i].soluong = sl;
                    break;
                }
            }
        }
        public List<DTO_Shoes> GetListDetailShoesID()
        {
            return listShoe;
        }

        public string setIdBillAdd()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var l1 = db.Bills.ToList();
            int count = l1.Count;
            count++;
            int sochuso = count.ToString().ToCharArray().Count();
            string iD = "BL";
            while (8 - sochuso > 0)
            {
                iD += "0";
                sochuso++;
            }
            iD += count.ToString();
            return iD;
        }

        public string setIdDetailBillAdd()
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var l1 = db.DetailedBills.ToList();
            int count = l1.Count;
            string id = l1[count - 1].detailedBillId;
            int idbill = Convert.ToInt32(id.Substring(2, 8));
            idbill++;
            int sochuso = count.ToString().ToCharArray().Count();
            string iD = "DB";
            while (8 - sochuso > 0)
            {
                iD += "0";
                sochuso++;
            }
            iD += idbill.ToString();
            return iD;
        }
        public float TongTien(List<DTO_Shoes> l)
        {
            float tong = 0;
            foreach (DTO_Shoes i in l)
            {
                FormThongBao.Show(i.soluong.ToString() +" "+ i.gia.ToString());
                tong += i.gia * i.soluong;
            }
            return tong;
        }
        public void addBill(Bill b)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            db.Bills.Add(b);
            db.SaveChanges();
        }
        internal void addDetaiBill(DetailedBill b)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            db.DetailedBills.Add(b);
            db.SaveChanges();
        }
        public void deleteSV_BLL(List<string> ls)
        {


            foreach (string j in ls)
            {
                for (int i = 0; i < listShoe.Count; i++)
                {
                    if (listShoe[i].detailShoeId.Equals(j))
                    {
                        listShoe.RemoveAt(i);
                    }
                }
            }
        }
        public string ChuyenUrlforId(string url)
        {
            char a = (char)92;
            string[] str = url.Split(a);
            string[] id = str[str.Length - 1].Split('.');
            return id[0];
        }


        public void updateHoaDon(string idb, DateTime date)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            Bill list = db.Bills.Find(idb);
            list.billEstablishedDate = date;
            var detail = db.DetailedBills.Where(p => p.billId == idb);
            foreach (DetailedBill d in detail.ToList())
            {
                db.DetailedBills.Remove(d);
            }

            db.SaveChanges();

        }
        public bool checkBillInDB(string id)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            var listTheoId = db.Bills.Where(p => p.billId == id).ToList();
            if (listTheoId.Count == 1)
            {
                return true;
            }
            return false;

        }

    }
}
