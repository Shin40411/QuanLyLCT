using DotNetNuke.Entities.Users;
using DotNetNuke.Web.Api;
using LCT;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lct
{
    public class CanBoController
    {
        lctDataContext db = new lctDataContext();
        UserInfo _currentUser = UserController.Instance.GetCurrentUserInfo();

        public List<ModelCanBo> getCanBo()
        {

                int Userid = _currentUser.UserID;
                var objND = db.NguoiDungInfos.Where(x => x.UserID == _currentUser.UserID).FirstOrDefault();
                int stt = 1;
                List<ModelCanBo> lstcb = new List<ModelCanBo>();
                if (_currentUser.IsInRole("NGUOIDUNG") && !_currentUser.IsSuperUser)
                {
                    List<CanBo> canBos = db.CanBos.Where(x => x.Donvi_ID == objND.ID_Donvi).OrderByDescending(x => x.ID_Canbo).OrderBy(x => x.Donvi_ID).ToList();

                    foreach (var cb in canBos)
                    {
                        ModelCanBo modelCanBo = new ModelCanBo();
                        modelCanBo.STT = Convert.ToInt32(stt++);
                        modelCanBo.ID_Canbo = cb.ID_Canbo;
                        modelCanBo.HoVaten = cb.Hovaten;
                        modelCanBo.Email = cb.Email;
                        modelCanBo.Sodienthoai = cb.Sodienthoai;
                        modelCanBo.Phongban = cb.Phongban;
                        modelCanBo.Chucvu = cb.Chucvu;
                        modelCanBo.Ghichu = cb.Ghichu;
                        modelCanBo.TenDV = cb.DonVi.Ten_Donvi;
                        modelCanBo.Donvi_ID = cb.DonVi.ID_Donvi;
                        lstcb.Add(modelCanBo);
                    }
                }
                else
                {
                    List<CanBo> canBos = db.CanBos.OrderByDescending(x => x.ID_Canbo).OrderBy(x => x.Donvi_ID).ToList();

                    foreach (var cb in canBos)
                    {
                        ModelCanBo modelCanBo = new ModelCanBo();
                        modelCanBo.STT = Convert.ToInt32(stt++);
                        modelCanBo.ID_Canbo = cb.ID_Canbo;
                        modelCanBo.HoVaten = cb.Hovaten;
                        modelCanBo.Email = cb.Email;
                        modelCanBo.Sodienthoai = cb.Sodienthoai;
                        modelCanBo.Phongban = cb.Phongban;
                        modelCanBo.Chucvu = cb.Chucvu;
                        modelCanBo.Ghichu = cb.Ghichu;
                        modelCanBo.TenDV = cb.DonVi.Ten_Donvi;
                        modelCanBo.Donvi_ID = cb.DonVi.ID_Donvi;
                        lstcb.Add(modelCanBo);
                    }
                }
            return lstcb;
        }

        public List<ModelCanBo> getCanBobyID(int dID)
        {
      
                List<CanBo> canBos = db.CanBos.Where(x => x.Donvi_ID == dID).ToList();
                List<ModelCanBo> lstcb = new List<ModelCanBo>();
                foreach (var cb in canBos)
                {
                    ModelCanBo modelCanBo = new ModelCanBo();
                    modelCanBo.ID_Canbo = cb.ID_Canbo;
                    modelCanBo.HoVaten = cb.Hovaten;
                    modelCanBo.Email = cb.Email;
                    modelCanBo.Sodienthoai = cb.Sodienthoai;
                    modelCanBo.Phongban = cb.Phongban;
                    modelCanBo.Chucvu = cb.Chucvu;
                    modelCanBo.Ghichu = cb.Ghichu;
                    modelCanBo.TenDV = cb.DonVi.Ten_Donvi;
                    modelCanBo.Donvi_ID = cb.DonVi.ID_Donvi;
                    lstcb.Add(modelCanBo);
                }
            return lstcb;
        }

        public ModelCanBo getCanBochitiet(int cID)
        {
                var chitietcb = db.CanBos.Where(x => x.ID_Canbo == cID).FirstOrDefault();
                ModelCanBo modelCan = new ModelCanBo();
                if (chitietcb != null)
                {
                    modelCan.ID_Canbo = chitietcb.ID_Canbo;
                    modelCan.HoVaten = chitietcb.Hovaten;
                    modelCan.Email = chitietcb.Email;
                    modelCan.Sodienthoai = chitietcb.Sodienthoai;
                    modelCan.Phongban = chitietcb.Phongban;
                    modelCan.Chucvu = chitietcb.Chucvu;
                    modelCan.Ghichu = chitietcb.Ghichu;
                    modelCan.TenDV = chitietcb.DonVi.Ten_Donvi;
                    modelCan.Donvi_ID = Convert.ToInt32(chitietcb.Donvi_ID);
                }

            return modelCan;
        }

        public bool addCanBo(ModelCanBo objCB)
        {
            bool status = false;
            if (objCB != null)
                {
                    CanBo canbo = new CanBo();
                    canbo.Hovaten = objCB.HoVaten;
                    canbo.Email = objCB.Email;
                    canbo.Sodienthoai = objCB.Sodienthoai;
                    canbo.Donvi_ID = objCB.Donvi_ID;
                    canbo.Chucvu = objCB.Chucvu;
                    canbo.Phongban = objCB.Phongban;
                    canbo.Ghichu = objCB.Ghichu;
                    db.CanBos.InsertOnSubmit(canbo);
                    db.SubmitChanges();
                    status = true;
            }
            return status;
        }

        public bool updateCanBo(ModelCanBo objCB)
        {
            bool status = false;
            if (objCB != null)
                {
                    CanBo canbo = db.CanBos.Where(x => x.ID_Canbo == objCB.ID_Canbo).FirstOrDefault();
                    canbo.ID_Canbo = objCB.ID_Canbo;
                    canbo.Hovaten = objCB.HoVaten;
                    canbo.Email = objCB.Email;
                    canbo.Sodienthoai = objCB.Sodienthoai;
                    canbo.Donvi_ID = objCB.Donvi_ID;
                    canbo.Chucvu = objCB.Chucvu;
                    canbo.Phongban = objCB.Phongban;
                    canbo.Ghichu = objCB.Ghichu;
                    db.SubmitChanges();
                    status = true;
                }
            return status;
        }

        public bool deleteCanBo(int cID)
        {
            bool status = false;
            if (cID != 0)
            {
                var lct = db.LichCongTacs.Where(x => x.CanBo_ID == cID).Count();
                if (lct == 0)
                {
                    var Cb = db.CanBos.Where(x => x.ID_Canbo == cID).FirstOrDefault();
                    if (Cb != null)
                    {
                        db.CanBos.DeleteOnSubmit(Cb);
                        db.SubmitChanges();
                        status = true;

                    }
                }
            }
            return status;
        }
    }
}
