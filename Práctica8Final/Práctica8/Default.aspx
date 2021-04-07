<%@ Page Title="Mostrar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Práctica8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2><%: Title %> - Álbum de fotos.</h2>
        <p>
            Todos los usuarios, autenticados o no, podrán ver las fotos, sólo los
            usuarios autenticados podrán añadir fotos y sólo los usuarios autenticados
            que tengan asignada la función de “Administradores” podrán borrar fotos.
        </p>
    </div>
    

    <div class="row">
        <div class="col-md-4">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fotosConnectionString %>" SelectCommand="SELECT [foto], [nombre], [autor], [descripcion] FROM [album] ORDER BY [autor]"></asp:SqlDataSource>

            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    &nbsp;<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("foto") %>' />
                    <br />
                    nombre:
                    <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
                    <br />
                    autor:
                    <asp:Label ID="autorLabel" runat="server" Text='<%# Eval("autor") %>' />
                    <br />
                    descripcion:
                    <asp:Label ID="descripcionLabel" runat="server" Text='<%# Eval("descripcion") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>

        </div>
    </div>

</asp:Content>
