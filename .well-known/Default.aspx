<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Culture="en-GB" UICulture="en-GB" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8" />
<title> Vision India Services | Attendance Management System </title>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta content="width=device-width, initial-scale=1" name="viewport" />
<meta content="Preview page of Metronic Admin Theme #4 for statistics, charts, recent events and reports" name="description" />
<meta content="" name="author" />

<!-- BEGIN GLOBAL MANDATORY STYLES -->
<link href="http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700&amp;subset=all" rel="stylesheet" type="text/css" />
<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet" type="text/css"/>
<link href="~/assets/global/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />


<!-- END GLOBAL MANDATORY STYLES -->

<!-- BEGIN PAGE LEVEL PLUGINS -->
<link href="~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/morris/morris.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/fullcalendar/fullcalendar.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/jqvmap/jqvmap/jqvmap.css" rel="stylesheet" type="text/css" />
<!-- END PAGE LEVEL PLUGINS -->

<!-- BEGIN THEME GLOBAL STYLES -->
<link href="~/assets/global/css/components.min.css" rel="stylesheet" id="style_components" type="text/css" />
<link href="~/assets/global/css/plugins.min.css" rel="stylesheet" type="text/css" />
<!-- END THEME GLOBAL STYLES -->

<!-- BEGIN THEME LAYOUT STYLES -->
<link href="~/assets/layouts/layout4/css/layout.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/layouts/layout4/css/themes/default.min.css" rel="stylesheet" type="text/css" id="style_color" />
<link href="~/assets/layouts/layout4/css/custom.min.css" rel="stylesheet" type="text/css" />
<!-- END THEME LAYOUT STYLES -->

<!-- FAVICON -->
<link rel="shortcut icon" href="images/favicon.ico" /> 


<style type="text/css">
.headbox h1{ width:100%; border:2px solid #f5f5f5; background-color:#e6e6e6; padding:10px; color:#e21f26; 
           border-radius:2px;font-weight:bold; font-size:17px;text-align:center ; font-family:'Lato', sans-serif}
</style>
<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet" type="text/css" />
 <script type="text/javascript" src="https://code.jquery.com/jquery-2.2.3.js"></script>

     


</head>
<body  class="page-container-bg-solid page-header-fixed page-sidebar-closed-hide-logo">
    <form id="form1" runat="server">
    

    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" ScriptMode="Release"></asp:ScriptManager>

     <!-- BEGIN HEADER -->
     <div class="page-header navbar navbar-fixed-top">
            <!-- BEGIN HEADER INNER -->
            <div class="page-header-inner ">
                <!-- BEGIN LOGO -->
                <div class="page-logo">
                    <a href="Default.aspx">
                        <asp:Image runat="server" ID="VisplLogo" Width="240" ImageUrl="~/images/galgotias-university-vector-logo.png" style="margin-top:10px"/> </a>
               <asp:Label ID="lbldate" runat="server" Visible="false"></asp:Label>
                     
                </div>
                <!-- END LOGO -->
               
                <!-- BEGIN PAGE TOP -->
                <div class="page-top">
                 
        <!-- BEGIN TOP NAVIGATION MENU -->
        <div class="top-menu" style="margin:10px 10px 0px 10px">
            <span class="btn green-meadow">Welcome : <asp:Label ID="lblusername" runat="server"></asp:Label></span><%--OnClick="btnlogout_Click"--%>
                        
                <asp:HyperLink runat="server" NavigateUrl="~/My_Attendance.aspx" CssClass="btn default" Text="My Attendance"></asp:HyperLink> 
                       
            <asp:Button runat="server" ID="btnlogout" CssClass="btn red" Text="Log Out" style="padding-left:10px" OnClick="btnlogout_Click" CausesValidation="false" />

                   
        </div>
        <!-- END TOP NAVIGATION MENU -->
                </div>

                <!-- END PAGE TOP -->
            </div>
            <!-- END HEADER INNER -->
        </div>
     <!-- END HEADER -->

    <div class="clearfix"> </div>
    <!-- END HEADER & CONTENT DIVIDER -->
    <!-- BEGIN CONTAINER -->
    
   <div class="page-container">
    <div class="page-content-wrapper">
     <!-- BEGIN CONTENT BODY -->
<div class="page-content">



<!-- BEGIN PAGE BASE CONTENT -->
<div class="row">
<div class="col-lg-3 col-md-3 col-sm-6 col-xs-12"></div>

<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">

<div class="headbox" id="headbx" runat="server">
<h1>Date Time : <asp:Label ID="lbldatetime" runat="server"></asp:Label> </h1>
</div>

<%-- Punch In Button Panel STart --%>
<asp:Panel ID="PnlPunchIn"  runat="server">
<div class="dashboard-stat2 bordered" style="padding-bottom:15px !important; text-align:center" title="Click to Mark Attendance">
<asp:ImageButton runat="server" ID="BtnAttendance" ImageUrl="~/images/buttonAttendance.png" style="width:50% !important;" OnClick="BtnAttendance_Click"/>

<br /> <br />   
<asp:Label ID="lbld" runat="server" Text="For your Attendance Please click on PUNCHIN" style="text-align:center; padding-top:10px; color:#337ab7; font-weight:bold; font-family:'Lato', sans-serif"></asp:Label>
</div>
</asp:Panel>

<%-- Punch Out Button Panel STart --%>
<asp:Panel runat="server" ID="PnlPunchout" Visible="false">
<div class="dashboard-stat2 bordered" style="padding-bottom:15px !important; text-align:center" title="Click to Punchout Attendance">
<asp:ImageButton ID="Btn_out" runat="server" OnClientClick="return confirm('Are sure want to Punch Out?');" OnClick="Btn_out_Click" ImageUrl="~/images/ButtonAttPunchout.png" style="width:50% !important;"/>

<br /> <br />   
<asp:Label ID="LblPucnchout" runat="server" Text="For your punchout Attendance Please click on PUNCHOUT" style="text-align:center; padding-top:10px; color:#337ab7; font-weight:bold; font-family:'Lato', sans-serif"></asp:Label>
</div>
<%--<asp:Button ID="Btn_out" runat="server" Text="Punch out" Visible="false" OnClientClick="return confirm('Are sure want to Punch Out?');" OnClick="Btn_out_Click" />--%>
</asp:Panel>



<asp:Panel ID="Pnlmsg"  runat="server" Visible="false">
<div class="dashboard-stat2 bordered" style="padding-bottom:15px !important; text-align:center" title="Click to Mark Attendance">

<div class="table-responsive">
<table class="table table-bordered">
<thead>
    <tr style="background-color:#f5f5f5">
        <th style="text-align:center">Punch In (Time)</th>
        <th style="text-align:center">Punch Out (Time)</th>
    </tr>

</thead>

<tbody>
<tr>
<td><asp:Label ID="lbl_checkin" runat="server" Text="Label"></asp:Label> </td>
<td><asp:Label ID="lbl_checkout" runat="server" Text="Label"></asp:Label></td>
</tr>
</tbody>
</table>
</div>
    <div class="headbox" style="display:none">
<h1>Working Hour : <asp:Label ID="Label3" runat="server" Text="" style="text-align:center; padding-top:10px; color:#337ab7; font-weight:bold; font-family:'Lato', sans-serif"></asp:Label>
 </h1>
</div>
  

  
<asp:Image runat="server" ID="imgtick" ImageUrl="~/images/correct.png" style="width:30px" ImageAlign="AbsMiddle"/>

<asp:Label ID="Label2" runat="server" Text="Thank You ! Have a good day" style="text-align:center; padding-top:10px; color:#337ab7; font-weight:bold; font-family:'Lato', sans-serif"></asp:Label>
</div>
</asp:Panel>

   <div id="pnlWeekOff" runat="server" visible="false">
      <div class="row">
<div class="col-md-12 col-lg-12 col-sm-12 col-xs-12">
<div class="headbox">
<h1>"Take a break, breathe in the moment, and enjoy this week off. It's the perfect time to recharge and refocus on what truly matters."<br /><br />Today is week off </h1>
</div>
    </div>
    </div>
<div class="row">
<div class="col-md-2 col-lg-2 hidden-sm hidden-xs"></div>
<div class="col-md-8 col-lg-8 col-sm-12 col-xs-12">
<img src="images/icon_holiday.png" alt="Week Off" style="width:100%;" />
</div>
<div class="col-md-2 col-lg-2 hidden-sm hidden-xs"></div>
</div>
</div>

       <div id="pnlWFH" runat="server" visible="false">
<div class="row">
<div class="col-md-12 col-lg-12 col-sm-12 col-xs-12">
<div class="headbox">
<h1>"Working from home offers great flexibility, but also requires discipline. Stay focused, prioritize your tasks, and 
    complete your work efficiently. Your dedication will pay off, and you'll enjoy the benefits of a job well done."<br /><br />Today is work from home</h1>
</div>
    </div>
    </div>
    <div class="row">
 <div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
        <div="col-md-4 col-lg-4 col-sm-12 col-xs-12">
            <img src="images/icon_wfh.png" alt="Week Off" style="width:40%;" />
        </div>
        <div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
    </div>



</div>

  <div id="pnlOD" runat="server" visible="false">
      <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12" style="margin-top:-10px;">
                <div class="headbox">
<h1>Being a team player is essential in any role, as it helps to build a positive and productive work environment.<br /><br />You have Applied - OD</h1>
</div>
            </div>
      </div>
<div class="row">
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">

<img src="images/leave_icon.png" alt="Od Applied" style="width:100%;margin: -76px 0px 0px -3px" />
</div>
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
</div>
</div>

    <div id="pnlLeave1" runat="server" visible="false">
      <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12" style="margin-top:-10px;">
                <div class="headbox">
<h1>Being a team player is essential in any role, as it helps to build a positive and productive work environment.<br /><br />You have Applied - <asp:Label ID="lblleaveType" runat="server"></asp:Label></h1>
</div>
            </div>
      </div>
<div class="row">
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">

<img src="images/leave_icon.png" alt="Od Applied" style="width:100%;margin: -76px 0px 0px -3px" />
</div>
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
</div>
</div>

    <div id="pnlODRequest" runat="server" visible="false">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12" style="margin-top:-10px;">
                <div class="headbox">
<h1>Being a team player is essential in any role, as it helps to build a positive and productive work environment.<br />You have Applied - <asp:Label runat="server" ID="lblLeave"></asp:Label></h1>
</div>
            </div>
        </div>
<div class="row">
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">

<img src="images/leave_icon.png" alt="Od Applied" style="width:100%;margin: -76px 0px 0px -3px" />
</div>
<div class="col-md-4 col-lg-4 hidden-sm hidden-xs"></div>
</div>
</div>

</div>
<asp:Label ID="lblmsg" runat="server"></asp:Label>

<div class="col-lg-3 col-md-3 col-sm-6 col-xs-12"></div>

<div class="col-lg-3 col-md-3 col-sm-6 col-xs-12" style="display:none" >

    <div>
    <label for="latitude">Latitude: </label><asp:Label ID="latitude" runat="server" Text=""></asp:Label><br />
<label for="longitude">Longitude: </label><asp:Label ID="longitude" runat="server" Text=""></asp:Label><br />
 <label  for="city">City: </label>
        <asp:Label ID="Label1"  runat="server" Text=""></asp:Label> <br />
       
    </div>
</div>
  

</div>

<!-- END PAGE BASE CONTENT -->

</div>
<!-- END CONTENT BODY -->
    </div>

     </div>


   <!-- BEGIN FOOTER -->
        <div class="page-footer" style="color:#fff; text-align:center">
            <div class="page-footer-inner" style="color:#fff; text-align:center"> 2017 &copy;  
                <a target="_blank" href="https://www.vispl.co.in/" style="color:#fff; text-align:center">Vision India  Services</a> &nbsp;|&nbsp;
                <a href="javascript:void(0)" title="Vision India Services (P) Limited" target="_blank" style="color:#fff; text-align:center"> All Rights Reserved</a>&nbsp;|&nbsp;
                
            </div>
            <div class="page-footer-inner" style="color:#fff; text-align:center">  Please visit  
                <a target="_blank" href="https://www.vispl.co.in/" style="color:#fff; text-align:center">www.vispl.co.in</a> | 
               <asp:HyperLink runat="server" ID="HynChangePass" NavigateUrl="~/changePassword.aspx" Visible="false" style="color:#e21f26; text-align:center;font-weight:600" Text="Change Password"></asp:HyperLink>
            </div>
            <div class="scroll-to-top">
                <i class="icon-arrow-up"></i>
            </div>
        </div>
        <!-- END FOOTER -->


    <!-- BEGIN CORE PLUGINS -->
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jquery.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/js.cookie.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jquery.blockui.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js" type="text/javascript"></script>
        <!-- END CORE PLUGINS -->

        <!-- BEGIN PAGE LEVEL PLUGINS -->
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/moment.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/morris/morris.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/morris/raphael-min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/counterup/jquery.waypoints.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/counterup/jquery.counterup.min.js" type="text/javascript"></script>
        
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/fullcalendar/fullcalendar.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/horizontal-timeline/horizontal-timeline.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/flot/jquery.flot.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/flot/jquery.flot.resize.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/flot/jquery.flot.categories.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jquery.sparkline.min.js" type="text/javascript"></script>
        
        <script src="http://visionindiaapp.in/admin/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js" type="text/javascript"></script>
        <!-- END PAGE LEVEL PLUGINS -->
        <!-- BEGIN THEME GLOBAL SCRIPTS -->
        <script src="http://visionindiaapp.in/admin/assets/global/scripts/app.min.js" type="text/javascript"></script>
        <!-- END THEME GLOBAL SCRIPTS -->
        <!-- BEGIN PAGE LEVEL SCRIPTS -->
        <script src="http://visionindiaapp.in/admin/assets/pages/scripts/dashboard.min.js" type="text/javascript"></script>
        <!-- END PAGE LEVEL SCRIPTS -->
        <!-- BEGIN THEME LAYOUT SCRIPTS -->
        <script src="http://visionindiaapp.in/admin/assets/layouts/layout4/scripts/layout.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/layouts/layout4/scripts/demo.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/layouts/global/scripts/quick-sidebar.min.js" type="text/javascript"></script>
        <script src="http://visionindiaapp.in/admin/assets/layouts/global/scripts/quick-nav.min.js" type="text/javascript"></script>
        <!-- END THEME LAYOUT SCRIPTS -->
        <script>
            $(document).ready(function()
            {
                $('#clickmewow').click(function()
                {
                    $('#radio1003').attr('checked', 'checked');
                });
            })
        </script>
    </form>
</body>
</html>
