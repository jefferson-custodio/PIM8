<%@ Page Title="Endereco" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="EnderecoForm.aspx.cs" Inherits="EnderecoForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Cadastrar/Editar Endereço</h1>
    </nav>

    <div>
        <div class="form-group">
            <asp:Label LabelID="label-logradouro" runat="server" Text="Logradouro" ></asp:Label>  
            <asp:TextBox TextBoxID="logradouro" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label LabelID="label-numero" runat="server" Text="Número" ></asp:Label>  
            <asp:TextBox TextBoxID="numero" runat="server" type="number" class="form-control"></asp:TextBox>
        </div>
      
         <div class="form-group">
            <asp:Label LabelID="label-cep" runat="server" Text="CEP" ></asp:Label>  
            <asp:TextBox TextBoxID="cep" runat="server" class="form-control"></asp:TextBox>
        </div> 

         <div class="form-group">
            <asp:Label LabelID="label-bairro" runat="server" Text="Bairro" ></asp:Label>  
            <asp:TextBox TextBoxID="bairro" runat="server" class="form-control"></asp:TextBox>
        </div> 

         <div class="form-group">
            <asp:Label LabelID="label-cidade" runat="server" Text="Cidade" ></asp:Label>  
            <asp:TextBox TextBoxID="cidade" runat="server" class="form-control"></asp:TextBox>
        </div> 

         <div class="form-group">
            <asp:Label LabelID="label-estado" runat="server" Text="Estado" ></asp:Label>  
            <asp:TextBox TextBoxID="estado" runat="server" class="form-control"></asp:TextBox>
        </div> 

        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Enviar"/>
    </div>

</asp:Content>
