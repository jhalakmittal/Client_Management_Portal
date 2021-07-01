using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

public partial class Home : System.Web.UI.Page
{
    public StringBuilder Announcements = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToBoolean(Session["IsAuth"]))
            {
                if (Session["role"].ToString().ToUpper() == "SALES")
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SalesConnectionString"].ConnectionString);
                        SqlCommand cmd = new SqlCommand("select Message from Announcement_table where datetime =CONVERT(CHAR(23),CONVERT(DATETIME,GetDate(),101),121)", conn);

                        try
                        {
                            Announcements = new StringBuilder();
                            conn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            int i = 1;
                            while (dr.Read())
                            {
                                Announcements.Append(i++);
                                Announcements.Append(")");
                                Announcements.Append(dr["Message"].ToString());
                                Announcements.Append("&nbsp;&nbsp;");
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            conn.Close();
                        }


                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
        }
        catch (Exception EX)
        {

            Response.Redirect("Login.aspx");
        }

    }
}