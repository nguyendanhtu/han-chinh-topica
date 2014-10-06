<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="f570_tra_cuu_don_dat_hang.aspx.cs" Inherits="ChucNang_f570_tra_cuu_don_dat_hang" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_txt_thang.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true,
                required: true,
                yearRange: '1950:2050',
                dateFormat: 'mm/yy'
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_header" runat="server" Text="TRA CỨU ĐƠN ĐẶT HÀNG" CssClass="cssManField"
                    Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:Label ID="m_lbl_ten_trung_tam" runat="server" CssClass="cssManField" Font-Bold="true"
                    Font-Size="Medium" ForeColor="GrayText"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_ngay_gui" runat="Server" Text="Tháng" CssClass="cssManField"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="m_txt_thang" runat="Server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_tim_kiem" runat="Server" Text="Nội dung tìm kiếm " CssClass="cssManField"></asp:Label>
                &nbsp;
                <asp:TextBox ID="m_txt_tim_kiem" runat="server" Width="300px" Height="20px" CssClass="cssTextBox"
                    placeholder="Nhập nội dung cần tìm kiếm"></asp:TextBox>
                &nbsp;
                <asp:Button ID="m_cmd_tim_kiem" runat="server" Text="Tìm kiếm" CssClass="cssGoogleButton"
                    Width="6%" CausesValidation="false" OnClick="m_cmd_tim_kiem_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td class="cssPageTitleBG" colspan="6">
                <asp:Label ID="m_lbl_danh_sach_dh" runat="server" CssClass="cssPageTitle" Text="Danh sách đơn hàng "></asp:Label>
                <asp:Label ID="m_lbl_thong_tim_m_grv_don_hang" runat="server" CssClass="cssPageTitle"></asp:Label>
                <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssManField" />
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:HiddenField ID="m_hdf_id_don_hang" runat="server" />
            </td>
           
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="m_grv_don_hang" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                    Width="99%" AllowPaging="true" PagerStyle-HorizontalAlign="Center" EmptyDataText="Không có đơn hàng!"
                    EmptyDataRowStyle-BorderColor="#810913" CellPadding="8" PageSize="20" OnPageIndexChanging="m_grv_dm_don_hang_PageIndexChanging"
                    OnRowCommand="m_grv_don_hang_RowCommand">
                    <PagerSettings Position="TopAndBottom" />
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle CssClass="GridViewFooterStyle" />
                    <RowStyle CssClass="GridViewRowStyle" />
                    <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                    <PagerStyle CssClass="GridViewPagerStyle" />
                    <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                    <HeaderStyle CssClass="GridViewHeaderStyle" />
                    <Columns>
                        <asp:TemplateField HeaderText="Chi tiết" ItemStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:LinkButton ID="m_lbt_detail" runat="server" CommandName="Detail" CommandArgument='<%#Eval("ID") %>'
                                    ToolTip="Chi tiết">
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
                        <asp:BoundField DataField="LAN" ItemStyle-HorizontalAlign="Left" HeaderText="LẦN ĐẶT HÀNG"
                            ItemStyle-Width="5%">
                            <ItemStyle HorizontalAlign="Right" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NGAY_DAT_HANG" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY ĐẶT HÀNG"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                            <ItemStyle HorizontalAlign="Left" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MA" ItemStyle-HorizontalAlign="Left" HeaderText="MÃ HÓA ĐƠN"
                            ItemStyle-Width="7%">
                            <ItemStyle HorizontalAlign="Left" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GIA_TRI_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GIA_TRI_DA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                            ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                            <ItemStyle HorizontalAlign="Right" Width="7%" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel_grv_detail" runat="server">
        <ContentTemplate>
            <asp:Panel ID="m_pnl_detail_grv" runat="server">
                <div class="cssLoadWapper">
                    <asp:MultiView ID="mtv_detail" runat="server">
                        <asp:View ID="View_detail" runat="server">
                            <div class="cssLoadContent2" style="width: 100%; margin: 100px auto 0 auto; overflow-y: scroll;">
                                <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                    <tr>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="m_lbl_grv_detail" runat="server" CssClass="cssPageTitle" BackColor="White"></asp:Label>
                                        </td>
                                        <td align="center" style="width: 60%">
                                            <asp:Label ID="m_lbl_ten_detail" runat="server" CssClass="cssPageTitle" Font-Size="Large"
                                                BackColor="White"></asp:Label>
                                                <asp:HiddenField ID="m_hdf_id_don_hang_detail" runat="server"></asp:HiddenField>
                                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            <asp:Label ID="m_lbl_pop_tong_tien_tl" runat="server" Text="Tổng tiền (đã VAT):" CssClass="cssManField" Font-Bold="true" BackColor="White"></asp:Label>
                                            &nbsp&nbsp
                                            <asp:Label ID="m_lbl_pop_tong_tien" runat="server" Text="---------" CssClass="cssManField" ForeColor="Red" Font-Bold="true" BackColor="White"></asp:Label>
                                        </td>
                                        <td align="right" style="width: 20%">
                                            <asp:ImageButton ID="_cmd_detail_exit" ImageUrl="../Images/Button/exit.png" Width="45px"
                                                Height="30px" runat="server" OnClick="m_cmd_detail_exit_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <asp:GridView ID="m_grv_detail" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                                            EmptyDataText="Chưa có dữ liệu báo cáo!" EmptyDataRowStyle-BorderColor="#810913"
                                            CellPadding="8" PageSize="7" OnPageIndexChanging="m_grv_detail_PageIndexChanging">
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
                                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <%# Container.DataItemIndex + 1 %>
                                                        <headerstyle width="15px" />
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="2%" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="MA_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="MÃ VPP"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Right" Width="3%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TEN_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN VPP"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Left" Width="7%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="SO_LUONG" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ LƯỢNG"
                                                    ItemStyle-Width="7%" HtmlEncode="false">
                                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                                                    ItemStyle-Width="7%" HtmlEncode="false">
                                                    <ItemStyle HorizontalAlign="Left" Width="3%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ(VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="THANH TOÁN (VNĐ)" ItemStyle-Width="7%" ItemStyle-HorizontalAlign="Right">
                                                    <ItemTemplate>
                                                    <asp:Label ID="m_lbl_thanh_toan" runat="server" Text='<%#get_so_tien_thanh_toan(Eval("SO_LUONG").ToString(),Eval("DON_GIA_CHUA_VAT").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                            </div>
                        </asp:View>
                    </asp:MultiView>
                    </tr> </table>
                </div>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
