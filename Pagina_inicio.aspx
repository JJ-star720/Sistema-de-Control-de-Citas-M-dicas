<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Pagina_inicio.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Pagina_inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="d-flex align-items-center py-4 bg-body-tertiary">
    <main class="form-signin w-100 m-auto">
        <h1 class="h3 mb-3 fw-normal">Inicio de sesion</h1>

        <div class="form-floating">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="SingleLine" placeholder="Email"></asp:TextBox>
            <label for="MainContent_txtEmail">Email</label>
        </div>

        <div class="form-floating">
            <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
            <label for="MainContent_txtPass">Contraseña</label>
        </div>

        <div class="form-check text-start my-3">
            <input class="form-check-input" type="checkbox" value="remember-me" id="flexCheckDefault">
            <label class="form-check-label" for="flexCheckDefault">
                Recordar 
            </label>
        </div>
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="btnLogin" runat="server" Text="Admin" OnClick="btnLogin_Click1" />
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="BtnPas" runat="server" Text="Pasciente" OnClick="BtnPas_Click" />
    </main>
</div>

<asp:Label ID="lblError" runat="server" Text="" CssClass="alert alert-danger" Visible="false"></asp:Label>

</asp:Content>
