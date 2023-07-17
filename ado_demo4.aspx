<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_demo4.aspx.cs" Inherits="IBM_Ado_demo.ado_demo4" %>

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
            <br />
            <asp:Repeater ID="Repeater1" runat="server">
                 <HeaderTemplate>Ibm Header   
                     <br>   </br></HeaderTemplate>
                 <SeparatorTemplate> 
                     <br> </br>================= 
                     <br> </br></SeparatorTemplate>
                 <FooterTemplate>  
                     <br>  </br> Ibm footer   
                     <br>   </br></FooterTemplate>
                 <ItemTemplate>
                        <%#DataBinder.Eval(Container,"DataItem.custid")%> 
                        <%#DataBinder.Eval(Container,"DataItem.custname")%> 
                        <%#DataBinder.Eval(Container,"DataItem.city")%> 
                        <%#DataBinder.Eval(Container,"DataItem.salary")%> 
                 </ItemTemplate>
            </asp:Repeater>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display all records " />
            <br />
            <br />
            <br />
            <br />
            <br />

             <asp:DataList ID="DataList1" runat="server">  
            <ItemTemplate>  
                <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;   
                border: dashed 2px #04AFEF; background-color: #FFFFFF">  
                    <tr>  
                        <td>  
                            <b>custid: </b><span ><%# Eval("custid") %></span><br />  
                            <b>custName: </b><span><%# Eval("custname") %></span><br />  
                            <b>city: </b><span ><%# Eval("city")%></span><br />  
                        </td>  
                    </tr>  
                </table>  
            </ItemTemplate>  
        </asp:DataList>  
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
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
