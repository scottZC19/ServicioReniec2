<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buscarreniec.aspx.cs" Inherits="WAReniec.buscarreniec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Busqueda por DNI"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Ingrese DNI"></asp:Label>
        <asp:TextBox ID="txtbuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="buscar" />
        <asp:GridView ID="gvdatos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
