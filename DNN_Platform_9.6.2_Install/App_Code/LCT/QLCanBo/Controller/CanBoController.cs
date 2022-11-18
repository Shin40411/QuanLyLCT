using DotNetNuke.Web.Api;
using LCT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace lct
{
    public class CanBoController : DnnApiController
    {
        lctDataContext db = new lctDataContext();
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage getCanBo()
        {
            try
            {
                int stt = 1;
                List<CanBo> canBos = db.CanBos.OrderByDescending(x=>x.ID_Canbo).ToList();
                List<ModelCanBo> lstcb = new List<ModelCanBo>();

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
                    lstcb.Add(modelCanBo);
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(lstcb), System.Text.Encoding.UTF8, "application/json");
                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        public HttpResponseMessage getCanBochitiet(int cID)
        {
            try
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

                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(modelCan), System.Text.Encoding.UTF8, "application/json");
                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage addCanBo([FromBody] ModelCanBo objCB)
        {
            try
            {

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
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(objCB), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage updateCanBo([FromBody] ModelCanBo objCB)
        {
            try
            {

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
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(objCB), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }
        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage deleteCanBo(int cID)
        {
            try
            {
                var obj = db.CanBos.Where(x => x.ID_Canbo == cID).FirstOrDefault();
                db.CanBos.DeleteOnSubmit(obj);
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
    }
}
