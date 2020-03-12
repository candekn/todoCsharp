<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Controles de Validacion</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>

    <div class="container">
        <form id="form1" runat="server">
            <div class="input-group">
                <asp:Label ID="Label1" runat="server" Text="Legajo: "></asp:Label>
                <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>
                <asp:CompareValidator CssClass="errorASP" ID="CompareValidator1" runat="server" ControlToValidate="txtLegajo" ErrorMessage="El legajo solo son números" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label2" runat="server" Text="Nombre y apellido: "></asp:Label>
                <asp:TextBox ID="txtNombreApellido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombreApellido" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label3" runat="server" Text="Fecha de Ingreso: "></asp:Label>
                <asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox>
                <asp:CompareValidator CssClass="errorASP" ID="CompareFecha" runat="server" ErrorMessage="Fecha debe ser menor o igual a hoy " Operator="LessThanEqual" Type="Date" ControlToValidate="txtFechaIngreso"></asp:CompareValidator>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFechaIngreso" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label4" runat="server" Text="Sueldo: "></asp:Label>
                <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtSueldo" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label5" runat="server" Text="Horas Extras: "></asp:Label>
                <asp:TextBox ID="txtHorasExtras" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtHorasExtras" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label6" runat="server" Text="CUIL: "></asp:Label>
                <asp:TextBox ID="txtCuil" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator CssClass="errorASP" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Ingrese CUIL Válido" ValidationExpression="^[0-9]{2}-[0-9]{8}-[0-9]$" ControlToValidate="txtCuil"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCuil" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>

            </div>
            <div class="input-group">
                <asp:Label ID="Label7" runat="server" Text="E-Mail: "></asp:Label>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="errorASP" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMail" ErrorMessage="Requerido!"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator CssClass="errorASP" ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtMail" ErrorMessage="E-mail no válido!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

            </div>
            <div class="form-group">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary btn-block text-center" CssClass="auto-style1" Height="30px" Width="64px" />
            </div>
        </form>
    </div>


</body>
<script src="Scripts/bootstrap.min.js"></script>
<script src="Scripts/jquery-3.4.1.min.js"></script>
</html>

