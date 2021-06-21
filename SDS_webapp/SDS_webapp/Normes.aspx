<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Normes.aspx.cs" Inherits="SDS_webapp.Normes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Физические нормативы" Font-Bold="True" Font-Size="X-Large"></asp:Label><br>
    <asp:Label ID="Good" runat="server" Text="Label" Visible="False"></asp:Label>
    <br>
    <asp:Label ID="Run_L" runat="server" Text="Бег 100м (с)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Run_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Run_R" runat="server" Text="Нет данных"></asp:Label>&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta0" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Cross_L" runat="server" Text="Бег 3000м (мин, сек)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Cross_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Cross_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta1" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Push_L" runat="server" Text="Подтягивания из виса на высокой перекладине"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Push_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Push_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta2" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Otz_L" runat="server" Text="Сгибание рук лежа в упоре на полу"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Otz_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Otz_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta3" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Nak_L" runat="server" Text="Наклон вперед из положения стоя"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NaK_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Nak_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta4" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Jump_L" runat="server" Text="Прыжок в длину с места, толчком  двумя ногами (см)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Jump_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Jump_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta5" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Press_L" runat="server" Text="Поднимание туловища (пресс кол-во раз за 1 мин)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Press_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Press_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta6" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Swim_L" runat="server" Text="Плавание 50 м (мин, сек)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Swim_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Swim_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta7" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Ski_L" runat="server" Text="Бег на лыжах 5 км (мин, сек)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Ski_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Ski_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta8" runat="server" Text="Нет данных"></asp:Label>
    <br>
    <asp:Label ID="Gir_L" runat="server" Text="Рывок гири 16 кг (количество раз)"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Gir_D" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Gir_R" runat="server" Text="Нет данных"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Delta9" runat="server" Text="Нет данных"></asp:Label>
    <br><br>
    <asp:Button ID="Button1" runat="server" Text="Обновить данные" OnClick="Button1_Click" />
</asp:Content>
