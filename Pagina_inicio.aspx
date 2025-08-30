<%@ Page Title="Clinica santas despedidas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Pagina_inicio.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Pagina_inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container py-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow-lg">
                    <div class="card-body">
                        <h2 class="card-title text-center mb-4">🔐 Inicio de sesión</h2>

                        <div class="form-floating mb-3">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="SingleLine" placeholder="Correo electrónico"></asp:TextBox>
                            <label for="MainContent_txtEmail">Correo electrónico</label>
                        </div>

                        <div class="form-floating mb-3">
                            <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                            <label for="MainContent_txtContraseña">Contraseña</label>
                        </div>

                        <div class="form-check mb-3">
                            <input class="form-check-input" type="checkbox" value="remember-me" id="flexCheckDefault">
                            <label class="form-check-label" for="flexCheckDefault">
                                Recordar sesión
                            </label>
                        </div>

                        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="btnLogin" runat="server" Text="Acceder" OnClick="btnLogin_Click1" />

                        <asp:Label ID="Label1" runat="server" Text="" CssClass="alert alert-danger mt-3" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <a href="Registro.aspx">¿Primera vez que ingresa?</a>
<asp:Label ID="lblError" runat="server" Text="" CssClass="alert alert-danger" Visible="false"></asp:Label>

</asp:Content>
