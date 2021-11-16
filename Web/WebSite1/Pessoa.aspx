<%@ Page Title="Pessoa" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="Pessoa.aspx.cs" Inherits="Pessoa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Pessoa</h1>
      <a runat="server" href="~/PessoaForm" class="btn btn-primary ml-auto">Novo</a>
    </nav>

    <table class="table">
      <thead>
        <tr>
          <th scope="col">Nome</th>
          <th scope="col">CPF</th>
          <th scope="col">Endereco</th>
          <th scope="col">Telefones</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Jefferson</td>
          <td>000.000.000-00</td>
          <td>Rua 1 nº 10 Feital, Mauá, São Paulo, CEP: 09333-200</td>
          <td>(11) 4545-4545 
              <br> 
              (11) 4245-4545
          </td>
          <td>
               <a href="#">Editar</a> <br />
               <a href="#">Excluir</a>
          </td>
        </tr>
      </tbody>
    </table>
</asp:Content>
