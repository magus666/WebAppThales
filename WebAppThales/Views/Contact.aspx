<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="WebAppThales.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <p>Pagina de Contacto.</p>

        <address>
            Ivan Mauricio marin<br />
            Bogota Colombia<br />
            <abbr title="Phone">P:</abbr>
            3175379103
        </address>

        <address>
            <strong>Soporte:</strong><a href="mailto:Support@example.com"> ivan_marin_lombo@hotmail.com</a><br />
        </address>
    </main>
</asp:Content>
