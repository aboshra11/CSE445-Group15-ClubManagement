<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClubManagementWeb.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login — Club Management System</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f4f4f4; padding: 50px; }
        h1 { color: #2c3e50; }
        .card {
            background: white; border-radius: 8px; padding: 30px;
            max-width: 400px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);
        }
        .field { margin-bottom: 15px; }
        .field label { display: block; font-weight: bold; margin-bottom: 5px; color: #555; }
        .field input[type="text"],
        .field input[type="password"] {
            width: 100%; padding: 10px; font-size: 1em;
            border: 1px solid #ccc; border-radius: 4px; box-sizing: border-box;
        }
        .btn {
            width: 100%; padding: 12px; background: #2980b9; color: white;
            border: none; border-radius: 4px; font-size: 1em; cursor: pointer;
        }
        .btn:hover { background: #1a6a9a; }
        .error {
            color: #c0392b; background: #fdf0ee;
            border-left: 4px solid #e74c3c;
            padding: 10px; margin-bottom: 15px; border-radius: 4px;
        }
        .remember { margin-bottom: 15px; }
        .links { margin-top: 15px; font-size: 0.9em; }
        .links a { color: #2980b9; text-decoration: none; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>🏛️ Club Management System</h1>
        <div class="card">
            <h2>Member Login</h2>

            <asp:Panel ID="pnlError" runat="server" Visible="false">
                <div class="error">
                    <asp:Label ID="lblError" runat="server" />
                </div>
            </asp:Panel>

            <div class="field">
                <label>Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" />
            </div>

            <div class="field">
                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </div>

            <div class="remember">
                <asp:CheckBox ID="chkRememberMe" runat="server" Text=" Remember Me" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                CssClass="btn" OnClick="btnLogin_Click" />

            <div class="links">
                <p>Don't have an account? <a href="../Page4/Signup.aspx">Sign up here</a></p>
                <p>Staff login? <a href="../Page6/StaffPage.aspx">Staff Page</a></p>
            </div>
        </div>
    </form>
</body>
</html>