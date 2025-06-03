<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="transaction_details.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.transaction_details" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Transaction Details</h2>

    <asp:Label ID="lblTransactionId" runat="server" Text=""></asp:Label>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="600px"></rsweb:ReportViewer>
</asp:Content>
