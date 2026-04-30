<%@ Page Title="Test CAPTCHA" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="TryIt_Captcha.aspx.cs" Inherits="ClubManagementWeb.TryIt_Captcha" %>
<%@ Register Src="~/CaptchaControl.ascx" TagName="CaptchaControl" TagPrefix="uc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>🔐 Test Shreya's CAPTCHA User Control</h2>
    <p>This page tests the custom CAPTCHA control developed by <strong>Shreya Sharma</strong> for Assignment 6.</p>
    <p>The CAPTCHA generates random 4-digit numbers. Enter the code correctly to pass verification.</p>
    
    <div style="background:#f5f5f5; padding:20px; border-radius:5px; max-width:400px;">
        <uc:CaptchaControl ID="captcha" runat="server" />
        <br />
        <asp:Button ID="btnTest" runat="server" Text="Verify CAPTCHA" OnClick="btnTest_Click" CssClass="btn btn-primary" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
    </div>
    
    <br />
    <a href="Default.aspx">← Back to Home</a>
</asp:Content>