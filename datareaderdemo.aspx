<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datareaderdemo.aspx.cs" Inherits="IBM_Ado_demo.datareaderdemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            SQL DATA READER&nbsp; :<br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DISPLAY RECORDS" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display" />
        </div>
    </form>
</body>
</html>
