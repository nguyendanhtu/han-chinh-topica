<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f460_Nhap_don_hang_le.aspx.cs" Inherits="ChucNang_f460_Nhap_don_hang_le" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
                <tr>
                    <td></td>
                    <td align="center" colspan="4">
                        <asp:Label ID="m_lbl_header" runat="server" Text="PHIẾU ĐỀ NGHỊ CẤP VÀ BÀN GIAO VPP" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
            <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">

                <tr>
                    <td class="cssPageTitleBG" colspan="8">
                        <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" ForeColor="White"
                            Text="Nhập thông tin phiếu đề nghị cấp và bàn giao VPP"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                        <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="" align="right">
                        <asp:Label ID="m_lbl_ban_trung_tam" runat="server" CssClass="cssManField" Text="Ban/Trung tâm:" ForeColor="Blue"></asp:Label>
                    </td>
                    <td align="left">&nbsp;<asp:Label ID="m_txt_ban_trung_tam" runat="server" CssClass="cssManField" Font-Bold="true" Text="TAD - Phòng hành chính"></asp:Label>
                    </td>
                    <td align="right">
                        <asp:Label ID="m_lbl_lan" runat="server" CssClass="cssManField" Text="Lần "></asp:Label>
                    </td>
                    <td align="left">&nbsp;<asp:TextBox ID="m_txt_so_lan" runat="server" CssClass="cssManField" Text=" " Width="20%"></asp:TextBox>
                    </td>
                    <td align="right">
                        <asp:Label ID="m_lbl_ngay_gui" runat="Server" Text="Ngày nhập: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td align="left">&nbsp;<ew:CalendarPopup ID="m_dat_ngay_gui" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                        TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN"
                        DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                        ShowGoToToday="true" Width="35%">
                        <WeekdayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="9px"
                            ForeColor="Black" />
                        <WeekendStyle BackColor="LightGray" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                            ForeColor="Black" />
                        <OffMonthStyle BackColor="AntiqueWhite" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                            Font-Size="XX-Small" ForeColor="Gray" />
                        <SelectedDateStyle BackColor="#810913" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                            Font-Size="XX-Small" ForeColor="Black" />
                        <MonthHeaderStyle BackColor="#810913" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                            Font-Size="XX-Small" ForeColor="White" />
                        <DayHeaderStyle BackColor="AliceBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                            Font-Size="XX-Small" ForeColor="Black" />
                        <ClearDateStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                            ForeColor="Black" />
                        <GoToTodayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                            ForeColor="Black" />
                        <TodayDayStyle BackColor="CadetBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                            Font-Size="XX-Small" ForeColor="Black" />
                    </ew:CalendarPopup>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="m_lbl_chon_vpp" runat="Server" Text="Chọn VPP" CssClass="cssManField"></asp:Label>
                    </td>
                    <td style="width:20%">
                        <asp:DropDownList ID="m_cbo_vpp" runat="Server" CssClass="cssDorpdownlistDefault"
                            Width="91%">
                        </asp:DropDownList>
                    </td>
                    <td align="right">
                        <asp:Label ID="m_lbl_so_luong" runat="Server" Text="Số lượng" CssClass="cssManField"></asp:Label>
                    </td>
                    <td align="left" style="width:10%">
                        <asp:TextBox ID="m_txt_so_luong" runat="server" CssClass="=cssTextBox" hint="Nhập số lượng" Width="20%"></asp:TextBox>
                        &nbsp;<asp:Label ID="Label2" runat="server" CssClass="cssManField" Text="Cái"></asp:Label>
                    </td>
                    <td align="right" style="width:10%">
                        <asp:Label ID="Label1" runat="server" CssClass="cssManField" Text="Đơn giá"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="m_txt_don_gia" runat="server" CssClass="=cssTextBox" Width="20%"></asp:TextBox>
                        &nbsp;<asp:Label ID="Label3" runat="server" CssClass="cssManField" Text="(VNĐ)"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:Button ID="m_cmd_them" runat="server" Text="Thêm vào phiếu" CssClass="cssGoogleButton" />
                    </td>
                    <td>
                        <asp:HiddenField ID="m_hdf_form_mode" runat="server" />
                        <asp:HiddenField ID="m_hdf_id_VPP" runat="server" />
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
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_phieu_de_nghi_va_ban_giao_VPP" runat="server" CssClass="cssPageTitle" ForeColor="White"
                            Text="Phiếu giao nhận và thanh toán"></asp:Label>
                        <asp:Label ID="m_lbl_thong_tim_grv_dm_bill" runat="server" CssClass="cssPageTitle"
                            ForeColor="White"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_phieu_de_nghi_cap_va_ban_giao_VPP" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không có dữ liệu phù hợp!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20"
                            OnRowEditing="m_grv_dm_bill_RowEditing"
                            OnRowDeleting="m_grv_dm_bill_RowDeleting"
                            OnPageIndexChanging="m_grv_phieu_de_nghi_cap_va_ban_giao_VPP_PageIndexChanging">
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
                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="SO_LUONG" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ LƯỢNG"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="center" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DON_GIA_GOM_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

