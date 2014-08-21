<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="f601_import_bill_from_excel_TNE.aspx.cs" Inherits="ChucNang_f601_import_bill_from_excel_TNE" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Import Namespace="IP.Core.IPCommon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            //$(".txtdatetime").datepicker();
            $(".txtdatetime").datepicker({
                //buttonImageOnly: true,
                changeMonth: true,
                changeYear: true,
                required: true,
                yearRange: '1950:2050',
                //onClose: function () {
                //    var a = $(this).valid();
                //},
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_header" runat="server" CssClass="cssManField" Text="IMPORT DANH SÁCH THƯ FILE EXCEL VÀ GỬI CHO TAD" Font-Size="X-Large" Font-Bold="true"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                <asp:Label ID="m_lbl_ten_trung_tam" runat="server" CssClass="cssManField" ForeColor="GrayText" Font-Bold="true" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
                <asp:HiddenField ID="m_hdf_so_ban_ghi" runat="server" />
                <asp:HiddenField ID="m_hdf_so_trang" runat="server" />
                <asp:HiddenField ID="m_hdf_so_ban_ghi_da_them" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="m_lbl_message" runat="Server"></asp:Label></td>
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
    <table border="0" cellspacing="0" cellpadding="0" width="60%">
        <tr>
            <td align="right" colspan="2">
                <asp:HyperLink ID="m_lnk_import_mau" runat="server" Text="Tải file import mẫu tại đây" ForeColor="Blue" Font-Italic="false" NavigateUrl="https://docs.google.com/uc?authuser=0&id=0BwKzsZuPh5A1SkpnSV83eDh0bHM&export=download" Target="blank"></asp:HyperLink>&nbsp;
            </td>
            <td colspan="2">&nbsp;<asp:Label ID="ghi_chu" runat="server" CssClass="cssManField" Text="(*File import phải là file Excel đuôi .xls)" ForeColor="Gray" Font-Size="Smaller"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" CssClass="cssManField" Font-Bold="true"></asp:Label></td>
            <td align="right">
                <asp:Label ID="Label1" runat="server" Text="Bước 1:" CssClass="cssManField" Font-Bold="true"></asp:Label>
            </td>
            <td align="left">
                <asp:FileUpload ID="m_fu_chon_file_import" runat="Server" EnableViewState="false" BorderStyle="Groove" BackColor="SteelBlue" ForeColor="White" BorderColor="WhiteSmoke" ToolTip="Chọn đường dẫn đến file Excel DS Bill cần gửi" />
            </td>

            <td align="right">
                <asp:Button ID="m_cmd_upload" runat="Server" Text="Bước 2: Hiển thị danh sách Bill" CssClass="cssGoogleButton" OnClick="m_cmd_upload_Click" />
                <asp:HiddenField ID="m_hdf_dir_save_excel" runat="Server" Value="" />
            </td>
            <td align="right">
                <asp:Button ID="m_cmd_kiem_tra_va_import" runat="Server" Text="Bước 3:Kiểm tra và Gửi cho TAD" CssClass="cssGoogleButton"
                    OnClick="m_cmd_kiem_tra_va_import_Click" />
            </td>
        </tr>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table width="100%">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">
                            <asp:Label ID="m_lbl_danh_muc_bill" runat="server" CssClass="cssPageTitle" ForeColor="DarkBlue"
                                Text="Danh sách các Bill đã được import"></asp:Label>
                            <asp:Label ID="m_lbl_thong_tim_grv_dm_bill" runat="server" CssClass="cssPageTitle"
                                ForeColor="DarkBlue"></asp:Label>
                            <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <asp:GridView ID="m_grv_dm_bill" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                                Width="99%" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                                EmptyDataText="Đã import thành công!" EmptyDataRowStyle-BorderColor="#810913"
                                CellPadding="2" PageSize="50"
                                OnRowDeleting="m_grv_dm_bill_RowDeleting"
                                OnPageIndexChanging="m_grv_dm_bill_PageIndexChanging"
                                AllowSorting="true">
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
                                    <asp:TemplateField ItemStyle-Width="10%" HeaderText="Nội dung" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox ID="m_txt_noi_dung_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" TextMode="MultiLine" ToolTip="Nhập nội dung gửi" runat="server" Text='<%#Eval("NOI_DUNG") %>'></asp:TextBox>
                                            <%-- <br />--%>
                                            <%--<asp:Label ID="m_lbl_noi_dung_message" runat="Server" CssClass="cssManField"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="15%" HeaderText="Nơi nhận" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox ID="m_txt_noi_nhan_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" TextMode="MultiLine" ToolTip="Nơi nhận không hợp lệ" runat="server" Text='<%#Eval("NOI_NHAN") %>'></asp:TextBox>
                                            <%-- <br />
                                            <asp:Label ID="m_lbl_noi_nhan_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="15%" HeaderText="Người nhận" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox ID="m_txt_nguoi_nhan_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" TextMode="MultiLine" runat="server" Text='<%#Eval("NGUOI_NHAN") %>'></asp:TextBox>
                                            <%-- <br />
                                            <asp:Label ID="m_lbl_nguoi_nhan_message" runat="Server"></asp:Label>--%>
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
                                            <asp:TextBox ID="m_txt_so_bill_grid" CssClass="cssTextBoxGrid" Style="text-align: right" AutoPostBack="true" Height="70%" runat="server" Text='<%#Eval("SO_BILL") %>'></asp:TextBox>
                                            <%-- <br />
                                            <asp:Label ID="m_lbl_so_bill_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="10%" HeaderText="Người gửi" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox Style="text-align: left" CssClass="cssTextBoxGrid" ID="m_txt_nguoi_gui_grid" AutoPostBack="false" runat="server" TextMode="MultiLine" Text='<%#Eval("NGUOI_GUI") %>'></asp:TextBox>
                                            <%--  <br />
                                            <asp:Label ID="m_lbl_nguoi_gui_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="10%" HeaderText="Ngày gửi" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox Style="text-align: center" CssClass="cssTextBoxGrid txtdatetime" ID="m_txt_ngay_gui_grid" AutoPostBack="false" runat="server" Text='<%#Eval("NGAY_GUI") %>'></asp:TextBox>
                                            <%-- <br />
                                            <asp:Label ID="m_lbl_ngay_gui_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="8%" HeaderText="Mã phòng ban" ItemStyle-HorizontalAlign="Right" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox Style="text-align: center" CssClass="cssTextBoxGrid" ID="m_txt_ma_phong_ban_grid" AutoPostBack="false" ToolTip="Nhập mã phòng ban" runat="server" Text='<%#Eval("MA_PHONG_BAN") %>'></asp:TextBox>
                                            <%-- <br />
                                            <asp:Label ID="m_lbl_ma_phong_ban_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="10%" HeaderText="Ghi chú" ItemStyle-VerticalAlign="Top">
                                        <ItemTemplate>
                                            <asp:TextBox ID="m_txt_ghi_chu_grid" CssClass="cssTextBoxGrid" AutoPostBack="false" TextMode="MultiLine" ToolTip="Nhập ghi chú" runat="server" Text='<%#Eval("GHI_CHU") %>'></asp:TextBox>
                                            <%--  <br />
                                            <asp:Label ID="m_lbl_ghi_chu_message" runat="Server"></asp:Label>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </table>

</asp:Content>

