<%@ Page Title="Telefone" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="TelefoneForm.aspx.cs" Inherits="TelefoneForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Cadastrar/Editar Telefone</h1>
    </nav>

    <div>
        <div class="form-group">
            <asp:Label LabelID="label-ddd" runat="server" Text="DDD" ></asp:Label>  
            <asp:TextBox TextBoxID="ddd" runat="server" type="number" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label LabelID="label-numero" runat="server" Text="Número" ></asp:Label>  
            <asp:TextBox TextBoxID="numero" runat="server" type="number" class="form-control"></asp:TextBox>
        </div>
      
         <div class="form-group">
            <asp:Label LabelID="label-tipo" runat="server" Text="Tipo" ></asp:Label>
            <select class="form-control" id="tipo">
              <option>Fixo</option>
            </select>
          </div>  

        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Enviar"/>
    </div>

</asp:Content>
