<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f456_export_excel.aspx.cs" Inherits="ChucNang_f456_export_excel" %>

<%@ Import Namespace="IP.Core.IPCommon" %>
<%@ Import Namespace="BCTKUS" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title>Quản lý hành chính</title>
    <link href="~/Styles/jquery-ui.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/Admin.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/menu.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/select2.css" rel="stylesheet" />

    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery-1.8.2.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery-ui-1.8.23.min.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/select2.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/menu.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery.ui.datepicker-vi.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery.dataTables.sorting.js")%>'></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cssLoadContent2" style="width: 100%; max-height: 100%; min-height: 100%; margin: 100px auto 0 auto; overflow-y: scroll; scrollbar-highlight-color: khaki">
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
                        <asp:HiddenField ID="m_hdf_id_don_hang" runat="server" />
                    </td>
                    <%--<td align="right" colspan="1">
                                    <asp:ImageButton ID="_cmd_detail_exit" ImageUrl="../Images/Button/exit.png" Width="24px" Height="24px" runat="server"
                                        OnClick="m_cmd_detail_exit_Click" />
                                </td>--%>
                </tr>
                <tr>
                    <%--     <td align="right">
                                    <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssPageTitle" ForeColor="Green" Font-Italic="true" BackColor="White"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="m_lbl_chon_vpp" runat="Server" Text="Chọn VPP" CssClass="cssManField"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="m_cbo_vpp" runat="Server"
                                        Width="91%" AutoPostBack="true" OnSelectedIndexChanged="m_cbo_vpp_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_so_luong" runat="Server" Text="Số lượng" CssClass="cssManField"></asp:Label>
                                    &nbsp
                                    <asp:TextBox ID="m_txt_so_luong" runat="server" CssClass="=cssTextBox" Width="50px"></asp:TextBox>
                                    &nbsp
                        <asp:Label ID="m_lbl_don_vi_tinh" runat="server" CssClass="cssManField" Text="Cái"></asp:Label>
                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                    <asp:Label ID="Label1" runat="server" CssClass="cssManField" Text="Đơn giá chưa VAT: "></asp:Label>
                                    <asp:Label ID="m_lbl_don_gia" runat="server" CssClass="=cssManField" Text="0" ForeColor="Blue"></asp:Label>
                                </td>--%>
                    <td align="left">
                        <%--                         <asp:Button ID="m_cmd_them_don_hang_de" runat="server" Text="Thêm vào phiếu" CssClass="cssGoogleButton" OnClick="m_cmd_them_don_hang_de_Click" />
                                    <asp:Button ID="m_cmd_cap_nhat_don_hang_de" runat="server" Text="Cập nhật lại" CssClass="cssGoogleButton" OnClick="m_cmd_cap_nhat_don_hang_de_Click" />--%>
                        <asp:HiddenField ID="m_hdf_form_mode" runat="server" />
                        <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
                        <asp:HiddenField ID="m_hdf_don_gia" runat="server" />
                        <asp:HiddenField ID="m_hdf_ma_trung_tam" runat="server" />
                        <asp:HiddenField ID="m_hdf_ID_GD_DON_DAT_HANG_DE" runat="server" />
                    </td>
                </tr>
            </table>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" style="width: 100%; margin-top: 6%; overflow-y: scroll">
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
                            CellPadding="8" PageSize="150">
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <%--  <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="m_lbt_delete" runat="server" CommandName="Delete" ToolTip="Xóa"
                                                        OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')">
                                            <img src="../Images/Button/deletered.png" alt="Delete" />
                                                    </asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle />
                                            </asp:TemplateField>--%>
                                <%--<asp:CommandField ItemStyle-Width="1%" EditText="Sửa" EditImageUrl="../Images/Button/edit.png"
                                                ShowEditButton="true" ButtonType="Image" HeaderText="Sửa" ItemStyle-HorizontalAlign="Center"
                                                HeaderStyle-HorizontalAlign="Center">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" Width="1%" />
                                            </asp:CommandField>--%>
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
                                <%--<asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center"
                                                Visible="False">
                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:CommandField>--%>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
