<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Bootstrap file and folders/Content/landing-page.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="intro-header">
        <div class="container">

            <div class="row">
                <div class="col-lg-12">
                    <marquee><h2><%=Announcements.ToString() %></h2></marquee>
                    <div class="intro-message">
                        <h1>Hello </h1>
                        <h3>Welcome to Client Management System</h3>
                        <hr class="intro-divider" />
                        
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

