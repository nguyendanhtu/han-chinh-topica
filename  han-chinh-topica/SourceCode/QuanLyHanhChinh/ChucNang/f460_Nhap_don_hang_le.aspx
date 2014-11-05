﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f460_Nhap_don_hang_le.aspx.cs" Inherits="ChucNang_f460_Nhap_don_hang_le" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">

    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_cbo_vpp.ClientID%>").select2();
        });
    </script>
    <%-- <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_txt_ngay_nhap.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true,
                required: true,
                yearRange: '1950:2050',
            });
        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <%--    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>

    <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_header" runat="server" Text="PHIẾU ĐỀ NGHỊ CẤP VÀ BÀN GIAO VPP" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:Label ID="m_lbl_title" runat="server" CssClass="cssManField" Font-Bold="true" Font-Size="Medium" ForeColor="GrayText"></asp:Label></td>
        </tr>
    </table>
    <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">

        <tr>
            <td class="cssPageTitleBG" colspan="9">
                <asp:Label ID="Label4" runat="server" CssClass="cssPageTitle"
                    Text="Thông tin đơn hàng"></asp:Label>
                <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
                <asp:HiddenField ID="m_hdf_id_don_hang" runat="server" />
                <asp:HiddenField ID="m_hdf_ngay_dat_hang" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="" align="right">
                <asp:Label ID="m_lbl_so_phieu" runat="server" CssClass="cssManField" Text="Số phiếu:" ForeColor="Blue"></asp:Label>
            </td>
            <td align="left">&nbsp;
                <asp:Label ID="m_lbl_hien_thi_so_phieu" runat="server" CssClass="cssManField" Text="-----------" ForeColor="Blue"></asp:Label>
            </td>
            <td align="right">
                <asp:Label ID="m_lbl_lan" runat="server" CssClass="cssManField" Text="Lần: "></asp:Label>
            </td>
            <td align="left">&nbsp;<asp:Label ID="m_txt_so_lan" runat="server" CssClass="cssManField" Text="0" Width="20%"></asp:Label>
            </td>
            <td align="right">
                <asp:Label ID="m_lbl_ngay_gui" runat="Server" Text="Ngày đặt hàng: " CssClass="cssManField"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;<asp:Label ID="m_txt_ngay_nhap" runat="Server" CssClass="cssLabel" Text="----------"></asp:Label>
            </td>
            <td align="left">
                <asp:Button ID="m_cmd_them_don_hang" runat="server" Text="Nhập đơn hàng" CssClass="cssGoogleButton" OnClick="m_cmd_them_don_hang_Click" Visible="true" />
            </td>
            <td align="left">
                <asp:Button ID="m_cmd_cap_nhat_don_hang" PostBackUrl="~/ChucNang/f560_tra_cuu_dm_vpp.aspx" runat="server" Text="Danh mục VPP" CssClass="cssGoogleButton" Visible="true"></asp:Button>
            </td>
            <%--          <td align="left">
                <asp:Button ID="m_cmd_gui_td" runat="server" Text="Gửi cho TD duyệt" CssClass="cssGoogleButton" OnClick="m_cmd_gui_td_Click" />
            </td>--%>
        </tr>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td class="cssPageTitleBG" colspan="6">
                <asp:Label ID="Label2" runat="server" CssClass="cssPageTitle"
                    Text="Chi tiết thông tin đơn hàng"></asp:Label>
                <asp:Label ID="m_lbl_thong_tin_don_hang" runat="server" CssClass="cssPageTitle"></asp:Label>
                <%--  &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="m_grv_don_hang_nhap" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                    Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                    EmptyDataText="Không có đơn hàng nào!" EmptyDataRowStyle-BorderColor="#810913"
                    CellPadding="8" PageSize="10"
                    OnRowCommand="m_grv_don_hang_nhap_RowCommand"
                    OnRowEditing="m_grv_don_hang_nhap_RowEditing"
                    OnRowDeleting="m_grv_don_hang_nhap_RowDeleting"
                    OnPageIndexChanging="m_grv_don_hang_PageIndexChanging">
                    <PagerSettings Position="TopAndBottom" />
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle CssClass="GridViewFooterStyle" />
                    <RowStyle CssClass="GridViewRowStyle" />
                    <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                    <PagerStyle CssClass="GridViewPagerStyle" />
                    <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                    <HeaderStyle CssClass="GridViewHeaderStyle" />
                    <Columns>
                        <%--        <asp:TemplateField HeaderText="Chọn" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkRow" runat="server" OnCheckedChanged="OnCheckedChanged_chkRow" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:LinkButton ID="m_lbt_delete" runat="server" CommandName="Delete" ToolTip="Xóa"
                                    OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')">
                                            <img src="../Images/Button/deletered.png" alt="Delete" />
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle />
                        </asp:TemplateField>
                        <asp:CommandField ItemStyle-Width="1%" EditText="Sửa" EditImageUrl="../Images/Button/edit.png"
                            ShowEditButton="true" ButtonType="Image" HeaderText="Sửa" ItemStyle-HorizontalAlign="Center"
                            HeaderStyle-HorizontalAlign="Center" Visible="false">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="1%" />
                        </asp:CommandField>
                        <asp:TemplateField HeaderText="Chi tiết" ItemStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:LinkButton ID="m_lbt_detail" runat="server" CommandName="Detail" ToolTip="Chi tiết"
                                    OnClick="m_lbt_detail_OnClick">
                                            <img src="../Images/Button/detail.png" alt="Detail" />
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                                <headerstyle width="15px" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="2%" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="NGAY_DAT_HANG" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY ĐẶT HÀNG"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                            <ItemStyle HorizontalAlign="Left" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MA" ItemStyle-HorizontalAlign="left" HeaderText="Số phiếu"
                            ItemStyle-Width="7%">
                            <ItemStyle HorizontalAlign="right" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LAN" ItemStyle-HorizontalAlign="Left" HeaderText="LẦN GỬI"
                            ItemStyle-Width="3%">
                            <ItemStyle HorizontalAlign="Right" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GIA_TRI_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="GIÁ TRỊ CHƯA VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GIA_TRI_DA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="GIÁ TRỊ GỒM VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DINH_MUC" ItemStyle-HorizontalAlign="Right" HeaderText="ĐỊNH MỨC (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Xin TAD duyệt" ItemStyle-Width="2%" ItemStyle-HorizontalAlign="Center" Visible="false">
                            <ItemTemplate>
                                <asp:LinkButton ID="m_lbt_xin_td_duyet" runat="server" CommandName="XinTDDuyet" ToolTip="Xin TD duyệt" CommandArgument='<%#Eval("ID") %>'
                                    OnClientClick="return confirm ('Bạn có thực sự muốn gửi cho TD duyệt đơn hàng này?')">
                                                <img src="../Images/Button/gmail-icon.png" alt="Xin TD duyệt" width="24px" height="24px" />
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle />
                        </asp:TemplateField>
                        <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center"
                            Visible="False">
                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    <asp:Panel ID="m_pnl_detail_grv" runat="server">
        <div class="cssLoadWapper">
            <asp:MultiView ID="mtv_detail" runat="server">
                <asp:View ID="View_detail" runat="server">
                    <div class="cssLoadContent2" style="width: 100%; max-height: 75%; min-height: 75%; margin: 100px auto 0 auto; overflow-y: scroll; scrollbar-highlight-color: khaki">
                        <table cellspacing="0" cellpadding="2" style="width: 100%; position: fixed" class="cssTable" border="0">
                            <tr>
                                <td align="center">
                                    <asp:Label ID="m_lbl_title_ma_don_hang" runat="server" CssClass="cssPageTitle"
                                        Text="Nhập vật tư đơn hàng"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_MP" runat="Server" Text="MP:" CssClass="cssManField"></asp:Label>
                                    &nbsp
                        <asp:Label ID="m_lbl_ma_don_hang_de" runat="Server" Text="..." CssClass="cssManField" Font-Bold="true" ForeColor="DarkRed"></asp:Label>
                                </td>
                                <td colspan="3" align="center">
                                    <asp:Label ID="m_lbl_pop_lan_tl" runat="Server" Text="Lần:" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_lan" runat="Server" Text="--" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_ngay_dat_hang_tl" runat="Server" Text="Ngày đặt:" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_ngay" runat="Server" Text="----------" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_tong_tien_tl" runat="Server" Text="Tổng tiền (đã VAT):" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_tong_tien" runat="Server" Text="----------" CssClass="cssManField" ForeColor="Green" Font-Bold="true"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_dinh_muc_tl" runat="Server" Text="Định mức:" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_dinh_muc" runat="Server" Text="----------" CssClass="cssManField" ForeColor="Red" Font-Bold="true"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_ti_le_vuot_tl" runat="Server" Text="Tỉ lệ vượt:" CssClass="cssManField"></asp:Label>
                                    &nbsp&nbsp
                                    <asp:Label ID="m_lbl_pop_ti_le_vuot" runat="Server" Text="----------" CssClass="cssManField" ForeColor="Red" Font-Bold="true"></asp:Label>
                                    <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
                                    <asp:HiddenField ID="m_hdf_id_user" runat="server" />
                                </td>
                                <td align="right" colspan="1">
                                    <asp:ImageButton ID="_cmd_detail_exit" ImageUrl="../Images/Button/exit.png" Width="24px" Height="24px" runat="server"
                                        OnClick="m_cmd_detail_exit_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="m_lbl_chon_vpp" runat="Server" Text="Chọn VPP" CssClass="cssManField"></asp:Label>
                                    <asp:DropDownList ID="m_cbo_vpp" runat="Server" Width="100%"
                                        AutoPostBack="true" OnSelectedIndexChanged="m_cbo_vpp_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_so_luong" runat="Server" Text="Số lượng" CssClass="cssManField"></asp:Label>
                                    &nbsp
                                    <asp:TextBox ID="m_txt_so_luong" runat="server" CssClass="=cssTextBox" Width="50px"></asp:TextBox>
                                    &nbsp
                        <asp:Label ID="m_lbl_don_vi_tinh" runat="server" CssClass="cssManField" Text="Cái"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="Label1" runat="server" CssClass="cssManField" Text="Đơn giá đã VAT: "></asp:Label>
                                    <asp:Label ID="m_lbl_don_gia" runat="server" CssClass="=cssManField" Text="0" ForeColor="Blue"></asp:Label>
                                     &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="Label7" runat="server" CssClass="cssManField" Text="Mô tả: "></asp:Label>
                                    &nbsp<asp:TextBox ID="m_txt_mo_ta" runat="server" CssClass="cssTextBox" TextMode="MultiLine" Width="250px" Height="18px"></asp:TextBox>
                                </td>
                                <td align="left">
                                    <asp:Button ID="m_cmd_them_don_hang_de" runat="server" Text="Thêm vào phiếu" CssClass="cssGoogleButton" OnClick="m_cmd_them_don_hang_de_Click" />
                                    <asp:Button ID="m_cmd_cap_nhat_don_hang_de" runat="server" Text="Cập nhật lại" CssClass="cssGoogleButton" OnClick="m_cmd_cap_nhat_don_hang_de_Click" />
                                    <asp:HiddenField ID="m_hdf_form_mode" runat="server" />
                                    <asp:HiddenField ID="m_hdf_ma_trung_tam" runat="server" />
                                    <asp:HiddenField ID="m_hdf_don_gia" runat="server" />
                                    <asp:HiddenField ID="m_hdf_ID_GD_DON_DAT_HANG_DE" runat="server" />
                                </td>
                            </tr>
                            <tr> <td align="left"><asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssPageTitle" ForeColor="Green" Font-Italic="true" BackColor="White"></asp:Label></td></tr>
                        </table>
                        <table border="0" cellspacing="0" cellpadding="0" width="100%" style="width: 100%; margin-top: 8%; overflow-y: scroll">
                            <%--<tr style="width: 100%; position: fixed">
                                <td class="cssPageTitleBG" colspan="6">
                                    <asp:Label ID="m_lbl_phieu_de_nghi_va_ban_giao_VPP" runat="server" CssClass="cssPageTitle"
                                        Text="Danh sách VPP đề nghị cấp"></asp:Label>
                                    <asp:Label ID="m_lbl_thong_tim_grv_don_hang_de" runat="server" CssClass="cssPageTitle"></asp:Label>
                                    &nbsp; &nbsp;
                

                                </td>
                            </tr>--%>
                            <tr>
                                <td colspan="4">
                                    <asp:GridView ID="m_grv_don_hang_de" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                                        Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                                        EmptyDataText="Không có mặt hàng!" EmptyDataRowStyle-BorderColor="#810913"
                                        CellPadding="8" PageSize="50"
                                        OnRowEditing="m_grv_don_hang_de_RowEditing"
                                        OnRowDeleting="m_grv_don_hang_de_RowDeleting"
                                        OnPageIndexChanging="m_grv_don_hang_de_PageIndexChanging">
                                        <PagerSettings Position="TopAndBottom" />
                                        <AlternatingRowStyle BackColor="White" />
                                        <FooterStyle CssClass="GridViewFooterStyle" />
                                        <RowStyle CssClass="GridViewRowStyle" />
                                        <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                                        <PagerStyle CssClass="GridViewPagerStyle" />
                                        <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                                        <HeaderStyle CssClass="GridViewHeaderStyle" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="m_lbt_delete" runat="server" CommandName="Delete" ToolTip="Xóa"
                                                        OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')">
                                            <img src="../Images/Button/deletered.png" alt="Delete" />
                                                    </asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle />
                                            </asp:TemplateField>
                                            <asp:CommandField ItemStyle-Width="1%" EditText="Sửa" EditImageUrl="../Images/Button/edit.png"
                                                ShowEditButton="true" ButtonType="Image" HeaderText="Sửa" ItemStyle-HorizontalAlign="Center"
                                                HeaderStyle-HorizontalAlign="Center">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" Width="1%" />
                                            </asp:CommandField>
                                            <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                    <headerstyle width="15px" />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" Width="2%" />
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="TEN_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN VPP"
                                                ItemStyle-Width="7%">
                                                <ItemStyle HorizontalAlign="Left" Width="12%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="SO_LUONG" ItemStyle-HorizontalAlign="Right" HeaderText="SỐ LƯỢNG"
                                                ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                <ItemStyle HorizontalAlign="right" Width="5%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                                                ItemStyle-Width="7%">
                                                <ItemStyle HorizontalAlign="Right" Width="5%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                                                ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                <ItemStyle HorizontalAlign="Right" Width="7%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DON_GIA_GOM_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                                ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                <ItemStyle HorizontalAlign="Right" Width="7%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="TONG_TIEN" ItemStyle-HorizontalAlign="Right" HeaderText="TỔNG TIỀN ĐÃ VAT (VNĐ)"
                                                ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                <ItemStyle HorizontalAlign="Right" Width="7%" />
                                            </asp:BoundField>
                                              <asp:BoundField DataField="MO_TA" ItemStyle-HorizontalAlign="Left" HeaderText="Mô tả"
                                                ItemStyle-Width="7%" HtmlEncode="false">
                                                <ItemStyle HorizontalAlign="Right" Width="7%" />
                                            </asp:BoundField>
                                            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center"
                                                Visible="False">
                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:CommandField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <table class="cssLoadContent2" cellspacing="0" cellpadding="2" style="width: 100%; margin-top: 0px; position: fixed" border="0">
                        <tr>
                            <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label6" runat="server" Text="Nhập người gửi (*): " CssClass="cssLabelTitle" ForeColor="DarkSlateBlue"></asp:Label>
                                <asp:TextBox ID="m_txt_nguoi_gui" runat="server" CssClass="cssTextBox" placeholder="Tên người gửi"></asp:TextBox>
                            </td>
                            <td align="left">
                                <asp:Label ID="m_lbl_nhap_mail" runat="server" Text="Nhập mail TD: " CssClass="cssLabelTitle" ForeColor="DarkSlateBlue"></asp:Label>
                                <asp:TextBox ID="m_txt_nhap_mail" runat="server" CssClass="cssTextBox" placeholder="sampt"></asp:TextBox>
                                <asp:Label ID="m_lbl_duoi_mail" runat="server" Text="@Topica.edu.vn" CssClass="cssLabel"></asp:Label>
                                &nbsp&nbsp
                <asp:Button ID="m_cmd_gui_mail" runat="server" Text="Gửi mail xin duyệt" CssClass="cssGoogleButton" OnClick="m_cmd_gui_mail_Click" />
                            </td>
                            <td align="right">
                                <asp:Button ID="m_cmd_xuat_Excel" runat="server" Text="Xuất Excel" CssClass="cssGoogleButton" OnClick="m_cmd_xuat_excel_Click" />
                                <asp:Button ID="m_cmd_thoat" runat="server" Text="Thoát" CssClass="cssGoogleButton" OnClick="m_cmd_thoat_Click" />

                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
        </div>
    </asp:Panel>
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
    <table cellspacing="0" cellpadding="2" style="width: 100%; margin-top: 10%; position: relative" class="cssTable" border="0">
        <tr>
            <td align="left">
                <asp:Label ID="Label3" runat="server" Text="Nhập mail TD: " CssClass="cssLabelTitle" ForeColor="DarkSlateBlue"></asp:Label>
                <asp:TextBox ID="m_txt_nhap_mail_main" runat="server" CssClass="cssTextBox" placeholder="sampt"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="@Topica.edu.vn" CssClass="cssLabel"></asp:Label>
                &nbsp&nbsp
                <asp:Button ID="m_cmd_gui_mail_main" runat="server" Text="Gửi mail xin duyệt" CssClass="cssGoogleButton" OnClick="m_cmd_gui_mail_main_Click" />
            </td>
        </tr>
    </table>
    <%--  </ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>

