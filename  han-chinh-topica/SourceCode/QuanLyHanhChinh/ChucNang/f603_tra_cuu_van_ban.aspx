<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f603_tra_cuu_van_ban.aspx.cs" Inherits="ChucNang_f603_tra_cuu_van_ban" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Import Namespace ="IP.Core.IPCommon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_cbo_phong_ban.ClientID%>").select2();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
   <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="4">
                        <asp:Label ID="m_lbl_tra_cuu_van_ban" Text="Tra cứu văn bản" runat="server" CssClass="cssPageTitle"
                            ForeColor="DarkBlue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%" align="right">
                        <asp:Label ID="m_lbl_phong_ban" runat="server" class="cssManField">Phòng ban </asp:Label>
                    </td>
                    <td style="width: 20%" align="left">
                        <asp:DropDownList ID="m_cbo_phong_ban" Width="50%" runat="server"></asp:DropDownList>
                    </td>
                    <td style="width: 10%" align="right">
                        <span class="cssManField">Từ khoá</span>
                    </td>
                    <td style="width: 40%" align="left">
                        <asp:TextBox ID="m_txt_tu_khoa" runat="server" CssClass="cssTextBox"></asp:TextBox>
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" CssClass="cssGoogleButton" Text="Tìm kiếm" OnClick="m_cmd_tim_kiem_Click" />
                    </td>
                </tr>
                <%--<tr>
                    <td align="right">
                        <span class="cssManField">Loại công văn </span>
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="m_cbo_loai_cong_van" Width="50%" runat="server" class="cssDorpdownlist"></asp:DropDownList>
                    </td>
                </tr>--%>
            </table>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG">
                        <asp:Label ID="m_grv_title" Text="Thông tin văn bản" runat="server" CssClass="cssPageTitle"
                            ForeColor="DarkBlue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="m_grv_dm_bill" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="100%" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không tìm thấy dữ liệu phù hợp!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="2" PageSize="50"
                            AllowSorting="true"
                            OnRowCommand="m_grv_dm_bill_RowCommand"
                            >
                            <PagerSettings Position="TopAndBottom" />
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="GridViewRowStyle" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="GridViewHeaderStyle" />
                            <Columns>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="STT" ItemStyle-Width="4%" ItemStyle-Height="40px" HeaderStyle-Height="40px">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <%--<asp:BoundField DataField="NGAY_LAP" HeaderText="Ngày lâp" DataFormatString="{0:dd/MM/yyyy}" />--%>
                                <asp:TemplateField HeaderText="Ngày tháng trên văn bản" >
                                    <ItemTemplate>
                                        <asp:Label ID="m_lbl_ngay_thang_tren_van_ban_grid" runat="server" 
                                            Text='<%#Eval("NGAY_THANG_TREN_CONG_VAN").ToString().Equals("")? "N/A":
                                       CIPConvert.ToDatetime(Eval("SO_CV_DEN"),"dd/MM/yyyy").ToString()%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số công văn đến" >
                                    <ItemTemplate>
                                        <asp:Label ID="m_lbl_so_cong_van_den_grid" runat="server" Text='<%#Eval("SO_CV_DEN").ToString().Equals("")? "N/A": Eval("SO_CV_DEN")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="SO_VA_KY_HIEU" HeaderText="Số và ký hiệu" />
                                <asp:BoundField DataField="TEN_LOAI_VA_TRICH_YEU_ND" HeaderText="Tên loại và trích yếu nội dung" />
                                <asp:TemplateField HeaderText="Người ký" >
                                    <ItemTemplate>
                                        <asp:Label ID="m_lbl_so_cong_van_den_grid" runat="server" Text='<%#Eval("NGUOI_KY").ToString().Equals("")? "N/A": Eval("NGUOI_KY")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%--<asp:BoundField DataField="NOI_GUI" HeaderText="Nơi gửi" />
                                <asp:BoundField DataField="NOI_NHAN" HeaderText="Nơi nhận" />--%>
                                <asp:BoundField DataField="NOI_NGUOI_NHAN_MPB" HeaderText="Nơi nhận" />
                                <asp:BoundField DataField="NGUOI_NHAN__BAN_LUU_MPB" HeaderText="Nơi phát hành" />
                                <asp:TemplateField HeaderText="Xem file scan" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:Button ID="m_hlk_link_scan" Height="100%" Width="100%" Text="Xem file" Visible='<%#is_enable_view(Eval("LINK_SCAN").ToString()) %>'
                                             style="cursor:pointer;" runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="TaiFile"></asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>

