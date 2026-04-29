<%@ Page Title="Staff Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="ClubManagementWeb.StaffPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h2>Staff Page</h2>
        <p>This page is for staff-only access. The can be tested using username <strong>TA</strong> and password <strong>Cse445!</strong>.</p>

        <asp:Panel ID="pnlLogin" runat="server">
            <h3>Staff Login</h3>

            <div class="form-group">
                <label>Username:</label><br />
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Width="300px" />
            </div>

            <div class="form-group">
                <label>Password:</label><br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" Width="300px" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Staff Login" OnClick="btnLogin_Click" CssClass="btn btn-primary mt-3" />
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true" ForeColor="Red" />
        </asp:Panel>

        <asp:Panel ID="pnlStaffContent" runat="server" Visible="false">
            <h3>Staff-Only Content</h3>
            <p>Welcome, staff user. You have succesfully logged in for viewing of staff-only content.</p>

            <ul>
                <li>Staff login has been verified.</li>
                <li>Staff-only content section here is visible.</li>
            </ul>
            
            <asp:Button ID="btnLogout" runat="server" Text="Staff Logout" OnClick="btnLogout_Click" CssClass="btn btn-secondary" />
        </asp:Panel>
    </main>
</asp:Content>