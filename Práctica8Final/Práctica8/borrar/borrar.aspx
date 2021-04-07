<%@ Page Title="Borrar foto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="borrar.aspx.cs" Inherits="Práctica8.borrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2><%: Title %> - Albúm de fotos.</h2>
        <p>
            Haga click en el elemento de la lista que desee borrar. Después haga click en "Borrar".
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="ls_Nombres" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="foto" Height="167px" Width="152px" AutoPostBack="True" OnSelectedIndexChanged="ls_Nombres_SelectedIndexChanged"></asp:ListBox>
                    </td>
                    <td>
                        
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Image ID="Image1" runat="server" Height="161px" Width="145px" />
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ls_Nombres" EventName="SelectedIndexChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </td>
                </tr>
            </table>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fotosConnectionString %>" SelectCommand="SELECT [foto], [nombre] FROM [album] ORDER BY [autor]"></asp:SqlDataSource>
            
            
            <br />
            <asp:Button ID="bt_Borrar" runat="server" Text="Borrar" OnClick="bt_Borrar_Click" />

        </div>
    </div>

</asp:Content>
