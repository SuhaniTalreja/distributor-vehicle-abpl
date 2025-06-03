<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="create_dist.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.create_dist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="container">
        <h2>Input Details to create a new Distributor</h2>
        <div class="group">
            <asp:TextBox ID="txtDistriName" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
            <span class="highlight"></span>
            <span class="bar"></span>
            <label for="txtDistriName">Name of Distributor</label>
        </div>
        <div class="group">
            <asp:TextBox ID="txtDCode" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
            <span class="highlight"></span>
            <span class="bar"></span>
            <label for="txtDCode">Distributor Code</label>
        </div>
       <div class="group">
           <asp:TextBox ID="txtDistance" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
           <span class="highlight"></span>
           <span class="bar"></span>
           <label for="txtDCode">Distance (in km)</label>
       </div>
        <div class="group">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
            <span class="highlight"></span>
            <span class="bar"></span>
            <label for="txtEmail">Email ID</label>
        </div>
        <div class="group">
            <asp:TextBox ID="txtMobileNum" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
             <asp:RegularExpressionValidator ID="revMobileNum" runat="server"
                ControlToValidate="txtMobileNum"
                ValidationExpression="^(\+91[\-\s]?)?[6-9]\d{9}$"
                ErrorMessage="Please enter a valid mobile number (e.g., 9876543210 or +91 9876543210)"
                Display="Dynamic" class="error-msg" />
            <span class="highlight"></span>
            <span class="bar"></span>
            <label for="txtMobileNum">Mobile No.</label>
        </div>
        <div class="form-group-buttons">
            <asp:Button ID="btnSubmit" class="btnSubmit" runat="server" Text="Submit"  OnClick="btnSubmit_Click"/>
            <asp:Button ID="btnClear" class="btnClear" runat="server" Text="Clear All" OnClick="btnClear_Click" />
        </div>
    </div>
</asp:Content>
