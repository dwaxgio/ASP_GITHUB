<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormBase.aspx.cs" Inherits="ASP.WebFormBase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Web Form Base</h1>
            <asp:Label ID="Label1" runat="server" Text="Label de Web Form Base"></asp:Label>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
        </div>
    </form>
</body>
</html>
