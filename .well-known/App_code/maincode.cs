using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Mail;


/// <summary>
/// Summary description for maincode
/// </summary>
public class maincode
{
    string con_str = ConfigurationManager.ConnectionStrings["VisionTime_Conn"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    


    public maincode()
    {
        
    }
    private string _strrandom;
    public string strrandom
    {
        get
        {
            return _strrandom;
        }
        set
        {
            _strrandom = value;
        }
    }

         private string _training_project_name;
    public string training_project_name
    {
        get
        {
            return _training_project_name;
        }
        set
        {
            _training_project_name = value;
        }
    }
    private string _Resistration_Mobi;
    public string Resistration_Mobi
    {
        get
        {
            return _Resistration_Mobi;
        }
        set
        {
            _Resistration_Mobi = value;
        }
    }
    private string _Interested_rate;
    public string Interested_rate
    {
        get
        {
            return _Interested_rate;
        }
        set
        {
            _Interested_rate = value;
        }
    }

    private string _project_brief;
    public string project_brief
    {
        get
        {
            return _project_brief;
        }
        set
        {
            _project_brief = value;
        }
    }

    private string _Trainee_status;
    public string Trainee_status
    {
        get
        {
            return _Trainee_status;
        }
        set
        {
            _Trainee_status = value;
        }
    }

    private string _remarks;
    public string remarks
    {
        get
        {
            return _remarks;
        }
        set
        {
            _remarks = value;
        }
    }

    private DateTime _CreateDate;
    public DateTime CreateDate
    {
        get
        {
            return _CreateDate;
        }
        set
        {
            _CreateDate = value;
        }
    }
    
         private string _puchin_location;
    public string puchin_location
    {
        get
        {
            return _puchin_location;
        }
        set
        {
            _puchin_location = value;
        }
    }

    private string _CreatedBy;
    public string CreatedBy
    {
        get
        {
            return _CreatedBy;
        }
        set
        {
            _CreatedBy = value;
        }
    }


    private string _flag;
    public string flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag = value;
        }
    }








    private string _center_name;
    public string center_name
    {
        get
        {
            return _center_name;
        }
        set
        {
            _center_name = value;
        }
    }

    private string _First_Name;
    public string First_Name
    {
        get
        {
            return _First_Name;
        }
        set
        {
            _First_Name = value;
        }
    }
    private string _Middle_Name;
    public string Middle_Name
    {
        get
        {
            return _Middle_Name;
        }
        set
        {
            _Middle_Name = value;
        }
    }


    private string _Last_Name;
    public string Last_Name
    {
        get
        {
            return _Last_Name;
        }
        set
        {
            _Last_Name = value;
        }
    }

    private string _Mobile_Number;
    public string Mobile_Number
    {
        get
        {
            return _Mobile_Number;
        }
        set
        {
            _Mobile_Number = value;
        }
    }


    private string _EmailID;
    public string EmailID
    {
        get
        {
            return _EmailID;
        }
        set
        {
            _EmailID = value;
        }
    }

    private string _Father_Name;
    public string Father_Name
    {
        get
        {
            return _Father_Name;
        }
        set
        {
            _Father_Name = value;
        }
    }
    private string _Mother_Name;
    public string Mother_Name
    {
        get
        {
            return _Mother_Name;
        }
        set
        {
            _Mother_Name = value;
        }
    }


    private DateTime  _Birth_Date;
    public DateTime Birth_Date
    {
        get
        {
            return _Birth_Date;
        }
        set
        {
            _Birth_Date = value;
        }
    }
    private string _Gender;
    public string Gender
    {
        get
        {
            return _Gender;
        }
        set
        {
            _Gender = value;
        }
    }
    private string _caste;
    public string caste
    {
        get
        {
            return _caste;
        }
        set
        {
            _caste = value;
        }
    }

    private string _Address;
    public string Address
    {
        get
        {
            return _Address;
        }
        set
        {
            _Address = value;
        }
    }

    private string _PIN_Code;
    public string PIN_Code
    {
        get
        {
            return _PIN_Code;
        }
        set
        {
            _PIN_Code = value;
        }
    }

    private string _Residence_Phone;
    public string Residence_Phone
    {
        get
        {
            return _Residence_Phone;
        }
        set
        {
            _Residence_Phone = value;
        }
    }

    private string _Specialization;
    public string Specialization
    {
        get
        {
            return _Specialization;
        }
        set
        {
            _Specialization = value;
        }
    }
    private string _UG_Course_Name;
    public string UG_Course_Name
    {
        get
        {
            return _UG_Course_Name;
        }
        set
        {
            _UG_Course_Name = value;
        }
    }

    private string _UG_University;
    public string UG_University
    {
        get
        {
            return _UG_University;
        }
        set
        {
            _UG_University = value;
        }
    }

    private string _UG_Study_Mode;
    public string UG_Study_Mode
    {
        get
        {
            return _UG_Study_Mode;
        }
        set
        {
            _UG_Study_Mode = value;
        }
    }


    private string _UG_Pass_Year;
    public string UG_Pass_Year
    {
        get
        {
            return _UG_Pass_Year;
        }
        set
        {
            _UG_Pass_Year = value;
        }
    }


    private string _ADHAAR_NO;
    public string ADHAAR_NO
    {
        get
        {
            return _ADHAAR_NO;
        }
        set
        {
            _ADHAAR_NO = value;
        }
    }

    private string _Resume_Attachment;
    public string Resume_Attachment
    {
        get
        {
            return _Resume_Attachment;
        }
        set
        {
            _Resume_Attachment = value;
        }
    }

    private string _interest;
    public string interest
    {
        get
        {
            return _interest;
        }
        set
        {
            _interest = value;
        }
    }

    private string _status;
    public string status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }



    private string _call_log;
    public string call_log
    {
        get
        {
            return _call_log;
        }
        set
        {
            _call_log = value;
        }
    }



    private string _Resistration_Source;
     public string Resistration_Source
    {
        get
        {
            return _Resistration_Source;
        }
        set
        {
            _Resistration_Source = value;
        }
    }


     private string _emp_name;
    public string emp_name
    {
        get
        {
            return _emp_name;
        }
        set
        {
            _emp_name = value;
        }
    }
 private string _sector_name;
         public string sector_name
    {
        get
        {
            return _sector_name;
        }
        set
        {
            _sector_name = value;
        }
    }
 private string _sector;
     public string sector
    {
        get
        {
            return _sector;
        }
        set
        {
            _sector = value;
        }
    }
private string _jobrole_name;
         public string jobrole_name
    {
        get
        {
            return _jobrole_name;
        }
        set
        {
            _jobrole_name = value;
        }
    }
    
        
         private DateTime _to_date;
    public DateTime to_date
    {
        get
        {
            return _to_date;
        }
        set
        {
            _to_date = value;
        }
    }
    

        private string _emp_id;
    public string emp_id
    {
        get
        {
            return _emp_id;
        }
        set
        {
            _emp_id = value;
        }
    }
    private DateTime _from_date;
    public DateTime from_date
    {
        get
        {
            return _from_date;
        }
        set
        {
            _from_date = value;
        }
    }


    private string _JOB_ID;
    public string JOB_ID
    {
        get
        {
            return _JOB_ID;
        }
        set
        {
            _JOB_ID = value;
        }
    }

    private string _JobTitle;
    public string JobTitle
    {
        get
        {
            return _JobTitle;
        }
        set
        {
            _JobTitle = value;
        }
    }

    private string _address;
    public string address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }
    private string _Location;
    public string Location
    {
        get
        {
            return _Location;
        }
        set
        {
            _Location = value;
        }
    }
    private string _Functional_Area_Name;
    public string Functional_Area_Name
    {
        get
        {
            return _Functional_Area_Name;
        }
        set
        {
            _Functional_Area_Name = value;
        }
    }
    private string _search_value;
    public string search_value
    {
        get
        {
            return _search_value;
        }
        set
        {
            _search_value = value;
        }
    }
    private string _Industry;
    public string Industry
    {
        get
        {
            return _Industry;
        }
        set
        {
            _Industry = value;
        }
    }
    private string _Experiance;
    public string Experiance
    {
        get
        {
            return _Experiance;
        }
        set
        {
            _Experiance = value;
        }
    }
    private string _Qualification;
    public string Qualification
    {
        get
        {
            return _Qualification;
        }
        set
        {
            _Qualification = value;
        }
    }
    
        private string _Training_Project_Name;
    public string Training_Project_Name
    {
        get
        {
            return _Training_Project_Name;
        }
        set
        {
            _Training_Project_Name = value;
        }
    }
    private string _Email;
    public string Email
    {
        get
        {
            return _Email;
        }
        set
        {
            _Email = value;
        }
    }

    private string _Mobile;
    public string Mobile
    {
        get
        {
            return _Mobile;
        }
        set
        {
            _Mobile = value;
        }
    }
    private string _Name;
    public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value;
        }
    }

    private string _paymenttype;
         public string paymenttype
         {
             get
             {
                 return _paymenttype;
             }
             set
             {
                 _paymenttype = value;
             }
         }
    private string _Job_Seeker_ID;
    public string Job_Seeker_ID
    {
        get
        {
            return _Job_Seeker_ID;
        }
        set
        {
            _Job_Seeker_ID = value;
        }
    }
    private string _Trainee_ID;
    public string Trainee_ID
    {
        get
        {
            return _Trainee_ID;
        }
        set
        {
            _Trainee_ID = value;
        }
    }

    private string _sno;
    public string sno
    {
        get
        {
            return _sno;
        }
        set
        {
            _sno = value;
        }
    }

    private string _emp_code;
    public string emp_code
    {
        get
        {
            return _emp_code;
        }
        set
        {
            _emp_code = value;
        }
    }
    private string _date;
    public string date
    {
        get
        {
            return _date;
        }
        set
        {
            _date = value;
        }
    }

    private string _Latitude;
    public string Latitude
    {
        get
        {
            return _Latitude;
        }
        set
        {
            _Latitude = value;
        }
    }
    private string _Longitude;
    public string Longitude
    {
        get
        {
            return _Longitude;
        }
        set
        {
            _Longitude = value;
        }
    }
    private string _ip_address;
    public string ip_address
    {
        get
        {
            return _ip_address;
        }
        set
        {
            _ip_address = value;
        }
    }
    private string _Direction;
    public string Direction
    {
        get
        {
            return _Direction;
        }
        set
        {
            _Direction = value;
        }
    }
    public SqlDataReader tbl_pmkkcenter_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tbl_pmkkcenter_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

   
    public SqlDataReader Mst_Course_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Course_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
public DataTable emp_performance_Report1(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "emp_performance_Report1";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            //  objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable emp_performance_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "emp_performance_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            //  objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable Skill_Dev_Candidate_view_profile_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Skill_Dev_Candidate_view_profile_select";

            objCommand.Parameters.AddWithValue("@training_project_name", Training_Project_Name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    

        public string lead_call_log_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "lead_call_log_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Trainee_ID", Trainee_ID);
            objCommand.Parameters.AddWithValue("@call_log", call_log);
            objCommand.Parameters.AddWithValue("@Trainee_status", Trainee_status);
            objCommand.Parameters.AddWithValue("@project_brief", project_brief);
            objCommand.Parameters.AddWithValue("@Interested_rate", Interested_rate);
            objCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    public string tbl_project_candidate_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "tbl_project_candidate_insert";
            objCommand.Parameters.AddWithValue("@Trainee_ID",Trainee_ID);
            objCommand.Parameters.AddWithValue("@First_Name", First_Name);
            objCommand.Parameters.AddWithValue("@Middle_Name", Middle_Name);
            objCommand.Parameters.AddWithValue("@Last_Name", Last_Name);
            objCommand.Parameters.AddWithValue("@EmailID", EmailID);
            objCommand.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
            objCommand.Parameters.AddWithValue("@Qualification", Qualification);
            objCommand.Parameters.AddWithValue("@Specialization", Specialization);
            objCommand.Parameters.AddWithValue("@Resume_Attachment", Resume_Attachment);
            objCommand.Parameters.AddWithValue("@Gender", Gender);
            objCommand.Parameters.AddWithValue("@Birth_Date", Birth_Date);
            objCommand.Parameters.AddWithValue("@UG_Course_Name", UG_Course_Name);
            objCommand.Parameters.AddWithValue("@UG_University", UG_University);
            objCommand.Parameters.AddWithValue("@UG_Study_Mode", UG_Study_Mode);
            objCommand.Parameters.AddWithValue("@UG_Pass_Year", UG_Pass_Year);
            objCommand.Parameters.AddWithValue("@Father_Name", Father_Name);
            objCommand.Parameters.AddWithValue("@Mother_Name", Mother_Name);
            objCommand.Parameters.AddWithValue("@Address", Address);
            objCommand.Parameters.AddWithValue("@PIN_Code", PIN_Code);
            objCommand.Parameters.AddWithValue("@Residence_Phone", Residence_Phone);
            objCommand.Parameters.AddWithValue("@Resistration_Source", Resistration_Source);
            objCommand.Parameters.AddWithValue("@Resistration_Mobi", Resistration_Mobi);
            
            objCommand.Parameters.AddWithValue("@Training_Project_Name", Training_Project_Name);
            objCommand.Parameters.AddWithValue("@ADHAAR_NO", ADHAAR_NO);
            objCommand.Parameters.AddWithValue("@center_name", center_name);
            objCommand.Parameters.AddWithValue("@caste", caste);
            objCommand.Parameters.AddWithValue("@Interested_rate", Interested_rate);
            objCommand.Parameters.AddWithValue("@project_brief", project_brief);
            objCommand.Parameters.AddWithValue("@Trainee_status", Trainee_status);
            objCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            objCommand.Parameters.AddWithValue("@flag", flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    

        public DataTable tbl_project_candidate_profile_mobilizerall(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tbl_project_candidate_profile_mobilizerall";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
public DataTable Skill_Dev_Candidate_view_profile_mobilizerall1(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Skill_Dev_Candidate_view_profile_mobilizerall1";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    
         public SqlDataReader Act_Job_Seeker_duplicacy_check(string Mobile_Number)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Act_Job_Seeker_duplicacy_check";
       // objCommand.Parameters.AddWithValue("@EmailID", EmailID);
        objCommand.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Act_Job_Seeker_resetpassword_select(string EmailID, string Mobile_Number)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Act_Job_Seeker_resetpassword_select";
        objCommand.Parameters.AddWithValue("@EmailID", EmailID);
        objCommand.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader tbl_pmkkcenter_SELECT1()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tbl_pmkkcenter_SELECT1";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
  public SqlDataReader m_crm_user_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_user_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    
         public DataTable Skill_Dev_Candidate_view_profile_BPO(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Skill_Dev_Candidate_view_profile_BPO";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@training_project_name", Training_Project_Name);
            objCommand.Parameters.AddWithValue("@center_name", center_name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    

          public DataTable Act_Job_Seeker_Search_profile1(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Act_Job_Seeker_Search_profile1";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable Act_Job_Seeker_Search_profile(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Act_Job_Seeker_Search_profile";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable tbl_Jobmaela_Candidate_Report1(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tbl_Jobmaela_Candidate_Report1";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@training_project_name", Training_Project_Name);
            objCommand.Parameters.AddWithValue("@center_name", center_name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable tbl_Jobmaela_Candidate_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tbl_Jobmaela_Candidate_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@training_project_name", Training_Project_Name);
            objCommand.Parameters.AddWithValue("@center_name", center_name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable Skill_Dev_Candidate_view_profile_mobilizerall(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Skill_Dev_Candidate_view_profile_mobilizerall";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@training_project_name", Training_Project_Name);
            objCommand.Parameters.AddWithValue("@center_name", center_name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public DataTable Skill_Dev_Candidate_view_profile_mobilizer(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Skill_Dev_Candidate_view_profile_mobilizer";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@emp_name", emp_name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public DataTable Employerlist_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Employerlist_select";           
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date",to_date);
          //  objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    
        public DataTable total_jobs_list_placement(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "total_jobs_list_placement";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    
         public DataTable vispl_job_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "vispl_job_select";
            objCommand.Parameters.AddWithValue("@fromDate", from_date);
            objCommand.Parameters.AddWithValue("@todate", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public SqlDataReader tblAttendance_userwise_Report(string emp_code)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tblAttendance_userwise_Report";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public DataTable total_jobs_list(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_GetEmployerwiseJobPosted";
            objCommand.Parameters.AddWithValue("@fromDate", from_date);
            objCommand.Parameters.AddWithValue("@todate", to_date);
            objCommand.Parameters.AddWithValue("@EmployerID", "0");
            objCommand.Parameters.AddWithValue("@ClientID", "0");
            objCommand.Parameters.AddWithValue("@Keyword", "");
            objCommand.Parameters.AddWithValue("@Status", "All");            //  objCommand.Parameters.AddWithValue("@search_value", search_value);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public SqlDataReader Rpl_Jobrole_SELECT1()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Rpl_Jobrole_SELECT1";
       // objCommand.Parameters.AddWithValue("@sector_id", sector_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Rpl_sector_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Rpl_sector_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public DataTable rpl_regd_profile_select_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "rpl_regd_profile_select_report";
            objCommand.Parameters.AddWithValue("@sector", sector_name);
            objCommand.Parameters.AddWithValue("@jobrole_name", jobrole_name);
            objCommand.Parameters.AddWithValue("@from_date",from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable location_wise_jobs_list(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_Locationwisejoblist";
            objCommand.Parameters.AddWithValue("@LocationKeyword", Location);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

   
    public DataTable Act_Job_Seeker_ADMINview_profile_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Act_Job_Seeker_ADMINview_profile_select";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@Functional_Area_Name", Functional_Area_Name);
            objCommand.Parameters.AddWithValue("@Location", Location);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    
         public DataTable tbl_project_candidate_HOLD_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tbl_project_candidate_HOLD_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable tbl_project_candidate_call_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tbl_project_candidate_call_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable Act_Job_Seeker_ADMINview_profile_select_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Act_Job_Seeker_ADMINview_profile_select_report";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@Functional_Area_Name", Functional_Area_Name);
            objCommand.Parameters.AddWithValue("@Location", Location);
            objCommand.Parameters.AddWithValue("@from_date",from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    

          public SqlDataReader Act_Job_Seeker_candidate_call_status_update(string Trainee_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Act_Job_Seeker_candidate_call_status_update";
        objCommand.Parameters.AddWithValue("@Trainee_ID", Trainee_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader tbl_project_candidate_duplicate_select(string Trainee_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tbl_project_candidate_duplicate_select";
        objCommand.Parameters.AddWithValue("@Trainee_ID", Trainee_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader lead_calllog_select(string Trainee_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "lead_calllog_select";
        objCommand.Parameters.AddWithValue("@Trainee_ID", Trainee_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    
        public SqlDataReader Total_RBPO_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_RBPO_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_RBPO_hold_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_RBPO_hold_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_RBPO_Selected_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_RBPO_Selected_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_RBPO_Call_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_RBPO_Call_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_vispl_job_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_vispl_job_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_job_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_job_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_Employer_count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_Employer_count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_Job_app_JF_Count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_Job_app_JF_Count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_Job_app_vj_Count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_Job_app_vj_Count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_skilldev_Count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_skilldev_Count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_Jobseeker_Count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_Jobseeker_Count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Total_Resume_Count()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Total_Resume_Count";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader tbl_project_candidate_Detail_update(string Job_Seeker_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tbl_project_candidate_Detail_update";
        objCommand.Parameters.AddWithValue("@Job_Seeker_ID", Job_Seeker_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader Act_Job_Seeker_view_profile_select(string Job_Seeker_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Act_Job_Seeker_view_profile_select";
        objCommand.Parameters.AddWithValue("@Job_Seeker_ID", Job_Seeker_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    
    public SqlDataReader Job_Application_Mailing(string ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Job_Application_Mailing";
        objCommand.Parameters.AddWithValue("@ID", ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Job_Postings_FULLpreview(string ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Job_Postings_FULLpreview";
        objCommand.Parameters.AddWithValue("@ID", ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader Act_Job_Seeker_update_profile_select( string Job_Seeker_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Act_Job_Seeker_update_profile_select";
        objCommand.Parameters.AddWithValue("@Job_Seeker_ID", Job_Seeker_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    
         public SqlDataReader Mst_Training_Project_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Training_Project_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    
         public SqlDataReader Mst_Functional_Area_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Functional_Area_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Mst_Specialization_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Specialization_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Mst_Pass_Year_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Pass_Year_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Mst_University_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_University_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Tbl_Course_Type_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Tbl_Course_Type_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
  
    public SqlDataReader Mst_Month_Name_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Month_Name_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Mst_Job_Location_SELECT()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mst_Job_Location_SELECT";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public DataTable Job_Seeker_Proto_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Job_Seeker_Proto_view";
            objCommand.Parameters.AddWithValue("@Job_Seeker_ID", Job_Seeker_ID);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
   
    public DataTable home_Job_search_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "home_Job_search_view";
             objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@Functional_Area_Name", Functional_Area_Name);
            objCommand.Parameters.AddWithValue("@Location", Location);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public DataTable home_Job_Postings_preview(maincode obj_main)
         {
             using (SqlConnection objConnection = new SqlConnection(con_str))
             {
                 SqlCommand objCommand;
                 objCommand = objConnection.CreateCommand();
                 objCommand.CommandType = CommandType.StoredProcedure;
                 objCommand.CommandText = "home_Job_Postings_preview";
                // objCommand.Parameters.AddWithValue("@search_value", search_value);
                 //objCommand.Parameters.AddWithValue("@from_date", from_date);
                 //objCommand.Parameters.AddWithValue("@to_date", to_date);
                 objConnection.Open();
                 objDataAdapter = new SqlDataAdapter();
                 objDataAdapter.SelectCommand = objCommand;
                 objDataSet = new DataSet();
                 objDataAdapter.Fill(objDataSet);
                 objCommand.Dispose();
                 objConnection.Close();
                 objConnection.Dispose();
                 return objDataSet.Tables[0];

             }
         }

    public DataTable BindFunctinalArea()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_GetFunctionalArea";
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public DataTable BindIndustryList()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_GetIndustryList";
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }


    public DataTable BindEmployer()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_GetEmployer";
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }


    public DataTable functionalarea_wise_jobs_list(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "functionalarea_wise_jobs_list";
            objCommand.Parameters.AddWithValue("@functionalareaID", Functional_Area_Name);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
   
    public DataTable IndustryType_wise_jobs_list(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_industry_type_wise_List";
            objCommand.Parameters.AddWithValue("@IndustryType", Industry);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public DataTable RecruterwiseJobPosted(string  RecruterID1)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_RecruterwiseJobsPosted";
            objCommand.Parameters.AddWithValue("@employerID", RecruterID1);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }



    public DataSet BindActiveJobsList(maincode obj_main, string ClientID)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_RecruterwiseActiveJobsList";
            objCommand.Parameters.AddWithValue("@FromDate", obj_main.from_date);
            objCommand.Parameters.AddWithValue("@Todate", obj_main.to_date);
            objCommand.Parameters.AddWithValue("@ClientID", ClientID);

            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet;

        }
    }

    public DataSet Statuswisecandidatelist(string ClientID , string candidatestatus)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "usp_JobswiseCandidateDetails";
            objCommand.Parameters.AddWithValue("@ClientID", ClientID);
            objCommand.Parameters.AddWithValue("@EmployerStatus", candidatestatus);

            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet;

        }

    }
    public SqlDataReader check_in()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "check_in";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@puchin_time", date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader check_intime()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "check_intime";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@date", date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    

         public SqlDataReader tblAttendance_location_Track_duplicacy(string emp_code,string date)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tblAttendance_location_Track_duplicacy";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@date", date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader check_out()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "check_out";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@puchout_time", date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader update_puchout_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "update_puchout_select";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@date", date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public string tblAttendance_location_Track_Out_Update()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "tblAttendance_location_Track_Out_Update";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@emp_code", emp_code);
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@Latitude", Latitude);
            objCommand.Parameters.AddWithValue("@Longitude", Longitude);
            objCommand.Parameters.AddWithValue("@Address", Address);
            objCommand.Parameters.AddWithValue("@date", date);
            objCommand.Parameters.AddWithValue("@ip_address", ip_address);
            objCommand.Parameters.AddWithValue("@Direction", Direction);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
}