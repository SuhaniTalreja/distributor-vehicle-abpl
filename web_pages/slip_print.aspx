<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="slip_print.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.slip_print" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align: center; color:black;">Slip Printing</h1>
    <asp:DropDownList ID="trn_input" runat="server" style="width: 50%; padding: 10px; margin: 10px auto; display: block; box-sizing: border-box;" required="required" AutoPostBack="True" OnSelectedIndexChanged="trn_input_SelectedIndexChanged">
        <asp:ListItem>Select Transaction ID</asp:ListItem>
    </asp:DropDownList>
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" OnRowCommand="gv_RowCommand" style="width: 100%; border: 1px solid #ddd; margin-top: 20px; text-align: center;">
        <Columns>
            <asp:BoundField DataField="trn_id" HeaderText="Transaction ID" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="dist_code" HeaderText="Distributor Code" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="vehicle_num" HeaderText="Vehicle Number" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="trn_date" HeaderText="Transaction Date" ItemStyle-HorizontalAlign="Center" />
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkViewDetails" runat="server" CommandName="ViewDetails" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" style="color: #2196F3; text-decoration: underline;">Print</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
