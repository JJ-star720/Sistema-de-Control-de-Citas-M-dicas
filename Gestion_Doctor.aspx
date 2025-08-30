<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Doctor.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container py-4">

 <!-- 📝 Formulario de registro -->
        <div class="card mb-4 shadow-sm">
            <div class="card-header bg-primary text-white">
                <h5 class="mb-0">Formulario de registro de doctor</h5>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <asp:TextBox ID="TxtNombreDc" runat="server" CssClass="form-control mb-3" placeholder="Nombre" />
                        <asp:TextBox ID="TxtApellidosDc" runat="server" CssClass="form-control mb-3" placeholder="Apellidos" />
                        <asp:TextBox ID="TxtEdadDc" runat="server" CssClass="form-control mb-3" TextMode="Number" placeholder="Edad" />
                        <asp:TextBox ID="TxtTelefonoDc" runat="server" CssClass="form-control mb-3" placeholder="Teléfono" />
                        <asp:TextBox ID="TxtDireccionDc" runat="server" CssClass="form-control mb-3" placeholder="Dirección" />
                        <asp:TextBox ID="TxtCorreoDc" runat="server" CssClass="form-control mb-3" placeholder="Correo electrónico" />
                        <asp:TextBox ID="TxtEspecialidad" runat="server" CssClass="form-control mb-3" placeholder="Especialidad" />
                        <asp:TextBox ID="TxtExperiencia" runat="server" CssClass="form-control mb-3" TextMode="Number" placeholder="Años de experiencia" />

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




   <asp:HiddenField ID="IDDocts" runat="server" />

     <!-- 👨‍⚕️ Lista de doctores -->
        <div class="card shadow-sm">
            <div class="card-header bg-info text-white">
                <h5 class="mb-0">Lista de doctores registrados</h5>
            </div>
            <div class="card-body">
                <asp:GridView ID="GvDoctor" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True"
                    OnSelectedIndexChanged="GvDoctor_SelectedIndexChanged" OnRowDeleting="GvDoctor_RowDeleting"
                    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                        <asp:BoundField DataField="NombreDc" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidosDc" HeaderText="Apellidos" />
                        <asp:BoundField DataField="EdadDc" HeaderText="Edad" />
                        <asp:BoundField DataField="TelefonoDc" HeaderText="Teléfono" />
                        <asp:BoundField DataField="DireccionDc" HeaderText="Dirección" />
                        <asp:BoundField DataField="CorreoDc" HeaderText="Correo" />
                        <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
                        <asp:BoundField DataField="Experiencia" HeaderText="Experiencia (años)" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
                    SelectCommand="SELECT * FROM [Tabla_Doctor]" />
            </div>
        </div>
 </div>

</asp:Content>
