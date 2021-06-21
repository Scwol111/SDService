<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="SDS_webapp.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Мой профиль"></asp:Label><br><br>
    
    <asp:Label ID="FIO" runat="server" Text="Нет данных"></asp:Label><br>
    <asp:Label ID="Label3" runat="server" Text="Электронная почта"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Mail" runat="server" Text="Нет данных"></asp:Label><br>

    <asp:Label ID="Label4" runat="server" Text="Преподаватель"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Label ID="Master" runat="server" Text="Нет данных"></asp:Label><br>
    <asp:Label ID="Label5" runat="server" Text="Телефонный номер"></asp:Label>
&nbsp;&nbsp;&nbsp; <asp:Label ID="Phone" runat="server" Text="Нет данных"></asp:Label><br>

    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Мои физические параметры</asp:LinkButton><br>

    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Visible="False">Изменить данные</asp:LinkButton><br>

</asp:Content>
