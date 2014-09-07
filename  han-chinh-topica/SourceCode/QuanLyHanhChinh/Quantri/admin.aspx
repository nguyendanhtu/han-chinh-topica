<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="Quantri_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="m_rdb_excute" runat="server" Text="Excute" GroupName="pr" Checked="true" />
                <asp:RadioButton ID="m_rdb_tim_proc" runat="server" Text="Tìm procedure" GroupName="pr" />
                <asp:RadioButton ID="m_rdb_tim_view" runat="server" Text="Tìm view" GroupName="pr" />
                <asp:TextBox ID="m_txt_convert_encoding" runat="server" PlaceHolder="Convert Encoding to text"></asp:TextBox>
                <asp:Button ID="m_cmd_convert" runat="server" CssClass="cssGoogleButton" Text="Convert" OnClick="m_cmd_convert_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 80%">
                <asp:TextBox ID="m_txt_command" runat="server" TextMode="MultiLine" Width="90%" Height="120px"></asp:TextBox>
            </td>

            <td style="width: 20%">
                <asp:Button ID="m_cmd_excute" runat="server" class="cssGoogleButton" OnClick="m_cmd_excute_Click" Text="Excute" Style="padding: 10px" Height="80px" Width="80px" /></td>
        </tr>
        <tr>
            <asp:GridView ID="m_grv" runat="server" AutoGenerateColumns="true" PagerStyle-HorizontalAlign="Center"
                CssClass="GridViewStyle" CellPadding="8">
                <PagerSettings Position="TopAndBottom" />
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle CssClass="GridViewFooterStyle" />
                <RowStyle CssClass="GridViewRowStyle" />
                <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                <PagerStyle CssClass="GridViewPagerStyle" />
                <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                <HeaderStyle CssClass="GridViewHeaderStyle" />
            </asp:GridView>
            <td colspan="2"></td>
        </tr>
    </table>



</asp:Content>

