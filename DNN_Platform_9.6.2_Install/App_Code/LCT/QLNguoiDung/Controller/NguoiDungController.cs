using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Membership;
using DotNetNuke.Security.Roles;
using LCT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// < summary >
/// Summary description for UserController
/// </ summary >
namespace lct
{
    public class NguoiDungController
    {
        lctDataContext db = new lctDataContext();

        public List<NdungInfo> GetListUser()
        {
            int stt = 1;
            List<NguoiDungInfo> user = db.NguoiDungInfos.OrderBy(x => x.ID_Donvi).ToList();
            List<NdungInfo> userInfo = new List<NdungInfo>();
            foreach (var i in user)
            {
                NdungInfo nd = new NdungInfo();
                nd.STT_nd = stt++;
                nd.ID_Ndung = i.UserID;
                nd.DisplayName = i.DisplayName;
                nd.Username = i.Username;
                nd.Email_nd = i.Email;
                nd.Sodienthoai_nd = i.Sodienthoai_User;
                nd.Phongban_nd = i.Phongban_User;
                nd.Chucvu_nd = i.Chucvu_User;
                nd.Ghichu_nd = i.Ghichu_User;
                nd.ID_Donvi = (int)i.ID_Donvi;
                nd.Ten_Donvi = i.DonVi.Ten_Donvi;
                nd.Nhom_nd = i.Nhom_User;
                nd.Matkhau_nd = "";
                userInfo.Add(nd);
            }

            return userInfo;

        }

        public NguoiDungInfo GetUserByID(int ID)
        {
            NguoiDungInfo nd = new NguoiDungInfo();
            var obj = db.NguoiDungInfos.Where(x => x.UserID == ID).FirstOrDefault();
            if (obj != null)
            {
                nd.UserID = obj.UserID;
                nd.DisplayName = obj.DisplayName;
                nd.Username = obj.Username;
                nd.Email = obj.Email;
                nd.Sodienthoai_User = obj.Sodienthoai_User;
                nd.Nhom_User = obj.Nhom_User;
                nd.ID_Donvi = obj.ID_Donvi;
                nd.Phongban_User = obj.Phongban_User;
                nd.Chucvu_User = obj.Chucvu_User;
                nd.Ghichu_User = obj.Ghichu_User;
            }
            return nd;
        }
        public bool UpdateUser(NdungInfo ndInfo, PortalSettings pPortalSetting)
        {
            if ( ndInfo != null)
            {
                if (ndInfo.ID_Ndung != 0)
                {
                    try
                    {  
                        // đổi mật khẩu

                        // sửa thông tin
                        var vNguoiDungInfo = db.NguoiDungInfos.Where(x => x.UserID == ndInfo.ID_Ndung).FirstOrDefault();
                        vNguoiDungInfo.DisplayName = ndInfo.DisplayName;
                        vNguoiDungInfo.Email = ndInfo.Email_nd;
                        vNguoiDungInfo.Sodienthoai_User = ndInfo.Sodienthoai_nd;
                        vNguoiDungInfo.Chucvu_User = ndInfo.Chucvu_nd;
                        vNguoiDungInfo.Phongban_User = ndInfo.Phongban_nd;
                        vNguoiDungInfo.Ghichu_User = ndInfo.Ghichu_nd;
                        vNguoiDungInfo.ID_Donvi = ndInfo.ID_Donvi;
                        vNguoiDungInfo.Nhom_User = ndInfo.Nhom_nd;
                        db.SubmitChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    
                    try
                    {
                        UserInfo vUserInfo = new UserInfo();
                        vUserInfo.PortalID = 0;
                        vUserInfo.IsSuperUser = false;
                        vUserInfo.FirstName = "";
                        vUserInfo.LastName = "";
                        vUserInfo.DisplayName = ndInfo.DisplayName;
                        if (string.IsNullOrEmpty(ndInfo.Email_nd))
                        {
                            vUserInfo.Email = "lctnguoidung@gmail.com";
                        }
                        else
                        {
                            vUserInfo.Email = ndInfo.Email_nd;
                        }
                        vUserInfo.Username = ndInfo.Username;


                        //Nạp giá trị vào objMembership
                        UserMembership objMembership = new UserMembership();
                        objMembership.Approved = true;
                        objMembership.CreatedDate = DateTime.Now;
                        objMembership.Password = ndInfo.Matkhau_nd;
                        vUserInfo.Membership = objMembership;


                        //Thêm user và trả đối tượng user vừa thêm
                        UserCreateStatus result = UserController.CreateUser(ref vUserInfo);

                        if (result == UserCreateStatus.Success)
                        {


                            RoleController vRoleControllerInfo = new RoleController();
                            RoleInfo vRoleInfo = vRoleControllerInfo.GetRoleByName(0, "NGUOIDUNG"); //Add người dùng vào role NGUOIDUNG
                            RoleController.AddUserRole(vUserInfo, vRoleInfo, pPortalSetting, RoleStatus.Approved, Null.NullDate, Null.NullDate, false, false);

                            //Them nguoi dung vao bang NguoiDungInfo 
                            NguoiDungInfo vNguoiDungInfo = new NguoiDungInfo();
                            vNguoiDungInfo.Username = vUserInfo.Username;
                            vNguoiDungInfo.UserID = vUserInfo.UserID;
                            vNguoiDungInfo.DisplayName = ndInfo.DisplayName;
                            vNguoiDungInfo.Email = ndInfo.Email_nd;
                            vNguoiDungInfo.Sodienthoai_User = ndInfo.Sodienthoai_nd;
                            vNguoiDungInfo.Chucvu_User = ndInfo.Chucvu_nd;
                            vNguoiDungInfo.Phongban_User = ndInfo.Phongban_nd;
                            vNguoiDungInfo.Ghichu_User = ndInfo.Ghichu_nd;
                            vNguoiDungInfo.ID_Donvi = ndInfo.ID_Donvi;
                            vNguoiDungInfo.Nhom_User = ndInfo.Nhom_nd;
                            db.NguoiDungInfos.InsertOnSubmit(vNguoiDungInfo);
                            db.SubmitChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool DeleteUser(int ID)
        {
            
            try
            {
                var objNguoiDung = db.NguoiDungInfos.Where(x => x.UserID == ID).FirstOrDefault();
                if (objNguoiDung != null)
                {
                    int v_userID = (int)objNguoiDung.UserID;
                    db.NguoiDungInfos.DeleteOnSubmit(objNguoiDung);
                    db.SubmitChanges();
                    UserController objUserDNN = new UserController();
                    var objUserInfo = objUserDNN.GetUser(0, v_userID);
                    UserController.DeleteUser(ref objUserInfo, false, false);
                    UserController.RemoveUser(objUserInfo);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool KiemTraTrungUsername(string pUsername)
        {
            try
            {
                bool vResult = false;
                var vNguoiDungInfos = db.NguoiDungInfos.Where(x => x.Username == pUsername).ToList();

                if (vNguoiDungInfos.Count() > 0)
                    vResult = true; //trùng
                else
                    vResult = false;//không trùng

                return vResult;

            }
            catch (Exception ex)
            {
                return true;
            }
        }
        public bool DoiMatKhau(NdungInfo ndInfo)
        {
            try
            {
                bool vResult = false;
                var vNguoiDungInfo = db.NguoiDungInfos.Where(x => x.UserID == ndInfo.ID_Ndung).FirstOrDefault();
                if (vNguoiDungInfo != null)
                {
                    UserInfo vUserInfo = UserController.GetUserById(0, vNguoiDungInfo.UserID);
                    string vOldPassword = UserController.ResetPassword(vUserInfo, vUserInfo.Membership.PasswordAnswer);
                    if (UserController.ChangePassword(vUserInfo, vOldPassword, ndInfo.Matkhau_nd) == true)
                    {
                        vResult = true; //thanh cong
                    }
                    else
                    {
                        vResult = false; //thatbai
                    }
                }

                return vResult;

            }
            catch (Exception ex)
            {
                return true;
            }
        }


    }
   


}

