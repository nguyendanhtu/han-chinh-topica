﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f422_dm_bill.aspx.cs" Inherits="ChucNang_f422_dm_bill" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="4">
                        <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" ForeColor="White" Text="Nhập thông tin bill"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="1">
                        <asp:Label ID="m_lbl_chon_trung_tam" runat="Server" Text="Chọn phòng ban" CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_trung_tam" runat="Server" CssClass="cssDorpdownlistDefault" Width="91%"></asp:DropDownList>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td align="right" style="width: 15%">
                        <asp:Label ID="m_lbl_so_bill" runat="Server" CssClass="cssManField" Text="Số bill"></asp:Label>
                    </td>
                    <td style="width: 35%">
                        <asp:TextBox ID="m_txt_so_bill" runat="Server" CssClass="cssTextBox" Width="40%"></asp:TextBox>
                    </td>
                    <td align="right" style="width: 15%">
                        <asp:Label ID="m_lbl_so_tien" runat="Server" CssClass="cssManField" Text="Số tiền" Width="50%"></asp:Label>
                    </td>
                    <td style="width: 35%">
                        <asp:TextBox ID="m_txt_so_tien" runat="Server" CssClass="cssTextBox" Width="50%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="m_lbl_nguoi_nhan" runat="Server" Text="Người nhận" CssClass="cssManField"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="m_txt_nguoi_nhan" runat="Server" CssClass="cssTextBox" Width="70%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="m_lbl_noi_nhan" runat="Server" CssClass="cssManField" Text="Nơi nhận"></asp:Label>
                    </td>
                    <td rowspan="1">
                        <asp:TextBox ID="m_txt_noi_nhan" runat="Server" TextMode="MultiLine" CssClass="cssTextBox" Width="90%"></asp:TextBox>
                    </td>
                    <td align="right">
                        <asp:Label ID="m_lbl_noi_dung" runat="Server" Text="Nội dung" CssClass="cssManField"></asp:Label>
                    </td>
                    <td rowspan="1">
                        <asp:TextBox ID="m_txt_noi_dung" runat="Server" TextMode="MultiLine" CssClass="cssTextBox" Width="90%"></asp:TextBox>
                    </td>
                </tr>
                <tr align="right">
                    <td>
                        <asp:Label ID="m_lbl_ngay_gui" runat="Server" Text="Ngày gửi" CssClass="cssManField"></asp:Label></td>
                    <td align="left">
                        <ew:CalendarPopup ID="m_dat_ngay_gui" runat="server" TextBoxLabelStyle-BorderColor="#810913"
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
                        <asp:Label ID="m_lbl_loai_thu" runat="Server" Text="Loại thư" CssClass="cssManField"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="m_cbo_loai_thu" runat="Server" CssClass="cssDorpdownlistDefault" Width="40%"></asp:DropDownList></td>
                </tr>
                </td>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
            </table>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                 <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_danh_muc_bill" runat="server" CssClass="cssPageTitle"
                            ForeColor="White" Text="Danh mục bill"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_dm_bill" runat="Server" AutoGenerateColumns="false"
                            CssClass="GridViewStyle" Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không có dữ liệu phù hợp!" EmptyDataRowStyle-BorderColor="#810913" CellPadding="8"
                            PageSize="20">
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
                                <asp:BoundField DataField="NOI_DUNG" ItemStyle-HorizontalAlign="Left" HeaderText="NƠI NHẬN"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NOI_NHAN" ItemStyle-HorizontalAlign="Left" HeaderText="NƠI NHẬN"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NGUOI_NHAN" ItemStyle-HorizontalAlign="Left" HeaderText="NGƯỜI NHẬN"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NGUOI_GUI" ItemStyle-HorizontalAlign="Left" HeaderText="NGƯỜI GỬI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
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

