<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f499_tra_cuu_tinh_hinh_CPN.aspx.cs" Inherits="ChucNang_f499_tra_cuu_tinh_hinh_CPN" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellspacing="0" cellpadding="1" style="width: 100%" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">

                        <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" Text="Tra cứu tình hình CPN"
                            ForeColor="White" />
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                        <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server"></asp:HiddenField>
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="2">
                        <asp:Label ID="m_lbl_tu_ngay" runat="server" Text="Từ ngày: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <ew:CalendarPopup ID="m_dat_tu_ngay" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                            TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN"
                            DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                            ShowGoToToday="false" Width="35%">
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
                    <td align="right" colspan="2">
                        <asp:Label ID="m_lbl_den_ngay" runat="server" Text="Đến ngày: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <ew:CalendarPopup ID="m_dat_den_ngay" runat="server" TextBoxLabelStyle-BorderColor="#810913"
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
                    <td align="center" colspan="6">
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" Text="Xem báo cáo" CssClass="cssGoogleButton" CausesValidation="false" OnClick="m_cmd_tim_kiem_Click" />
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
                        <asp:Label ID="m_lbl_ten_trung_tam" runat="server" CssClass="cssPageTitle" ForeColor="White">
                        </asp:Label>
                        <asp:Label ID="m_lbl_thong_tim_grv_dm_bill" runat="server" CssClass="cssPageTitle"
                            ForeColor="White"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssManField" />
                    </td>
                    <td>&nbsp;
                    </td>
                    <td>
                        <asp:HiddenField ID="m_hdf_id_bill" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_v_bc_tinh_hinh_CPN" runat="Server"
                            AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID_PHONG_BAN" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Chưa có dữ liệu báo cáo!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20"
                            OnPageIndexChanging="m_grv_v_bc_tinh_hinh_CPN_PageIndexChanging">
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <EmptyDataRowStyle BorderColor="#810913" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <%--     <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                        <headerstyle width="15px" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="2%" />
                                </asp:TemplateField>--%>
                                <asp:BoundField DataField="TONG_SO_BILL" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG SỐ BILL ĐÃ GỬI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <%--                       <asp:BoundField DataField="TRANG_THAI" ItemStyle-HorizontalAlign="right" HeaderText="TRẠNG THÁI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>--%>
                                <asp:BoundField DataField="TONG_SO_TIEN" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN ĐÃ TÍNH VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DINH_MUC" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN ĐỊNH MỨC (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TI_LE_DA_VUOT" ItemStyle-HorizontalAlign="Left" HeaderText="TỶ LỆ ĐÃ VƯỢT (%)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:P1}">
                                    <ItemStyle HorizontalAlign="right" Width="7%" />
                                </asp:BoundField>
                                <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center"
                                    Visible="False">
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:CommandField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <table cellspacing="0" cellpadding="1" style="width: 100%" class="cssTable" border="1">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">

                            <asp:Label ID="Label1" runat="server" CssClass="cssPageTitle" Text="Chi tiết tổng hợp tình hình CPN"
                                ForeColor="White" />
                            &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                            <asp:HiddenField ID="HiddenField1" runat="server"></asp:HiddenField>
                        </td>
                    </tr>
                    <tr style="background-color: lightgrey">
                        <td align="center" style="width:25%">
                            <asp:Label ID="Label7" runat="server" Text="Trạng thái Bill" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="center" style="width:25%">
                            <asp:Label ID="Label8" runat="server" Text="Tổng số Bill" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="center" style="width:25%">
                            <asp:Label ID="Label9" runat="server" Text="Tổng số tiền đã tính VAT (VNĐ)" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="center" style="width:25%">
                            <asp:Label ID="Label6" runat="server" Text="Click xem chi tiết" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Label ID="Label5" runat="server" Text="Bill chưa gửi cho CPN" CssClass="cssPageTitle" ForeColor="Black" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_bill_chua_gui_cho_CPN" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="right">
                            <asp:Label ID="Label10" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" Text="0" />
                        </td>
                        <td align="center" style="width: 150px">
                            <asp:ImageButton ID="Button1" ImageUrl="../Images/Button/detail.png"
                                PostBackUrl="/QuanLyHanhChinh/ChucNang/f444_tra_cuu_trang_thai.aspx" runat="Server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Label ID="Label4" runat="server" Text="Bill đã gửi cho CPN" CssClass="cssPageTitle" ForeColor="Black" />

                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_so_bill_da_gui_thanh_cong" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_tong_tien_da_gui_thanh_cong" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="center" style="width: 150px">
                            <asp:ImageButton ID="ImageButton1" ImageUrl="../Images/Button/detail.png"
                                PostBackUrl="/QuanLyHanhChinh/ChucNang/f444_tra_cuu_trang_thai.aspx" runat="Server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Label ID="Label2" runat="server" Text="Bill trả lại mất phí" CssClass="cssPageTitle" ForeColor="Black" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_so_bill_bi_tra_lai_mat_phi" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_so_tien_bill_bi_tra_lai_mat_phi" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="center" style="width: 150px">
                            <asp:ImageButton ID="ImageButton2" ImageUrl="../Images/Button/detail.png"
                                PostBackUrl="/QuanLyHanhChinh/ChucNang/f444_tra_cuu_trang_thai.aspx" runat="Server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Label ID="Label3" runat="server" Text="Bill trả lại không mất phí" CssClass="cssPageTitle" ForeColor="Black" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_so_bill_bi_tra_lai_khong_mat_phi" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" />
                        </td>
                        <td align="right">
                            <asp:Label ID="m_lbl_so_tien_bill_tra_lai_khong_mat_phi" runat="server" CssClass="cssPageTitle" ForeColor="Maroon" Text="0" />
                        </td>
                        <td align="center" style="width: 150px">
                            <asp:ImageButton ID="ImageButton3" ImageUrl="../Images/Button/detail.png"
                                PostBackUrl="/QuanLyHanhChinh/ChucNang/f444_tra_cuu_trang_thai.aspx" runat="Server" />
                        </td>
                    </tr>
                </table>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

