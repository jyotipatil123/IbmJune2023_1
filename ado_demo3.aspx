<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_demo3.aspx.cs" Inherits="IBM_Ado_demo.ado_demo3" %>

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
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="INSERT, DELETE UPDATE USING STORED PROCEDURE DEMO"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="DISPLAY ALL RECORDS" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INSERT" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DELETE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="UPDATE" />
            <br />
            <br />
            <asp:Panel ID="inspanel" runat="server" Visible="False">
                <br />
                INSERTION :
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="delpanel" runat="server" Visible="False">
                DELETION :
                <br />
                <asp:Label ID="Label2" runat="server" Text="ENTER CUSTOMER ID : "></asp:Label>
                <asp:TextBox ID="TXTCUSTID" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Delete" />
            </asp:Panel>
            <br />
            <asp:Panel ID="updatepanel" runat="server" Visible="False">
                UPDATION :
                <br />
                <br />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
