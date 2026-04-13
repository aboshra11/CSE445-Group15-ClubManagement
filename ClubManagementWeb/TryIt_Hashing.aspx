<%@ Page Title="Test Hashing" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt_Hashing.aspx.cs" Inherits="ClubManagementWeb.TryIt_Hashing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h2>🔐 Test Shreya's Password Hashing DLL</h2>
            <p>This page tests the <strong>ShreyaHashLib.dll</strong> - a custom DLL that hashes passwords using SHA256.</p>

            <div class="well" style="background:#f5f5f5; padding:20px; border-radius:5px;">
                <h3>Hash a Password</h3>
                <div class="form-group">
                    <label for="txtPassword">Enter Password:</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" Width="300px" />
                </div>
                <asp:Button ID="btnHash" runat="server" Text="Generate Hash" OnClick="btnHash_Click" CssClass="btn btn-primary" />
                <br /><br />
                <asp:Label ID="lblHashResult" runat="server" Font-Bold="true" />
            </div>

            <div class="well" style="background:#f5f5f5; padding:20px; border-radius:5px; margin-top:20px;">
                <h3>Verify a Password</h3>
                <div class="form-group">
                    <label for="txtVerifyPassword">Enter Password to Verify:</label>
                    <asp:TextBox ID="txtVerifyPassword" runat="server" TextMode="Password" CssClass="form-control" Width="300px" />
                </div>
                <div class="form-group">
                    <label for="txtStoredHash">Enter Stored Hash:</label>
                    <asp:TextBox ID="txtStoredHash" runat="server" CssClass="form-control" Width="500px" />
                </div>
                <asp:Button ID="btnVerify" runat="server" Text="Verify Password" OnClick="btnVerify_Click" CssClass="btn btn-success" />
                <br /><br />
                <asp:Label ID="lblVerifyResult" runat="server" Font-Bold="true" />
            </div>

            <br />
            <asp:Button ID="btnBack" runat="server" Text="← Back to Home" OnClick="btnBack_Click" CssClass="btn btn-default" />
        </section>
    </main>

</asp:Content>