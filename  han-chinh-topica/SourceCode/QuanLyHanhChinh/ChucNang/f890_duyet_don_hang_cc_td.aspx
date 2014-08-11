<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f890_duyet_don_hang_cc_td.aspx.cs" Inherits="ChucNang_f890_duyet_don_hang_cc_td" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanelAll" runat="server">
        <ContentTemplate>
            <div style="text-align: center">
                <asp:Label ID="m_lbl_header" runat="server" Text="DUYỆT ĐƠN ĐẶT HÀNG" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <br />
                <asp:Label ID="m_lbl_title" runat="server" CssClass="cssManField" Font-Bold="true" Font-Size="Medium" ForeColor="GrayText"></asp:Label>
            </div>
            <br />
            <br />
            <div style="text-align: center">
                <asp:Label ID="m_lbl_chon_thang" runat="server" Text="Chọn tháng"> </asp:Label>
                &nbsp<ew:CalendarPopup ID="m_dat_thang" runat="server" TextBoxLabelStyle-BorderColor="#810913"
                    TextBoxLabelStyle-BorderWidth="1" ControlDisplay="TextBoxImage" Culture="vi-VN"
                    DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                    ShowGoToToday="true" Width="10%">
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
            </div>
            <br />
            <table cellspacing="0" cellpadding="2" style="width: 100%">
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label1" runat="Server" Text="Tổng tiền định mức: "></asp:Label>&nbsp&nbsp
                        &nbsp&nbsp<asp:Label ID="Label3" runat="Server" Text="0"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label4" runat="Server" Text=" Số tiền đã chi thực tế: "></asp:Label>
                        &nbsp&nbsp<asp:Label ID="Label5" runat="Server" Text="0"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td>
                        <asp:GridView ID="m_grv_don_hang_nhap" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không có đơn hàng nào!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20">
                            <%--OnRowEditing="m_grv_don_hang_nhap_RowEditing"
                        OnRowDeleting="m_grv_don_hang_nhap_RowDeleting"
                        OnPageIndexChanging="m_grv_don_hang_PageIndexChanging">--%>
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <asp:TemplateField HeaderText="Không duyệt" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="m_lbt_delete" runat="server" CommandName="Delete" ToolTip="Xóa">
                                            <%--OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')">--%>
                                                <img src="../Images/Button/deletered.png" alt="Delete" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle />
                                </asp:TemplateField>
                                <asp:CommandField ItemStyle-Width="1%" EditText="Duyệt" EditImageUrl="../Images/Button/edit.png"
                                    ShowEditButton="true" ButtonType="Image" HeaderText="Duyệt" ItemStyle-HorizontalAlign="Center"
                                    HeaderStyle-HorizontalAlign="Center">   
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" Width="1%" />
                                </asp:CommandField>
                                <%--<asp:TemplateField HeaderText="Chi tiết" ItemStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="m_lbt_detail" runat="server" CommandName="Detail" ToolTip="Chi tiết">   
                                            OnClick="m_lbt_detail_OnClick">
                                                <img src="../Images/Button/detail.png" alt="Detail" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle />
                                </asp:TemplateField>--%>
                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                        <headerstyle width="10px" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="1%" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="NGAY_DAT_HANG" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY ĐẶT HÀNG"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="MA" ItemStyle-HorizontalAlign="left" HeaderText="Mã hóa đơn"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="LAN" ItemStyle-HorizontalAlign="Left" HeaderText="LẦN GỬI"
                                    ItemStyle-Width="3%">
                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GIA_TRI_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GIA_TRI_DA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="SO_TIEN_SAU_DON" ItemStyle-HorizontalAlign="Right" HeaderText="Số tiền chi sau đơn (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PHAN_TRAM_VUOT" ItemStyle-HorizontalAlign="Right" HeaderText="Phần trăm vượt (%)"
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

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>



