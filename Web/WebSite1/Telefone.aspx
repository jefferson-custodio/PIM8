<%@ Page Title="Telefone" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="Telefone.aspx.cs" Inherits="Telefone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Telefones</h1>
      <a runat="server" href="~/TelefoneForm" class="btn btn-primary ml-auto">Novo</a>
    </nav>

    <table class="table">
      <thead>
        <tr>
          <th scope="col">DDD</th>
          <th scope="col">Numero</th>
          <th scope="col">Tipo</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>11</td>
          <td>4545-4545</td>
          <td>Fixo</td>
          <td>
               <a href="#">Editar</a> <br />
               <a href="#">Excluir</a>
          </td>
        </tr>
      </tbody>
    </table>
</asp:Content>
