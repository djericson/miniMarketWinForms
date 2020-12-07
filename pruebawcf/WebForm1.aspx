<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pruebawcf.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Clave</td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Apellidos</td>
                <td>
                    <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Correo</td>
                <td>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
