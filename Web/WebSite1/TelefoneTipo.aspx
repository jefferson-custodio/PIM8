<%@ Page Title="Telefone Tipo" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeFile="TelefoneTipo.aspx.cs" Inherits="TelefoneTipo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <h1 class="h3">Telefones Tipos</h1>
      <a runat="server" href="~/TelefoneTipoForm" class="btn btn-primary ml-auto">Novo</a>
    </nav>

    <table class="table">
      <thead>
        <tr>
          <th scope="col">Tipo</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Fixo</td>
          <td>
               <a href="#">Editar</a> <br />
               <a href="#">Excluir</a>
          </td>
        </tr>
      </tbody>
    </table>
</asp:Content>
