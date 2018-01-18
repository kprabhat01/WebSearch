<%@ Page Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true"
    CodeFile="Feedback.aspx.cs" Inherits="WebPart_Feedback" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script>
        function Validate(Message, value) {
            AlertMessage(Message, value);
        }
    </script>

    <div class="**">
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
            <asp:TextBox ID="ConPerson" runat="server" CssClass="form-control" MaxLength="50"
                placeholder="Contact Name"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter contact name."
            ForeColor="Red" ControlToValidate="ConPerson" SetFocusOnError="true"></asp:RequiredFieldValidator>
    </div>
    <div class="**">
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
            <asp:TextBox ID="email" runat="server" CssClass="form-control" placeholder="email"
                MaxLength="50"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email"
            ForeColor="Red" ErrorMessage="Please enter email address."></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ControlToValidate="email" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
    </div>
    <div class="**">
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-phone"></i></span>
            <asp:TextBox ID="phnumber" runat="server" CssClass="form-control phone" placeholder="Mobile#"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phnumber"
            ForeColor="Red" ErrorMessage="Please enter phone number."></asp:RequiredFieldValidator>
    </div>
    <div class="**">
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-comment"></i></span>
            <asp:TextBox ID="TxtComment" runat="server" CssClass="form-control" TextMode="MultiLine"
                placeholder="Please enter your comment.."></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtComment"
            ForeColor="Red" ErrorMessage="Please enter valid comment."></asp:RequiredFieldValidator>
    </div>
    <div class="**">
        <center>
            <asp:LinkButton ID="SubInformation" runat="server" CssClass="btn btn-primary" OnClick="Sub_Click"><span class="glyphicon glyphicon-ok"></span> Send</asp:LinkButton>
        </center>
    </div>
    <div class="**">
        <br />
        <center>
            <div id="Message" style="display: none" class="alert alert-info">
                <strong><span class="glyphicon glyphicon-info-sign"></span>Info!</strong> <span class="Message">This alert box could indicate a neutral informative change or action.</span>
            </div>
        </center>
    </div>
</asp:Content>
