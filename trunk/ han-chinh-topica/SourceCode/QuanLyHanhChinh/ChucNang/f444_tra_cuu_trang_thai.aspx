<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="f444_tra_cuu_trang_thai.aspx.cs" Inherits="ChucNang_f444_tra_cuu_trang_thai" %>

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
            <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" Text="Tra cứu trạng thái"
                            ForeColor="White" />
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                        <asp:hiddenfield ID="m_hdf_id_trung_tam" runat="server"></asp:hiddenfield>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:label ID="Label1" runat ="server"  CssClass="cssManField" text="Trung tâm-ban:"></asp:label>
                    </td>
                    <td align="left">
                        <asp:label ID="m_lbl_ten_trung_tam" runat ="server"  CssClass="cssManField" Font-Bold="true" Font-Size="Medium"></asp:label>
                    </td>
                    <td align="right">
                        <asp:Label ID="m_lbl_tu_ngay" runat="server" Text="Từ ngày: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <ew:CalendarPopup ID="m_dat_tu_ngay" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                            TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN"
                            DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                            ShowGoToToday="false" Width="35%" 
                            ondatechanged="m_dat_tu_ngay_DateChanged">
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
                 <%--   <td align="right">
                        <asp:Label ID="m_lbl_trung_tam" runat="server" Text="Chọn trung tâm: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_trung_tam" runat="server" CssClass="cssDorpdownlistDefault"
                            Width="91%">
                        </asp:DropDownList>
                    </td>--%>
                    <td align="right">
                        <asp:Label ID="m_lbl_trang_thai" runat="server" Text="Trạng thái: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_trang_thai" runat="server" CssClass="cssDorpdownlistDefault"
                            Width="45%">
                        </asp:DropDownList>
                    </td>
                     <td align="right">
                        <asp:Label ID="m_lbl_den_ngay" runat="server" Text="Đến ngày: " CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <ew:CalendarPopup ID="m_dat_den_ngay" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                            TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN"
                            DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                            ShowGoToToday="true" Width="35%" 
                            ondatechanged="m_dat_den_ngay_DateChanged">
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
            </table>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_danh_muc_bill" runat="server" CssClass="cssPageTitle" ForeColor="White"
                            Text="Danh mục Bill theo trạng thái"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssManField" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:TextBox ID="m_txt_tim_kiem" runat="server" Width="400px" CssClass="cssTextBox"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" Text="Tìm kiếm" CssClass="cssGoogleButton" CausesValidation="false" OnClick="m_cmd_tim_kiem_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_v_dm_bill" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không có dữ liệu phù hợp!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20" OnPageIndexChanging="m_grv_v_dm_bill_PageIndexChanging">
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <%-- <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
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
                           <%--     <asp:BoundField DataField="TEN_PHONG_BAN" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN TRUNG TÂM"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="12%" />
                                </asp:BoundField>--%>
                                <asp:BoundField DataField="SO_BILL" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ BILL"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="3%" />
                                </asp:BoundField>
                                  <asp:BoundField DataField="TRANG_THAI_THU" ItemStyle-HorizontalAlign="Left" HeaderText="TRẠNG THÁI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                 <asp:BoundField DataField="SO_TIEN" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ TIỀN (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NGAY_GUI" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY GỬI"
                                    ItemStyle-Width="7%"  HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Left" Width="3%" />
                                </asp:BoundField>
                                     <asp:BoundField DataField="NGUOI_GUI" ItemStyle-HorizontalAlign="Left" HeaderText="NGƯỜI GỬI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NGUOI_NHAN" ItemStyle-HorizontalAlign="Left" HeaderText="NGƯỜI NHẬN"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                  <asp:BoundField DataField="NOI_NHAN" ItemStyle-HorizontalAlign="Left" HeaderText="NƠI NHẬN"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="15%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NOI_DUNG" ItemStyle-HorizontalAlign="Left" HeaderText="NỘI DUNG"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="5%" />
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
