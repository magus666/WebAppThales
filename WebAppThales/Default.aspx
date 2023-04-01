<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebAppThales._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">Thales Web App is a responsive site to show information about employees</p>
        </section>

        <div class="row">
            <section class="col-md-6" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    To get started, please select the Employee item from the top Menu.
                </p>
            </section>
            <section class="col-md-6" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Important Information</h2>
                <p>
                    The application loads the information from the Thales API created in a separate project hosted on GitHub and published another URL.
                </p>
                <p>
                    The dummy API is invoked from the code behind but as it has connectivity problems the information is not displayed in a grid, only an error message is displayed when there is no connection.
                </p>
                <p>
                    <asp:Button ID="BtnOpenApi" runat="server" Text="Web Api" CssClass="btn btn-primary" OnClick="BtnOpenApi_Click" />
                </p>
            </section>
        </div>
    </main>

</asp:Content>
