<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChangeAccountData.aspx.cs" Inherits="SDS_webapp.ChangeAccountData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label12" runat="server" Text="Изменить данные" Font-Bold="True" Font-Size="X-Large"></asp:Label><br><br>
            <asp:Label ID="Label9" runat="server" Text="Фамилия" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Fam" runat="server" Width="215px">Нет данных</asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label10" runat="server" Text="Имя" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="User_name" runat="server" Width="215px">Нет данных</asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label11" runat="server" Text="Отчество" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="User_otch" runat="server" Width="215px">Нет данных</asp:TextBox><br>
            <asp:Label ID="Label7" runat="server" Text="Электронная почта" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mail" runat="server" Width="215px">Нет данных</asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
    <asp:Label ID="Label13" runat="server" Text="Телефонный номер"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Phone" runat="server" Width="215px">Нет данных</asp:TextBox>
    <br>
            <asp:Label ID="Label8" runat="server" Text="Преподаватель" Width="140px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Width="220px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br>

            &nbsp;<asp:Button ID="Button4" runat="server" BackColor="White" Text="Сохранить изменения" OnClick="Button4_Click" />
</asp:Content>
