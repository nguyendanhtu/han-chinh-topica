using IP.Core.IPBusinessService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
public partial class Quantri_admin : System.Web.UI.Page
{
    #region Private Methods
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        m_txt_command.Focus();
        if (!IsPostBack)
        {
            //m_txt_convert_encoding.Text = CIPConvert.Deciphering(m_txt_convert_encoding.Text.Trim());
        }
    }

    protected void m_cmd_excute_Click(object sender, EventArgs e)
    {
        try
        {
            BS_Object v_bs = new BS_Object();
            DataSet op_ds = new DataSet();
            DataTable v_dt = new DataTable();
            op_ds.Tables.Add(v_dt);
            op_ds.AcceptChanges();
            string v_str_command = "";
            if (m_rdb_excute.Checked == true) v_str_command = m_txt_command.Text;
            else if (m_rdb_tim_proc.Checked == true) v_str_command =
                "SELECT OBJECT_NAME(object_id)as 'procedure',definition as 'Script' FROM sys.sql_modules WHERE objectproperty(object_id,'IsProcedure') = 1 AND definition    like '%" + m_txt_command.Text + "%'";
            else if (m_rdb_tim_view.Checked == true) v_str_command =
                    "Select table_name AS 'Table name', VIEW_DEFINITION AS 'Script' From INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME LIKE'%"+m_txt_command.Text+"%'";

            SqlCommand v_sql_cmd = new SqlCommand(v_str_command);
            v_bs.FillDatasetByCommand(op_ds, v_sql_cmd);
            m_lbl_mess.Text = "Command(s) completed successfully.";
            m_grv.DataSource = op_ds.Tables[0];
            m_grv.DataBind();
        }
        catch (Exception v_e)
        {
            m_lbl_mess.Text = "Lỗi: " + v_e.ToString();
            m_grv.DataSource = null;
            m_grv.DataBind();

        }
    }
    protected void m_cmd_convert_Click(object sender, EventArgs e)
    {
        m_lbl_mess.Text = CIPConvert.Deciphering(m_txt_convert_encoding.Text.Trim());
    }
    #endregion


    
}