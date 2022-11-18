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

/// <summary>
/// Summary description for DonviController
/// </summary>
namespace lct
{
    public class DonviController : DnnApiController
    {
        lctDataContext db = new lctDataContext();
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetListDonvi()
        {
            try
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
                    dv.Thutu_Donvi = Convert.ToString(i.Thutu_Donvi);
                    donviInfo.Add(dv);
                }
                var res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(JsonConvert.SerializeObject(donviInfo), System.Text.Encoding.UTF8, "application/json");
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

