<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="margin-left: 5%">
        <asp:ScriptManager runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
                <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
    </div>

    <div style="clip: rect(auto, auto, auto, auto); margin-left: 5%; padding-right: 5%;">

        <table width="315px">
            <tr class="title_ttql">
                <td>CHUYỂN PHÁT NHANH
                </td>
            </tr>
        </table>

        <!-- Bang Dat -->
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tbody>
                <tr>
                    <td style="padding-left: 8px; padding-right: 5px;" valign="top">
                        <table border="0" cellpadding="0" cellspacing="0" width="300">
                            <tbody>
                                <tr>
                                    <td valign="top">
                                        <table border="0" width="200" cellpadding="0" cellspacing="3" align="left">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href="/QuanLyHanhChinh/ChucNang/f600_import_bill_from_excel_file.aspx" title="Nhập bill Excel">
                                                            <img border="0" src="Images/Trangchu/excel-xls-icon.png" width="100"
                                                                title="Nhập bill Excel" /></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                       <td valign="top">
                                        <table border="0" width="200" cellpadding="0" cellspacing="3" align="left">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href="/QuanLyHanhChinh/ChucNang/f600_import_bill_from_excel_file.aspx" title="Nhập bill Excel">
                                                            <img border="0" src="Images/Trangchu/excel-xls-icon.png" width="100"
                                                                title="Nhập bill Excel" /></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="link_news_hot" style="margin-top: 0px; margin-bottom: 5px">
                                            <a href="/QuanLyHanhChinh/ChucNang/f600_import_bill_from_excel_file.aspx" style="color: maroon; font-size: larger; font-weight: bold">Nhập bill Excel</a>
                                        </p>
                                    </td>
                                     <td>
                                        <p class="link_news_hot" style="margin-top: 0px; margin-bottom: 5px">
                                            <a href="/QuanLyHanhChinh/ChucNang/f600_import_bill_from_excel_file.aspx" style="color: maroon; font-size: larger; font-weight: bold">Nhập bill Excel</a>
                                        </p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                            <tbody>
                                                <tr>
                                                    <td>Nhập danh sách bill từ file excel theo mẫu
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="width: 40%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table5" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a href="https://docs.google.com/document/d/1LH5b7A0RJt2cELj_D2o0s5uHz4Xe6YMH1KoYuM7qx08/edit" style="font-weight: bold; color: maroon; font-size: x-large">Quy trình CPN</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật</span> <span class="HotNews_date">2014-07-28
                                                        14:45:58</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="https://docs.google.com/document/d/1gSf4MwcVr0IJcypkv02GR2Znd9edIi8ay9IYrr3IqvY/edit" style="font-weight: bold; color: maroon; font-size: x-large">Hướng dẫn sử dụng</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2014-07-28
                                                        23:17:05</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>
                    <td style="width: 60%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table6" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/f444_tra_cuu_trang_thai.aspx" style="font-weight: bold; color: maroon; font-size: x-large">Tra cứu trạng thái bill</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2014-07-28
                                                        15:05:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/f499_tra_cuu_tinh_hinh_CPN.aspx" style="font-weight: bold; color: maroon; font-size: x-large">Báo cáo tình hình CPN</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        14:10:57</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
        <!-- Ket thuc bang Nha-->
        <hr />
        <!-- Bang Nha -->
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tbody>
                <tr>
                    <td style="padding-left: 8px; padding-right: 5px;" valign="top">
                        <table border="0" cellpadding="0" cellspacing="0" width="300">
                            <tbody>
                                <tr>
                                    <td valign="top">
                                        <table border="0" width="200" cellpadding="0" cellspacing="3" align="left">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href="#" title="Quản lý nhà">
                                                            <img border="0" src="Images/pager/nha1.jpg" width="200" title="Quản lý nhà" /></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="link_news_hot" style="margin-top: 0px; margin-bottom: 5px">
                                            <a href="#">Quản lý nhà</a>
                                        </p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                            <tbody>
                                                <tr>
                                                    <td>Tập hợp các thông tin về nhà của đơn vị sử dụng, theo dõi sử dụng nhà, báo cáo cho tổng cục
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="width: 40%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table1" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a href="/QuanLyHanhChinh/ChucNang/F100_QuanLyNha.aspx" style="font-weight: bold">Quản lý danh sách nhà</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-31
                                                        14:45:58</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F102_DeNghiXuLyNha.aspx" style="font-weight: bold">Đề nghị xử lý nhà</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-21
                                                        23:17:05</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F302_khau_hao_nha.aspx" style="font-weight: bold">Khấu hao nhà</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-16
                                                        23:22:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>
                    <td style="width: 60%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table4" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo kê khai nhà</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        15:05:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo đề nghị xử lý nhà</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        14:10:57</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
        <!-- Ket thuc bang Nha-->
        <hr />
        <!-- Bang Oto -->
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tbody>
                <tr>
                    <td style="padding-left: 8px; padding-right: 5px;" valign="top">
                        <table border="0" cellpadding="0" cellspacing="0" width="300">
                            <tbody>
                                <tr>
                                    <td valign="top">
                                        <table border="0" width="200" cellpadding="0" cellspacing="3" align="left">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href="#" title="Quản lý Oto">
                                                            <img border="0" src="Images/pager/oto1.jpg" width="200" title="Quản lý Oto"></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="link_news_hot" style="margin-top: 0px; margin-bottom: 5px">
                                            <a href="#">Quản lý Ô tô </a>
                                        </p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                            <tbody>
                                                <tr>
                                                    <td>Tập hợp các thông tin về oto của đơn vị sử dụng, theo dõi sử dụng oto, báo cáo cho tổng cục
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="width: 40%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table2" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a href="/QuanLyHanhChinh/ChucNang/F500_QuanLyOto.aspx" style="font-weight: bold">Quản lý danh sách Ô tô </a>&nbsp;<br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-31
                                                        14:45:58</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F410_DeNghiXuLyOto.aspx" style="font-weight: bold">Đề nghị xử lý Ô tô</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-21
                                                        23:17:05</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F103_KhauHaoOto.aspx" style="font-weight: bold">Khấu hao Ô tô</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-16
                                                        23:22:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>

                    <td style="width: 60%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table7" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo kê khai Ô tô</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        15:05:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo đề nghị xử lý Ô tô</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        14:10:57</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
        <!-- Ket thuc Oto-->
        <hr />
        <!-- Bang Tai San Khac -->
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tbody>
                <tr>
                    <td style="padding-left: 8px; padding-right: 5px;" valign="top">
                        <table border="0" cellpadding="0" cellspacing="0" width="300">
                            <tbody>
                                <tr>
                                    <td valign="top">
                                        <table border="0" width="200" cellpadding="0" cellspacing="3" align="left">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href="#" title="Quản lý tài sản khác">
                                                            <img border="0" src="Images/pager/cau_my_thuan.jpg" width="200" title="Quản lý tài sản khác"></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="link_news_hot" style="margin-top: 0px; margin-bottom: 5px">
                                            <a href="#">Quản lý tài sản khác</a>
                                        </p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                            <tbody>
                                                <tr>
                                                    <td>Tập hợp các thông tin về các tài sản khác của đơn vị sử dụng, theo dõi sử dụng tài sản này, báo cáo cho tổng cục
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 5px;"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="width: 40%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table3" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a href="/QuanLyHanhChinh/ChucNang/F200_DanhMucTaiSanKhac.aspx" style="font-weight: bold">Quản lý danh sách tài sản khác</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-31
                                                        14:45:58</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F202_DeNghiXuLyTaiSanKhac.aspx" style="font-weight: bold">Đề nghị xử lý tài sản khác</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-21
                                                        23:17:05</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="/QuanLyHanhChinh/ChucNang/F303_khau_hao_tai_san_khac.aspx" style="font-weight: bold">Khấu hao tài sản khác</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-16
                                                        23:22:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>

                    <td style="width: 60%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                        valign="top">
                        <table id="Table8" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                            <tbody>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo kê khai tài sản khác</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        15:05:17</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" width="100%">
                                            <tbody>
                                                <tr>
                                                    <td class="OtherNews_td">
                                                        <a class="link_OtherNews" href="#" style="font-weight: bold">Báo cáo đề nghị xử lý tài sản
                                                        khác</a>
                                                        <br>
                                                        <span class="HotNews_DateText">Ngày cập nhật:</span> <span class="HotNews_date">2013-07-29
                                                        14:10:57</span>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>

                </tr>
            </tbody>
        </table>
        <!-- Ket thuc bang Tai San Khac-->

    </div>
</asp:Content>
