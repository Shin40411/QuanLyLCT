using LCT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for DonviController
/// </summary>
namespace lct
{
    public class DonviController
    {
        lctDataContext db = new lctDataContext();
        public List<DonviInfo> GetListDonvi()
        {
            List<DonVi> donvi = db.DonVis.ToList();
            List<DonviInfo> donviInfo = new List<DonviInfo>();
            foreach (var i in donvi)
            {
                DonviInfo dv = new DonviInfo();
                dv.Ten_Donvi = i.Ten_Donvi;
                dv.Nhom_Donvi = i.Nhom_Donvi;
                dv.Mota_Donvi = i.Mota_Donvi;
                dv.Thutu_Donvi = i.Thutu_Donvi.ToString();
                donviInfo.Add(dv);
            }

            return donviInfo;
        }
        public DonviInfo GetDonvi(int ID)
        {
            DonviInfo dv = new DonviInfo();
            dv = GetListDonvi().Where(x => x.ID_Donvi == ID).FirstOrDefault();

            return dv;
        }
        
    }
}

