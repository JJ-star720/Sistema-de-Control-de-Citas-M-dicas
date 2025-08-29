<%@ Page Title="Manejo de Cita" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestion_Citas.aspx.vb" Inherits="Sistema_de_Control_de_Citas_Médicas.Gestion_Citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <h3>Formulario</h3>

       <div class="form-group mb-3">
            <label for="TxtFechaCita">Fecha de cita</label>
            <asp:TextBox ID="TxtFechaCita" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

        <div class="form-group mb-3">
             <label for="TxtHora_Cita">Hora de la cita</label>
             <asp:TextBox ID="TxtHora_Cita" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="TxtArea">Area</label>
            <asp:TextBox ID="TxtArea" runat="server" CssClass="form-control"></asp:TextBox>
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



     <asp:HiddenField ID="IDCit" runat="server" />
 <div class="row mb-3">
 <div class="col-md-4">
     <h2>Horarios disponibles para citas</h2>
 <asp:GridView ID="GvCita" runat="server" AllowPaging="True"
      OnSelectedIndexChanged="GvCita_SelectedIndexChanged"
      OnRowDeleting="GvCita_RowDeleting"
      AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ID"
      DataSourceID  ="SqlDataSource" Width="819px">
    <Columns>
       <asp:CommandField ShowSelectButton="True"></asp:CommandField>
       <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
       <asp:BoundField DataField="Fecha_Cita" HeaderText="Fecha_Cita" SortExpression="Fecha_Cita" />
       <asp:BoundField DataField="Hora_Cita" HeaderText="Hora_Cita" SortExpression="Hora_Cita" />
       <asp:BoundField DataField="Area" HeaderText="Area" SortExpression="Area" />
       <asp:CommandField ShowDeleteButton="True" />
    </Columns>
  </asp:GridView>

<asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
 SelectCommand="SELECT * FROM [Tabla_Cita]">
</asp:SqlDataSource>



    </div>

  </div>





</asp:Content>
