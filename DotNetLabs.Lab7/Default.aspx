<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DotNetLabs.Lab7.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Прізвище:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="118px"></asp:TextBox>
            <br />Ім'я:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="118px"></asp:TextBox>
            <br />По-батькові:<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="118px"></asp:TextBox>
            <br />email:<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="118px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ОК" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
