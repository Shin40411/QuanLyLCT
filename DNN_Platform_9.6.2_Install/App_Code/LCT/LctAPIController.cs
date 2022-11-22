using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LCT;
using Newtonsoft.Json;

namespace lct {
    public class LctAPIController : DnnApiController
    {
        lctDataContext db = new lctDataContext();
        NguoiDungController nguoiDungController = new NguoiDungController();
        DonviController donviController = new DonviController();

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetListUser()
        {
            try
            {

                var Nd = nguoiDungController.GetListUser();
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(Nd), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetUserByID(int ID)
        {
            try
            {
                var Nd = nguoiDungController.GetUserByID(ID);
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(Nd), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage UpdateUser([FromBody] NdungInfo ndInfo)
        {
            try
            {
                string _Status = "FALSE";
                if (ndInfo.ID_Ndung == 0 && nguoiDungController.KiemTraTrungUsername(ndInfo.Username) ==true)
                {
                    _Status = "TONTAI";
                }
                else
                {
                    bool Nd = nguoiDungController.UpdateUser(ndInfo, PortalSettings);
                    if (Nd == true)
                    {
                        _Status = "OK";
                    }
                }
             
            
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(_Status), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }
        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage DoiMatKhau([FromBody] NdungInfo ndInfo)
        {
            try
            {
                string _Status = "FALSE";
                bool Nd = nguoiDungController.DoiMatKhau(ndInfo);
                if (Nd == true)
                {
                    _Status = "OK";
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(_Status), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage DeleteUser(int ID)
        {
            try
            {
                string _Status = "FALSE";
                bool Nd = nguoiDungController.DeleteUser(ID);
                if(Nd == true)
                {
                    _Status = "OK";
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(_Status), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetList()
        {
            try
            {
                var Dv = donviController.GetListDonvi();
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(Dv), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetListByUser()
        {
            try
            {
                var Dv = donviController.GetListDonviByUser();
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(Dv), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetDonviByID(int ID)
        {
            try
            {
                var Dv = donviController.GetDonvi(ID);
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(Dv), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage UpdateDonvi([FromBody] DonviInfo donVi)
        {
            try
            {
                string _Status = "FALSE";
                bool Dv = donviController.UpdateDonvi(donVi);
                if (Dv == true)
                {
                    _Status = "OK";
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(_Status), System.Text.Encoding.UTF8, "application/json");

                return res;
            }
            catch (Exception Ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Ex.Message, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            }
        }



        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage DeleteDonvi(int ID)
        {
            try
            {
                string _Status = "FALSE";
                bool Dv = donviController.DeleteDonvi(ID);
                if (Dv == true)
                {
                    _Status = "OK";
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(_Status), System.Text.Encoding.UTF8, "application/json");

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

