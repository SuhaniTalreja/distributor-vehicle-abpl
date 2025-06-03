<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="create_vehicle.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.create_vehicle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <h2>Input Details To Create New Vehicle</h2>
    <div class="group">
        <asp:TextBox ID="txtVehicleNo" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revVehicleNo" runat="server"
            ControlToValidate="txtVehicleNo"
            ValidationExpression="^[A-Z]{2}-[0-9]{1,2}-[A-Z]{1,2}-[0-9]{1,4}$"
            ErrorMessage="Please enter a valid vehicle number format (e.g., AB-12-CD-1234)"
            Display="Dynamic" class="error-msg" />

        <span class="highlight"></span>
        <span class="bar"></span>
        <label for="txtVehicleNo">Vehicle No.</label>
    </div>

    <div class="group">
        <asp:TextBox ID="txtAvg" runat="server" CssClass="form-control" required="required" onkeypress="focusNextInput(event, this)"></asp:TextBox>
        <span class="highlight"></span>
        <span class="bar"></span>
        <label for="txtAvg">Mileage of Vehicle</label>
    </div>

    <div class="form-group-buttons">
        <asp:Button ID="btnSubmit" class="btnSubmit" runat="server" Text="Submit"  OnClick="btnSubmit_Click"/>
        <asp:Button ID="btnClear" class="btnClear" runat="server" Text="Clear All" OnClick="btnClear_Click" />
    </div>
</div>

</asp:Content>
