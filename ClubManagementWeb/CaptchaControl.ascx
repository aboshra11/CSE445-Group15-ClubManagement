<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CaptchaControl.ascx.cs" 
            Inherits="ClubManagementWeb.CaptchaControl" %>
<div style="background:#f0f0f0; padding:15px; border:1px solid #ccc; width:300px;">
    <div style="text-align:center; margin-bottom:10px;">
        <asp:Label ID="lblCaptcha" runat="server" Font-Bold="true" Font-Size="24px" 
                   BackColor="Yellow" ForeColor="Blue" Font-Names="Courier New" />
    </div>
    <div>
        <asp:TextBox ID="txtCaptcha" runat="server" placeholder="Enter the code above" Width="200px" />
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" CausesValidation="false" />
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false" />
    </div>
</div>
