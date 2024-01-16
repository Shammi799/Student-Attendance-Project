<%@ Page Language="C#" AutoEventWireup="true" CodeFile="My_Attendance.aspx.cs" Inherits="My_Attendance" %>

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
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type="text/javascript">

function setText(val, e) {
    document.getElementById(e).value = val;
}

function insertText(val, e) {
    document.getElementById(e).value += val;
}

var nav = null; 

function requestPosition() {
 if (nav == null) {
      nav = window.navigator;
  }
  if (nav != null) {
      var geoloc = nav.geolocation;
      if (geoloc != null) {
          geoloc.getCurrentPosition(successCallback);
      }
      else {
          alert("geolocation not supported");
      }
  }
  else {
      alert("Navigator not found");
  }
}



function successCallback(position)
{
   setText(position.coords.latitude, "latitude");
   setText(position.coords.longitude, "longitude");

}

</script>



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
                    <a href="home.aspx">
                        <asp:Image runat="server" ID="VisplLogo" Width="240" ImageUrl="~/images/vispl_logo.png" style="margin-top:10px"/> </a>
                  
                </div>
                <!-- END LOGO -->
               
                <!-- BEGIN PAGE TOP -->
                <div class="page-top">
                 
                    <!-- BEGIN TOP NAVIGATION MENU -->
                    <div class="top-menu" style="margin:10px 10px 0px 10px">
                     <span class="btn green-meadow">Welcome : <asp:Label ID="lblusername" runat="server"></asp:Label></span><%--OnClick="btnlogout_Click"--%>
                         
                          <asp:HyperLink runat="server" NavigateUrl="~/Default.aspx" CssClass="btn default" Text="Home"></asp:HyperLink>
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
<!-- BEGIN PAGE HEAD-->
<div class="page-head">

                      
</div>
<!-- END PAGE HEAD-->


<!-- BEGIN PAGE BASE CONTENT -->
<div class="row" style="padding:0px 12px 0px 12px">
 <!-- BEGIN SAMPLE TABLE PORTLET-->
<div class="portlet box red">
<div class="portlet-title">
<div class="caption">
<i class="fa fa-cogs"></i>Details </div>

</div>
<div class="portlet-body">
<div class="table-scrollable">
<asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"   ShowFooter= "true" 
 AllowPaging ="false" Width="100%" EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid"  PageSize="40" PagerStyle-CssClass="pgr"> 
<FooterStyle BackColor="#CCCC99" HorizontalAlign="Right" Font-Bold ="true" />  
<Columns >

<asp:TemplateField HeaderText="Sno." Visible="true">
<ItemTemplate>
<%#Container.DataItemIndex+1 %>
</ItemTemplate>
</asp:TemplateField>
      <asp:TemplateField HeaderText="Emp Code">
<ItemTemplate>
  
<asp:Label ID="lblID" runat="server" Text ='<%#Eval("emp_code") %>' />
                                      
</ItemTemplate>
</asp:TemplateField>     
 
 <asp:BoundField DataField ="Date" HeaderText ="Date"/>  
 <asp:BoundField DataField ="inTime" HeaderText ="InTime"/> 
 <asp:BoundField DataField ="outTime" HeaderText ="OutTime"/>    
                   
</Columns>


</asp:GridView>
</div>
</div>
</div>
<!-- END SAMPLE TABLE PORTLET-->

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