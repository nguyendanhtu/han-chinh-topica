using System;
using System.Web.SessionState;
using System.Web;

using BCTKDS;
using BCTKUS;
using BCTKUS;
using BCTKDS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPData.DBNames;

using System.Web.UI.WebControls;
using System.Data;
using System.Net;


namespace IP.Core.WinFormControls
{
    /// <summary>
    /// Summary description for ApplicationControls.
    /// </summary>
    public class WinFormControls
    {
        public WinFormControls()
        {
           

        }
        public static bool SendEmailHanhChinhTopica(string ip_str_toEmail, string ip_str_subject, string ip_str_noi_dung)
        {
            try
            {
                string fromAddress = "topica.quanlyhanhchinh@gmail.com";// Gmail Address from where you send the mail
                string toAddress = ip_str_toEmail;
                const string fromPassword = "quanlyhanhchinh1992";//Password of your gmail address
                string subject = ip_str_subject;
                string body = ip_str_noi_dung;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;
                }
                smtp.Send(fromAddress, toAddress, subject, body);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        #region Public Interfaces
        public enum eTAT_CA
        {
            YES,
            NO
        }

        #endregion
    }
}
