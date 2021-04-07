<%@ Page Title="Añadir foto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="añadir.aspx.cs" Inherits="Práctica8.añadir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2><%: Title %> - Albúm de fotos.</h2>
        <p>
            Haga click en "Examinar" para seleccionar una foto. Introduzca el nombre de la foto, el autor
            y la descripción de la misma. Finalmente haga click en "Añadir".
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">

            <asp:Label ID="Label1" runat="server" Text="Selecciona una foto:"></asp:Label>
            <asp:Label ID="et_Archivo" runat="server" ForeColor="Red"></asp:Label>
        <asp:FileUpload ID="sa_SubirArchivo" runat="server" />
            <asp:Label ID="Label4" runat="server" Text="Nombre de la foto:"></asp:Label>
            <br />
            <asp:TextBox ID="ct_Nombre" runat="server" OnTextChanged="TextBox1_TextChanged" MaxLength="30"></asp:TextBox>
            <asp:Label ID="et_Nombre" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Autor:"></asp:Label>
            <br />
            <asp:TextBox ID="ct_Autor" runat="server" MaxLength="30"></asp:TextBox>
            <asp:Label ID="et_Autor" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
            <br />
            <asp:TextBox ID="ct_Descripcion" runat="server" Height="69px" Width="269px" MaxLength="400"></asp:TextBox>
            <br />
            <asp:Button ID="bt_Añadir" runat="server" Text="Añadir" OnClick="bt_Añadir_Click" />

        </div>
    </div>

</asp:Content>
