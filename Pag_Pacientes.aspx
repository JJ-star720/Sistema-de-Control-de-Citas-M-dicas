<%@ Page Title="Agendacion de cita " Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Pag_Pacientes.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Pag_Pacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:HiddenField ID="IDPass" runat="server" />

<div class="container py-4">

    <!-- 👨‍⚕️ Lista de pacientes -->
    <div class="card mb-4 shadow-sm">
        <div class="card-header bg-primary text-white">
            <h5 class="mb-0">Lista de pacientes</h5>
        </div>
        <div class="card-body">
            <asp:GridView ID="GvPasiente" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                OnSelectedIndexChanged="GvPaciente_SelectedIndexChanged" AllowSorting="True" AutoGenerateColumns="False"
                DataKeyNames="ID" DataSourceID="SqlDataSource">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Edad" HeaderText="Edad" />
                    <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                    <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo electrónico" />
                    <asp:BoundField DataField="altura" HeaderText="Altura (cm)" />
                    <asp:BoundField DataField="peso" HeaderText="Peso (kg)" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                SelectCommand="SELECT * FROM [Tabla_Paciente]" />
        </div>
    </div>

    <!-- 🗓️ Horarios disponibles para citas -->
    <asp:HiddenField ID="IDCit" runat="server" />
    <div class="card shadow-sm">
        <div class="card-header bg-success text-white">
            <h5 class="mb-0">Horarios disponibles para citas</h5>
        </div>
        <div class="card-body">
            <asp:GridView ID="GvCita" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                OnSelectedIndexChanged="GvCita_SelectedIndexChanged" AllowSorting="True" AutoGenerateColumns="False"
                DataKeyNames="ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Fecha_Cita" HeaderText="Fecha" />
                    <asp:BoundField DataField="Hora_Cita" HeaderText="Hora" />
                    <asp:BoundField DataField="Area" HeaderText="Área" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                SelectCommand="SELECT * FROM [Tabla_Cita]" />
        </div>
    </div>

</div>



       <asp:HiddenField ID="IDDocts" runat="server" />

<div class="container py-4">

    <!-- 👨‍⚕️ Lista de doctores -->
    <div class="card mb-4 shadow-sm">
        <div class="card-header bg-info text-white">
            <h5 class="mb-0">Lista de doctores registrados</h5>
        </div>
        <div class="card-body">
            <asp:GridView ID="GvDoctor" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                OnSelectedIndexChanged="GvDoctor_SelectedIndexChanged" AllowSorting="True" AutoGenerateColumns="False"
                DataKeyNames="ID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="NombreDc" HeaderText="Nombre" />
                    <asp:BoundField DataField="ApellidosDc" HeaderText="Apellidos" />
                    <asp:BoundField DataField="EdadDc" HeaderText="Edad" />
                    <asp:BoundField DataField="TelefonoDc" HeaderText="Teléfono" />
                    <asp:BoundField DataField="DireccionDc" HeaderText="Dirección" />
                    <asp:BoundField DataField="CorreoDc" HeaderText="Correo electrónico" />
                    <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
                    <asp:BoundField DataField="Experiencia" HeaderText="Experiencia (años)" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                SelectCommand="SELECT * FROM [Tabla_Doctor]" />
        </div>
    </div>

    <!-- 📅 Lista de citas agendadas -->
    <asp:HiddenField ID="IDAgenda" runat="server" />
    <div class="card shadow-sm">
        <div class="card-header bg-warning text-dark">
            <h5 class="mb-0">Citas médicas agendadas</h5>
        </div>
        <div class="card-body">
            <asp:GridView ID="GvAgenda" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                OnSelectedIndexChanged="GvAgenda_SelectedIndexChanged" OnRowDeleting="GvAgenda_RowDeleting" AllowSorting="True" 
                AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource3">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="NombrePas" HeaderText="Nombre del paciente" />
                    <asp:BoundField DataField="ApellidosPas" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Profecional" HeaderText="Profesional encargado" />
                    <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
                    <asp:BoundField DataField="Fechacita" HeaderText="Fecha" />
                    <asp:BoundField DataField="Horacita" HeaderText="Hora" />
                    <asp:BoundField DataField="AreaEs" HeaderText="Área médica" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                SelectCommand="SELECT * FROM [Agendas]" />
        </div>
    </div>

</div>


<div class="container py-4">
    <!-- 📝 Formulario de agendación -->
    <div class="card shadow-sm mb-4">
        <div class="card-header bg-primary text-white">
            <h5 class="mb-0">Formulario de agendación de cita</h5>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control mb-3" placeholder="Nombre del paciente" />
                    <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control mb-3" placeholder="Apellidos del paciente" />
                    <asp:TextBox ID="TxtAreaEs" runat="server" CssClass="form-control mb-3" placeholder="Área médica" />
                    <asp:TextBox ID="TxtProfecional" runat="server" CssClass="form-control mb-3" placeholder="Profesional encargado" />
                    <asp:TextBox ID="TxtEspecialidad" runat="server" CssClass="form-control mb-3" placeholder="Especialidad" />
                    <asp:TextBox ID="TxtFechaCita" runat="server" CssClass="form-control mb-3" placeholder="Fecha de la cita" />
                    <asp:TextBox ID="TxtHora_Cita" runat="server" CssClass="form-control mb-3" placeholder="Hora de la cita" />

                    <div class="d-flex gap-2 mt-3">
                        <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Agendar" OnClick="btnGuardar_Click" />
                        <asp:Button ID="btnCancelar" CssClass="btn btn-warning" runat="server" Text="Limpiar" OnClick="btnCancelar_Click" />
                    </div>

                    <asp:Label ID="LblMensaje" runat="server" CssClass="mt-3 text-danger d-block" Text="" />
                </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>
