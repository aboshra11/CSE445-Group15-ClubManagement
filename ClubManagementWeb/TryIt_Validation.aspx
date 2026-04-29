<%@ Page Title="TryIt Validation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt_Validation.aspx.cs" Inherits="ClubManagementWeb.TryIt_Validation" %>

<%@ Register Src="~/ValidationInputControl.ascx" TagPrefix="uc" TagName="ValidationInputControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row">
            <h2>Keenan Validation Components TryIt Page</h2>
            <p>This page demonstrates local validation components and validation web service.</p>

            <h3>1. Local User Control Test</h3>
            <uc:ValidationInputControl ID="ValidationInputControl1" runat="server" />

            <hr />

            <h3>2. Web Service Test</h3>

            <div class="form-group" style="margin-bottom:10px;">
                <label for="txtServiceInput">Input:</label>
                <asp:TextBox ID="txtServiceInput" runat="server" CssClass="form-control" Width="300px" />
            </div>

            <div class="form-group">
                <label for="ddlServiceType">Validation Type:</label>
                <asp:DropDownList ID="ddlServiceType" runat="server" CssClass="form-control" Width="200px">
                    <asp:ListItem Text="Email" Value="email" />
                    <asp:ListItem Text="Phone" Value="phone" />
                    <asp:ListItem Text="ZIP" Value="zip" />
                    <asp:ListItem Text="Password" Value="password" />
                </asp:DropDownList>
            </div>

            <div class="mt-3">
                <asp:Button ID="btnServiceValidate" runat="server" Text="Call Validation Service" OnClick="btnServiceValidate_Click" CssClass="btn btn-primary" />
            </div>

            <div class="mt-2">
                <asp:Label ID="lblServiceResult" runat="server" Font-Bold="true" />
            </div>
        </section>
    </main>
</asp:Content>