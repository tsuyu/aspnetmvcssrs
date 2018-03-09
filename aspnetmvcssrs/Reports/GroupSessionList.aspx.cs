using System;
using System.Collections.Generic;
using Microsoft.Reporting.WebForms;

namespace WebApplication1.Reports
{
    public partial class GroupSessionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String reportFolder = "eKaunselingReport";
                    String reportUsername = "Administrator";
                    String reportPassword = "123456";
                    String reportDomain = "s12";
                    
                    List<ReportParameter> reportParams = new List<ReportParameter>();
                    reportParams.Add(new ReportParameter("StaffID", Request["StaffID"].ToString()));
                    reportParams.Add(new ReportParameter("StdID", Request["StdID"].ToString()));
                    reportParams.Add(new ReportParameter("sMonth", Request["sMonth"].ToString()));
                    reportParams.Add(new ReportParameter("sYear", Request["sYear"].ToString()));

                    IReportServerCredentials ssrscredentials = new CustomSSRSCredentials(reportUsername, reportPassword, reportDomain);

                    gsl.ProcessingMode = ProcessingMode.Remote;
                    gsl.ServerReport.ReportServerCredentials = ssrscredentials;
                    gsl.ServerReport.ReportServerUrl = new Uri("http://localhost:81/ReportServer");

                    gsl.ServerReport.ReportPath = String.Format("/{0}/GroupSessionList", reportFolder);
                    gsl.ServerReport.SetParameters(reportParams);
                    gsl.ServerReport.Refresh();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}