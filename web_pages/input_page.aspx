<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="input_page.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.input_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Input the following details</h2>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="group">
                    <asp:DropDownList ID="ddlDistributorCode" runat="server" CssClass="form-control" required="required" AutoPostBack="True" OnSelectedIndexChanged="ddlDistributorCode_SelectedIndexChanged">
                        <asp:ListItem>Select Distributor</asp:ListItem>
                    </asp:DropDownList>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
                <div class="group">
                    <asp:TextBox ID="txtDistributorName" runat="server" CssClass="form-control" required="required" ReadOnly="True" placeholder="Distributor Name"></asp:TextBox>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
                <div class="group">
                    <asp:TextBox ID="txtMobileNum" runat="server" CssClass="form-control" required="required" ReadOnly="True" placeholder="Mobile No."></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revMobileNum" runat="server"
                        ControlToValidate="txtMobileNum"
                        ValidationExpression="^(\+91[\-\s]?)?[6-9]\d{9}$"
                        ErrorMessage="Please enter a valid mobile number (e.g., 9876543210 or +91 9876543210)"
                        Display="Dynamic" class="error-msg" />
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
                <div class="group">
                    <asp:TextBox ID="txtDistanceCovered" runat="server" CssClass="form-control" TextMode="Number" required="required" ReadOnly="True" placeholder="Distance Covered (in km)"></asp:TextBox>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
                <div class="group">
                    <asp:TextBox ID="txtDieselUsed" runat="server" CssClass="form-control" required="required" TextMode="Number"></asp:TextBox>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                    <label for="txtDieselUsed">Diesel Used (in liters)</label>
                </div>
                <div class="group">
                    <asp:DropDownList ID="ddlVehicleNo" runat="server" CssClass="form-control" required="required" AutoPostBack="True" OnSelectedIndexChanged="ddlVehicleNo_SelectedIndexChanged">
                        <asp:ListItem>Select Vehicle</asp:ListItem>
                    </asp:DropDownList>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
                <div class="group">
                    <asp:TextBox ID="txtVehicleAvg" runat="server" CssClass="form-control" required="required" ReadOnly="True" placeholder="Vehicle Mileage"></asp:TextBox>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                </div>
        </ContentTemplate>
        </asp:UpdatePanel>
                <div class="form-group-buttons">
                    <asp:Button ID="btnSubmit" runat="server" class="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnClear" runat="server" class="btnClear" Text="Clear All" OnClick="btnClear_Click" />
                    
                </div>
           
    </div>
</asp:Content>
