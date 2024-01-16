using System;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

public partial class _Default : System.Web.UI.Page
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
        else
        {
            if (!IsPostBack)
            {
                lbldatetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt");
                lblusername.Text = Session["username"].ToString();

                string a = DateTime.Now.ToString("yyyy/MM/dd");
                string emp_code = Session["emp_code"].ToString();
                string emp_id = Session["emp_id"].ToString();
                obj_main.date = a;
                ViewState["date"] = a;
            }
        }
    }
    public void Afterpuchout()
    {
        string a = DateTime.Now.ToString("yyyy/MM/dd");
        string emp_code = Session["emp_code"].ToString();
        string emp_id = Session["emp_id"].ToString();
        obj_main.date = a;
        ViewState["date"] = a;
        objReader1 = obj_main.check_out();
        if (objReader1.Read())
        {
            PnlPunchIn.Visible = false;
            PnlPunchout.Visible = false;
            Pnlmsg.Visible = true;
            lbl_checkout.Text = objReader1["OutTime"].ToString();
            lbl_checkin.Text = objReader1["puchin_time"].ToString();
        }
    }
    protected void BtnAttendance_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            latitude.Text = "";
            longitude.Text = "";
            Label1.Text = "";
            if (Session["location"].ToString() == "Jammu")
            {
                latitude.Text = "Jammu";
                longitude.Text = "Jammu";
                Label1.Text = "Jammu";
                insertdata();
                PnlPunchIn.Visible = false;

                PnlPunchout.Visible = true;
                return;
            }

            objReader2 = obj_main.tblAttendance_location_Track_duplicacy(Session["emp_code"].ToString(), ViewState["date"].ToString());
            if (objReader2.Read())
            {
                PnlPunchIn.Visible = false;

                PnlPunchout.Visible = true;
            }
            else
            {
                string ip_address = HttpContext.Current.Request.UserHostAddress;
                using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
                {
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {


                        sqlCmd.CommandText = @"insert into tblAttendance_location_Track(sno,emp_id,emp_code,Latitude,Longitude,puchin_location,ip_address,puchin_time,status,Attndate,DBsinkdate,DateCol)
                VALUES ((select isnull(max(sno),0)+1 from tblAttendance_location_Track),@emp_id,@emp_code,@Latitude,@Longitude,@puchin_location,@ip_address,@puchin_time,@status,GETDATE(),GETDATE(),@DateCol);";
                        sqlCmd.Parameters.AddWithValue("@sno", '0');
                        sqlCmd.Parameters.AddWithValue("@Latitude", latitude.Text);
                        sqlCmd.Parameters.AddWithValue("@Longitude", longitude.Text);
                        sqlCmd.Parameters.AddWithValue("@puchin_location", "");
                        sqlCmd.Parameters.AddWithValue("@puchin_time", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));
                        sqlCmd.Parameters.AddWithValue("@DateCol", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));
                        sqlCmd.Parameters.AddWithValue("@emp_code", Session["emp_code"].ToString());
                        sqlCmd.Parameters.AddWithValue("@emp_id", Session["emp_id"].ToString());
                        sqlCmd.Parameters.AddWithValue("@ip_address", ip_address);
                        sqlCmd.Parameters.AddWithValue("@status", "P");
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Thank you for punching in, your attendance for today in recorded, Have a nice & productive day ahead!!');", true);
                    }
                }
                //insertdata();
                PnlPunchIn.Visible = false;
                PnlPunchout.Visible = true;
            }
        }
        catch (Exception ex)
        {
            if (ex.Message == "Object reference not set to an instance of an object")
            {
                BtnAttendance_Click(BtnAttendance, null);
            }
            else
            {

                ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:requestPosition(); ", true);
            }
        }
    }
    public void insertdata()
    {
        try
        {

            string ip_address = HttpContext.Current.Request.UserHostAddress;
            using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
            {
                using (SqlCommand sqlCmd = new SqlCommand())
                {

                    sqlCmd.CommandText = @"insert into tblAttendance_location_Track(sno,emp_id,emp_code,Latitude,Longitude,puchin_location,ip_address,status,puchin_time,Attndate,DBsinkdate,DateCol)
        VALUES ((select isnull(max(sno),0)+1 from tblAttendance_location_Track),@emp_id,@emp_code,@Latitude,@Longitude,@puchin_location,@ip_address,@status,@puchin_time,GETDATE(),GETDATE(),@DateCol);";
                    sqlCmd.Parameters.AddWithValue("@sno", '0');
                    sqlCmd.Parameters.AddWithValue("@Latitude", latitude.Text);
                    sqlCmd.Parameters.AddWithValue("@Longitude", longitude.Text);
                    sqlCmd.Parameters.AddWithValue("@puchin_location", Label1.Text);
                    sqlCmd.Parameters.AddWithValue("@puchin_time", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));
                    sqlCmd.Parameters.AddWithValue("@DateCol", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));
                    sqlCmd.Parameters.AddWithValue("@emp_code", Session["emp_code"].ToString());
                    sqlCmd.Parameters.AddWithValue("@emp_id", Session["emp_id"].ToString());
                    sqlCmd.Parameters.AddWithValue("@ip_address", ip_address);
                    sqlCmd.Parameters.AddWithValue("@status", "P");
                    sqlCmd.Connection = sqlConn;
                    sqlConn.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Thank you for punching in, your attendance for today in recorded, Have a nice & productive day ahead!!');", true);
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Check internet connection and on your GPS');", true);
        }
    }
    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("admin-login.aspx");
    }
    public void insert_out()
    {
        try
        {
            string ip_address = HttpContext.Current.Request.UserHostAddress;
            using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
            {
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    if (ViewState["Flag"].ToString() == "I")
                    {
                        obj_main.emp_code = Session["emp_code"].ToString();
                        obj_main.date = ViewState["date"].ToString();
                        objReader1 = obj_main.update_puchout_select();
                        if (objReader1.Read())
                        {
                            string sno = objReader1["sno"].ToString();
                            string emp_code = objReader1["emp_code"].ToString();
                            sqlCmd.CommandText = @"update tblAttendance_location_Track set 
                                    puchout_location=@puchout_location,
                                    puchout_time=@puchout_time
                                    where sno=@sno";
                            sqlCmd.Parameters.AddWithValue("@sno", sno);
                            sqlCmd.Parameters.AddWithValue("@puchout_location", Label1.Text);
                            sqlCmd.Parameters.AddWithValue("@puchout_time", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));

                            sqlCmd.Connection = sqlConn;
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlConn.Close();
                        }

                    }
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Thank you for punching out, your attendance for today in recorded, Have a nice & productive day ahead!!');", true);
                    Afterpuchout();
                    PnlPunchIn.Visible = false;
                    PnlPunchout.Visible = false;
                    Pnlmsg.Visible = true;
                    this.Page_Load(null, null);

                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Check internet connection and on your GPS');", true);
        }
    }
    protected void Btn_out_Click(object sender, EventArgs e)
    {
        try
        {
            latitude.Text = "";
            longitude.Text = "";
            Label1.Text = "";
            if (Session["location"].ToString() == "Jammu")
            {
                latitude.Text = "Jammu";
                longitude.Text = "Jammu";
                Label1.Text = "Jammu";
                insert_out();
                Afterpuchout();
                PnlPunchIn.Visible = false;
                PnlPunchout.Visible = false;
                Pnlmsg.Visible = true;
                this.Page_Load(null, null);
                return;
            }

            string ip_address = HttpContext.Current.Request.UserHostAddress;
            using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
            {
                using (SqlCommand sqlCmd = new SqlCommand())
                {

                    obj_main.emp_code = Session["emp_code"].ToString();
                    obj_main.date = ViewState["date"].ToString();
                    objReader1 = obj_main.update_puchout_select();
                    if (objReader1.Read())
                    {
                        string sno = objReader1["sno"].ToString();
                        string emp_code = objReader1["emp_code"].ToString();
                        sqlCmd.CommandText = @"update tblAttendance_location_Track set 
                                    puchout_location=@puchout_location,
                                    puchout_time=@puchout_time
                                    where sno=@sno";
                        sqlCmd.Parameters.AddWithValue("@sno", sno);
                        sqlCmd.Parameters.AddWithValue("@puchout_location", Label1.Text);
                        sqlCmd.Parameters.AddWithValue("@puchout_time", DateTime.Now.ToString("yyyy\\/MM\\/dd hh:mm:ss tt"));

                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();
                    }
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Thank you for punching out, your attendance for today in recorded, Have a nice & productive day ahead!!');", true);
                    Afterpuchout();
                    PnlPunchIn.Visible = false;
                    PnlPunchout.Visible = false;
                    Pnlmsg.Visible = true;
                    this.Page_Load(null, null);
                }
            }
        }
        catch (Exception ex)
        {
            if (ex.Message == "Object reference not set to an instance of an object")
            {
                Btn_out_Click(Btn_out, null);
            }
            else
            {
            }
        }
    }
    protected void btnApplyLeave_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://www.visionindiaapp.in/myvisionindia/MyvisionLogin.aspx?EmpCode=" + Session["emp_code"].ToString() + "&EmpPass=" + Session["password"].ToString());
    }
    private void ChkAttendance()
    {
        ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:requestPosition(); ", true);
        string ip_address = HttpContext.Current.Request.UserHostAddress;
        lbldatetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt");
        lbldate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        string a = DateTime.Now.ToString("yyyy/MM/dd");
        string emp_code = Session["emp_code"].ToString();
        string emp_id = Session["emp_id"].ToString();
        obj_main.emp_code = emp_code;
        obj_main.date = a;
        ViewState["date"] = a;
        objReader = obj_main.check_in();
        if (objReader.Read())
        {

            PnlPunchIn.Visible = false;
            string checkin = objReader["Time"].ToString();
            lbl_checkin.Text = Convert.ToDateTime(checkin).ToString("hh:mm:ss");
            PnlPunchout.Visible = true;
            ViewState["Flag"] = "I";
            objReader1 = obj_main.check_out();
            if (objReader1.Read())
            {
                PnlPunchIn.Visible = false;
                PnlPunchout.Visible = false;
                Pnlmsg.Visible = true;
                string checkout = objReader1["OutTime"].ToString();
                lbl_checkout.Text = Convert.ToDateTime(checkout).ToString("hh:mm:ss");
                // string checkout = Convert.ToDateTime(lbl_checkout.Text).ToString("hh:mm:ss tt");
                TimeSpan ts1 = TimeSpan.Parse(checkin); //"1:35"
                TimeSpan ts2 = TimeSpan.Parse(checkout); //"3:30"
                Label3.Text = (ts2 - ts1).ToString();
            }
        }
    }
  
    private DateTime GetSaturdayByWeek(DateTime dateofMonth, int weekNumber)
    {
        DateTime firstDateofMonth = new DateTime(dateofMonth.Year, dateofMonth.Month, 1);
        DateTime resultDate = CultureInfo.InvariantCulture.Calendar.AddWeeks(firstDateofMonth, weekNumber - 1);
        int dayWeek = Convert.ToInt32(resultDate.DayOfWeek);
        int day = dayWeek < 6 ? (dayWeek - 6) * -1 : 0;
        return resultDate.AddDays(day);
    }
}
