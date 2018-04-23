'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

<%@ Page Title="About Us" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeBehind="About.aspx.vb" Inherits="ReportService.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<h2>
		About
	</h2>
	<p>
		Put content here.
	</p>
</asp:Content>