using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.Script.Serialization;
using System.Net;
using System.Data;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Text.RegularExpressions;

public partial class My_Attendance : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    string path, path1;
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address;
    string value, value1;
    string SlickTicket = ConfigurationManager.ConnectionStrings["VisionTime_Conn"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/admin-login.aspx");

        }
        if (!IsPostBack)
        {
            lblusername.Text = Session["username"].ToString();

            grdLead.DataSource = obj_main.tblAttendance_userwise_Report(Session["emp_code"].ToString());
            grdLead.DataBind();

        }
    }
    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("admin-login.aspx");
    }
}