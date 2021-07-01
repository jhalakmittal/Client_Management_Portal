﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string myrole = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Userid"]==null)
        {
            Response.Redirect("Login.aspx");

        }
        try
        {
            if(Convert.ToBoolean(Session["IsAuth"]))
            {
                switch(Session["Role"].ToString())
                {
                    case "Sales":
                        myrole = "<ul class='nav navbar-nav' id='mUser'><li><a href='Home.aspx'>Home</a></li><li><a href='OppType.aspx'>Client Type</a></li><li><a href='CreateClient.aspx'>Oppourtunities</a></li><li><a href='Proposals.aspx'>Proposals</a></li><li><a href='Projects.aspx'>Projects</a></li></ul>";
                        break;
                       case "Manager":
                        myrole = "<ul class='nav navbar-nav' id='mManager'><li><a href='Home.aspx'>Home</a></li><li><a href='CreateSales.aspx'>Sales</a></li><li><a href='Announcements.aspx'>Announcements</a></li></ul>";
                        break;
                    case "Admin" :
                        myrole = "<ul class='nav navbar-nav' id='mAdmin'><li><a href='Home.aspx'>Home</a></li><li><a href='CreateManager.aspx'>Manager</a></li></ul>";
                        break;
                    default:
                        break;
                }
            }
        }
        catch(Exception ex)
        {
            Response.Redirect("Login.aspx");
        }

    }
}
