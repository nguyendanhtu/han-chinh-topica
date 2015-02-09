using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Data.SqlClient;

using System.Collections.Generic;

//using ConnectionMan;

using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OpenId;
using DotNetOpenAuth.OpenId.RelyingParty;
using DotNetOpenAuth.ComponentModel;
using DotNetOpenAuth.Configuration;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPCommon;

public partial class Account_LoginGoogle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OpenIdRelyingParty openidd = new OpenIdRelyingParty();
        IAuthenticationResponse response = openidd.GetResponse();

        if (response != null && response.Status == AuthenticationStatus.Authenticated && response.Provider.Uri == new Uri("https://www.google.com/accounts/o8/ud"))
        {
            FetchResponse fetch = response.GetExtension<FetchResponse>();
            string email = String.Empty;
       
            if (fetch != null)
            {
                //lấy email đăng nhập
                email = fetch.GetAttributeValue(WellKnownAttributes.Contact.Email); //Fetching requested emailid
                US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
                DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
                v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, "where ten_truy_cap = '" + email + "' and trang_thai=0 and built_in_yn='Y'");
                decimal v_id_user_group = CIPConvert.ToDecimal(v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["ID_USER_GROUP"]);
                US_HT_QUAN_HE_SU_DUNG_DU_LIEU v_us_ht_qh_sd_dl = new US_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                DS_HT_QUAN_HE_SU_DUNG_DU_LIEU v_ds_ht_qh_sd_dl = new DS_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                v_us_ht_qh_sd_dl.FillDataset(v_ds_ht_qh_sd_dl, "where ID_USER_GROUP =" + v_id_user_group);
                m_hdf_id_trung_tam.Value = v_ds_ht_qh_sd_dl.HT_QUAN_HE_SU_DUNG_DU_LIEU.Rows[0]["ID_PHONG_BAN"].ToString();
                //nếu email có rồi  
                //set session
                if (v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Count == 0)
                {
                    Session[SESSION.NHOM_PHAN_QUYEN] = -1; 
                    Session[SESSION.UserID] = -1;
                    Session[SESSION.UserName] = email;
                }
                else
                {
                    DataRow v_dr = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0];
                    Session[SESSION.NHOM_PHAN_QUYEN] = v_dr[7];
                    Session[SESSION.UserID] = v_dr[0];
                    Session[SESSION.UserName] = v_dr[2];
                }
                Session[SESSION.AccounLoginYN] = "Y";
            }

            FormsAuthentication.RedirectFromLoginPage(email.Trim(), false);
        }
		
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (OpenIdRelyingParty openid = new OpenIdRelyingParty())
        {
            IAuthenticationRequest request = openid.CreateRequest("https://www.google.com/accounts/o8/id");
            FetchRequest fetch = new FetchRequest();
            fetch.Attributes.AddRequired(WellKnownAttributes.Contact.Email);
            
            ////            fetch.Attributes.AddRequired(WellKnownAttributes.Contact.Email); // Request for email id 
            request.AddExtension(fetch); // Adding in request obj
            request.RedirectToProvider();
        }
    }
}