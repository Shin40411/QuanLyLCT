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
                List<CanBo> canBos = db.CanBos.ToList();
                List<ModelCanBo> lstcb = new List<ModelCanBo>();

                foreach (var cb in canBos)
                {
                    ModelCanBo modelCanBo = new ModelCanBo();
                    modelCanBo.STT = Convert.ToInt32(stt++);
                    modelCanBo.ID_CanBo = cb.ID_Canbo;
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
    }
}
