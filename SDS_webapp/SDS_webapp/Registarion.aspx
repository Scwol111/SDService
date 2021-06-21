<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registarion.aspx.cs" Inherits="SDS_webapp.Registarion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Password1 {
            height: 21px;
            width: 214px;
        }
        #Password2 {
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 240px">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Система электронного дневника самоконтроля"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Создать новый аккаунт" style="margin-left: 139px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Large" Font-Strikeout="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" ForeColor="Red" Text="При создании аккаунта произошла ошибка, попробуйте снова позже" Visible="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Имя пользователя" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="Пользователь с таким именем уже существует" Visible="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Пароль" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <input id="Password1" runat="server" type="password" />&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Подтвердите Пароль"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <input id="Password2" runat="server" type="password" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label13" runat="server" ForeColor="Red" Text="Пароли не совпадают" Visible="False"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Электронная почта" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mail" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Преподаватель" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Width="220px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Фамилия" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Fam" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Имя" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="User_name" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" Text="Отчество" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="User_otch" runat="server" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="Телефонный номер" Width="140px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="215px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Зарегистрироваться" style="margin-left: 139px" OnClick="Button1_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
