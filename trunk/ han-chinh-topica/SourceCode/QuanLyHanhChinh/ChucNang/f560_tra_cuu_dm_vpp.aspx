<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f560_tra_cuu_dm_vpp.aspx.cs" Inherits="ChucNang_f560_tra_cuu_dm_vpp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
 <tr>
 <td align="center" colspan=4 >
 <asp:Label ID="m_lbl_header" runat="server" Text="TRA CỨU DANH MỤC VĂN PHÒNG PHẨM" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
 </td>
 </tr>
 <tr>
            <td align="left">
                <asp:Label ID="m_lbl_nha_cc" runat="server" Text="Nhà cung cấp : " CssClass="cssManField"></asp:Label>
      
                <asp:DropDownList ID="m_cbo_nha_cc" runat="server" CssClass="cssDorpdownlistDefault"
                    Width="30%">
                </asp:DropDownList>
            </td>
        </tr>
 <tr>
                    <td align="center" colspan="4">
                        <asp:Label ID="Label2" runat="server" Text="Nội dung tìm kiếm " CssClass="cssManField"></asp:Label>
                        <asp:TextBox ID="m_txt_tim_kiem" runat="server" Width="350px" Height="20px" CssClass="cssTextBox" placeholder="Nhập mã , tên VPP"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" Text="Tìm kiếm" CssClass="cssGoogleButton" CausesValidation="false" OnClick="m_cmd_tim_kiem_Click" />
                    </td>
                </tr>
</table>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">
                            <asp:Label ID="m_lbl_danh_muc_vpp" runat="server" CssClass="cssPageTitle"
                                Text="Danh mục văn phòng phẩm "></asp:Label>
                            <asp:Label ID="m_lbl_thong_tim_grv_dm_vpp" runat="server" CssClass="cssPageTitle"></asp:Label>
                            <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
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
                <asp:GridView ID="m_grv_dm_vpp" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                    Width="99%"  AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                    EmptyDataText="Không có mặt hàng!" EmptyDataRowStyle-BorderColor="#810913"
                    CellPadding="8" PageSize="20"
                    OnPageIndexChanging="m_grv_dm_vpp_PageIndexChanging">
                    <PagerSettings Position="TopAndBottom" />
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle CssClass="GridViewFooterStyle" />
                    <RowStyle CssClass="GridViewRowStyle" />
                    <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                    <PagerStyle CssClass="GridViewPagerStyle" />
                    <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                    <HeaderStyle CssClass="GridViewHeaderStyle" />
                    <Columns>
                        <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                                <headerstyle width="15px" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="2%" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="MA" ItemStyle-HorizontalAlign="Left" HeaderText="MÃ VPP"
                            ItemStyle-Width="5%">
                            <ItemStyle HorizontalAlign="Right" Width="12%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TEN_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN VPP"
                            ItemStyle-Width="7%">
                            <ItemStyle HorizontalAlign="Left" Width="12%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                            ItemStyle-Width="7%">
                            <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DON_GIA_GOM_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
 </table>
</asp:Content>

