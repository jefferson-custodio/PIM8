<%@ Page Title="Telefone Tipo" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="TelefoneTipoForm.aspx.cs" Inherits="TelefoneTipoForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Cadastrar/Editar Telefone Tipo</h1>
    </nav>

    <div>
        <div class="form-group">
            <asp:Label LabelID="label-tipo" runat="server" Text="Tipo" ></asp:Label>  
            <asp:TextBox TextBoxID="tipo" runat="server"  class="form-control"></asp:TextBox>
        </div>
      
        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Enviar"/>
    </div>

</asp:Content>
