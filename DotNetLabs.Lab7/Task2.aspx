<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="DotNetLabs.Lab7.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Output" runat="server"></asp:Label>
        </div>
        <div>
            Логін<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="118px"></asp:TextBox>
            <br />Пароль<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="118px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ОК" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
