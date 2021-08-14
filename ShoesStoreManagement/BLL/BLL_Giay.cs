using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_SanPham;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.BLL
{
    class BLL_Giay
    {
        private static BLL_Giay _Instance;

        public static BLL_Giay Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Giay();
                }
                return _Instance;

            }

            private set => _Instance = value;
        }
        string path = BLL_DuongDan.Instance.ImagePath();
        public List<DTO_CBBLoaiGiay> GetALL_ShoesTypes()
        {
         
            ShoesStoreEntities db = new ShoesStoreEntities();
            return db.ShoesTypes.Select(p => new DTO_CBBLoaiGiay()
            {
                ShoesTypeId = p.shoesTypeId,
                ShoesType = p.shoesType1

            }).ToList();

        }
        public string GetMa(string maSP)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();

            string i = ((db.Shoes.Where(p => p.shoesId.Contains(maSP))).Select(p => p.shoesId).Count()).ToString();
            i = (Convert.ToInt32(i) + 1).ToString();
            while (i.Length < 4)
            {
                i = "0" + i;
            }
            return maSP + i;


        }
        public DetailedSho GetDetailedShoes(string s)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            return db.DetailedShoes.Where(p => p.detailedShoesId.Equals(s)).FirstOrDefault();
        }
        public List<DTO_CBBMaGiay> MaGiay()
        {
            List<DTO_CBBMaGiay> MaGiay = new List<DTO_CBBMaGiay>();
            ShoesStoreEntities db = new ShoesStoreEntities();
            return db.Shoes.Select(p => new DTO_CBBMaGiay()
            {
                MaGiay = p.shoesId

            }).ToList();
        }
        public void AddSho(Sho s)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                Sho test = db.Shoes.Where(d => d.shoesId.Equals(s.shoesId)).FirstOrDefault();
                if (test == null)
                {
                    db.Shoes.Add(s);
                }
                else
                {
                    test.shoesCost = s.shoesCost;
                    test.shoesDescription = s.shoesDescription;
                }
                db.SaveChanges();
            }
        }

        public int GetMaDetailedShoes(String s)
        {
            ShoesStoreEntities db = new ShoesStoreEntities();
            return db.DetailedShoes.Where(p => p.shoesId.Equals(s)).Count();
        }
        public String GetMaDetailedShoesToString(String maGiay, int n)
        {
            String ma = n.ToString();
            while (ma.Length < 3)
            {
                ma = "0" + ma;
            }
            return maGiay + ma;
        }
        public void AddMauSize(ucSP mauSize, Sho s, String color)
        {
            List<DTO_KichThuoc> kThuoc = mauSize.kichThuoc1();
            ShoesStoreEntities db = new ShoesStoreEntities();
            int n = GetMaDetailedShoes(s.shoesId);
            DetailedSho detailSho;
            for (int i = 0; i < kThuoc.Count; i++)
            {
                detailSho = new DetailedSho();
                detailSho.detailedShoesId = GetMaDetailedShoesToString(s.shoesId, n + i + 1);
                detailSho.shoesColor = color;
                detailSho.shoesId = s.shoesId;
                detailSho.shoesQuantity = kThuoc[i].SoLuong;
                detailSho.shoesSize = kThuoc[i].Size;
                db.DetailedShoes.Add(detailSho);
                mauSize.Luu(detailSho.detailedShoesId);
                db.SaveChanges();
            }
        }
        public Sho GetThongTinGiay(string maGiay)
        {
            Sho giay = null;
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                giay = db.Shoes.Where(p => p.shoesId.Equals(maGiay)).FirstOrDefault();
                return giay;
            }
        }
        public List<DTO_KichThuoc> GetKichThuocTheoMau(string mau, string maGiay)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                List<DTO_KichThuoc> listKichThuoc = new List<DTO_KichThuoc>();
                List<DetailedSho> sanPham = null;
                sanPham = db.DetailedShoes.Where(p => p.shoesId.Equals(maGiay)).Where(d => d.shoesColor.Equals(mau)).ToList();
                if (sanPham != null)
                {
                    for (int i = 0; i < sanPham.Count; i++)
                    {
                        DTO_KichThuoc kichThuoc = new DTO_KichThuoc();
                        kichThuoc.Size = (float)sanPham[i].shoesSize;
                        kichThuoc.SoLuong = Convert.ToInt32(sanPham[i].shoesQuantity);
                        listKichThuoc.Add(kichThuoc);
                    }
                }
                return listKichThuoc;
            }
        }
        public List<String> CountMau(string s)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                var l1 = db.DetailedShoes.Where(p => p.shoesId.Equals(s));
                List<String> mau = l1.Select(d => d.shoesColor).Distinct().ToList();
                return mau;
            }
        }
        public string GetMaSPDauTien(string maGiay, string mau)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                return db.DetailedShoes.Where(p => p.shoesId.Equals(maGiay) && p.shoesColor.Equals(mau)).FirstOrDefault().detailedShoesId;
            }
        }
        public List<DetailedSho> TimKiem(List<string> mauSac, List<string> size, string ma, int gia, string hang, string loaiGiay, string tenGiay)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                var l1 = db.DetailedShoes.ToList();
                List<DetailedSho> l2 = new List<DetailedSho>();//ma
                if (!ma.Equals(""))
                {
                    for (int i = 0; i < l1.Count; i++)
                    {
                        if (ma.ToLower().Equals(l1[i].shoesId.ToLower()) || ma.ToLower().Equals(l1[i].detailedShoesId.ToLower()))
                        {
                            l2.Add(l1[i]);
                        }
                    }
                }
                else
                {
                    l2 = l1;
                }
                List<DetailedSho> l3 = new List<DetailedSho>();//hang
                if (hang.Equals(""))
                {
                    l3 = l2;
                }
                else
                {
                    for (int i = 0; i < l2.Count; i++)
                    {
                        if (l2[i].Sho.shoesBrand.ToLower().Contains(hang.ToLower()))
                        {
                            l3.Add(l2[i]);
                        }
                    }
                }
                List<DetailedSho> l4 = new List<DetailedSho>();//gia
                for (int i = 0; i < l3.Count; i++)
                {
                    switch (gia)
                    {
                        case 0:
                            l4.Add(l3[i]);
                            break;
                        case 1:
                            if (l3[i].Sho.shoesCost <= 100)
                            {
                                l4.Add(l3[i]);
                            }
                            break;
                        case 2:
                            if (l3[i].Sho.shoesCost >= 100 && l3[i].Sho.shoesCost <= 150)
                            {
                                l4.Add(l3[i]);
                            }
                            break;
                        case 3:
                            if (l3[i].Sho.shoesCost >= 150 && l3[i].Sho.shoesCost <= 200)
                            {
                                l4.Add(l3[i]);
                            }
                            break;
                        case 4:
                            if (l3[i].Sho.shoesCost >= 200 && l3[i].Sho.shoesCost <= 250)
                            {
                                l4.Add(l3[i]);
                            }
                            break;
                        case 6:
                            if (l3[i].Sho.shoesCost >= 250)
                            {
                                l4.Add(l3[i]);
                            }
                            break;
                    }
                }
                List<DetailedSho> l5 = new List<DetailedSho>();//mauSac
                if (mauSac.Count > 0)
                {
                    for (int i = 0; i < l4.Count; i++)
                    {
                        for (int j = 0; j < mauSac.Count; j++)
                        {
                            if (l4[i].shoesColor.ToLower().Contains(mauSac[j].ToLower()))
                            {
                                l5.Add(l4[i]);
                            }
                        }
                    }
                }
                else
                {
                    l5 = l4;
                }
                List<DetailedSho> l6 = new List<DetailedSho>();//size
                if (size.Count > 0)
                {
                    for (int i = 0; i < l5.Count; i++)
                    {
                        for (int j = 0; j < size.Count; j++)
                        {
                            if (l5[i].shoesSize.ToString().Equals(size[j]))
                            {
                                l6.Add(l5[i]);
                            }
                        }
                    }
                }
                else
                {
                    l6 = l5;
                }
                List<DetailedSho> l7 = new List<DetailedSho>();//loaigiay
                if (loaiGiay.Equals(""))
                {
                    l7 = l6;
                }
                else
                {
                    for (int i = 0; i < l6.Count; i++)
                    {
                        if (l6[i].Sho.ShoesType.shoesTypeId.Equals(loaiGiay))
                        {
                            l7.Add(l6[i]);
                        }
                    }
                }
                List<DetailedSho> l8 = new List<DetailedSho>();//tenGiay
                if (tenGiay.Equals(""))
                {
                    l8 = l7;
                }
                else
                {
                    for (int i = 0; i < l7.Count; i++)
                    {
                        if (l7[i].Sho.shoesName.Contains(tenGiay))
                        {
                            l8.Add(l7[i]);
                        }
                    }
                }
                return l8;
            }
        }
        public void CapNhatGiay(List<DTO_KichThuoc> kThuocCapNhat, string mauSac, string ID, string pathAnh)
        {
            using (ShoesStoreEntities db = new ShoesStoreEntities())
            {
                List<DetailedSho> dts = null;
                for (int i = 0; i < kThuocCapNhat.Count; i++)
                {
                    dts = db.DetailedShoes.Where(p => p.shoesColor.Equals(mauSac) && p.shoesId.Equals(ID)).ToList();
                    DetailedSho dtsho = dts.Where(p => p.shoesSize.ToString().Equals(kThuocCapNhat[i].Size.ToString())).FirstOrDefault();
                    if (dtsho != null)
                    {
                        dtsho.shoesQuantity = kThuocCapNhat[i].SoLuong;
                    }
                    else
                    {
                        string ma = ID;
                        int n = GetMaDetailedShoes(ma);
                        DetailedSho spmoi = new DetailedSho();
                        spmoi.detailedShoesId = GetMaDetailedShoesToString(ma, n + 1);
                        spmoi.shoesColor = mauSac;
                        spmoi.shoesId = ma;
                        spmoi.shoesQuantity = kThuocCapNhat[i].SoLuong;
                        spmoi.shoesSize = kThuocCapNhat[i].Size;
                        db.DetailedShoes.Add(spmoi);
                        File.Copy(pathAnh, path + spmoi.detailedShoesId + ".png");
                    }
                    db.SaveChanges();
                }

            }
        }
    }
}
