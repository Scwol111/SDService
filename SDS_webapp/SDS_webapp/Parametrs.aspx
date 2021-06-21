<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Parametrs.aspx.cs" Inherits="SDS_webapp.Parametrs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Индекс массы тела" Width="200px"></asp:Label>
    <asp:Label ID="IMT_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="IMT_R" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="Delta" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://ru.wikipedia.org/wiki/%D0%98%D0%BD%D0%B4%D0%B5%D0%BA%D1%81_%D0%BC%D0%B0%D1%81%D1%81%D1%8B_%D1%82%D0%B5%D0%BB%D0%B0"> Справка </a>
    <br>
    <asp:Label ID="Label3" runat="server" Text="Экскурсия" Width="200px"></asp:Label>
    <asp:Label ID="EX_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="EX_R" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="Delta0" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://ru.wikipedia.org/wiki/%D0%A7%D0%B0%D1%81%D1%82%D0%BE%D1%82%D0%B0_%D0%B4%D1%8B%D1%85%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D1%8B%D1%85_%D0%B4%D0%B2%D0%B8%D0%B6%D0%B5%D0%BD%D0%B8%D0%B9"> Справка </a>
    <br>
    <asp:Label ID="Label4" runat="server" Text="Показатель Эрисмана" Width="200px"></asp:Label>
    <asp:Label ID="EX_D0" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="EX_R0" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="Delta1" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://studopedia.ru/14_4277_indeks-erismana-indeks-proportsionalnosti-grudnoy-kletki.html"> Справка </a>
    <br>
    <asp:Label ID="Label5" runat="server" Text="Индекс талии-бедра" Width="200px"></asp:Label>
    <asp:Label ID="ITB_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="IT_R" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="Delta2" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://ru.wikipedia.org/wiki/%D0%A1%D0%BE%D0%BE%D1%82%D0%BD%D0%BE%D1%88%D0%B5%D0%BD%D0%B8%D0%B5_%D1%82%D0%B0%D0%BB%D0%B8%D0%B8_%D0%B8_%D0%B1%D1%91%D0%B4%D0%B5%D1%80#:~:text=Waist%E2%80%93hip%20ratio)%20%E2%80%94%20%D0%B1%D0%B5%D0%B7%D1%80%D0%B0%D0%B7%D0%BC%D0%B5%D1%80%D0%BD%D0%BE%D0%B5,%D0%B8%20%D0%B1%D1%91%D0%B4%D0%B5%D1%80%20%D0%BF%D1%80%D0%B8%D0%BC%D0%B5%D1%80%D0%BD%D0%BE%200%2C79."> Справка </a>
    <br>
    <asp:Label ID="Label6" runat="server" Text="Крепость телосложения" Width="200px"></asp:Label>
    <asp:Label ID="KT_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="KT_R" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="Delta3" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://vladimirus-team.blogspot.com/2019/11/blog-post.html"> Справка </a>
    <br>
    <asp:Label ID="Label7" runat="server" Text="Верхняя граница пульса" Width="200px"></asp:Label>
    <asp:Label ID="PU_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="PU_R" runat="server" Text="" Width="100px"></asp:Label>
    <asp:Label ID="Delta4" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://support.polar.com/e_manuals/A300/Polar_A300_user_manual_Russian/Content/Heart_rate_Zones.htm"> Справка </a>
    <br>
    <asp:Label ID="Label8" runat="server" Text="Нижняя граница пульса" Width="200px"></asp:Label>
    <asp:Label ID="PD_D0" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="PD_R0" runat="server" Text="" Width="100px"></asp:Label>
    <asp:Label ID="Delta5" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://support.polar.com/e_manuals/A300/Polar_A300_user_manual_Russian/Content/Heart_rate_Zones.htm"> Справка </a>
    <br>
    <asp:Label ID="Label9" runat="server" Text="Жизненная эмкость лекгих" Width="200px"></asp:Label>
    <asp:Label ID="GEL_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="GEL_R" runat="server" Text="" Width="100px"></asp:Label>
    <asp:Label ID="Delta6" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://ru.wikipedia.org/wiki/%D0%96%D0%B8%D0%B7%D0%BD%D0%B5%D0%BD%D0%BD%D0%B0%D1%8F_%D1%91%D0%BC%D0%BA%D0%BE%D1%81%D1%82%D1%8C_%D0%BB%D1%91%D0%B3%D0%BA%D0%B8%D1%85#:~:text=%D0%96%D0%B8%D0%B7%D0%BD%D0%B5%D0%BD%D0%BD%D0%B0%D1%8F%20%D1%91%D0%BC%D0%BA%D0%BE%D1%81%D1%82%D1%8C%20%D0%BB%D1%91%D0%B3%D0%BA%D0%B8%D1%85%20(%D0%96%D0%81%D0%9B)%20%E2%80%94,%D0%B2%D1%8B%D0%B4%D0%BE%D1%85%D0%BD%D1%83%D1%82%D1%8C%20%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%20%D1%81%D0%B0%D0%BC%D0%BE%D0%B3%D0%BE%20%D0%B3%D0%BB%D1%83%D0%B1%D0%BE%D0%BA%D0%BE%D0%B3%D0%BE%20%D0%B2%D0%B4%D0%BE%D1%85%D0%B0."> Справка </a>
    <br>
    <asp:Label ID="Label10" runat="server" Text="Жизненный показатель" Width="200px"></asp:Label>
    <asp:Label ID="GP_D" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <asp:Label ID="GP_R" runat="server" Text="" Width="100px"></asp:Label>
    <asp:Label ID="Delta7" runat="server" Text="Нет данных" Width="100px"></asp:Label>
    <a target="_blank" href="https://ru.wikipedia.org/wiki/%D0%96%D0%B8%D0%B7%D0%BD%D0%B5%D0%BD%D0%BD%D0%B0%D1%8F_%D1%91%D0%BC%D0%BA%D0%BE%D1%81%D1%82%D1%8C_%D0%BB%D1%91%D0%B3%D0%BA%D0%B8%D1%85#:~:text=%D0%96%D0%B8%D0%B7%D0%BD%D0%B5%D0%BD%D0%BD%D0%B0%D1%8F%20%D1%91%D0%BC%D0%BA%D0%BE%D1%81%D1%82%D1%8C%20%D0%BB%D1%91%D0%B3%D0%BA%D0%B8%D1%85%20(%D0%96%D0%81%D0%9B)%20%E2%80%94,%D0%B2%D1%8B%D0%B4%D0%BE%D1%85%D0%BD%D1%83%D1%82%D1%8C%20%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%20%D1%81%D0%B0%D0%BC%D0%BE%D0%B3%D0%BE%20%D0%B3%D0%BB%D1%83%D0%B1%D0%BE%D0%BA%D0%BE%D0%B3%D0%BE%20%D0%B2%D0%B4%D0%BE%D1%85%D0%B0."> Справка </a>
    </asp:Content>
