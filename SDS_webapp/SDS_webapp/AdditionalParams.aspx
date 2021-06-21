<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AdditionalParams.aspx.cs" Inherits="SDS_webapp.AdditionalParams" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Good" runat="server" ForeColor="#009900" Text="Данные успешно обновлены" Visible="False"></asp:Label>
    <br>
    <asp:Label ID="Label2" runat="server" Text="Оценка устойчивости организма к гипоксии и гиперкапнии" Font-Bold="True" Font-Size="Large"></asp:Label><br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Shatnge_L" runat="server" Text="Время задержки дыхания на вдохе (с)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Shtange_D" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Shtange_R" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Shtange_Delta" runat="server" Text="Нет данных"></asp:Label>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Genchi_L" runat="server" Text="Время задержки дыхания на выдохе (с)"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Genchi_D" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Genchi_R" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Genchi_Delta" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <br>
    <asp:Label ID="Label3" runat="server" Text="Тест купера" Font-Bold="True" Font-Size="Large"></asp:Label><br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Kuper_L" runat="server" Text="Расстояние в метрах"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Kuper_D" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Kuper_R" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Kuper_Delta" runat="server" Text="Нет данных"></asp:Label><br>
    <br>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Гарвардский степ-тест"></asp:Label>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label11" runat="server" Text="Рекомендуемая восота скамейки"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Step_Sk" runat="server" Text="Нет данных"></asp:Label>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Пульс по окончании упражнения (за 30с)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Step_Pulse" runat="server"></asp:TextBox>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Пульс на начало второй минуты отдыха (за 30с)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Step_Pulse2" runat="server"></asp:TextBox>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server" Text="Пульс на начало третьей минуты отдыха (за 30с)"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Step_Pulse3" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Step_D" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Step_R" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Step_Delta" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <br>
    <asp:Label ID="Label12" runat="server" Text="Функциональная проба с приседаниями" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label13" runat="server" Text="Пульс в покое"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Pulse_Stil" runat="server"></asp:TextBox><br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label14" runat="server" Text="Пульс после 20 приседаний"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Pulse_20sit" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label15" runat="server" Text="Пульс через 1 минуту"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Pulse_1m" runat="server"></asp:TextBox>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label16" runat="server" Text="Пульс через 2 минуты"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Pulse_2m" runat="server"></asp:TextBox>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label17" runat="server" Text="Пульс через 3 минуты"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Pulse_3m" runat="server"></asp:TextBox>
    <br>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Pulse_R" runat="server" Text="Нет данных"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Pulse_Delta" runat="server" Text="Нет данных"></asp:Label>
    <br><br>
    <asp:Button ID="Button1" runat="server" Text="Обновить данные" OnClick="Button1_Click" />
</asp:Content>
