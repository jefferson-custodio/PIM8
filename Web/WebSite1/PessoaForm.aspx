<%@ Page Title="Pessoa" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="PessoaForm.aspx.cs" Inherits="PessoaForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Cadastrar/Editar Pessoa</h1>
    </nav>

    <div>
        <div class="form-group">
            <asp:Label LabelID="label-nome" runat="server" Text="Nome" ></asp:Label>  
            <asp:TextBox TextBoxID="nome" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label LabelID="label-cpf" runat="server" Text="CPF" ></asp:Label>  
            <asp:TextBox TextBoxID="cpf" runat="server" type="number" class="form-control"></asp:TextBox>
        </div>
      
         <div class="form-group">
            <asp:Label LabelID="label-endereco" runat="server" Text="Endereço" ></asp:Label>
            <select class="form-control" id="endereco">
              <option>Rua 1 nº 10 Feital, Mauá, São Paulo, CEP: 09333-200</option>
            </select>
          </div>  

          <div class="form-group">
            <asp:Label LabelID="label-telefone" runat="server" Text="Telefone" ></asp:Label>
            <select multiple class="form-control" id="telefone">
                <option>(11) 4545-4545</option>
                <option>(11) 4245-4545</option>
            </select>
            </div>

        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Enviar"/>
    </div>

</asp:Content>
