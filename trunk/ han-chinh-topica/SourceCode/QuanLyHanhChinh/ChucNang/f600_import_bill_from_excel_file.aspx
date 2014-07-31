<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f600_import_bill_from_excel_file.aspx.cs" Inherits="ChucNang_f600_import_bill_from_excel_file" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Import Namespace="IP.Core.IPCommon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td class="cssPageTitleBG" colspan="4">
                <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" ForeColor="White"
                    Text="Import bill từ file excel"></asp:Label>
                &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="m_lbl_message" runat="Server"></asp:Label></td>
        </tr>
    </table>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td>
                        <asp:FileUpload ID="m_fu_chon_file_import" runat="Server" /></td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Button ID="m_cmd_upload" runat="Server" Text="Bắt đầu upload file" CssClass="cssGoogleButton" OnClick="m_cmd_upload_Click" />
                        <asp:HiddenField ID="m_hdf_dir_save_excel" runat="Server" Value="" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <hr>
                        </td>
                </tr>
                <tr>
                    <td colspan="4" align="left">

                        <asp:Button ID="m_cmd_kiem_tra_va_import" runat="Server" Text="Kiểm tra và cập nhật danh sách bill" CssClass="cssGoogleButton"
                            OnClick="m_cmd_kiem_tra_va_import_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_dm_bill" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Đã import thành công!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="2" PageSize="200"
                            OnRowDeleting="m_grv_dm_bill_RowDeleting">
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="STT" ItemStyle-Width="4%" ItemStyle-Height="95px" HeaderStyle-Height="40px">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="10%" HeaderText="Nội dung" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox ID="m_txt_noi_dung_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" Height="70%" TextMode="MultiLine" runat="server" Text='<%#Eval("NOI_DUNG") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_noi_dung_message" runat="Server" CssClass="cssManField"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="15%" HeaderText="Nơi nhận" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox ID="m_txt_noi_nhan_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" Height="70%" TextMode="MultiLine" runat="server" Text='<%#Eval("NOI_NHAN") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_noi_nhan_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="15%" HeaderText="Người nhận" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox ID="m_txt_nguoi_nhan_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" Height="70%" TextMode="MultiLine" runat="server" Text='<%#Eval("NGUOI_NHAN") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_nguoi_nhan_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="10%" HeaderText="Loại thư" ItemStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:RadioButton ID="m_rdb_trong_nuoc" runat="Server" Text="Trong nước" GroupName="LoaiThu"
                                            Checked='<%#Eval("TRONG_NUOC").ToString().Trim().ToUpper().Equals("X")?true:false %>' />
                                        <br />
                                        <asp:RadioButton ID="m_rdb_nuoc_ngoai" runat="Server" Text="Nước ngoài" GroupName="LoaiThu"
                                            Checked='<%#Eval("NGOAI_NUOC").ToString().Trim().ToUpper().Equals("X")?true:false %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="8%" HeaderText="Số bill" ItemStyle-HorizontalAlign="Right" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox ID="m_txt_so_bill_grid" CssClass="cssTextBoxGrid" Style="text-align: right" AutoPostBack="true" Height="50%" runat="server" Text='<%#Eval("SO_BILL") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_so_bill_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="10%" HeaderText="Người gửi" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox Style="text-align: left" CssClass="cssTextBoxGrid" ID="m_txt_nguoi_gui_grid" Height="70%" AutoPostBack="false" runat="server" TextMode="MultiLine" Text='<%#Eval("NGUOI_GUI") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_nguoi_gui_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="10%" HeaderText="Ngày gửi" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <ew:CalendarPopup ID="m_dat_ngay_gui" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                                            TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN" SelectedDate='<%#Eval("NGAY_GUI") %>'
                                            DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                                            ShowGoToToday="true" Width="70%">
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
                                        <br />
                                        <asp:Label ID="m_lbl_ngay_gui_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="8%" HeaderText="Mã phòng ban" ItemStyle-HorizontalAlign="Right" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox Style="text-align: center" CssClass="cssTextBoxGrid" ID="m_txt_ma_phong_ban_grid" Height="50%" AutoPostBack="false" runat="server" Text='<%#Eval("MA_PHONG_BAN") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_ma_phong_ban_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="10%" HeaderText="Ghi chú" ItemStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <asp:TextBox ID="m_txt_ghi_chu_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" Height="70%" TextMode="MultiLine" runat="server" Text='<%#Eval("GHI_CHU") %>'></asp:TextBox>
                                        <br />
                                        <asp:Label ID="m_lbl_ghi_chu_message" runat="Server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


