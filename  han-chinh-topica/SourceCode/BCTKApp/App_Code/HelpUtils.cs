using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using IP.Core.IPCommon;

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
    }
}
