<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Doctor.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h3>Formulario</h3>

    <div class="form-group mb-3">
         <label for="TxtNombreDc">NombreDc</label>
         <asp:TextBox ID="TxtNombreDc" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

     <div class="form-group mb-3">
          <label for="TxtApellidosDc">ApellidosDc</label>
          <asp:TextBox ID="TxtApellidosDc" runat="server" CssClass="form-control"></asp:TextBox>
     </div>

     <div class="form-group mb-3">
         <label for="TxtEdadDc">EdadDc</label>
         <asp:TextBox TextMode="Number" ID="TxtEdadDc" runat="server" CssClass="form-control"></asp:TextBox>
     </div>

     <div class="form-group mb-3">
        <label for="TxtTelefonoDc">TelefonoDc</label>
        <asp:TextBox ID="TxtTelefonoDc" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

      <div class="form-group mb-3">
           <label for="TxtDireccionDc">DireccionDc</label>
           <asp:TextBox ID="TxtDireccionDc" runat="server" CssClass="form-control"></asp:TextBox>
      </div>

     <div class="form-group mb-3">
       <label for="TxtCorreoDc">CorreoDc</label>
       <asp:TextBox ID="TxtCorreoDc" runat="server" CssClass="form-control"></asp:TextBox>
     </div>

      <div class="form-group mb-3">
         <label for="TxtEspecialidad">Especialidad</label>
         <asp:TextBox ID="TxtEspecialidad" runat="server" CssClass="form-control"></asp:TextBox>
      </div>

      <div class="form-group mb-3">
         <label for="TxtExperiencia">Experiencia</label>
         <asp:TextBox TextMode="Number" ID="TxtExperiencia" runat="server" CssClass="form-control"></asp:TextBox>
      </div>

      


     <div class="form-group">
         <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
     </div>

     <div class="form-group">
         <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Limpiar" OnClick="btnCancelar_Click" />
     </div>


     <div class="form-group">
       <asp:Button ID="Back" CssClass="btn btn-primary" runat="server" Text="Volver" OnClick="Back_Click" />
     </div>

     <div class="form-group mb-3">
         <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
     </div>



   <asp:HiddenField ID="IDDocts" runat="server" />
  <div class="row mb-3">
  <div class="col-md-4">

     <h2>Lista de Doctores</h2>
 <asp:GridView ID="GvDoctor" runat="server" AllowPaging="True"
      OnSelectedIndexChanged="GvDoctor_SelectedIndexChanged"
      OnRowDeleting="GvDoctor_RowDeleting"
      AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
      DataSourceID  ="SqlDataSource" Width="819px">
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
       <asp:CommandField ShowDeleteButton="True" />
    </Columns>
  </asp:GridView>

      <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
           SelectCommand="SELECT * FROM [Tabla_Doctor]">
      </asp:SqlDataSource>

</div>

</div>

</asp:Content>
