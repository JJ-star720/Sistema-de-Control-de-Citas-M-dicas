<%@ Page Title="Agendacion de cita " Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Pag_Pacientes.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Pag_Pacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:HiddenField ID="IDPass" runat="server" />
            <div class="row mb-3">
            <div class="col-md-4">
       <h2>Pasientes</h2>

    <asp:GridView ID="GvPasiente" runat="server" AllowPaging="True"
      OnSelectedIndexChanged="GvPaciente_SelectedIndexChanged"
      AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
      DataSourceID  ="SqlDataSource" Width="819px">

        <Columns>
           <asp:CommandField ShowSelectButton="True"></asp:CommandField>
           <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
           <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
           <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
           <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
           <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
           <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
           <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
           <asp:BoundField DataField="altura" HeaderText="altura" SortExpression="altura" />
           <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
        SelectCommand="SELECT * FROM [Tabla_Paciente]">
    </asp:SqlDataSource>

  </div>
</div>

         <asp:HiddenField ID="IDCit" runat="server" />
 <div class="row mb-3">
 <div class="col-md-4">
     <h2>Horarios disponibles para citas</h2>
 <asp:GridView ID="GvCita" runat="server" AllowPaging="True"
      OnSelectedIndexChanged="GvCita_SelectedIndexChanged"
      AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
      DataSourceID  ="SqlDataSource1" Width="819px">
    <Columns>
       <asp:CommandField ShowSelectButton="True"></asp:CommandField>
       <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
       <asp:BoundField DataField="Fecha_Cita" HeaderText="Fecha_Cita" SortExpression="Fecha_Cita" />
       <asp:BoundField DataField="Hora_Cita" HeaderText="Hora_Cita" SortExpression="Hora_Cita" />
       <asp:BoundField DataField="Area" HeaderText="Area" SortExpression="Area" />
    </Columns>
  </asp:GridView>

      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
              SelectCommand ="SELECT * FROM [Tabla_Cita]">
      </asp:SqlDataSource>

    </div>
  </div>


       <asp:HiddenField ID="IDDocts" runat="server" />
  <div class="row mb-3">
  <div class="col-md-4">

     <h2>Lista de Doctores</h2>
 <asp:GridView ID="GvDoctor" runat="server" AllowPaging="True"
      OnSelectedIndexChanged="GvDoctor_SelectedIndexChanged"
      AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
      DataSourceID  ="SqlDataSource2" Width="819px">
    <Columns>
       <asp:CommandField ShowSelectButton="True"></asp:CommandField>
       <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
       <asp:BoundField DataField="NombreDc" HeaderText="NombreDc" SortExpression="NombreDc" />
       <asp:BoundField DataField="ApellidosDc" HeaderText="ApellidosDc" SortExpression="ApellidosDc" />
       <asp:BoundField DataField="EdadDc" HeaderText="EdadDc" SortExpression="EdadDc" />
       <asp:BoundField DataField="TelefonoDc" HeaderText="TelefonoDc" SortExpression="TelefonoDc" />
       <asp:BoundField DataField="DireccionDc" HeaderText="DireccionDc" SortExpression="DireccionDc" />
       <asp:BoundField DataField="CorreoDc" HeaderText="CorreoDc" SortExpression="CorreoDc" />
       <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad" />
       <asp:BoundField DataField="Experiencia" HeaderText="Experiencia" SortExpression="Experiencia" />
    </Columns>
  </asp:GridView>

      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
           SelectCommand="SELECT * FROM [Tabla_Doctor]">
      </asp:SqlDataSource>

   </div>

   </div>


          <asp:HiddenField ID="IDAgenda" runat="server" />
         <div class="row mb-3">
         <div class="col-md-4">

    <h2>Lista de citas agendadas</h2>
<asp:GridView ID="GvAgenda" runat="server" AllowPaging="True"
     OnSelectedIndexChanged="GvAgenda_SelectedIndexChanged"
     AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
     DataSourceID  ="SqlDataSource3" Width="819px">
   <Columns>
      <asp:CommandField ShowSelectButton="True"></asp:CommandField>
      <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
      <asp:BoundField DataField="NombrePas" HeaderText="NombrePas" SortExpression="NombrePas" />
      <asp:BoundField DataField="ApellidosPas" HeaderText="ApellidosPas" SortExpression="ApellidosPas" />
      <asp:BoundField DataField="Profecional" HeaderText="Profecional" SortExpression="Profecional" />
      <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad" />
      <asp:BoundField DataField="Fechacita" HeaderText="Fechacita" SortExpression="Fechacita" />
      <asp:BoundField DataField="Horacita" HeaderText="Horacita" SortExpression="Horacita" />
      <asp:BoundField DataField="AreaEs" HeaderText="AreaEs" SortExpression="AreaEs" />
   </Columns>
 </asp:GridView>

     <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
          SelectCommand="SELECT * FROM [Agendas]">
     </asp:SqlDataSource>

  </div>

  </div>




     <h3>Formulario</h3>

    <div class="form-group mb-3">
         <label for="TxtNombre">Nombre</label>
         <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mb-3">
        <label for="TxtApellidos">Apellidos</label>
        <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

   <div class="form-group mb-3">
       <label for="TxtAreaEs">Area</label>
      <asp:TextBox ID="TxtAreaEs" runat="server" CssClass="form-control"></asp:TextBox>
   </div>

   <div class="form-group mb-3">
       <label for="TxtProfecional">Profecinal encargado</label>
       <asp:TextBox ID="TxtProfecional" runat="server" CssClass="form-control"></asp:TextBox>
   </div>

    <div class="form-group mb-3">
       <label for="TxtEspecialidad">Especialidad</label>
       <asp:TextBox ID="TxtEspecialidad" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mb-3">
        <label for="TxtFechaCita">Fecha de cita</label>
        <asp:TextBox ID="TxtFechaCita" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mb-3">
      <label for="TxtHora_Cita">Hora de la cita</label>
      <asp:TextBox ID="TxtHora_Cita" runat="server" CssClass="form-control"></asp:TextBox>
    </div>


    <div class="form-group">
      <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Agendar" OnClick="btnGuardar_Click" />
    </div>

   <div class="form-group">
      <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Limpiar" OnClick="btnCancelar_Click" />
   </div>

    <div class="form-group mb-3">
      <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
