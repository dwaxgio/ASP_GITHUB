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
            <!-- <%Response.Write("Hello World</br>"); %> -->
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

        <h2>De aca en adelante, se muestra la información del WebUserControl</h2>

        <!-- 8. Se hace referencia al componente del WebUserControl -->
        <TWebControl:WebControl ID="Header" runat="server" MinValue="100"/>

        <!-- 15. Se agregan campos de formulario, para ser consultados en la db -->
        <h2>De aca en adelante, se envia información de tabla de db a formulario</h2>

        <asp:Label ID="Label1" runat="server" Text="Tutorial ID"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ASPDemoDBDatasource" DataTextField="TutorialID" DataValueField="TutorialID"></asp:ListBox>
        
        <asp:SqlDataSource ID="ASPDemoDBDatasource" runat="server" ConnectionString="<%$ ConnectionStrings:ASPDemoDBConnectionString %>" SelectCommand="SELECT * FROM [demotb]"></asp:SqlDataSource>
        
        <asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server" DataSourceID="ASPDemoDBDatasource" DataTextField="TutorialName" DataValueField="TutorialName"></asp:ListBox>

    </form>
</body>
</html>
