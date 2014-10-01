<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f481_td_duyet_don_hang_1.aspx.cs" Inherits="ChucNang_f481_td_duyet_don_hang_1" %>

<%@ Import Namespace="IP.Core.IPCommon" %>
<%@ Import Namespace="BCTKUS" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title>Quản lý hành chính</title>
    <link href="~/Styles/jquery-ui.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/Admin.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/menu.css" rel="stylesheet" type="text/css" />
    <link href="~/Styles/select2.css" rel="stylesheet" />

    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery-1.8.2.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery-ui-1.8.23.min.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/select2.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/menu.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery.ui.datepicker-vi.js")%>'></script>
    <script type="text/javascript" src='<%=ResolveClientUrl("~/Scripts/jquery.dataTables.sorting.js")%>'></script>
</head>
<body style="background-color:white">
    <%--    <asp:UpdatePanel ID="UpdatePanelAll" runat="server">
        <ContentTemplate>--%>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div style="text-align: center">
            <br/>
            <asp:Label ID="m_lbl_header" runat="server" Text="DUYỆT ĐƠN ĐẶT HÀNG (TD)" CssClass="cssManField" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="m_lbl_title" runat="server" CssClass="cssManField" Font-Bold="true" Font-Size="Medium" ForeColor="GrayText"></asp:Label>
        </div>
        <br/>
        <br/>
        <div style="text-align: center">
            <asp:Label ID="m_lbl_chon_thang" runat="server" Text="Chọn tháng"></asp:Label>
            &nbsp               
                <asp:DropDownList ID="m_cbo_chon_thang" CssClass="cssDorpdownlist" OnSelectedIndexChanged="m_cbo_chon_thang_OnSelectedIndexChanged" runat="server" AutoPostBack="true">
                    <asp:ListItem runat="server" Value="1">Tháng 1 </asp:ListItem>
                    <asp:ListItem runat="server" Value="2">Tháng 2</asp:ListItem>
                    <asp:ListItem runat="server" Value="3">Tháng 3</asp:ListItem>
                    <asp:ListItem runat="server" Value="4">Tháng 4 </asp:ListItem>
                    <asp:ListItem runat="server" Value="5">Tháng 5 </asp:ListItem>
                    <asp:ListItem runat="server" Value="6">Tháng 6</asp:ListItem>
                    <asp:ListItem runat="server" Value="7">Tháng 7</asp:ListItem>
                    <asp:ListItem runat="server" Value="8">Tháng 8 </asp:ListItem>
                    <asp:ListItem runat="server" Value="9">Tháng 9 </asp:ListItem>
                    <asp:ListItem runat="server" Value="10">Tháng 10</asp:ListItem>
                    <asp:ListItem runat="server" Value="11">Tháng 11</asp:ListItem>
                    <asp:ListItem runat="server" Value="12">Tháng 12</asp:ListItem>
                </asp:DropDownList>
        </div>
        <br />
        <table runat="server" cellspacing="0" cellpadding="2" style="width: 100%">
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
        <table runat="server" border="0" cellspacing="0" cellpadding="0" width="100%">
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
                            <asp:TemplateField HeaderText="Không duyệt" ItemStyle-Width="2%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton ID="m_lbt_khong_duyet" runat="server" CommandName="KhongDuyet" ToolTip="Không duyệt đơn này" CommandArgument='<%#Eval("ID") %>'
                                        OnClientClick="return confirm ('Bạn có thực sự muốn huỷ duyệt đơn hàng này?')">
                                                <img src="../Images/Button/deletered.png" alt="Huỷ duyệt" />
                                    </asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Duyệt" ItemStyle-Width="2%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton ID="m_lbt_duyet" runat="server" CommandName="Duyet" ToolTip="Duyệt đơn hàng" CommandArgument='<%#Eval("ID") %>'
                                        OnClientClick="return confirm ('Bạn có thực sự muốn duyệt đơn hàng này?')" Visible='<%# is_td_duyet(Eval("ID").ToString(),Eval( "phan_tram_vuot").ToString()) %>'>
                                                <img src="../Images/Button/Update.gif" alt="Duyệt" />
                                    </asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Xin TAD duyệt" ItemStyle-Width="2%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton ID="m_lbt_xin_tad_duyet" runat="server" CommandName="XinTADDuyet" ToolTip="Xin TAD duyệt" CommandArgument='<%#Eval("ID") %>'
                                        OnClientClick="return confirm ('Bạn có thực sự muốn gửi cho TAD duyệt đơn hàng này?')" Visible='<%# is_tad_duyet(Eval("ID").ToString(),Eval( "phan_tram_vuot").ToString()) %>'>
                                                <img src="../Images/Button/gmail-icon.png" alt="Xin TAD duyệt" />
                                    </asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Xin CC duyệt" ItemStyle-Width="2%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton ID="m_lbt_xin_cc_duyet" runat="server" CommandName="XinCCDuyet" ToolTip="Xin CC duyệt" CommandArgument='<%#Eval("ID") %>'
                                        OnClientClick="return confirm ('Bạn có thực sự muốn gửi cho CC duyệt đơn hàng này?')" Visible='<%# is_cc_duyet(Eval("ID").ToString(),Eval( "phan_tram_vuot").ToString()) %>'>
                                                <img src="../Images/Button/gmail-icon.png" alt="Xin CC duyệt" width="24px" height="24px"/>
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
                                ItemStyle-Width="10%">
                                <ItemStyle HorizontalAlign="right" Width="7%" />
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
                                <ItemStyle HorizontalAlign="Right" Width="5%" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Xem chi tiết" ItemStyle-Width="5%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton ID="m_lbt_detail" runat="server" CommandName="Detail" OnClick=" m_lbt_detail_OnClick" ToolTip="Chi tiết">
                                            <img src="../Images/Button/detail.png" alt="Detail" />
                                    </asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle />
                            </asp:TemplateField>
                            <%--<asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center"
                                Visible="False">
                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:CommandField>--%>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>

        </table>

        <%--        </ContentTemplate>
    </asp:UpdatePanel>--%>
        <asp:Panel ID="m_pnl_detail_grv" runat="server">
            <div class="cssLoadWapper">
                <asp:MultiView ID="mtv_detail" runat="server">
                    <asp:View ID="View_detail" runat="server">
                        <div class="cssLoadContent2" style="width: 100%; max-height: 85%; min-height: 75%; margin: 100px auto 0 auto; overflow-y: scroll;">
                            <table runat="server" cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="m_lbl_MP" runat="Server" Text="MP:" CssClass="cssManField"></asp:Label>
                                        &nbsp
                        <asp:Label ID="m_lbl_ma_don_hang_de" runat="Server" Text="..." CssClass="cssManField" Font-Bold="true" ForeColor="DarkRed"></asp:Label>
                                    </td>
                                    <td colspan="3" align="left">
                                        <asp:Label ID="Label2" runat="Server" Text="Tổng tiền:" CssClass="cssManField"></asp:Label>
                                        &nbsp&nbsp
                                    <asp:Label ID="m_lbl_tong_tien" runat="server" Text="0" CssClass="cssManField"></asp:Label>
                                        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                      <asp:Label ID="Label3" runat="Server" Text="Tỉ lệ vượt:" CssClass="cssManField"></asp:Label>
                                        &nbsp&nbsp
                                    <asp:Label ID="m_lbl_ti_le_vuot" runat="server" Text="0" CssClass="cssManField"></asp:Label>
                                        <asp:HiddenField ID="m_hdf_id_don_hang" runat="server" />
                                    </td>
                                    <td align="left">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Duyet" BorderStyle="Groove" Text="Duyệt" ToolTip="Duyệt đơn hàng" Width="24px"
                                            OnClick="m_lbt_duyet_OnClick">
                                            <img src="../Images/Button/check.png" width="24px" alt="Duyet" />
                                        </asp:LinkButton>
                                        <asp:Label ID="m_lbl_duyet" runat="server" Text="Duyệt" CssClass="cssLabel"></asp:Label>
                                        &nbsp&nbsp&nbsp&nbsp&nbsp
                                     <asp:LinkButton ID="LinkButton2" runat="server" CommandName="KhongDuyet" BorderStyle="Groove" Text=" Không Duyệt" ToolTip="KHông duyệt đơn hàng" Width="24px"
                                         OnClick="m_lbt_khong_duyet_OnClick">
                                            <img src="../Images/Button/deletered.png" width="24px" alt="Duyet" />
                                     </asp:LinkButton>
                                        <asp:Label ID="Label4" runat="server" Text=" Không duyệt" CssClass="cssLabel"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="m_lbl_nhap_mail" runat="server" Text="Nhập mail TD: " CssClass="cssLabelTitle" ForeColor="DarkSlateBlue"></asp:Label>
                                        <asp:TextBox ID="m_txt_nhap_mail" runat="server" CssClass="cssTextBox" placeholder="sampt"></asp:TextBox>
                                        <asp:Label ID="m_lbl_duoi_mail" runat="server" Text="@Topica.edu.vn" CssClass="cssLabel"></asp:Label>
                                        &nbsp&nbsp
                <asp:Button ID="m_cmd_gui_mail" runat="server" Text="Gửi mail xin duyệt" CssClass="cssGoogleButton" OnClick="m_cmd_gui_mail_Click" />
                                    </td>
                                    <td runat="server" align="right" colspan="1">
                                        <asp:ImageButton ID="_cmd_detail_exit" ImageUrl="../Images/Button/exit.png" Width="45px" Height="30px" ToolTip="Thoát" runat="server"
                                            OnClick="m_cmd_detail_exit_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <asp:HiddenField ID="m_hdf_don_gia" runat="server" />
                                        <asp:HiddenField ID="m_hdf_ID_GD_DON_DAT_HANG_DE" runat="server" />
                                    </td>
                                </tr>
                            </table>
                            <table runat="server" border="0" cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td class="cssPageTitleBG" colspan="6">
                                        <asp:Label ID="m_lbl_phieu_de_nghi_va_ban_giao_VPP" runat="server" CssClass="cssPageTitle"
                                            Text="Danh sách VPP đề nghị cấp"></asp:Label>
                                        <asp:Label ID="m_lbl_thong_tim_grv_don_hang_de" runat="server" CssClass="cssPageTitle"></asp:Label>
                                        &nbsp; &nbsp;
                <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssPageTitle" ForeColor="Green" Font-Italic="true" BackColor="White"></asp:Label>
                                        <%-- &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        <asp:GridView ID="m_grv_don_hang_de" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                                            EmptyDataText="Không có mặt hàng!" EmptyDataRowStyle-BorderColor="#810913"
                                            CellPadding="8">
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
                                                <asp:BoundField DataField="TEN_VPP" ItemStyle-HorizontalAlign="Left" HeaderText="TÊN VPP"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Left" Width="12%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="SO_LUONG" ItemStyle-HorizontalAlign="Right" HeaderText="SỐ LƯỢNG"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="right" Width="5%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_VI_TINH" ItemStyle-HorizontalAlign="Left" HeaderText="ĐƠN VỊ TÍNH"
                                                    ItemStyle-Width="7%">
                                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_GIA_CHUA_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ CHƯA VAT (VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DON_GIA_GOM_VAT" ItemStyle-HorizontalAlign="Right" HeaderText="ĐƠN GIÁ GỒM VAT (VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TONG_TIEN" ItemStyle-HorizontalAlign="Right" HeaderText="TỔNG TIỀN ĐÃ VAT (VNĐ)"
                                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N0}">
                                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
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
                        </div>
                    </asp:View>
                </asp:MultiView>
            </div>
        </asp:Panel>
        <asp:Panel ID="m_pnl_confirm_tg" runat="server">
            <div class="cssLoadWapper">
                <asp:MultiView ID="m_mtv_1" runat="server">
                    <asp:View ID="m_view_confirm" runat="server">
                        <div class="cssLoadContent2" style="width: 50%">
                            <table runat="server" border="0" cellspacing="0" cellpadding="2" width="100%">
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
    </form>
</body>
</html>


