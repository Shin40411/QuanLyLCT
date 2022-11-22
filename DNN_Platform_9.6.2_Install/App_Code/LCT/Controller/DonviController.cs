using DotNetNuke.Entities.Users;
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
        UserInfo _currentUser = UserController.Instance.GetCurrentUserInfo();
        public List<DonviInfo> GetListDonvi()
        {
            int stt = 1;
            List<DonVi> donvi = db.DonVis.OrderBy(x => x.Thutu_Donvi).ThenByDescending(x => x.ID_Donvi).ToList();
            List<DonviInfo> donviInfo = new List<DonviInfo>();
            foreach (var i in donvi)
            {   
                DonviInfo dv = new DonviInfo();
                dv.STT_Donvi = stt++;
                dv.ID_Donvi = i.ID_Donvi;
                dv.Ten_Donvi = i.Ten_Donvi;
                dv.Nhom_Donvi = i.Nhom_Donvi;
                dv.Mota_Donvi = i.Mota_Donvi;
                dv.Thutu_Donvi = Convert.ToInt32(i.Thutu_Donvi);
                donviInfo.Add(dv);
            }

            return donviInfo;
        }
        public List<DonviInfo> GetListDonviByUser()
        {
            if (_currentUser.IsInRole("NGUOIDUNG") && !_currentUser.IsSuperUser)
            {
                int Userid = _currentUser.UserID;
                var objND = db.NguoiDungInfos.Where(x => x.UserID == _currentUser.UserID).FirstOrDefault();

                List<DonVi> donvi = db.DonVis.Where(x => x.ID_Donvi == objND.ID_Donvi).ToList();
                List<DonviInfo> donviInfo = new List<DonviInfo>();

                foreach (var i in donvi)
                {
                    DonviInfo dv = new DonviInfo();
                    dv.ID_Donvi = i.ID_Donvi;
                    dv.Ten_Donvi = i.Ten_Donvi;
                    dv.Nhom_Donvi = i.Nhom_Donvi;
                    dv.Mota_Donvi = i.Mota_Donvi;
                    dv.Thutu_Donvi = Convert.ToInt32(i.Thutu_Donvi);
                    donviInfo.Add(dv);
                }
                return donviInfo;
            }
            else
            {
                List<DonVi> donvi = db.DonVis.ToList();
                List<DonviInfo> donviInfo = new List<DonviInfo>();
                foreach (var i in donvi)
                {
                    DonviInfo dv = new DonviInfo();
                    dv.ID_Donvi = i.ID_Donvi;
                    dv.Ten_Donvi = i.Ten_Donvi;
                    dv.Nhom_Donvi = i.Nhom_Donvi;
                    dv.Mota_Donvi = i.Mota_Donvi;
                    dv.Thutu_Donvi = Convert.ToInt32(i.Thutu_Donvi);
                    donviInfo.Add(dv);
                }
                return donviInfo;
            }
        }

        public DonviInfo GetDonvi(int ID)
        {
            DonviInfo dv = new DonviInfo();
            var obj = db.DonVis.Where(x => x.ID_Donvi == ID).FirstOrDefault();
            if (obj != null)
            {   
                dv.ID_Donvi = obj.ID_Donvi;
                dv.Ten_Donvi = obj.Ten_Donvi;
                dv.Nhom_Donvi = obj.Nhom_Donvi;
                dv.Mota_Donvi = obj.Mota_Donvi;
                dv.Thutu_Donvi = Convert.ToInt32( obj.Thutu_Donvi);
            }
            return dv;
        }
        public bool UpdateDonvi(DonviInfo dvi)
        {
            bool status = false;

            if (dvi != null)
            {
                if (dvi.ID_Donvi != 0)
                {
                    var obj = db.DonVis.Where(x => x.ID_Donvi == dvi.ID_Donvi).FirstOrDefault();
                    obj.Ten_Donvi = dvi.Ten_Donvi;
                    obj.Nhom_Donvi = dvi.Nhom_Donvi;
                    obj.Mota_Donvi = dvi.Mota_Donvi;
                    obj.Thutu_Donvi = Convert.ToInt32(dvi.Thutu_Donvi);
                    db.SubmitChanges();
                }
                else
                {
                    DonVi obj = new DonVi();
                    obj.Ten_Donvi = dvi.Ten_Donvi;
                    obj.Nhom_Donvi = dvi.Nhom_Donvi;
                    obj.Mota_Donvi = dvi.Mota_Donvi;
                    obj.Thutu_Donvi = Convert.ToInt32(dvi.Thutu_Donvi);
                    db.DonVis.InsertOnSubmit(obj);
                    db.SubmitChanges();
                }

                status = true;
            }
            return status;

            
        }

        public bool DeleteDonvi(int ID)
        {
            bool status = false; 
            if (ID != 0)
            {
                var lct = db.LichCongTacs.Where(x => x.Donvi_ID == ID).Count();
                if(lct == 0)
                {
                    var Dv = db.DonVis.Where(x => x.ID_Donvi == ID).FirstOrDefault();
                    if (Dv != null)
                    {
                        db.DonVis.DeleteOnSubmit(Dv);
                        db.SubmitChanges();
                        status = true;
                    }
                }
                
            }
            return status;
        }
    } 
}

