<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="ASP.Demo" %>

<!-- 7. Se registra el WebUserControl, para que aparezca en la ejecución del programa -->
<%@ Register Src="~/WebUserControl.ascx" TagName="WebControl" TagPrefix="TWebControl"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- 1. Response retorna información al usuario -->
            <!-- <%Response.Write("Hello World\n"); %> -->
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:ListBox ID="lstLocation" runat="server">
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Mangalore</asp:ListItem>
            <asp:ListItem>Hyderabad</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:RadioButton ID="rdMale" runat="server" Text="Male" />
        </p>
        <asp:RadioButton ID="rdFemale" runat="server" Text="Female" />
        <p>
            <asp:CheckBox ID="chkASP" runat="server" Text="ASP.NET" />
        </p>
        <asp:CheckBox ID="chkC" runat="server" Text="C#" />
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>

        <h1>De aca en adelante, se muestra la información del WebUserControl</h1>

        <!-- 8. Se hace referencia al componente del WebUserControl -->
        <TWebControl:WebControl ID="Header" runat="server" MinValue="100"/>
        
    </form>
</body>
</html>
