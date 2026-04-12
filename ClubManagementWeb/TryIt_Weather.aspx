<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt_Weather.aspx.cs" Inherits="ClubManagementWeb.TryIt_Weather" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page 3 – Weather Service TryIt</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f4f4f4; padding: 30px; }
        h1 { color: #2c3e50; }
        .card {
            background: white; border-radius: 8px; padding: 25px;
            margin: 15px 0; box-shadow: 0 2px 6px rgba(0,0,0,0.1);
            max-width: 600px;
        }
        input[type="text"] {
            padding: 10px; font-size: 1em; width: 250px;
            border: 1px solid #ccc; border-radius: 4px; margin-right: 10px;
        }
        input[type="submit"] {
            padding: 10px 20px; background: #2980b9; color: white;
            border: none; border-radius: 4px; font-size: 1em; cursor: pointer;
        }
        input[type="submit"]:hover { background: #1a6a9a; }
        .result {
            margin-top: 20px; padding: 15px;
            background: #eaf4fb; border-left: 4px solid #2980b9;
            border-radius: 4px; font-size: 1em; color: #2c3e50;
        }
        .error { border-left-color: #e74c3c; background: #fdf0ee; color: #c0392b; }
        .info { color: #777; font-size: 0.9em; margin-top: 8px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>⛅ Weather Service — TryIt Page (Page 3)</h1>
        <p>This page tests <strong>WeatherService.svc</strong> — Amir Boshra's WCF/WSDL remote service.</p>
        <p class="info">Service operation: <code>GetWeather(string zipCode) → string</code></p>

        <div class="card">
            <label><strong>Enter a US Zip Code:</strong></label><br /><br />
            <asp:TextBox ID="txtZipCode" runat="server" 
                placeholder="e.g. 85281" MaxLength="5" Width="200px" />
            <asp:Button ID="btnGetWeather" runat="server" 
                Text="Get Weather" OnClick="btnGetWeather_Click" />

            <asp:Panel ID="pnlResult" runat="server" Visible="false">
                <div class="result">
                    <strong>Result:</strong><br />
                    <asp:Label ID="lblResult" runat="server" />
                </div>
            </asp:Panel>

            <asp:Panel ID="pnlError" runat="server" Visible="false">
                <div class="result error">
                    <strong>Error:</strong><br />
                    <asp:Label ID="lblError" runat="server" />
                </div>
            </asp:Panel>
        </div>

        <p class="info">
            Sample zip codes to test: 85281 (Arizona), 90210 (California), 
            10001 (New York), 60601 (Illinois), 77001 (Texas), 
            33101 (Florida), 98101 (Washington), 30301 (Georgia)
        </p>
    </form>
</body>
</html>