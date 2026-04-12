<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="ClubManagementWeb.MemberPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Page — Club Management System</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f4f4f4; padding: 30px; }
        h1 { color: #2c3e50; }
        .card {
            background: white; border-radius: 8px; padding: 25px;
            margin: 15px 0; box-shadow: 0 2px 6px rgba(0,0,0,0.1);
            max-width: 600px;
        }
        .welcome { color: #27ae60; font-size: 1.2em; font-weight: bold; }
        .info { color: #555; margin: 5px 0; }
        .btn-logout {
            padding: 10px 20px; background: #e74c3c; color: white;
            border: none; border-radius: 4px; font-size: 1em; 
            cursor: pointer; margin-top: 15px;
        }
        .btn-logout:hover { background: #c0392b; }
        .session-box {
            background: #eafaf1; border-left: 4px solid #27ae60;
            padding: 15px; border-radius: 4px; margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>🏛️ Club Management System</h1>

        <div class="card">
            <p class="welcome">✅ Welcome, <asp:Label ID="lblUsername" runat="server" />!</p>
            <p class="info">You are logged in as a club member.</p>

            <div class="session-box">
                <strong>Session Info:</strong><br />
                <asp:Label ID="lblSessionInfo" runat="server" />
            </div>

            <div class="session-box" style="background:#eaf4fb; border-color:#2980b9; margin-top:10px;">
                <strong>Cookie Status:</strong><br />
                <asp:Label ID="lblCookieInfo" runat="server" />
            </div>

            <asp:Button ID="btnLogout" runat="server" Text="Logout" 
                CssClass="btn-logout" OnClick="btnLogout_Click" />
        </div>

        <p><a href="~/Default.aspx">← Back to Home</a></p>
    </form>
</body>
</html>