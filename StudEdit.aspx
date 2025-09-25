<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudEdit.aspx.cs" Inherits="StudEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtsid" runat="server" Width="216px"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
    :&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="211px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="CITY"></asp:Label>
    :&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged" 
        Width="213px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="UPDATE" />
&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="DELETE" />
    </form>
</body>
</html>
