<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Orderwise.Calculator.Web.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jaco's Calculator</title>
    <link rel="stylesheet" href="Style/StyleSheet.css" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">       
        <div class="container" style="border:1px solid #e9e5e5"> 
                <div class="row">
                    <div class="col-xs-12">
                        <h4><asp:Label ID="lblTitle" Text="JACO KLEYNHANS ORDERWISE ASSESSMENT" runat="server" CssClass="label label-primary" /></h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-2">
                        <img src="Images/logo.png" style="float:left; margin:0; padding:0"  />
                    </div>
                    <div class="col-xs-10">                        
                        <h1 style="margin-top:3px !important"><asp:Label ID="lblSubTitle" Text="ONLINE CALCULATOR" runat="server" Style="float:right; " CssClass="label label-default" /></h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <hr />
                        <asp:TextBox ID="tbResult" runat="server" CssClass="form-control" ReadOnly="true" Style="margin-top: 10px; font-size:25px; text-align:right; padding-right:10px" Height="41px" />
                    </div>
                </div>
                <div class="row row-centered">
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b1" Text="1" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b2" Text="2" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b3" Text="3" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnPlus" Text="+" runat="server"  CssClass="btn btn-primary" OnClick="Command_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b4" Text="4" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b5" Text="5" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b6" Text="6" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnSubtract" Text="-" runat="server" CssClass="btn btn-primary" OnClick="Command_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b7" Text="7" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b8" Text="8" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b9" Text="9" runat="server" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnMultiply" Text="*" runat="server" CssClass="btn btn-primary" OnClick="Command_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnTrimEnd" Text="&larr;" runat="server" CssClass="btn btn-primary" OnClick="TrimLastCharacter_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="b0" runat="server" Text="0" CssClass="btn btn-default" OnClick="Btn_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnDecimal" Text="," runat="server" CssClass="btn btn-info" OnClick="SpecialCharacters_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnDivide" Text="/" runat="server" CssClass="btn btn-primary" OnClick="Command_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnAddToMemory" Text="M+" runat="server" CssClass="btn btn-primary" OnClick="AddObjectToMemory_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnCancel" runat="server" Text="C" CssClass="btn btn-primary" OnClick="Cancel_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnRoot" Text="√" runat="server" CssClass="btn btn-primary" OnClick="SquareRoot_Click" />
                    </div>
                    <div class="col-xs-3 col-centered">
                        <asp:Button ID="btnEquals" runat="server" Text="=" CssClass="btn btn-primary" OnClick="Result_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <hr />
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                    <div class="col-xs-3 col-centered">

                    </div>
                </div> 

            </div>
    </form>
</body>
</html>
