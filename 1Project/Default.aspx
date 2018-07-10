<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1Project.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Введите ИНН"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="INN" runat="server" Width="217px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Найти" />
        </p>
        <asp:Label ID="Name" runat="server"></asp:Label>
    </form>
</body>
</html>
