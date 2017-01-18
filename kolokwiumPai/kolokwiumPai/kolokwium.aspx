<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kolokwium.aspx.cs" Inherits="kolokwiumPai.kolokwium" %>

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
        <p>test<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
