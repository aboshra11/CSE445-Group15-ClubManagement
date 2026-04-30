<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClubManagementWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row" aria-labelledby="clubTitle">
            <h1 id="clubTitle">🏆 Club Management System</h1>
            <p class="lead">Welcome to the Club Management System. This application allows club members to register, login, and access member-only content. Use the buttons below to navigate to the Member or Staff pages.</p>
            <p><strong>WebStrar Deployment URL:</strong> http://webstrarportal-env.eba-uzcvm8rb.us-west-2.elasticbeanstalk.com/sites/website15/Page0/Default.aspx</p>
            <p>
                <asp:Button ID="btnMember" runat="server" Text="Member Page" OnClick="btnMember_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnStaff" runat="server" Text="Staff Page" OnClick="btnStaff_Click" CssClass="btn btn-default" />
            </p>
        </section>

        <!-- Application and Components Summary Table -->
        <section class="row" aria-labelledby="serviceDirectoryTitle">
            <h2 id="serviceDirectoryTitle">📋 Application and Components Summary Table</h2>
            <p><strong>Team:</strong> Group 15 — Shreya Sharma (sshar318), Amir Boshra (aboshra), Keenan Tait (ktait1)</p>
            <div class="table-responsive">
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>Provider</th>
                            <th>Component Type</th>
                            <th>Operation / Description</th>
                            <th>Parameters</th>
                            <th>Return Type</th>
                            <th>TryIt Link</th>
                        </tr>
                    </thead>
                    <tbody>
                        <!-- Shreya's Components -->
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>DLL (Class Library)</td>
                            <td>HashPassword — SHA256 password hashing</td>
                            <td>string password</td>
                            <td>string (SHA256 hash)</td>
                            <td><a href="TryIt_Hashing.aspx" class="btn btn-sm btn-info">Test Hashing</a></td>
                        </tr>
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>User Control</td>
                            <td>CAPTCHA Verification — validates user is human on signup</td>
                            <td>user input</td>
                            <td>bool</td>
                            <td>
                                <a href="MemberSignup.aspx" class="btn btn-sm btn-info">Test on Signup</a>
                                <a href="TryIt_Captcha.aspx" class="btn btn-sm btn-info" style="margin-left:5px;">Test CAPTCHA</a>
                            </td>
                        </tr>
                        <tr>
                            <td>Shreya Sharma</td>
                            <td>WCF Service (SVC)</td>
                            <td>GetRandomFact — returns random fact about a category</td>
                            <td>string category</td>
                            <td>string</td>
                            <td><a href="TryIt_Fact.aspx" class="btn btn-sm btn-info">Test Service</a></td>
                        </tr>

                        <!-- Amir's Components -->
                        <tr>
                            <td>Amir Boshra</td>
                            <td>Global.asax</td>
                            <td>Application_Start, Session_Start, Application_Error — tracks app start time, visitor count, and errors</td>
                            <td>none</td>
                            <td>void</td>
                            <td><a href="GlobalInfo.aspx" class="btn btn-sm btn-info">View Global Info</a></td>
                        </tr>
                        <tr>
                            <td>Amir Boshra</td>
                            <td>Cookie / Session State</td>
                            <td>Remember Me cookie and session tracking — stores logged-in username and login time</td>
                            <td>string username, bool rememberMe</td>
                            <td>void</td>
                            <td><a href="Login.aspx" class="btn btn-sm btn-info">Test on Login</a></td>
                        </tr>
                        <tr>
                            <td>Amir Boshra</td>
                            <td>WCF Service (SVC)</td>
                            <td>GetWeather — returns weather info for a given US zip code</td>
                            <td>string zipCode</td>
                            <td>string</td>
                            <td><a href="TryIt_Weather.aspx" class="btn btn-sm btn-info">Test Weather</a></td>
                        </tr>

                        <!-- Keenan's Components -->
                        <tr>
                            <td>Keenan Tait</td>
                            <td>DLL (Class Library)</td>
                            <td>Validate — validates email, phone, zip code, and password formats</td>
                            <td>string input, string type</td>
                            <td>bool</td>
                            <td><a href="TryIt_Validation.aspx" class="btn btn-sm btn-info">Test Validation</a></td>
                        </tr>
                        <tr>
                            <td>Keenan Tait</td>
                            <td>User Control</td>
                            <td>ValidationInputControl — input validation user control</td>
                            <td>string input, string type</td>
                            <td>bool</td>
                            <td><a href="TryIt_Validation.aspx" class="btn btn-sm btn-info">Test Control</a></td>
                        </tr>
                        <tr>
                            <td>Keenan Tait</td>
                            <td>WCF Service (SVC)</td>
                            <td>GetStockPrice — returns mock stock price for a given symbol</td>
                            <td>string symbol</td>
                            <td>double</td>
                            <td><a href="TryIt_Stock.aspx" class="btn btn-sm btn-info">Test Stock</a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </section>

        <!-- Test Hashing Demo -->
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
