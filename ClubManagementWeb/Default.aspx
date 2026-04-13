<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClubManagementWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="clubTitle">
            <h1 id="clubTitle">🏆 Club Management System</h1>
            <p class="lead">Welcome to the Club Management System. This application allows club members to register, login, and access member-only content.</p>
            <p>
                <asp:Button ID="btnMember" runat="server" Text="Member Page" OnClick="btnMember_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnStaff" runat="server" Text="Staff Page" OnClick="btnStaff_Click" CssClass="btn btn-default" />
            </p>
        </section>

        <!-- Shreya's Service Directory -->
        <section class="row" aria-labelledby="serviceDirectoryTitle">
            <h2 id="serviceDirectoryTitle">📋 Service Directory - Shreya's Components</h2>
            <div class="table-responsive">
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>Provider</th>
                            <th>Component Type</th>
                            <th>Operation</th>
                            <th>Parameters</th>
                            <th>Return Type</th>
                            <th>TryIt Link</th>
                        </tr>
                    </thead>
                    <tbody>
                        <!-- DLL Component -->
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>DLL (Class Library)</td>
                            <td>HashPassword</td>
                            <td>string password</td>
                            <td>string (SHA256 hash)</td>
                            <td><a href="TryIt_Hashing.aspx" class="btn btn-sm btn-info">Test Hashing</a></td>
                        </tr>
                        <!-- User Control Component -->
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>User Control</td>
                            <td>CAPTCHA Verification</td>
                            <td>user input</td>
                            <td>bool</td>
                            <td><a href="MemberSignup.aspx" class="btn btn-sm btn-info">Test on Signup</a></td>
                        </tr>
                        <!-- Web Service Component -->
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>WCF Service (SVC)</td>
                            <td>GetRandomFact</td>
                            <td>string category</td>
                            <td>string</td>
                            <td><a href="TryIt_Fact.aspx" class="btn btn-sm btn-info">Test Service</a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </section>

        <!-- Test Hashing Demo (Visible/Testable requirement) -->
        <section class="row" aria-labelledby="hashingDemo">
            <h3>🔐 Test Password Hashing (Shreya's DLL)</h3>
            <div class="well">
                <div class="form-group">
                    <label for="txtTestPassword">Enter Password:</label>
                    <asp:TextBox ID="txtTestPassword" runat="server" CssClass="form-control" Width="300px" TextMode="Password" />
                </div>
                <asp:Button ID="btnHashDemo" runat="server" Text="Hash Password" OnClick="btnHashDemo_Click" CssClass="btn btn-success" />
                <br /><br />
                <asp:Label ID="lblHashResult" runat="server" Font-Bold="true" />
            </div>
        </section>
    </main>

</asp:Content>