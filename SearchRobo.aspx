<%@ Page Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true"
    CodeFile="SearchRobo.aspx.cs" Inherits="SearchRobo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script>
        $(function () {
            GetCategories(0, '');
            GetCities(0);
        });

        function getUrl() {
            window.onpopstate = function (e) {
                if (e.state) {
                    document.getElementById("content").innerHTML = e.state.html;
                    document.title = e.state.pageTitle;
                    alert(document.title);
                }
            }
        }
    </script>

    <div class="container-fluid header">
        <div class="row">
            <div class="col-sm-2 PadCenter">
                <h3>
                    <span class="headerText">WEBREMEDI</span>
                </h3>
            </div>
            <div class="col-sm-10">
                <div class="row">
                    <div class="col-sm-12 PadRight topAnchor">
                        <a onclick="ShowModalContent('/WebPart/AboutUs.aspx', 'About Us', '700', '500');"><span class="glyphicon glyphicon-lock"></span>&nbsp;About us</a>&nbsp;&nbsp;
                        <a><span class="glyphicon glyphicon-envelope"></span>&nbsp;Contact</a>&nbsp;&nbsp;
                        <a onclick="ShowModalContent('/WebPart/Feedback.aspx', 'Feedback', '600', '450');"><span class="glyphicon glyphicon-question-sign"></span>&nbsp;Feedback</a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-1 PadRight">
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle input-sm" style="width: 110px;" type="button" data-toggle="dropdown">
                                <span class="catname">Categories </span>
                            </button>
                            <ul class="dropdown-menu CatInfo">
                                <li class="dropdown-header">Categories</li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="srcText" placeholder="Begin your search...." runat="server" CssClass="form-control input-sm"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-9 PadRight">
                        <div class="dropdown">
                            <button class="btn btn-link dropdown-toggle input-sm" style="color: #fff; text-decoration: none;"
                                type="button" data-toggle="dropdown">
                                <span class="citivalue">All</span> &nbsp;<span class="glyphicon glyphicon-map-marker"></span> <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu dropdown-menu-right Citilites">
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="wrapper">
        <div class="row">
            <div class="col-sm-12">
                <div class="col-sm-3 CatData" style="margin: 0px; padding: 0px;">
                    <img src="https://tpc.googlesyndication.com/simgad/12315454941091187839" border="0" width="300" alt="" class="img_ad">
                </div>
                <div class="col-sm-6">
                </div>
                <div class="col-sm-3">
                    <img src="https://tpc.googlesyndication.com/simgad/536230514988555807" border="0" width="320" alt="" class="img_ad">
                    <br />
                    <br />
                    <img src="https://tpc.googlesyndication.com/simgad/6823671371663581376" border="0" width="320" alt="" class="img_ad">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
