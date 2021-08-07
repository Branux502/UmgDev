﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebProducto.aspx.cs" Inherits="DXWebApplication.WebForms.Mantenimientos.Producto.WebProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/StyleWebForm.css") %>" type="text/css" />
    <div class="contenedor" id="contenedor">
        <div class="cabecera" id="cabecera">
            <th>Mantenimiento de Productos</th>
        </div>
        
        <dx:ASPxGridView ID="dxGridProducto" runat="server" AutoGenerateColumns="false"  ClientInstanceName="dxGridProducto" KeyFieldName="ID_PRODUCTO" SettingsBehavior-ConfirmDelete ="true"
              Width="100%">
            <SettingsAdaptivity AdaptivityMode="HideDataCells" />
            <SettingsPager PageSize="10" />            
            <EditFormLayoutProperties>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </EditFormLayoutProperties>            
            <SettingsSearchPanel Visible="true" />
            <Settings  ShowFooter="True"/>
            <SettingsCommandButton>
                    <EditButton  Text="Editar" Image-Url="~/Content/Images/edit.png" />
                    <NewButton   Text="Nuevo"  Image-Url="~/Content/Images/new.png"/>
                    <DeleteButton   Text="Eliminar"  Image-Url="~/Content/Images/borrar.png"/>
            </SettingsCommandButton>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowNewButton="true" ShowDeleteButton="true" />  
                               
                <dx:GridViewDataTextColumn Caption="CODIGO" FieldName="ID_PRODUCTO" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="PRODUCTO" FieldName="DESCRIPCION" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn Caption="CATEGORIA" FieldName="ID_TIPO_PRODUCTO" VisibleIndex="2">
                    <PropertiesComboBox TextField="DESCRIPCION" ValueField="TIPO_PRODUCTO" ValueType="System.Int32" DataSourceID="sqlDtsCategoria" EnableSynchronization="False" IncrementalFilteringMode="StartsWith">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn Caption="PRECIO" FieldName="PRECIO" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="EXISTENCIA" FieldName="EXISTENCIA" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn Caption="ESTADO" FieldName="ESTADO" VisibleIndex="5">
                    <PropertiesComboBox TextField="ESTADO" ValueField="ESTADO" ValueType="System.Int32" IncrementalFilteringMode="StartsWith">
                        <Items>
                            <dx:ListEditItem Text="Inactivo" Value="0" />
                            <dx:ListEditItem Text="Activo" Value="1" />
                        </Items>
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>
    </div>
    <asp:SqlDataSource ID="sqlDtsCategoria" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SrvSistema %>" 
        SelectCommand="SELECT ID_TIPO_PRODUCTO AS TIPO_PRODUCTO, DESCRIPCION FROM POS.TIPO_PRODUCTO">
    </asp:SqlDataSource>


</asp:Content>
