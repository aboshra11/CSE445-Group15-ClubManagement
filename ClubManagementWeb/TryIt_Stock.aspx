<%@ Page Title="TryIt Stock Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt_Stock.aspx.cs" Inherits="ClubManagementWeb.TryIt_Stock" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h2>Keenan Stock Service TryIt Page</h2>
        <p>This page tests StockService.svc web service.</p>

        <div class="form-group">
            <label>Enter stock symbol:</label><br />
            <asp:TextBox ID="txtSymbol" runat="server" CssClass="form-control" Width="300px" />
        </div>

        <asp:Button ID="btnGetPrice" runat="server" Text="Get Stock Price" OnClick="btnGetPrice_Click" CssClass="btn btn-primary mt-3" />
        <br /><br />

        <asp:Label ID="lblResult" runat="server" Font-Bold="true" />

        <hr />
        <p>Sample symbols: AAPL, MSFT, GOOGL, AMZN, TSLA</p>
        <p><a href="Default.aspx">Back To Home</a></p>
    </main>
</asp:Content>