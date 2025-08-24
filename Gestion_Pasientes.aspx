<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Pasientes.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Pasientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="IDPass" runat="server" />
    <div class="row mb-3">
    <div class="col-md-4">
        <h2>Pasientes</h2>
    <asp:GridView ID="GvPasiente" runat="server" AllowPaging="True"
         OnSelectedIndexChanged="GvPasiente_SelectedIndexChanged"
         OnRowDeleting="GvPasiente_RowDeleting"
         AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="PasienteID"
         DataSourceID  ="SqlDataSource" Width="819px">
       <Columns>
          <asp:CommandField ShowSelectButton="True"></asp:CommandField>
          <asp:BoundField DataField="PasienteID" HeaderText="PasienteID" InsertVisible="False" ReadOnly="True" SortExpression="PasienteID" />
          <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
          <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
          <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
          <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
          <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
          <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
          <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
          <asp:BoundField DataField="altura" HeaderText="altura" SortExpression="altura" />
          <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
          <asp:CommandField ShowDeleteButton="True" />
       </Columns>
     </asp:GridView>

   <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
    SelectCommand="SELECT * FROM [Tabla_Paciente]">
   </asp:SqlDataSource>

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
             <label for="TxtFechaNaciemnto">FechaNacimiento</label>
             <asp:TextBox ID="TxtFechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="TxtEdad">Edad</label>
            <asp:TextBox TextMode="Number" ID="TxtEdad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
           <label for="TxtTelefono">Telefono</label>
           <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

         <div class="form-group mb-3">
              <label for="TxtDireccion">Direccion</label>
              <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

        <div class="form-group mb-3">
          <label for="TxtCorreo">Correo</label>
          <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class="form-group mb-3">
            <label for="Txtaltura">altura</label>
            <asp:TextBox ID="Txtaltura" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

         <div class="form-group mb-3">
            <label for="Txtpeso">peso</label>
            <asp:TextBox ID="Txtpeso" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

         


        <div class="form-group">
            <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>

        <div class="form-group">
            <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Limpiar" OnClick="btnCancelar_Click" />
        </div>

        <div class="form-group mb-3">
            <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </div>

  </div>
</asp:Content>
