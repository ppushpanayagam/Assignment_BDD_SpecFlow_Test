using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace Assignment_SpecFlow_BDD_Tests.Utility;

public class ExtentReport
{
    public static ExtentReports _ExtentReport;
    public static ExtentTest _Feature;
    public static ExtentTest _Scenario;

    public static string dir = AppDomain.CurrentDomain.BaseDirectory;
    public static string testOutPutPath = dir.Replace("bin/Debug/net 6.0", "TestResults");

    public static void ExtentReportInIt()
    {
        Console.Write("***************************"+dir);
        var htmlReporter = new ExtentHtmlReporter(testOutPutPath);
        htmlReporter.Config.ReportName = "Automation Test Report";
        htmlReporter.Config.DocumentTitle = "Shopping Cart Report";
        htmlReporter.Config.Theme = Theme.Dark;
        htmlReporter.Start();

        _ExtentReport = new ExtentReports();
        _ExtentReport.AttachReporter(htmlReporter);
        _ExtentReport.AddSystemInfo("Application", "Katalon Demo Application");
        _ExtentReport.AddSystemInfo("Browser", "Chrome");
        _ExtentReport.AddSystemInfo("OS", "Windows");
        
    }

    public static void ExtentReportTearDown()
    {
        _ExtentReport.Flush();
    }
}