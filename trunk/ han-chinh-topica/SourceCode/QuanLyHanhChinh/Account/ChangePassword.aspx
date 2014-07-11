<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Account_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
        <tr>
            <td class="cssPageTitleBG" colspan="3">
                <asp:Label ID="lblUser" runat="server" CssClass="cssPageTitle"
                    Text="Thay đổi mật khẩu" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true" />
                <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 15%;">
                <asp:Label ID="Label4" CssClass="cssManField" runat="server"
                    Text="Mật khẩu cũ (*)" />
            </td>
            <td style="width: 30%;">
                <asp:TextBox ID="m_txt_old_password" CssClass="cssTextBox" runat="server" TextMode="Password"
                    MaxLength="35" Width="200px" />
            </td>
            <td style="width: 5%;">
                <asp:RequiredFieldValidator ID="m_rqv_old_passwprd" runat="server"
                    ControlToValidate="m_txt_old_password" ErrorMessage="Mật khẩu cũ không được để trống"
                    Display="Static" Text="(*)" />
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 15%;">
                <asp:Label ID="lblFullName" CssClass="cssManField" runat="server"
                    Text="Mật khẩu mới (*)" />
            </td>
            <td style="width: 30%;">
                <asp:TextBox ID="m_txt_new_password" CssClass="cssTextBox" runat="server" TextMode="Password"
                    MaxLength="35" Width="200px" />
            </td>
            <td style="width: 5%;">
                <asp:RequiredFieldValidator ID="m_rqv_new_password" runat="server"
                    ControlToValidate="m_txt_new_password" ErrorMessage="Mật khẩu mới không được để trống"
                    Display="Static" Text="(*)" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="lblAnswer0" runat="server" CssClass="cssManField"
                    Text="Nhập lại mật khẩu mới (*)" />
            </td>
            <td align="left">
                <asp:TextBox ID="m_txt_mat_khau_retype" CssClass="cssTextBox" AccessKey="m" runat="server" Width="200px"
                    TextMode="Password" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="m_ctv_retype_mat_khau" runat="server"
                    ControlToValidate="m_txt_mat_khau_retype" ErrorMessage="Mật khẩu nhập lại không được để trống"
                    Display="Static" Text="*" />
                <asp:CompareValidator ID="m_ctv_mat_khau" runat="server"
                    ControlToCompare="m_txt_mat_khau_retype" ControlToValidate="m_txt_new_password"
                    ErrorMessage="Mật khẩu và mật khẩu nhập lại phải giống nhau">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td colspan="2" align="left">
                <asp:Button ID="m_cmd_doi_mat_khau" AccessKey="c" CssClass="cssGoogleButton"
                    runat="server" Text="Lưu" OnClick="m_cmd_doi_mat_khau_Click"
                    CausesValidation="False"  />&nbsp;&nbsp;&nbsp;
			<asp:Button ID="m_cmd_thoat" AccessKey="u" CssClass="cssGoogleButton"
                runat="server" Text="Thoát" OnClick="m_cmd_thoat_Click"
                CausesValidation="False" />
            </td>
        </tr>
    </table>
</asp:Content>

