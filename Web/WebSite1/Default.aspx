<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PIM8</h1>
        <p class="lead">Escolha uma opção</p>
    </div>

        
    <div class="row">
        <div class="col-md-3">
            <div class="card" style="width: 18rem;">
              <div class="card-body">
                <h5 class="card-title">Telefones tipos</h5>
                <a runat="server" href="~/TelefoneTipo" class="btn btn-primary">Acessar</a>
              </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card" style="width: 18rem;">
              <div class="card-body">
                <h5 class="card-title">Telefones</h5>
                <a runat="server" href="~/Telefone" class="btn btn-primary">Acessar</a>
              </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card" style="width: 18rem;">
              <div class="card-body">
                <h5 class="card-title">Endereços</h5>
                <a runat="server" href="~/Endereco" class="btn btn-primary">Acessar</a>
              </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card" style="width: 18rem;">
              <div class="card-body">
                <h5 class="card-title">Pessoas</h5>
                <a runat="server" href="~/Pessoa" class="btn btn-primary">Acessar</a>
              </div>
            </div>
        </div>
    </div>
</asp:Content>
