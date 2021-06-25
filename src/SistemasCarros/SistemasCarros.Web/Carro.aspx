<%@ Page Title="Carro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carro.aspx.cs" Inherits="SistemasCarros.Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Carros cadastrados.</h2>

    <div class="mt-3">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
