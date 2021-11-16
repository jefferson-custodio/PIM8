<%@ Page Title="Endereco" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="Endereco.aspx.cs" Inherits="Endereco" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Endereços</h1>
      <a runat="server" href="~/EnderecoForm" class="btn btn-primary ml-auto">Novo</a>
    </nav>

    <table class="table">
      <thead>
        <tr>
          <th scope="col">Logradouro</th>
          <th scope="col">Numero</th>
          <th scope="col">CEP</th>
          <th scope="col">Bairro</th>
          <th scope="col">Cidade</th>
          <th scope="col">Estado</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Rua 1</td>
          <td>10</td>
          <td>09333-200</td>
          <td>Feital</td>
          <td>Mauá</td>
          <td>São Paulo</td>
          <td>
               <a href="#">Editar</a> <br />
               <a href="#">Excluir</a>
          </td>
        </tr>
      </tbody>
    </table>
</asp:Content>
