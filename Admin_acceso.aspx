<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Admin_acceso.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Admin_acceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <div class="d-flex align-items-center py-4 bg-body-tertiary">
    <main class="form-signin w-100 m-auto">
        <h1 class="h3 mb-3 fw-normal">Pagina de Admins</h1>

        <h3>Si desea manipular los datos de los doctores </h3>
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="btnDoc" runat="server" Text="Doctores" OnClick="btnDoc_Click" />
        <h3>Si desea manipular los datos de los pasientes </h3>
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="BtnPas" runat="server" Text="Pacientes" OnClick="BtnPas_Click" />
        <h3>Si desea agegar nuevos horarios para citas medicas </h3>
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="BtnCit" runat="server" Text="Citas" OnClick="BtnCit_Click" />
        <h3>Si desea volver a la pagina de inicio puelce este boton </h3>
        <asp:Button CssClass="btn btn-primary w-100 py-2" ID="BynBack" runat="server" Text="Cerrar sesion " OnClick="BynBack_Click" />
    </main>
</div>
</asp:Content>
