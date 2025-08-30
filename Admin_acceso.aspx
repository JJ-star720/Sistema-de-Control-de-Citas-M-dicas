<%@ Page Title="Manejo administrativo" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Admin_acceso.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Admin_acceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container py-5">
        <div class="card shadow-lg">
            <div class="card-body">
                <h1 class="card-title text-center mb-4">Panel Administrativo</h1>
                <p class="text-muted text-center mb-4">Seleccione una opción para gestionar el sistema</p>

                <div class="mb-3">
                    <h5>👨‍⚕️ Gestión de doctores</h5>
                    <asp:Button CssClass="btn btn-outline-primary w-100" ID="btnDoc" runat="server" Text="Administrar Doctores" OnClick="btnDoc_Click" />
                </div>

                <div class="mb-3">
                    <h5>🧑‍🤝‍🧑 Gestión de pacientes</h5>
                    <asp:Button CssClass="btn btn-outline-success w-100" ID="BtnPas" runat="server" Text="Administrar Pacientes" OnClick="BtnPas_Click" />
                </div>

                <div class="mb-3">
                    <h5>🕒 Horarios de citas médicas</h5>
                    <asp:Button CssClass="btn btn-outline-warning w-100" ID="BtnCit" runat="server" Text="Configurar Citas" OnClick="BtnCit_Click" />
                </div>

                <div class="mb-3">
                    <h5>🔙 Cerrar sesión</h5>
                    <asp:Button CssClass="btn btn-outline-danger w-100" ID="BynBack" runat="server" Text="Cerrar Sesión" OnClick="BynBack_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
