<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-1.7.1.min.js"></script>
    <link href="Styles/select2.css" rel="stylesheet" />
    <script type="text/javascript" src="Scripts/select2.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#e1").select2();
            $("#<%=m_cbo_bill.ClientID%>").select2();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <select id="e1" style="width: 300px">
                <option value="AL">Alabama</option>
                <option value="Am">Amalapuram</option>
                <option value="An">Anakapalli</option>
                <option value="Ak">Akkayapalem</option>
                <option value="WY">Duong Minh Tu</option>
                <option value="WY">Nguyen Ngoc Duy</option>
                <option value="WY">Wyoming</option>
                <option value="WY">Wyoming</option>
            </select>
            <asp:DropDownList ID="m_cbo_bill" width ="90%"
                 runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
