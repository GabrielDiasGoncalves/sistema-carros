<%@ Page Title="Marca" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marca.aspx.cs" Inherits="SistemasCarros.Web.MarcaPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Marcas cadastradas.</h2>
    <div class="mt-3">
        <asp:GridView ID="Grd_Marcas" runat="server">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Codigo" ItemStyle-CssClass="hidecss" HeaderStyle-CssClass="hidecss" >
                  <ItemStyle Width="80px" HorizontalAlign="Left" />
                  <HeaderStyle Width="80px" Wrap="False" />
                  </asp:BoundField>                           
                  <asp:BoundField HeaderText="Name" DataField="Nome">
                    <ItemStyle Width="200px" HorizontalAlign="Left" />
                    <HeaderStyle Width="200px" Wrap="False" />
                  </asp:BoundField>
            </Columns>
            <EmptyDataTemplate>No records registered</EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
