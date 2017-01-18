<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kolokwium.aspx.cs" Inherits="kolokwiumPai.kolokwium" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Podaj x1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>Podaj x2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="policz" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Wynik: "></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Czas: "></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Bledy:"></asp:Label>
        </p>
    </div>
        <p>
            <asp:Chart ID="Chart1" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </p>
    </form>
</body>
</html>
