<%@ Page Title="Test Fact Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt_Fact.aspx.cs" Inherits="ClubManagementWeb.TryIt_Fact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h2>📖 Test Shreya's Fact Service</h2>
            <p>This page tests the <strong>FactService.svc</strong> - a WCF service that returns random facts.</p>

            <div class="well" style="background:#f5f5f5; padding:20px; border-radius:5px;">
                <h3>Get a Random Fact</h3>
                <div class="form-group">
                    <label for="ddlCategory">Select Category:</label>
                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" Width="200px">
                        <asp:ListItem Text="club" />
                        <asp:ListItem Text="sports" />
                        <asp:ListItem Text="technology" />
                        <asp:ListItem Text="general" />
                    </asp:DropDownList>
                </div>
                <asp:Button ID="btnGetFact" runat="server" Text="Get Random Fact" OnClick="btnGetFact_Click" CssClass="btn btn-primary" />
                <br /><br />
                <div class="alert alert-info" style="padding:15px; background:#d9edf7; border-radius:5px;">
                    <asp:Label ID="lblFact" runat="server" Font-Size="14px" />
                </div>
            </div>

            <br />
            <asp:Button ID="btnBack" runat="server" Text="← Back to Home" OnClick="btnBack_Click" CssClass="btn btn-default" />
        </section>
    </main>

</asp:Content>