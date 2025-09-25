<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudAdd.aspx.cs" Inherits="StudAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Name:
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        CITY:
        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textsid" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ADD" />
    
    </div>
    </form>
</body>
</html>
