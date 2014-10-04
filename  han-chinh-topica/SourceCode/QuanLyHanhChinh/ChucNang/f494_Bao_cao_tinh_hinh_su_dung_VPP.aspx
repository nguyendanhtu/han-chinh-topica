<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f494_Bao_cao_tinh_hinh_su_dung_VPP.aspx.cs" Inherits="ChucNang_f494_Bao_cao_tinh_hinh_su_dung_VPP" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <%--    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_txt_tu_ngay.ClientID%>").datepicker({
                    changeMonth: true,
                    changeYear: true,
                    required: true,
                    yearRange: '1950:2050',
                });
            });
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_txt_den_ngay.ClientID%>").datepicker({
                    changeMonth: true,
                    changeYear: true,
                    required: true,
                    yearRange: '1950:2050',
                });
            });
    </script>--%>
    <script type="text/javascript">
        $(function () {
            $("#<%=m_txt_tu_ngay.ClientID%>").datepicker({
                defaultDate: "+1w",
                changeMonth: true,
                onClose: function (selectedDate) {
                    $("#<%=m_txt_den_ngay.ClientID%>").datepicker("option", "minDate", selectedDate);
                }
            });
            $("#<%=m_txt_den_ngay.ClientID%>").datepicker({
                defaultDate: "+1w",
                changeMonth: true,
                onClose: function (selectedDate) {
                    $("#<%=m_txt_tu_ngay.ClientID%>").datepicker("option", "maxDate", selectedDate);
                }
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table cellspacing="0" cellpadding="1" style="width: 100%" class="cssTable" border="0">
        <tr>
            <td align="center">
                <asp:Label ID="m_lbl_header" runat="server" Text="BÁO CÁO TÌNH HÌNH SỬ DỤNG VĂN PHÒNG PHẨM" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server"></asp:HiddenField>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="m_lbl_ten_trung_tam" runat="server" CssClass="cssManField" ForeColor="GrayText" Font-Bold="true" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <br />

            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="m_lbl_tu_ngay" runat="server" Text="Từ ngày " CssClass="cssManField"></asp:Label>

                <asp:TextBox ID="m_txt_tu_ngay" runat="Server" Width="7%" OnTextChanged="Tu_ngay_OnTextChanged" AutoPostBack="true"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="m_lbl_den_ngay" runat="server" Text="Đến ngày " CssClass="cssManField"></asp:Label>

                <asp:TextBox ID="m_txt_den_ngay" runat="Server" Width="7%" OnTextChanged="Den_ngay_OnTextChanged" AutoPostBack="true"></asp:TextBox>
                &nbsp;&nbsp;
  <%--              <asp:Label ID="m_lbl_nguoi_gui" runat="server" Text="Người gửi" CssClass="cssManField"></asp:Label>

                <asp:TextBox ID="m_txt_nguoi_gui_tk" runat="Server" CssClass="cssTextBox" placeholder="Tất cả người gửi" Width="12%" ToolTip="Nhập tên người gửi để xem báo cáo theo người gửi" AutoPostBack="true"></asp:TextBox>
                &nbsp;&nbsp;--%>
                <asp:Button ID="m_cmd_xem_bao_cao" runat="server" Text="Xem báo cáo" CssClass="cssGoogleButton" OnClick="m_cmd_xem_bao_cao_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <br />
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel_grv_detail" runat="server">
        <ContentTemplate>
            <asp:Panel ID="m_pnl_detail_grv" runat="server">
                <div class="cssLoadWapper">
                    <asp:MultiView ID="mtv_detail" runat="server">
                        <asp:View ID="View_detail" runat="server">
                            <div class="cssLoadContent2" style="width: 100%; scrollbar-highlight-color:blue; min-height: 80%; max-height: 80%; margin: 100px auto 0 auto; overflow-y: scroll;">
                                <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                    <tr>
                                        <td align="left" style="width: 20%">
                                            &nbsp&nbsp&nbsp&nbsp
                                            <asp:Label ID="m_lbl_grv_detail" runat="server" CssClass="cssManField" BackColor="White"></asp:Label>
                                        </td>
                                        <td align="center" style="width: 60%">
                                            <asp:Label ID="m_lbl_ten_detail" runat="server" CssClass="cssPageTitle"  BackColor="White"></asp:Label>
                                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            <asp:Label ID="Label1" runat="server" Text="Ngày đặt:" CssClass="cssManField" Font-Bold="true" BackColor="White"></asp:Label>
                                            &nbsp&nbsp
                                            <asp:Label ID="m_lbl_pop_ngay_dat" runat="server" Text="---------" CssClass="cssManField" Font-Bold="true" BackColor="White"></asp:Label>
                                             &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            <asp:Label ID="m_lbl_pop_tong_tien_tl" runat="server" Text="Tổng tiền (đã VAT):" CssClass="cssManField" Font-Bold="true" BackColor="White"></asp:Label>
                                            &nbsp&nbsp
                                            <asp:Label ID="m_lbl_pop_tong_tien" runat="server" Text="---------" CssClass="cssManField" ForeColor="Red" Font-Bold="true" BackColor="White"></asp:Label>

                                        </td>
                                        <td align="right" style="width: 20%">
                                            <asp:ImageButton ID="_cmd_detail_exit" ImageUrl="../Images/Button/exit.png" Width="45px" Height="30px" runat="server"
                                                OnClick="m_cmd_detail_exit_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <asp:GridView ID="m_grv_detail" runat="Server"
                                            AutoGenerateColumns="false" CssClass="GridViewStyle"
                                            Width="99%" DataKeyNames="MA_VPP" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                                            EmptyDataText="Chưa có dữ liệu báo cáo!" EmptyDataRowStyle-BorderColor="#810913"
                                            CellPadding="8" PageSize="10" OnPageIndexChanging="m_grv_detail_PageIndexChanging">
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
                                                    <ItemStyle HorizontalAlign="Left" Width="4%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TEN_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN VPP"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Left" Width="12%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Left" Width="4%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="SO_LUONG" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ LƯỢNG"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="4%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_GIA_GOM_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                                </asp:BoundField>
                                            </Columns>
                                        </asp:GridView>
                            </div>
                        </asp:View>
                    </asp:MultiView>
                    </tr>
                    </table>
                </div>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel_grv_bc" runat="server">
        <ContentTemplate>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_thong_tim_grv_dm_bill" Text="Tổng hợp báo cáo" runat="server" CssClass="cssPageTitle"></asp:Label>
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
                        <asp:GridView ID="m_grv_v_bc_tinh_hinh_VPP" runat="Server"
                            AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID_PHONG_BAN" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Chưa có dữ liệu báo cáo!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20"
                            OnPageIndexChanging="m_grv_v_bc_tinh_hinh_VPP_PageIndexChanging">
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
                                <asp:BoundField DataField="TONG_DON_HANG" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG ĐƠN HÀNG ĐÃ ĐẶT"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <%--                       <asp:BoundField DataField="TRANG_THAI" ItemStyle-HorizontalAlign="right" HeaderText="TRẠNG THÁI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>--%>
                                <asp:BoundField DataField="TONG_SO_TIEN" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN ĐÃ TÍNH VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DINH_MUC" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN ĐỊNH MỨC (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
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
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_chi_tiet_bc" runat="server" Text="Chi tiết báo cáo" CssClass="cssPageTitle"></asp:Label>
                        <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_chi_tiet_bc" runat="Server"
                            AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="MA_HD" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Chưa có dữ liệu báo cáo!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20"
                            OnPageIndexChanging="m_grv_chi_tiet_bc_PageIndexChanging"
                            OnSelectedIndexChanged="m_grv_chi_tiet_bc_SelectedIndexChanged">
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
                                <asp:TemplateField HeaderText="Chi tiết" ItemStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="m_lbt_detail" runat="server" CommandName="Detail" ToolTip="Click để xem chi tiết" OnClick="m_lbt_detail_OnClick">
                                            <img src="../Images/Button/detail.png" alt="Delete" />
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
                                <asp:BoundField DataField="NGAY_DAT_HANG" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY ĐẶT HÀNG"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="MA_HD" ItemStyle-HorizontalAlign="right" HeaderText="MÃ ĐƠN HÀNG"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="LAN" ItemStyle-HorizontalAlign="right" HeaderText="LẦN"
                                    ItemStyle-Width="4%">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GIA_TRI_CHUA_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN CHƯA VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="right" Width="7%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GIA_TRI_DA_VAT" ItemStyle-HorizontalAlign="Left" HeaderText="TỔNG TIỀN ĐÃ VAT (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
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
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

