<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="F800_Users.aspx.cs" Inherits="Quantri_F800_Users" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="3">
                        <asp:Label ID="lblUser" runat="server" CssClass="cssPageTitle" Text="Quản lý người dùng" />
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
                        <asp:Label ID="Label4" CssClass="cssManField" runat="server" Text="Nhóm người dùng" />
                    </td>
                    <td style="width: 30%;">
                        <asp:DropDownList ID="m_cbo_user_group" runat="server" Width="264px" CssClass="cssDorpdownlist"
                            AutoPostBack="true" OnSelectedIndexChanged="m_cbo_loai_tu_dien_SelectedIndexChanged" />
                    </td>
                    <td style="width: 5%;">
                        <asp:CustomValidator ID="m_cvt_loai_tu_dien" runat="server" ControlToValidate="m_cbo_user_group"
                            ErrorMessage="Bạn phải chọn Nhóm người dùng" Display="Static" Text="*" />
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 15%;">
                        <asp:Label ID="lblFullName0" CssClass="cssManField" runat="server" Text="Họ và tên người dùng(*)" />
                    </td>
                    <td style="width: 30%;">
                        <asp:TextBox ID="m_txt_ho_va_ten" CssClass="cssTextBox" runat="server" MaxLength="25"
                            Width="200px" />
                    </td>
                    <td style="width: 5%;">
                        <asp:CustomValidator ID="m_ctv_ma_tu_dien0" runat="server" ControlToValidate="m_txt_ho_va_ten"
                            ErrorMessage="Bạn phải nhập Họ và tên người dùng" Display="Static" Text="*" />
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 15%;">
                        <asp:Label ID="lblFullName" CssClass="cssManField" runat="server" Text="Tên đăng nhập(*)" />
                    </td>
                    <td style="width: 30%;">
                        <asp:TextBox ID="m_txt_ten_dang_nhap" CssClass="cssTextBox" runat="server" MaxLength="25"
                            Width="150px" />
                    </td>
                    <td style="width: 5%;">
                        <asp:CustomValidator ID="m_ctv_ma_tu_dien" runat="server" ControlToValidate="m_txt_ten_dang_nhap"
                            ErrorMessage="Bạn phải nhập Tên đăng nhập" Display="Static" Text="*" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="lblAnswer0" runat="server" CssClass="cssManField" Text="Mật khẩu(*)" />
                    </td>
                    <td align="left">
                        <asp:TextBox ID="m_txt_mat_khau" AccessKey="m" runat="server" Width="150px" TextMode="Password" CssClass="cssTextBox" />
                    </td>
                    <td>
                        <asp:CustomValidator ID="m_ctv_ten_tu_ngan" runat="server" ControlToValidate="m_txt_mat_khau"
                            ErrorMessage="Mật khẩu không được để trống!" Display="Static" Text="*" />
                        <asp:CompareValidator ID="m_ctv_mat_khau" runat="server" ControlToCompare="m_txt_mat_khau"
                            ControlToValidate="m_txt_mat_khau_go_lai" ErrorMessage="Mật khẩu và Nhập lại mật khẩu phải giống nhau">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="lblAnswer" runat="server" CssClass="cssManField" Text="Nhập lại mật khẩu(*)" />
                    </td>
                    <td align="left">
                        <asp:TextBox ID="m_txt_mat_khau_go_lai" AccessKey="m" runat="server" Width="150px"
                            TextMode="Password" CssClass="cssTextBox" />
                    </td>
                    <td>
                        <asp:CustomValidator ID="m_ctv_mk_go_lai" runat="server" ControlToValidate="m_txt_mat_khau_go_lai"
                            ErrorMessage="Mật khẩu không được để trống, ít nhất 5 ký tự" Display="Static"
                            Text="*" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="m_lbl_ghi_chu" runat="server" CssClass="cssManField" Text="Tài khoản bị khóa?" />
                    </td>
                    <td align="left">
                        <asp:CheckBox ID="m_chk_lock_yn" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right">&nbsp;
                    </td>
                    <td valign="top" colspan="2">
                        <asp:HiddenField ID="m_hdf_id_user_group" runat="server" Visible="False" />
                        <asp:HiddenField ID="m_hdf_pw" runat="server" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2" align="left">
                        <asp:Button ID="m_cmd_tao_moi" AccessKey="c" CssClass="cssGoogleButton" runat="server"
                            Text="Tạo mới(c)" OnClick="m_cmd_tao_moi_Click" />&nbsp;
                <asp:Button ID="m_cmd_cap_nhat" AccessKey="u" CssClass="cssGoogleButton" runat="server"
                    Text="Cập nhật(u)" OnClick="m_cmd_cap_nhat_Click" />&nbsp;
                <asp:Button ID="btnCancel" AccessKey="r" CssClass="cssGoogleButton" runat="server"
                    Text="Xóa trắng(r)" OnClick="btnCancel_Click" />
                        <asp:HiddenField ID="m_hdf_form_mode" runat="Server" />
                        <asp:HiddenField ID="m_hdf_id_nguoi_su_dung" runat="Server" />
                    </td>
                </tr>

            </table>
            <asp:Panel ID="m_pnl_confirm_tg" runat="server">
                <div class="cssLoadWapper">
                    <asp:MultiView ID="m_mtv_1" runat="server">
                        <asp:View ID="m_view_confirm" runat="server">
                            <div class="cssLoadContent2" style="width: 50%">
                                <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                    <tr>
                                        <td align="center">
                                            <br />
                                            <asp:Label ID="m_lbl_popup_mess" CssClass="cssManField" Style="font-size: 14px" runat="server"></asp:Label>
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center">
                                            <asp:Button ID="m_cmd_ok" AccessKey="c" CssClass="cssGoogleButton" runat="server"
                                                Text="OK" OnClick="m_cmd_ok_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:View>
                    </asp:MultiView>
                </div>
            </asp:Panel>
            <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="3">
                        <asp:Label ID="Label11" runat="server" CssClass="cssPageTitle" Text="Danh sách người dùng" />
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="m_lbl_thong_bao" Visible="false" runat="server" CssClass="cssManField" />
                    </td>
                    <td>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label5" CssClass="cssManField" runat="server" Text="Nhóm người dùng" />
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_user_group_on_grid" runat="server" CssClass="cssDorpdownlist" Width="264px" AutoPostBack="True"
                            OnSelectedIndexChanged="m_cbo_loai_tu_dien_grv_SelectedIndexChanged" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="3" style="height: 450px;" valign="top">
                        <asp:GridView ID="m_grv_dm_tu_dien" runat="server" AutoGenerateColumns="false"
                            Width="90%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            PageSize="20" CssClass="GridViewStyle" CellPadding="8"
                            EmptyDataText="Không có dữ liệu phù hợp!" OnRowDeleting="m_grv_dm_tu_dien_RowDeleting"
                            OnSelectedIndexChanging="m_grv_dm_tu_dien_SelectedIndexChanging" OnPageIndexChanging="m_grv_dm_tu_dien_PageIndexChanging">
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <asp:TemplateField HeaderText="Xóa">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbt_delete" runat="server" CommandName="Delete" ToolTip="Xóa"
                                            OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')">
                     <img alt="Xóa" src="../Images/Button/deletered.png" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sửa">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbt_update" runat="server" CausesValidation="false" CommandName="Select"
                                            ToolTip="Sửa">
                     <img alt="Sửa" src="../Images/Button/edit.png" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                    <HeaderStyle Width="3%" />
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:TemplateField>
                                <asp:BoundField DataField="ID_USER_GROUP" HeaderText="Nhóm người dùng" Visible="False">
                                    <ItemStyle HorizontalAlign="Left" Width="4%"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="TEN" ItemStyle-HorizontalAlign="Center" HeaderText="Họ và tên người dùng">
                                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="TEN_TRUY_CAP" HeaderText="Tên đăng nhập" />
                                <asp:BoundField DataField="MAT_KHAU" HeaderText="Mật khẩu" Visible="False" />
                                <asp:BoundField DataField="TRANG_THAI" ItemStyle-HorizontalAlign="Center" HeaderText="Trạng thái tài khoản (O: Bình thường, 1: Bị khóa)">
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
