<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin.Master" AutoEventWireup="true" CodeBehind="indexAdmin.aspx.cs" Inherits="CarroVirtual.indexAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 runat="server" id="txt_titulo">Bienvenido Administrador (AD-Market)</h1>
    <p runat="server" id="txt_subtitulo" class="subtitle">Small business with big dreams</p>
    <div class="home_btn">
        &nbsp;<asp:Button class="btn btn-md" ID="Button1" runat="server" Height="55px" Text="Cerrar Sesion" Width="156px" OnClick="Button1_Click" />
    </div>
</asp:Content>
