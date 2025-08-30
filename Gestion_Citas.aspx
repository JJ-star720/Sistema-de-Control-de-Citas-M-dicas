<%@ Page Title="Manejo de Cita" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Citas.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container py-4">

        <!-- 📝 Formulario de cita -->
        <div class="card mb-4 shadow-sm">
            <div class="card-header bg-primary text-white">
                <h5 class="mb-0">Formulario de cita médica</h5>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <asp:TextBox ID="TxtFechaCita" runat="server" CssClass="form-control mb-3" placeholder="Fecha de cita" />
                        <asp:TextBox ID="TxtHora_Cita" runat="server" CssClass="form-control mb-3" placeholder="Hora de la cita" />
                        <asp:TextBox ID="TxtArea" runat="server" CssClass="form-control mb-3" placeholder="Área médica" />

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

        <!-- 📅 Horarios disponibles -->
        <div class="card shadow-sm">
            <div class="card-header bg-info text-white">
                <h5 class="mb-0">Horarios disponibles para citas</h5>
            </div>
            <div class="card-body">
                <asp:GridView ID="GvCita" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                    OnSelectedIndexChanged="GvCita_SelectedIndexChanged" OnRowDeleting="GvCita_RowDeleting"
                    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                        <asp:BoundField DataField="Fecha_Cita" HeaderText="Fecha" />
                        <asp:BoundField DataField="Hora_Cita" HeaderText="Hora" />
                        <asp:BoundField DataField="Area" HeaderText="Área" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                    SelectCommand="SELECT * FROM [Tabla_Cita]" />
            </div>
        </div>

        <asp:HiddenField ID="IDCit" runat="server" />
    </div>

</asp:Content>
