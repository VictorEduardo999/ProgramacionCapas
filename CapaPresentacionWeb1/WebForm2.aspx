<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="CapaPresentacionWeb1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Datos personales"></asp:Label>
                <br />
                <br />
                <asp:Label ID="txtApellidos" runat="server" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="txtNombres" runat="server" Text="Nombres"></asp:Label>
                <asp:TextBox ID="txtNombre2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="txtEdad" runat="server" Text="Edad"></asp:Label>
                <asp:TextBox ID="txtEdad2" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Label ID="lblResul" runat="server" Text="Label"></asp:Label>
            </asp:Panel>
        </div>
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" />
        <asp:Button ID="BtnReporte" runat="server" Text="Reporte" />
    </form>
</body>
</html>
