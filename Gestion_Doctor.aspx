<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Doctor.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
      SelectCommand="SELECT * FROM [Tabla_Doctor]">
    </asp:SqlDataSource>

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
         <asp:TextBox ID="TxtExperiencia" runat="server" CssClass="form-control"></asp:TextBox>
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

</asp:Content>
