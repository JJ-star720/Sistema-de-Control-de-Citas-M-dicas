<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container py-5 d-flex justify-content-center">
        <div class="card shadow-lg p-4" style="max-width: 400px; width: 100%;">
            <div class="card-body">
                <h2 class="h4 mb-4 text-center text-primary">Crear una cuenta</h2>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Correo electrónico" />
                    <label for="MainContent_txtEmail">Correo electrónico</label>
                </div>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña" />
                    <label for="MainContent_txtContraseña">Contraseña</label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass"
                        ControlToValidate="txtContraseña"
                        Display="Dynamic"
                        CssClass="text-danger small"
                        ErrorMessage="La contraseña es requerida"
                        runat="server" />
                </div>

                <asp:Button CssClass="btn btn-success w-100 py-2 mb-3" ID="btnRegistrar" runat="server" Text="Registrarse" OnClick="btnRegistrar_Click" />

                <div class="text-center">
                    <a href="Pagina_inicio.aspx" class="text-decoration-none">¿Ya estás registrado? Inicia sesión</a>
                </div>

                <asp:Label ID="lblError" runat="server" CssClass="text-danger mt-3 d-block" Text="" />
            </div>
        </div>
    </div>

</asp:Content>
