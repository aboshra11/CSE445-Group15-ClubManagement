<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ValidationInputControl.ascx.cs" Inherits="ClubManagementWeb.ValidationInputControl" %>

<div style="background:#f7f7f7; padding:15px; border:1px solid #ccc; width:420px;">
    <h4>Validation Control</h4>

    <div style="margin-bottom:10px;">
        <asp:Label ID="lblInput" runat="server" Text="Enter Value:" AssociatedControlID="txtInput" />
        <br />
        <asp:TextBox ID="txtInput" runat="server" Width="300px" />
    </div>

    <div style="margin-bottom:10px;">
        <asp:Label ID="lblType" runat="server" Text="Validation Type:" AssociatedControlID="ddlType" />
        <br />
        <asp:DropDownList ID="ddlType" runat="server">
            <asp:ListItem Text="Email" Value="email" />
            <asp:ListItem Text="Phone" Value="phone" />
            <asp:ListItem Text="ZIP" Value="zip" />
            <asp:ListItem Text="Password" Value="password" />
        </asp:DropDownList>
    </div>

    <asp:Button ID="btnValidate" runat="server" Text="Validate" OnClick="btnValidate_Click" CssClass="btn btn-primary mt-3" />
    <br /><br />
    <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
</div>