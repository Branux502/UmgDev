<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebBiblioteca.aspx.cs" Inherits="DXWebApplication.WebForms.Mantenimientos.Biblioteca.WebBiblioteca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="./StyleBiblioteca.css" rel="stylesheet" />
    <div id="MainBiblioteca">
        <div id="FormBiblioteca">   
            <asp:Label ID="Label2" runat="server" Text="Biblioteca Central"></asp:Label>

            <asp:DropDownList runat="server" ID="ddlista">
            </asp:DropDownList>
    </div>
        <asp:SqlDataSource ID="sqlDtsCategoria" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SrvSistema %>" 
        SelectCommand="SELECT ID_LIBRO, NOMBRE FROM TB_LIBRO">
    </asp:SqlDataSource>


        </div>
    
</asp:Content>
