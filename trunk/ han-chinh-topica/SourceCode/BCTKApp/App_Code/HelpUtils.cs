using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using IP.Core.IPCommon;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace BCTKApp.App_Code
{
    public class HelpUtils
    {
        /// <summary>
        /// Hàm này để ghi text lên ảnh
        /// </summary>
        /// <param name="ip_graphics"></param>
        /// <param name="ip_i_demo">0: hiển thị thông tin demo trên form; 1: hiển thị thông tin demo trong US</param>
        /// <param name="ip_us_tt_phoi"></param>
        public static void ghi_text_to_image(Graphics ip_graphics
                                    , string ip_str_du_lieu_dien
                                    , float ip_f_vi_tri_x1, float ip_f_vi_tri_y, float ip_f_vi_tri_x2
                                    , string ip_str_font, float ip_f_font_size
                                    , Brush ip_str_font_color, string ip_str_center_yn)
        {
            Font v_font = new Font(ip_str_font, ip_f_font_size);
            PointF v_pointf = new PointF(ip_f_vi_tri_x1, ip_f_vi_tri_y);

            // đoạn này ghi căn thông tin ra giữa
            if (CIPConvert.ToBoolean(ip_str_center_yn))
            {
                int v_i_real_width = (int)ip_graphics.MeasureString(ip_str_du_lieu_dien, v_font).Width + 5;

                int v_i_width = Convert.ToInt32(ip_f_vi_tri_x2 - ip_f_vi_tri_x1) * 3;
                int v_i_height = (int)ip_graphics.MeasureString(ip_str_du_lieu_dien, v_font).Height;

                if (v_i_real_width > v_i_width)
                    v_i_width = v_i_real_width;

                Rectangle rect1 = new Rectangle(Convert.ToInt32(ip_f_vi_tri_x1)
                                           , Convert.ToInt32(ip_f_vi_tri_y)
                                           , v_i_width
                                           , v_i_height);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                ip_graphics.DrawString(ip_str_du_lieu_dien, v_font, ip_str_font_color, rect1, stringFormat);
                ip_graphics.DrawRectangle(Pens.White, rect1);
            }
            else
            {
                ip_graphics.DrawString(ip_str_du_lieu_dien
                    , v_font, ip_str_font_color, v_pointf);
            }
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
        public static bool SendEmailWithHtmlContent(string ip_str_toEmail, string ip_str_subject, string ip_str_noi_dung, string ip_str_file_name)
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
                    smtp.Timeout = 200000;
                }
                System.Net.Mail.MailMessage ms = new System.Net.Mail.MailMessage(fromAddress, ip_str_toEmail);
                if (!ip_str_file_name.Equals(""))
                {
                    BCTKApp.App_Code.HelpUtils.DownloadInApp(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PdfScan", ip_str_file_name.Replace("210.245.89.37/FileUpload_Vanthu/", ""));
                    string v_str_file_save = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PdfScan\\" + ip_str_file_name.Replace("210.245.89.37/FileUpload_Vanthu/", "");
                    System.Net.Mail.Attachment v_attach = new System.Net.Mail.Attachment(v_str_file_save);
                    ms.Attachments.Add(v_attach);
                }

                ms.Subject = ip_str_subject;
                ms.IsBodyHtml = true;
                ms.Body = ip_str_noi_dung;

                smtp.Send(ms);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static void openPDFFile(string ip_str_file_name)
        {
            try
            {
                string v_str_file_save = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PdfScan\\" + ip_str_file_name.Replace("210.245.89.37/FileUpload_Vanthu/", "");
                if (!ip_str_file_name.Equals(""))
                {
                    if(!File.Exists(v_str_file_save))
                    BCTKApp.App_Code.HelpUtils.DownloadInApp(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PdfScan", ip_str_file_name.Replace("210.245.89.37/FileUpload_Vanthu/", ""));
                    System.Diagnostics.Process.Start(v_str_file_save);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Máy tính của bạn chưa cài chương trình đọc pdf, bạn có thể cài đặt Foxit Reader hoặc một chương trình đọc file pdf để có thể xem được file scan!", "Cảnh báo");
            }
            
        }
        public static bool ftpTransfer(string destination, string fileName)
        {
            string ftpAddress = ConfigurationSettings.AppSettings["DOMAIN"];
            string username = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
            string password = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
            FileInfo fileInf = new FileInfo(destination + fileName);
            string uri = "ftp://" + ftpAddress + "/FileUpload_Vanthu/" + fileName;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpAddress + "/FileUpload_Vanthu/" + fileName));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(username, password);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            //reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("File đính kèm quá nặng, có lỗi xảy ra trong quá trình lưu file, bạn hãy chọn file nhẹ hơn");
                return false;
            }

        }
        public static void Download(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                string ftpAddress = ConfigurationSettings.AppSettings["DOMAIN"];
                string username = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
                string password = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpAddress + "/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(username, password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DownloadInApp(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                string ftpAddress = ConfigurationSettings.AppSettings["DOMAIN"];
                string username = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
                string password = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpAddress + "/FileUpload_Vanthu/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(username, password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void open_pdf_file(string file_name, string file_path)
        {
            //Download(file_path, file_name);
            System.Diagnostics.Process.Start(@"C:" + "\\" + file_name);
        }

    }
}
