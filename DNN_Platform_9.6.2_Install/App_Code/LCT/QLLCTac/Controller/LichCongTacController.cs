using DotNetNuke.Entities.Users;
using DotNetNuke.Web.Api;
using LCT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace lct
{
    public class LichCongTacController : DnnApiController
    {
        lctDataContext db = new lctDataContext();
        UserInfo _currentUser = UserController.Instance.GetCurrentUserInfo();

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage getLCT(string tungay, string denngay)
        {
            try
            {

                int Userid = _currentUser.UserID;
                var objND = db.NguoiDungInfos.Where(x => x.UserID == _currentUser.UserID).FirstOrDefault();

                DateTime startday = DateTime.ParseExact(tungay, "yyyy-MM-d", CultureInfo.InvariantCulture);
                DateTime endday = DateTime.ParseExact(denngay, "yyyy-MM-d", CultureInfo.InvariantCulture);
                int stt = 1;

                List<ModelLCT> lstlct = new List<ModelLCT>();
                if (_currentUser.IsInRole("NGUOIDUNG") && !_currentUser.IsSuperUser)
                {
                    List<LichCongTac> lichCongTacs = db.LichCongTacs.Where(x => x.Donvi_ID == objND.ID_Donvi).Where(x => x.Ngay_Giohop.Value.Date >= startday.Date && x.Ngay_Giohop.Value.Date <= endday.Date).OrderBy(x => x.Ngay_Giohop.Value.Date).OrderByDescending(x => x.ID_Lich).ToList();

                    foreach (var lich in lichCongTacs)
                    {
                        ModelLCT modelLCT = new ModelLCT();
                        modelLCT.STT = Convert.ToInt32(stt++);
                        modelLCT.ID_Lich = lich.ID_Lich;
                        modelLCT.Ngay_Giohop = (DateTime)lich.Ngay_Giohop;
                        modelLCT.Ngay = modelLCT.Ngay_Giohop.ToString("dd/MM/yyyy");
                        modelLCT.Gio = modelLCT.Ngay_Giohop.ToString("HH:mm");
                        modelLCT.TenDonVi = lich.CanBo.DonVi.Ten_Donvi;
                        modelLCT.Donvi_ID = Convert.ToInt32(lich.Donvi_ID);
                        modelLCT.NguoiChuTri = lich.CanBo.Hovaten;
                        modelLCT.CanBo_ID = Convert.ToInt32(lich.CanBo_ID);
                        modelLCT.DiaDiem = lich.Diadiem;
                        modelLCT.NoiDung = lich.Noidung;
                        modelLCT.ThanhPhan = lich.ThanhPhan;
                        lstlct.Add(modelLCT);
                    }
                }
                else
                {
                    List<LichCongTac> lichCongTacs = db.LichCongTacs.Where(x => x.Ngay_Giohop.Value.Date >= startday.Date && x.Ngay_Giohop.Value.Date <= endday.Date).OrderByDescending(x => x.Ngay_Giohop.Value.Date).ThenBy(x => x.ID_Lich).ToList();

                    foreach (var lich in lichCongTacs)
                    {
                        ModelLCT modelLCT = new ModelLCT();
                        modelLCT.STT = Convert.ToInt32(stt++);
                        modelLCT.ID_Lich = lich.ID_Lich;
                        modelLCT.Ngay_Giohop = (DateTime)lich.Ngay_Giohop;
                        modelLCT.Ngay = modelLCT.Ngay_Giohop.ToString("dd/MM/yyyy");
                        modelLCT.Gio = modelLCT.Ngay_Giohop.ToString("HH:mm");
                        modelLCT.TenDonVi = lich.CanBo.DonVi.Ten_Donvi;
                        modelLCT.Donvi_ID = Convert.ToInt32(lich.Donvi_ID);
                        modelLCT.NguoiChuTri = lich.CanBo.Hovaten;
                        modelLCT.CanBo_ID = Convert.ToInt32(lich.CanBo_ID);
                        modelLCT.DiaDiem = lich.Diadiem;
                        modelLCT.NoiDung = lich.Noidung;
                        modelLCT.ThanhPhan = lich.ThanhPhan;
                        lstlct.Add(modelLCT);
                    }
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(lstlct), System.Text.Encoding.UTF8, "application/json");
                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage getLichCongTac(string Day)
        {
            try
            {
                DateTime date_search = DateTime.ParseExact(Day, "d/MM/yyyy", CultureInfo.InvariantCulture);
                int stt = 1;
                List<LichCongTac> lichCongTacs = db.LichCongTacs.Where(x => x.Ngay_Giohop.Value.Date == date_search.Date).OrderByDescending(x => x.Donvi_ID).ThenBy(x=>x.CanBo_ID).ToList();
                List<ModelLCT> lstlct = new List<ModelLCT>();
                foreach (var lich in lichCongTacs)
                {
                    ModelLCT modelLCT = new ModelLCT();
                    modelLCT.STT = Convert.ToInt32(stt++);
                    modelLCT.ID_Lich = lich.ID_Lich;
                    modelLCT.Ngay_Giohop = (DateTime)lich.Ngay_Giohop;
                    modelLCT.Ngay = modelLCT.Ngay_Giohop.ToString("dd/MM/yyyy");
                    modelLCT.Gio = modelLCT.Ngay_Giohop.ToString("HH:mm");
                    modelLCT.TenDonVi = lich.CanBo.DonVi.Ten_Donvi;
                    modelLCT.Donvi_ID = Convert.ToInt32(lich.Donvi_ID);
                    modelLCT.NguoiChuTri = lich.CanBo.Hovaten;
                    modelLCT.CanBo_ID = Convert.ToInt32(lich.CanBo_ID);
                    modelLCT.DiaDiem = lich.Diadiem;
                    modelLCT.NoiDung = lich.Noidung;
                    modelLCT.ThanhPhan = lich.ThanhPhan;
                    lstlct.Add(modelLCT);
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(lstlct), System.Text.Encoding.UTF8, "application/json");
                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage getLCTchitiet(int lID)
        {
            try
            {
                    

                var chitietlich = db.LichCongTacs.Where(x => x.ID_Lich == lID).FirstOrDefault();

                ModelLCT lstlctCT = new ModelLCT();

                    if (chitietlich != null)
                    {
                        lstlctCT.ID_Lich = chitietlich.ID_Lich;
                        lstlctCT.Ngay = Convert.ToDateTime(chitietlich.Ngay_Giohop).ToString("yyyy-MM-dd");
                        lstlctCT.Gio = Convert.ToDateTime(chitietlich.Ngay_Giohop).ToString("HH:mm");
                        lstlctCT.TenDonVi = chitietlich.CanBo.DonVi.Ten_Donvi;
                        lstlctCT.Donvi_ID = Convert.ToInt32(chitietlich.Donvi_ID);
                        lstlctCT.NguoiChuTri = chitietlich.CanBo.Hovaten;
                        lstlctCT.CanBo_ID = Convert.ToInt32(chitietlich.CanBo_ID);
                        lstlctCT.DiaDiem = chitietlich.Diadiem;
                        lstlctCT.NoiDung = chitietlich.Noidung;
                        lstlctCT.ThanhPhan = chitietlich.ThanhPhan;
                    }

                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(lstlctCT), System.Text.Encoding.UTF8, "application/json");
                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage addLCT([FromBody] ModelLCT objLichCongTac)
        {
            try
            {

                if (objLichCongTac != null)
                {
                        LichCongTac lich = new LichCongTac();
                        lich.ID_Lich = objLichCongTac.ID_Lich;
                        string time = objLichCongTac.Ngay+"T"+objLichCongTac.Gio;
                        lich.Ngay_Giohop = Convert.ToDateTime(time);
                        lich.Donvi_ID = objLichCongTac.Donvi_ID;
                        lich.CanBo_ID = objLichCongTac.CanBo_ID;
                        lich.Diadiem = objLichCongTac.DiaDiem;
                        lich.Noidung = objLichCongTac.NoiDung;
                        lich.ThanhPhan = objLichCongTac.ThanhPhan;
                        db.LichCongTacs.InsertOnSubmit(lich);
                        db.SubmitChanges();
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(objLichCongTac), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage updateLCT([FromBody] ModelLCT objLichCongTac)
        {
            try
            {

                if (objLichCongTac != null)
                {
                    LichCongTac lichCongTac = db.LichCongTacs.Where(x => x.ID_Lich == objLichCongTac.ID_Lich).FirstOrDefault();
                    lichCongTac.ID_Lich = objLichCongTac.ID_Lich;
                    string time = objLichCongTac.Ngay+"T"+objLichCongTac.Gio;
                    lichCongTac.Ngay_Giohop = Convert.ToDateTime(time);
                    lichCongTac.Donvi_ID = objLichCongTac.Donvi_ID;
                    lichCongTac.CanBo_ID = objLichCongTac.CanBo_ID;
                    lichCongTac.Diadiem = objLichCongTac.DiaDiem;
                    lichCongTac.Noidung = objLichCongTac.NoiDung;
                    lichCongTac.ThanhPhan = objLichCongTac.ThanhPhan;
                    db.SubmitChanges();
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(objLichCongTac), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }


        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage deleteLCT(int lID)
        {
            try
            {
                var obj = db.LichCongTacs.Where(x => x.ID_Lich == lID).FirstOrDefault();
                db.LichCongTacs.DeleteOnSubmit(obj);
                db.SubmitChanges();

                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(obj), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }
        public class RouteMapper : IServiceRouteMapper
        {
            public void RegisterRoutes(IMapRoute mapRouteManager)
            {
                mapRouteManager.MapHttpRoute("lct", "default", "{controller}/{action}", new[] { "lct" });
            }
        }
    }
}
