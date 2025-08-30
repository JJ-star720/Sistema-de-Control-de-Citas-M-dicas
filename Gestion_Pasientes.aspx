<%@ Page Title="Gestion de Pacientes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Pasientes.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Pasientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container py-4">

        <!-- 📝 Formulario de paciente -->
        <div class="card mb-4 shadow-sm">
            <div class="card-header bg-primary text-white">
                <h5 class="mb-0">Formulario de registro de paciente</h5>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control mb-3" placeholder="Nombre" />
                        <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control mb-3" placeholder="Apellidos" />
                        <asp:TextBox ID="TxtEdad" runat="server" CssClass="form-control mb-3" TextMode="Number" placeholder="Edad" />
                        <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control mb-3" placeholder="Teléfono" />
                        <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control mb-3" placeholder="Dirección" />
                        <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control mb-3" placeholder="Correo electrónico" />
                        <asp:TextBox ID="Txtaltura" runat="server" CssClass="form-control mb-3" placeholder="Altura (cm)" />
                        <asp:TextBox ID="Txtpeso" runat="server" CssClass="form-control mb-3" placeholder="Peso (kg)" />

                        <div class="d-flex gap-2 mt-3">
                            <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                            <asp:Button ID="btnCancelar" CssClass="btn btn-warning" runat="server" Text="Limpiar" OnClick="btnCancelar_Click" />
                            <asp:Button ID="Back" CssClass="btn btn-secondary" runat="server" Text="Volver" OnClick="Back_Click" />
                        </div>

                        <asp:Label ID="LblMensaje" runat="server" CssClass="mt-3 text-danger d-block" Text="" />
                    </div>
                </div>
            </div>
        </div>

        <!-- 👨‍⚕️ Lista de pacientes -->
        <div class="card shadow-sm">
            <div class="card-header bg-info text-white">
                <h5 class="mb-0">Lista de pacientes registrados</h5>
            </div>
            <div class="card-body">
                <asp:GridView ID="GvPasiente" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                    OnSelectedIndexChanged="GvPaciente_SelectedIndexChanged" OnRowDeleting="GvPaciente_RowDeleting"
                    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                        <asp:BoundField DataField="Edad" HeaderText="Edad" />
                        <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                        <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" />
                        <asp:BoundField DataField="altura" HeaderText="Altura (cm)" />
                        <asp:BoundField DataField="peso" HeaderText="Peso (kg)" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                    SelectCommand="SELECT * FROM [Tabla_Paciente]" />
            </div>
        </div>

        <asp:HiddenField ID="IDPass" runat="server" />
    </div>

</asp:Content>
