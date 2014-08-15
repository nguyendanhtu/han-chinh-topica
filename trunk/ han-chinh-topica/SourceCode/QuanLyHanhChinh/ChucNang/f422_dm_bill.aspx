<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="f422_dm_bill.aspx.cs" Inherits="ChucNang_f422_dm_bill" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 15%;
            height: 24px;
        }

        .style2
        {
            width: 35%;
            height: 24px;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=m_txt_ngay_gui.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true,
                required: true,
                yearRange: '1950:2050',
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <table cellspacing="0" cellpadding="2" style="width: 100%" class="cssTable" border="0">
        <tr>
            <td class="cssPageTitleBG" colspan="4">
                <asp:Label ID="m_lbl_title" runat="server" CssClass="cssPageTitle" ForeColor="White"
                    Text="Nhập thông tin bill"></asp:Label>
                &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                <asp:HiddenField ID="m_hdf_id_trung_tam" runat="server" />
            </td>
        </tr>
        <tr>
            <%-- <td align="right" colspan="1">
                        <asp:Label ID="m_lbl_chon_trung_tam" runat="Server" Text="Chọn phòng ban" CssClass="cssManField"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_trung_tam" runat="Server" CssClass="cssDorpdownlistDefault"
                            Width="91%">
                        </asp:DropDownList>
                    </td>--%>
            <td align="right">
                <asp:Label ID="m_lbl_ngay_gui" runat="Server" Text="Ngày gửi" CssClass="cssManField"></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox ID="m_txt_ngay_gui" runat="Server"></asp:TextBox>
            </td>
            <td align="right">
                <asp:Label ID="Label1" runat="server" CssClass="cssManField" Text="Ban/Trung tâm:"></asp:Label>
            </td>
            <td align="left">
                <asp:Label ID="m_lbl_ten_trung_tam" runat="server" CssClass="cssManField" Font-Bold="true" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style1">
                <asp:Label ID="m_lbl_so_bill" runat="Server" CssClass="cssManField" Text="Số bill(*)"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="m_txt_so_bill" runat="Server" CssClass="cssTextBox" Width="45%" placeholder="Nhập số bill gồm 8 chữ số"></asp:TextBox>
            </td>
            <td align="right" class="style1">
                <asp:Label ID="m_lbl_so_tien" runat="Server" CssClass="cssManField" Text="Số tiền"
                    Width="50%"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="m_txt_so_tien" runat="Server" CssClass="cssTextBox" Width="45%"></asp:TextBox>
                <asp:Label ID="m_lbl_vnd" runat="server" CssClass="cssManField" Text="(VNĐ)"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="m_lbl_nguoi_nhan" runat="Server" Text="Người nhận(*)" CssClass="cssManField"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="m_txt_nguoi_nhan" runat="Server" CssClass="cssTextBox" Width="45%" placeholder="Nhập người nhận"></asp:TextBox>
            </td>
            <td align="right">
                <asp:Label ID="m_lbl_nguoi_gui" runat="Server" Text="Người gửi(*)" CssClass="cssManField"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="m_txt_nguoi_gui" runat="Server" CssClass="cssTextBox" Width="45%" placeholder="Nhập người gửi"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="m_lbl_noi_nhan" runat="Server" CssClass="cssManField" Text="Nơi nhận(*)"></asp:Label>
            </td>
            <td rowspan="1">
                <asp:TextBox ID="m_txt_noi_nhan" runat="Server" TextMode="MultiLine" CssClass="cssTextBox"
                    Width="90%" placeholder="Nhập nơi nhận"></asp:TextBox>
            </td>
            <td align="right">
                <asp:Label ID="m_lbl_ghi_chu" runat="Server" Text="Ghi chú" CssClass="cssManField"></asp:Label>
            </td>
            <td rowspan="1">
                <asp:TextBox ID="m_txt_ghi_chu" runat="Server" TextMode="MultiLine" CssClass="cssTextBox"
                    Width="45%" placeholder="Nhập ghi chú"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="m_lbl_noi_dung" runat="Server" Text="Nội dung" CssClass="cssManField"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="m_txt_noi_dung" runat="Server" CssClass="cssTextBox" Width="90%" placeholder="Nhập nội dung"></asp:TextBox>
            </td>
            <td align="right">
                <asp:Label ID="m_lbl_khu_vuc" runat="Server" Text="Khu vực: " CssClass="cssManField"></asp:Label>
            </td>
            <td>
                <asp:RadioButton ID="m_rdb_trong_nuoc" runat="server" CssClass="cssManField" Text="Trong nước"
                    GroupName="khu_vuc" Checked="true" AutoPostBack="true" />
                <asp:RadioButton ID="m_rdb_nuoc_ngoai" runat="server" CssClass="cssManField" Text="Nước ngoài"
                    GroupName="khu_vuc" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td colspan="2" align="center">
                <asp:Button ID="m_cmd_them" runat="server" Text="Gửi cho TAD" CssClass="cssGoogleButton"
                    OnClick="m_cmd_them_Click" />
                <asp:Button ID="m_cmd_sua" runat="server" Text="Cập nhật và gửi lại TAD" CssClass="cssGoogleButton"
                    OnClick="m_cmd_sua_Click" />
                <asp:Button ID="m_cmd_huy" runat="server" Text="Hủy thao tác" CssClass="cssGoogleButton"
                    OnClick="m_cmd_huy_Click" />
            </td>
            <td>
                <asp:HiddenField ID="m_hdf_form_mode" runat="server" />
                <asp:HiddenField ID="m_hdf_id_bill" runat="server" />
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
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_danh_muc_bill" runat="server" CssClass="cssPageTitle" ForeColor="White"
                            Text="Danh sách các Bill đã gửi cho TAD"></asp:Label>
                        <asp:Label ID="m_lbl_thong_tim_grv_dm_bill" runat="server" CssClass="cssPageTitle"
                            ForeColor="White"></asp:Label>
                        &nbsp;<span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="Label2" runat="server" Text="Nội dung tìm kiếm " CssClass="cssManField"></asp:Label>
                        <asp:TextBox ID="m_txt_tim_kiem" runat="server" Width="400px" CssClass="cssTextBox" placeholder="Nhập số Bill, người nhận, nơi nhận, người gửi"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" Text="Tìm kiếm" CssClass="cssGoogleButton" CausesValidation="false" OnClick="m_cmd_tim_kiem_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="m_grv_dm_bill" runat="Server" AutoGenerateColumns="false" CssClass="GridViewStyle"
                            Width="99%" DataKeyNames="ID" AllowPaging="true" PagerStyle-HorizontalAlign="Center"
                            EmptyDataText="Không có dữ liệu phù hợp!" EmptyDataRowStyle-BorderColor="#810913"
                            CellPadding="8" PageSize="20"
                            OnRowEditing="m_grv_dm_bill_RowEditing"
                            OnRowDeleting="m_grv_dm_bill_RowDeleting"
                            OnPageIndexChanging="m_grv_v_dm_bill_PageIndexChanging">
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
                                <asp:BoundField DataField="SO_BILL" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ BILL"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NGAY_GUI" ItemStyle-HorizontalAlign="Left" HeaderText="NGÀY GỬI"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="center" Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="SO_TIEN" ItemStyle-HorizontalAlign="Left" HeaderText="SỐ TIỀN (VNĐ)"
                                    ItemStyle-Width="7%" HtmlEncode="false" DataFormatString="{0:N}">
                                    <ItemStyle HorizontalAlign="Right" Width="7%" />
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
                                    <ItemStyle HorizontalAlign="Left" Width="12%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NOI_DUNG" ItemStyle-HorizontalAlign="Left" HeaderText="NỘI DUNG"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="Left" Width="4%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TRONG_NUOC" ItemStyle-HorizontalAlign="Left" HeaderText="TRONG NƯỚC"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="center" Width="3%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NUOC_NGOAI" ItemStyle-HorizontalAlign="Left" HeaderText="NƯỚC NGOÀI"
                                    ItemStyle-Width="7%">
                                    <ItemStyle HorizontalAlign="center" Width="3%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="GHI_CHU" ItemStyle-HorizontalAlign="Left" HeaderText="GHI CHÚ"
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
