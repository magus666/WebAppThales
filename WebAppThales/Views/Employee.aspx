﻿<%@ Page Title="" Async="true" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Site.Master" CodeBehind="Employee.aspx.vb" Inherits="WebAppThales.Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" style="margin-top: 60px">
        <div class="row">
            <div id="IdMensajeSucess" class="alert alert-success alert-dismissible fade show" runat="server" visible="false" role="alert">
                <asp:Label ID="LblMensajeExitoso" runat="server" Text="Label"></asp:Label>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>

            <div id="IdMensajeWarning" class="alert alert-warning alert-dismissible fade show" runat="server" visible="false" role="alert">
                <a><i class="fa fa fa-warning fa-fw" aria-hidden="true"></i>&nbsp; 
                    <asp:Label ID="LblMensajeAviso" runat="server" Text="Label"></asp:Label>
                </a>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
            <div id="IdMensajeDanger" class="alert alert-danger alert-dismissible fade show" runat="server" visible="false" role="alert">
                <asp:Label ID="LblMensajePeligro" runat="server" Text="Label"></asp:Label>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>


            <div class="col-sm-12">
                <div class="card m-2 pb-2 shadow bg-white rounded" style="overflow-y: auto">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6">
                                <asp:Label ID="LblBuscar" runat="server" CssClass="form-label" Text="Select a Employee"></asp:Label>
                                <asp:DropDownList ID="DdlEmployee" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlEmployee_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="col-sm-6">
                                <asp:Label ID="LblBuscarBoton" runat="server" CssClass="form-label" Text="Search a Employee"></asp:Label>
                                <div class="input-group mb-3">
                                    <asp:TextBox ID="TxtSearch" runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="TxtSearch_TextChanged"></asp:TextBox>
                                    <div class="input-group-append">
                                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-sm-12">
                    <div class="card m-2 pb-2 shadow bg-white rounded" style="overflow-y: auto">
                        <div class="card-body">
                            <div class="col-sm-12 mt-3">
                                <asp:GridView ID="GrwEmployee" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-condensed table-responsive table-hover">
                                    <Columns>
                                        <asp:BoundField DataField="IdEmployee" HeaderText="Id" />
                                        <asp:BoundField DataField="NameEmployee" HeaderText="Name" />
                                        <asp:BoundField DataField="AgeEmployee" HeaderText="Age" />
                                        <asp:BoundField DataField="SalaryEmployee" HeaderText="Salary" />
                                        <asp:BoundField DataField="AnualSalary" HeaderText="Anual Salary" />
                                        <asp:TemplateField HeaderText="User Image">
                                            <ItemTemplate>
                                                <asp:Image ID="ImgUser" runat="server" Width="100" Height="100" ImageUrl='<%# Eval("ImageEmployee") %>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
