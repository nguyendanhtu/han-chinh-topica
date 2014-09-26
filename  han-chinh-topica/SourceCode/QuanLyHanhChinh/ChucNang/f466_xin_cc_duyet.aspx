<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f466_xin_cc_duyet.aspx.cs" Inherits="ChucNang_f466_xin_cc_duyet" %>

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
                <asp:Label ID="m_lbl_header" runat="server" Text="DUYỆT ĐƠN ĐẶT HÀNG (CC)" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <br />
                <asp:Label ID="m_lbl_title" runat="server" CssClass="cssManField" Font-Bold="true" Font-Size="Medium" ForeColor="GrayText"></asp:Label>
            </div>
            <br />
            <br />
            <div style="text-align: center">
                <asp:Label ID="m_lbl_chon_thang" runat="server" Text="Chọn tháng"> </asp:Label>
                <asp:DropDownList ID="m_cbo_chon_thang" runat="server" CssClass="cssDorpdownlist"  OnSelectedIndexChanged="m_cbo_chon_thang_OnSelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Value="1">Tháng 1 </asp:ListItem>
                    <asp:ListItem Value="2">Tháng 2</asp:ListItem>
                    <asp:ListItem Value="3">Tháng 3</asp:ListItem>
                    <asp:ListItem Value="4">Tháng 4 </asp:ListItem>
                    <asp:ListItem Value="5">Tháng 5 </asp:ListItem>
                    <asp:ListItem Value="6">Tháng 6</asp:ListItem>
                    <asp:ListItem Value="7">Tháng 7</asp:ListItem>
                    <asp:ListItem Value="8">Tháng 8 </asp:ListItem>
                    <asp:ListItem Value="9">Tháng 9 </asp:ListItem>
                    <asp:ListItem Value="10">Tháng 10</asp:ListItem>
                    <asp:ListItem Value="11">Tháng 11</asp:ListItem>
                    <asp:ListItem Value="12">Tháng 12</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <table cellspacing="0" cellpadding="2" style="width: 100%">
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label1" runat="Server" Text="Tổng tiền định mức: "></asp:Label>&nbsp&nbsp
                        &nbsp&nbsp<asp:Label ID="m_lbl_tong_tien_dm" runat="Server" Text="0"></asp:Label>
                        <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
                        <asp:HiddenField ID="m_hdf_ma_trung_tam" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="m_lbl_so_tien_da_chi" runat="Server" Text=" Số tiền đã chi thực tế: "></asp:Label>
                        &nbsp&nbsp<asp:Label ID="m_lbl_tong_tien_da_chi" runat="Server" Text="0"></asp:Label>
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
                            CellPadding="8" PageSize="20"
                            OnRowCommand="m_grv_don_hang_nhap_RowCommand">
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
                                        <asp:LinkButton ID="m_lbt_khong_duyet" runat="server" CommandName="KhongDuyet" ToolTip="Không duyệt đơn này" CommandArgument='<%#Eval("ID") %>'
                                            OnClientClick="return confirm ('Bạn có thực sự muốn huỷ duyệt đơn hàng này?')">
                                                <img src="../Images/Button/deletered.png" alt="Huỷ duyệt" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Duyệt" ItemStyle-Width="1%" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="m_lbt_duyet" runat="server" CommandName="Duyet" ToolTip="Không duyệt đơn này" CommandArgument='<%#Eval("ID") %>'
                                            OnClientClick="return confirm ('Bạn có thực sự muốn duyệt đơn hàng này?')">
                                                <img src="../Images/Button/Update.gif" alt="Duyệt" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle />
                                </asp:TemplateField>
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
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:F3}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GIA_TRI_DA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:F3}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="SO_TIEN_SAU_DON" ItemStyle-HorizontalAlign="Right" HeaderText="Số tiền chi sau đơn (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:F3}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PHAN_TRAM_VUOT" ItemStyle-HorizontalAlign="Right" HeaderText="Phần trăm vượt (%)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:F3}">
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
