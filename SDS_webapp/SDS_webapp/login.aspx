<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SDS_webapp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 200px">
            <asp:Localize ID="Localize1" runat="server"></asp:Localize>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Система электронного дневника самоконтроля"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Выполнить вход" style="margin-left: 139px" Width="150px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Large" Font-Strikeout="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" ForeColor="Red" style="margin-left: 100px" Text="Введены неверные имя пользователя или пароль" Visible="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Имя пользователя" Width="140px"></asp:Label>
            <asp:TextBox ID="Name" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Пароль" Width="140px"></asp:Label>
            <input id="Password1" runat="server" type="password" width="215px" />&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button2_Click">Нет аккаунта? Создайте новый</asp:LinkButton>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Войти" style="margin-left: 139px" Width="122px" OnClick="Button1_Click"/>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
