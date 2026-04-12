<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GlobalInfo.aspx.cs" Inherits="ClubManagementWeb.GlobalInfo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page 1 – Global Application Info</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f4f4f4; padding: 30px; }
        h1 { color: #2c3e50; }
        .card {
            background: white; border-radius: 8px; padding: 20px;
            margin: 15px 0; box-shadow: 0 2px 6px rgba(0,0,0,0.1);
        }
        .label { font-weight: bold; color: #555; }
        .value { color: #2c3e50; font-size: 1.1em; }
        .error-box { border-left: 4px solid #e74c3c; padding-left: 10px; }
        .ok-box   { border-left: 4px solid #2ecc71; padding-left: 10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>📊 Global Application Monitor — Page 1</h1>
        <p>This page displays live data collected by <strong>Global.asax</strong> event handlers.</p>

        <div class="card">
            <span class="label">🕐 Application Start Time:</span><br />
            <span class="value"><asp:Label ID="lblStartTime" runat="server" /></span>
        </div>

        <div class="card">
            <span class="label">👥 Total Visitor Sessions:</span><br />
            <span class="value"><asp:Label ID="lblVisitorCount" runat="server" /></span>
        </div>

        <div class="card">
            <span class="label">🕐 Your Session Started:</span><br />
            <span class="value"><asp:Label ID="lblSessionStart" runat="server" /></span>
        </div>

        <div class="card">
            <span class="label">⚠️ Last Application Error:</span><br />
            <asp:Panel ID="pnlError" runat="server">
                <span class="value"><asp:Label ID="lblLastError" runat="server" /></span>
            </asp:Panel>
        </div>
    </form>
</body>
</html>