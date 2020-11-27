using HubDataServices;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using VoscalLogger;

namespace ConsoleApplication1
{
    public class Spn
    {
        public string SPN;
        public string SPNDescription;
        public string ServiceDeliverable;
        public string EPC;
        public string ApplStd;
        public string SAC;
    }
    class Program
    {
        private static Service svc = new Service();

        private const object Svc = null;

        static void Main(string[] args)
        {
            #region...Ldap Service...
            //ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPE) { return true; };
            //string appName = "CATS";
            //string idType = "EmployeeNumber";
            //string id = "00835114";
            //string pwd = "";
            ////svc.BeginldapAuth(appName, idType, id, pwd, new AsyncCallback(LdapCallback), null);
            ////string result = svc.ldapAuth(appName, idType, id, pwd);

            //LdapServiceRef.LdapServiceClient client = new LdapServiceRef.LdapServiceClient();
            //string result = client.ldapAuth(appName, idType, id, pwd);
            //Console.WriteLine(result);
            ////Console.ReadLine();

            //ATSpcWcssSpcActivity.WCSSActivityInsertOrUpdate_Input input = new ATSpcWcssSpcActivity.WCSSActivityInsertOrUpdate_Input();
            //input.



            #endregion

            #region...Email...
            //System.Net.Mail.MailMessage mailMsg = new System.Net.Mail.MailMessage("jinbao_gao@keysight.com", "jinbao_gao@keysight.com", "Test Email Sending", "Happy New Year");
            //System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(

            //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("192.25.218.43");

            //client.Send(mailMsg);
            #endregion

            #region...XML XPATH...
            //XmlDocument xmlDocLogoConfig = new XmlDocument();
            ////XmlDocument xmlDocReportConfig = new XmlDocument();
            //xmlDocLogoConfig.Load("LogoConfig.xml");
            ////xmlDocReportConfig.Load("ReportConfig.xml");
            //XmlNode xmlNode = xmlDocLogoConfig.DocumentElement.SelectSingleNode(string.Format("//Office[@Code='{0}']", "8065"));
            //string logoFile = string.Empty;
            //if (xmlNode != null)
            //{
            //    XmlNode logoNode = xmlNode.SelectSingleNode(string.Format("./{0}", "LOCAL_ACCRED_LOGO_MV_CAL"));
            //    logoFile = logoNode.InnerText.Trim();
            //    Console.WriteLine(logoFile);

            //    XmlNode nodeTitle = xmlNode.SelectSingleNode("./TITLE");
            //    string OverrideTitle = nodeTitle == null ? string.Empty : nodeTitle.InnerText.Trim(); //officeInstance.TITLE;
            //    XmlNode nodeRemarks = xmlNode.SelectSingleNode("./REMARKS");
            //    string OverrideCaseRemarks = nodeRemarks == null ? string.Empty : nodeRemarks.InnerText.Trim();//officeInstance.REMARKS;
            //    XmlNode nodeCertNo = xmlNode.SelectSingleNode("./CERTIFICATE_NO");
            //    string OverrideCaseCertNumberLabel = nodeCertNo == null ? string.Empty : nodeCertNo.InnerText.Trim();//officeInstance.CERTIFICATE_NO;
            //    Console.WriteLine(OverrideTitle);
            //    Console.WriteLine(OverrideCaseRemarks);
            //    Console.WriteLine(OverrideCaseCertNumberLabel);
            //}
            ////XmlNode xmlNode6 = xmlDocLogoConfig.DocumentElement.SelectSingleNode(string.Format("//Office[@Code='{0}']", mServiceOrder.Entity));
            #endregion...

            #region...FTP...
            //string ftpUri = string.Format("ftp://lcossdo9.cos.is.keysight.com/pub/caldoc/reports/Calibration Report_1-6244401733-1.pdf");
            //FtpWebRequest ftpWebReq = (FtpWebRequest)WebRequest.Create(ftpUri);
            //ftpWebReq.Method = WebRequestMethods.Ftp.DownloadFile;
            //ftpWebReq.Credentials = new NetworkCredential("ingres", "123");
            //ftpWebReq.UseBinary = true;
            //ftpWebReq.UsePassive = true;
            //ftpWebReq.KeepAlive = true;
            //FtpWebResponse ftpResponse = (FtpWebResponse)ftpWebReq.GetResponse();
            //Stream ftpStream = ftpResponse.GetResponseStream();
            ///* Open a File Stream to Write the Downloaded File */
            //FileStream localFileStream = new FileStream("D:\\TEST_FTP.txt", FileMode.Create);
            ///* Buffer for the Downloaded Data */
            //byte[] byteBuffer = new byte[2048];
            //int bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
            ///* Download the File by Writing the Buffered Data Until the Transfer is Complete */
            //try
            //{
            //    while (bytesRead > 0)
            //    {
            //        localFileStream.Write(byteBuffer, 0, bytesRead);
            //        bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
            //    }
            //}
            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            ///* Resource Cleanup */
            //localFileStream.Close();
            //ftpStream.Close();
            //ftpResponse.Close();
            //ftpWebReq = null;
            #endregion...

            #region...Version Number...
            /* Environment Version
            Major is 4
            Minor is 0
            Build is 30319
            Revision is 42000
            Full version is 4.0.30319.42000
            */
            //Console.WriteLine(string.Format("Major is {0}", Environment.Version.Major));
            //Console.WriteLine(string.Format("Minor is {0}", Environment.Version.Minor));
            //Console.WriteLine(string.Format("Build is {0}", Environment.Version.Build));
            //Console.WriteLine(string.Format("Revision is {0}", Environment.Version.Revision));
            //Console.WriteLine(string.Format("Full version is {0}", Environment.Version.ToString()));


            /* OS Version
            Major is 6
            Minor is 1
            Build is 7601
            Revision is 65536
            Full version is 6.1.7601.65536
            */
            //List<string> version = new List<string>();
            //version.Add(string.Format("Major is {0}", Environment.OSVersion.Version.Major));
            //version.Add(string.Format("Minor is {0}", Environment.OSVersion.Version.Minor));
            //version.Add(string.Format("Build is {0}", Environment.OSVersion.Version.Build));
            //version.Add(string.Format("Revision is {0}", Environment.OSVersion.Version.Revision));
            //version.Add(string.Format("Full version is {0}", Environment.OSVersion.Version.ToString()));
            //File.WriteAllLines("D:\\VersionNumber.txt", version.ToArray());
            #endregion

            #region Get all offices from OCPP configuration file
            //string result = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
            //string fileName = @"C:\ocpp\ocpp9_07_12_VCA2\ocppCopy.cfg";
            //List<string> offices = new List<string>();
            //using (StreamReader reader = new StreamReader(fileName))
            //{
            //    while (reader.Peek() != -1)
            //    {
            //        string line = reader.ReadLine();
            //        string[] items = line.Split('|');
            //        string first = items[0];
            //        string[] mainItems = first.Split('=')[0].Split('-');
            //        string region = mainItems[0];
            //        string country = mainItems[1];
            //        string officeCode = mainItems[2];
            //        string ownerId = items[2];
            //        string officeNodes = string.Format("<Office><Name>{0}</Name><OfficeCode>{1}</OfficeCode><Region>{2}</Region><SiebelOwnerID>{3}</SiebelOwnerID></Office>", country, officeCode, region, ownerId);
            //        offices.Add(officeNodes);
            //    }
            //    File.WriteAllLines("D:\\Offices.xml", offices.ToArray());
            //} 
            #endregion

            #region Practise ForEach IEnumerable
            //List<string> source = new List<string>();
            //source.Add("GAO");
            //source.Add("JIN");
            //source.Add("BAO");
            //source.ForEach(s => s = string.Format("'{0}'", s));
            #endregion

            #region Practise string and double parse
            //string temp = "thisisateststringFOROCPP";
            ////string newone = temp.Substring(0, temp.Length > 20 ? 20 : temp.Length);
            //double tmp;
            //Double.TryParse(temp, out tmp);
            //var calTime = tmp; 
            #endregion

            #region Practise NET USE and RSync
            ////Init
            ////string path = @"\\wchnemu1.bei.is.keysight.com\TestRepos";
            //string path = @"\\lapis.srs.is.keysight.com\wcss_cal_monitor\TME";
            //string user = "wcss_bjbld";
            //string pwd = "!Qaz@Wsx#Edc$Rfv%Tgb^Yhn";
            //string rsync_errmsg = string.Empty;

            //string path = @"\\wtmedbupload.cos.is.keysight.com\TME-Database Backup";
            //string user = "rsync";
            //string pwd = "!Qaz@Wsx";
            //string rsync_errmsg = string.Empty;

            ////Connect
            //bool isConnected = CreateRemoteConnection(path, user, pwd);

            ////Sync
            //int syncResult = Rsync(@"D:\Change_log.txt", "Change_log.txt", false, ref rsync_errmsg);

            ////Disconnect
            //bool isDisconnected = DisconnectRemoteSite(path); 
            #endregion

            #region Practise Logger

            //string message = string.Format("[{0}]Test[{1}][{2}]", nameof(Main), nameof(Program), nameof(ConsoleApplication1));
            //Logger.Instance.Debug(message);

            #endregion

            #region...Sample - HttpWebRequest read web content...

            //Uri uri = new Uri("http://scgsbu09.scs.is.keysight.com/tspm/eServices.asp?Station=5CG5264R9M&&ClientID=TSPMCLIENT1.0&Service=QUERYALLPACKAGES");
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
            //request.UseDefaultCredentials = true;
            //request.PreAuthenticate = true;
            //request.Credentials = CredentialCache.DefaultCredentials;
            //request.Timeout = 10000;
            //System.Net.WebResponse response = request.GetResponse();
            ////File.WriteAllText("D:\\cntLength.txt", response.ContentLength.ToString());

            //Stream stream = response.GetResponseStream();

            //StreamReader reader = new StreamReader(stream);
            //string contentString = reader.ReadToEnd();

            #region...Can't real completely...
            //byte[] sData = new byte[40960];
            //int count = stream.Read(sData, 0, (int)response.ContentLength); //14428
            //string contentString = Encoding.Default.GetString(sData, 0, count);
            #endregion

            //File.WriteAllText("D:\\DownloadContent1.txt", contentString);
            //return contentString;

            #endregion

            #region...SPN-SAC.dat...
            //List<Spn> spnsac = new List<Spn>();
            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50V-501",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "OPV",
            //    ApplStd = "VE",
            //    SAC = "OK - VOSCAL Operational Verification"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50W-501",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "OPV",
            //    ApplStd = "VE",
            //    SAC = "OK - VOSCAL Operational Verification"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-511",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CAL",
            //    ApplStd = "AT",
            //    SAC = "OL - VOSCAL Keysight Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-511",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CAL",
            //    ApplStd = "AT",
            //    SAC = "OL - VOSCAL Keysight Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-560",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CAL",
            //    ApplStd = "L8",
            //    SAC = "OL - VOSCAL Keysight Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-521",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "540",
            //    ApplStd = "MA",
            //    SAC = "OW - VOSCAL Z540-1 Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-521",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "540",
            //    ApplStd = "MA",
            //    SAC = "OW - VOSCAL Z540-1 Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-531",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MVC",
            //    ApplStd = "AT",
            //    SAC = "OT - VOSCAL MV Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-531",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MVC",
            //    ApplStd = "AT",
            //    SAC = "OT - VOSCAL MV Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-532",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "54M",
            //    ApplStd = "MA",
            //    SAC = "OT - VOSCAL MV Z540"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-532",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "54M",
            //    ApplStd = "MA",
            //    SAC = "OT - VOSCAL MV Z540"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-531-MU",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "AMV",
            //    ApplStd = "RT",
            //    SAC = "OX - VOSCAL MV + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-531-MU",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "AMV",
            //    ApplStd = "RT",
            //    SAC = "OX - VOSCAL MV + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R50C-535",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "54P",
            //    ApplStd = "MA",
            //    SAC = "OZ - VOSCAL MV Z540OOT"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R50G-535",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "54P",
            //    ApplStd = "MA",
            //    SAC = "OZ - VOSCAL MV Z540OOT"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R50C-534",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MVP",
            //    ApplStd = "AT",
            //    SAC = "OG - VOSCAL MV OOT"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R50G-534",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MVP",
            //    ApplStd = "AT",
            //    SAC = "OG - VOSCAL MV OOT"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-511-MU",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACM",
            //    ApplStd = "RT",
            //    SAC = "OU - VOSCAL Keysight Cal + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-511-MU",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACM",
            //    ApplStd = "RT",
            //    SAC = "OU - VOSCAL Keysight Cal + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-511-MU-R",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "UMU",
            //    ApplStd = "RA",
            //    SAC = "OM - AM_VOSCAL + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-511-MU-R",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "UMU",
            //    ApplStd = "RA",
            //    SAC = "OM - AM_VOSCAL + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-511-MU-C",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "UMU",
            //    ApplStd = "RA",
            //    SAC = "OM - CN_VOSCAL + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-511-MU-C",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "UMU",
            //    ApplStd = "RA",
            //    SAC = "OM - CN_VOSCAL + Uncert"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-516",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ISO",
            //    ApplStd = "17",
            //    SAC = "OP - VOSCAL + Uncert + GB"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-516",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ISO",
            //    ApplStd = "17",
            //    SAC = "OP - VOSCAL + Uncert + GB"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-517",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACC",
            //    ApplStd = "SU",
            //    SAC = "OA - VOSCAL Accredited Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-517",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACC",
            //    ApplStd = "NM",
            //    SAC = "OA - VOSCAL Accredited Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-561",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACC",
            //    ApplStd = "JC",
            //    SAC = "OA - VOSCAL Accredited Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-561",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "ACC",
            //    ApplStd = "JC",
            //    SAC = "OA - VOSCAL Accredited Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-523",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "APF",
            //    ApplStd = "Z3",
            //    SAC = "OV - Z540.3"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-523",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "APF",
            //    ApplStd = "Z3",
            //    SAC = "OV - Z540.3"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-503",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CAL",
            //    ApplStd = "AT",
            //    SAC = "OL - VOSCAL Keysight Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-51D-503",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CAL",
            //    ApplStd = "AT",
            //    SAC = "OL - VOSCAL Keysight Cal"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "RCD5C",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CDC",
            //    ApplStd = "SS",
            //    SAC = "OC - VOSCAL Custom Calibration"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R1608A",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "CDC",
            //    ApplStd = "SS",
            //    SAC = "OY - VOSCAL Custom Cal OOT"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50C-530",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MET",
            //    ApplStd = "MV",
            //    SAC = "OD - VOSCAL Basic Calibration"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "R-50G-530",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "MET",
            //    ApplStd = "MV",
            //    SAC = "OD - VOSCAL Basic Calibration"
            //});

            //spnsac.Add(new Spn
            //{
            //    SPN = "RCD5C",
            //    SPNDescription = "",
            //    ServiceDeliverable = "",
            //    EPC = "RBC",
            //    ApplStd = "RB",
            //    SAC = ""
            //});

            //List<string> spnList = new List<string>();
            //foreach (Spn item in spnsac)
            //{
            //    string content = string.Format("{0}|{1}|{2}|{3}|{4}|{5}", item.SPN, item.SPNDescription, item.ServiceDeliverable, item.EPC, item.ApplStd, item.SAC);
            //    spnList.Add(content);
            //}
            //File.WriteAllLines("D:\\SPN-SAC.dat", spnList.ToArray());
            #endregion

            #region Version parts & ReadKey
            //Version version = Assembly.GetExecutingAssembly().GetName().Version;
            //string versionNumber = string.Format("OCPP {0}.{1}", version.Major, version.Minor.ToString().PadLeft(2, '0'));
            //Console.WriteLine(version.ToString());
            //Console.WriteLine(versionNumber);
            //Console.ReadKey(true);
            #endregion

            #region Investigation OCPP Bulk Insert CATS Data
            //string mEnvDbFile = @"C:\ocpp\Dev\environm.mdb";
            //string mImportFolder = @"C:\ocpp\Dev";
            //string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            //OleDbConnection connection = new OleDbConnection(strConnection);
            //try
            //{
            //    //agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle
            //    //string cmdString = string.Format("INSERT INTO [agt_model] (agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle) SELECT agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle FROM [Text;DATABASE={0}].[{1}]", mImportFolder, "agilent_models.txt");
            //    string cmdString = string.Format("INSERT INTO [agt_model] (agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle) SELECT agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle FROM [Text;DATABASE={0}].[{1}]", mImportFolder, "agilent_models.txt");
            //    //string cmdString = string.Format("SELECT F1,F2,F3,F4,F5,F6,F7 INTO [agt_model_new] FROM [Text;DATABASE={0}].[{1}]", mImportFolder, "agilent_models.txt");
            //    OleDbCommand command = new OleDbCommand(cmdString, connection);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //connection.Close();

            //string mEnvDbFile = @"C:\ocpp\Dev\environm.mdb";
            //string mSrcFile = @"C:\ocpp\Dev\agilent_models.txt";
            //string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            //OleDbConnection connection = new OleDbConnection(strConnection);
            //try
            //{
            //    connection.Open();
            //    //string selectString = "SELECT * FROM [agt_model]";
            //    string insertString = "INSERT INTO [agt_model] (agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle) VALUES (@agilent_model,@mfr_cd,@mfr_model,@model_descr,@model_option,@option_descr,@cal_cycle)";
            //    OleDbCommand insertCommand = new OleDbCommand(insertString, connection);
            //    //OleDbDataAdapter adapter = new OleDbDataAdapter();
            //    //insertCommand.Parameters.Add("@agilent_model", OleDbType.VarChar, 25, "agilent_model");
            //    //insertCommand.Parameters.Add("@mfr_cd", OleDbType.VarChar, 3, "mfr_cd");
            //    //insertCommand.Parameters.Add("@mfr_model", OleDbType.VarChar, 50, "mfr_model");
            //    //insertCommand.Parameters.Add("@model_descr", OleDbType.VarChar, 100, "model_descr");
            //    //insertCommand.Parameters.Add("@model_option", OleDbType.VarChar, 15, "model_option");
            //    //insertCommand.Parameters.Add("@option_descr", OleDbType.VarChar, 100, "option_descr");
            //    //insertCommand.Parameters.Add("@cal_cycle", OleDbType.Integer);

            //    insertCommand.Parameters.Add(new OleDbParameter("@agilent_model", "3458A"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@mfr_cd", "KTI"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@mfr_model", "3458A"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@model_descr", "description"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@model_option", "options"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@option_descr", "option_description"));
            //    insertCommand.Parameters.Add(new OleDbParameter("@cal_cycle", 12));

            //    //adapter.InsertCommand = insertCommand;

            //    //OleDbCommand selectCommand = new OleDbCommand(selectString, connection);
            //    //adapter.SelectCommand = selectCommand;

            //    //DataTable table = new DataTable();
            //    //adapter.Fill(table);

            //    //using (StreamReader reader = new StreamReader(mSrcFile))
            //    //{
            //    //    reader.ReadLine();//Comments line
            //    //    reader.ReadLine();//Headers line
            //    //    string[] allLines = reader.ReadToEnd().Split('\n');
            //    //    foreach (string line in allLines)
            //    //    {
            //    //        string[] elements = line.Split('|');
            //    //        if (elements.Length != 7)
            //    //        {

            //    //        }
            //    //    }
            //    //}

            //    //connection.Open();
            //    insertCommand.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //connection.Close();

            #endregion

            #region Dns HostName

            //string hostName = Dns.GetHostEntry("").HostName;
            //string hsotName1 = Dns.GetHostEntry(Environment.MachineName).HostName;
            //Console.WriteLine(hostName);

            #endregion

            #region XML CalLabelInfo

            //XmlDocument xmlDoc = new XmlDocument();

            //XmlNode rootNode = xmlDoc.CreateNode(XmlNodeType.Element, "CalLabelInfo", string.Empty);
            //xmlDoc.AppendChild(rootNode);

            ////CSONumber
            //XmlNode csoNode = xmlDoc.CreateElement("CSONumber");
            //csoNode.InnerText = "1-8888888888-1";
            //rootNode.AppendChild(csoNode);

            ////AgilentModel
            //XmlNode agtModelNode = xmlDoc.CreateElement("AgilentModel");
            //agtModelNode.InnerText = "33250A";
            //rootNode.AppendChild(agtModelNode);

            ////SerialNumber
            //XmlNode serialNumberNode = xmlDoc.CreateElement("SerialNumber");
            //serialNumberNode.InnerText = "MY686868";
            //rootNode.AppendChild(serialNumberNode);

            ////WDB
            //XmlNode wdbNode = xmlDoc.CreateElement("WDB");
            //wdbNode.InnerText = "F400";
            //rootNode.AppendChild(wdbNode);

            #endregion

            #region System Special Folder
            //string path1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            //string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            //string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Programs);

            //Console.WriteLine("Environment.SpecialFolder.ProgramFiles:");
            //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));

            //Console.WriteLine("Environment.SpecialFolder.ProgramFilesX86:");
            //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));

            //Console.WriteLine("Environment.SpecialFolder.Is64BitOperatingSystem:");
            //Console.WriteLine(Environment.Is64BitOperatingSystem);
            #endregion

            #region EMU Rebuild Index File
            //Process.Start("http://emu.service.keysight.com/cgi-bin/find_models.exe?search=575L&load=Search+again&getindex=Yes&detail=basic");
            #endregion

            #region Regex Match
            //string source = "AT";
            //if (Regex.IsMatch(source,"2P|3P|VE"))
            //{
            //    Console.WriteLine("AT Match");
            //}

            //string source1 = "VE";
            //if (Regex.IsMatch(source1, "2P|3P|VE"))
            //{
            //    Console.WriteLine("VE Match");
            //}
            #endregion

            #region Process WorkingSet64 (Close MainWindow from Process)
            //try
            //{
            //    Process myProcess;
            //    myProcess = Process.Start("Notepad.exe");
            //    // Display physical memory usage 5 times at intervals of 2 seconds.
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (!myProcess.HasExited)
            //        {
            //            // Discard cached information about the process.
            //            myProcess.Refresh();
            //            // Print working set to console.
            //            Console.WriteLine("Physical Memory Usage: " + myProcess.WorkingSet64.ToString());
            //            // Wait 2 seconds.
            //            Thread.Sleep(5000);
            //        }
            //        else {
            //            break;
            //        }
            //    }

            //    // Close process by sending a close message to its main window.

            //    myProcess.CloseMainWindow();
            //    // Free resources associated with process.
            //    myProcess.Close();

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The following exception was raised: ");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Get Version and DateTime.Parse
            //string ver= Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //Console.WriteLine(ver);

            //string source = "21 Jan 2017";
            //DateTime newValue = DateTime.Parse(source);
            #endregion

            #region GetDirsBy["*8753D*"]; FileInfo.Length; EncodingInfo[]
            //string target = @"C:\srmuxroot\STE9000\RESULTS";
            //string[] dirs = Directory.GetDirectories(target, "*8753D*", SearchOption.TopDirectoryOnly);

            //foreach (var item in dirs)
            //{
            //    string[] subDirs = Directory.GetDirectories(item, "3410A07619");
            //    if (subDirs.Length > 0)
            //    {
            //        Console.WriteLine(subDirs[0]);
            //    }
            //}

            //FileInfo fi = new FileInfo(@"C:\ocpp\ocpp9_07_18\environm.mdb");
            //Console.WriteLine(fi.Length);

            //ExportEnvironment();
            //ExportSystems();

            //ImportEnvironmentExist();

            //EncodingInfo[] encodingInfos = Encoding.GetEncodings();
            //List<string> strInfos = new List<string>();
            //foreach (var item in encodingInfos)
            //{
            //    strInfos.Add($"{item.CodePage}|{item.DisplayName}|{item.Name}|{item.GetEncoding().ToString()}");
            //}
            #endregion

            #region The << works as double

            //int[] sValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 127, 128, 129, 254, 255, 256, 257, int.MaxValue };
            //foreach (int item in sValues)
            //{
            //    int result = item << 1;
            //    Console.WriteLine(item + "|" + result + "|" + Convert.ToString(result, 2));
            //}

            #endregion

            #region GetCatsServer; Double Calc; cdPublishInstallLocation; MimeMapping
            //WebClient wc = new WebClient();
            //wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
            //string result = wc.DownloadString("http://lcossdo7.cos.is.keysight.com/getCatsServer.htm");

            //Console.WriteLine(result);

            //try
            //{
            //    Test(false);

            //    Test(true);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //double test1 = 100 / 30;
            //double test2 = 100.00 / 30;
            //double test3 = 100.0 / 30.0;
            //double test4 = Math.Round(100.0 / 30, 1);

            //List<string> lTest = new List<string>() { "test" };
            //Console.WriteLine(lTest[0]);

            //List<string> newContent = new List<string>();
            //string[] links = File.ReadAllLines("D:\\invalid_links.txt");
            //foreach (var item in links)
            //{
            //    bool isValid = isValidUrl(item);
            //    string new_content = item + "," + isValid.ToString();
            //    newContent.Add(new_content);
            //}

            //File.WriteAllLines("D:\\validate_result.csv", newContent.ToArray());

            //FindAllDataSheet();

            //List<string> src = new List<string>();
            //src.Add("Test1");
            //src.Add("Test1");
            //src.ForEach(p => Console.WriteLine(p));

            //string location = string.Empty;//@"C:\Program Files (x86)\CalDoc Publisher\";
            //try
            //{
            //    //var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
            //    //RegistryKey cdPublishInstallLocation = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"); //\CalDoc Publisher_is1
            //    //foreach (var key in cdPublishInstallLocation.GetSubKeyNames())
            //    //{
            //    //    Console.WriteLine(key);
            //    //}
            //    RegistryKey cdPublishInstallLocation = null;
            //    if (Environment.Is64BitOperatingSystem)
            //    {
            //        //var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            //        //cdPublishInstallLocation = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            //        cdPublishInstallLocation = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\CalDoc Publisher_is1");
            //    }
            //    else
            //    {
            //        cdPublishInstallLocation = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\CalDoc Publisher_is1");
            //    }
            //    if (cdPublishInstallLocation == null) Console.WriteLine(string.Empty);
            //    location = cdPublishInstallLocation.GetValue("InstallLocation").ToString();
            //}
            //catch
            //{
            //    Console.WriteLine(string.Empty);
            //}
            //Console.WriteLine(string.Empty);

            // Method 1
            //List<string> src = new List<string>();
            //src.Add("Test1");
            //src.Add("Test2");
            //src.Add("Test3");
            //src.Add("Test4");

            //List<string> target = new List<string>();
            //src.ForEach(delegate(string file) {
            //    string new_content = file + ".bak";
            //    target.Add(new_content);
            //});

            // Method 2
            //List<string> src = new List<string>();
            //src.Add("Test1");
            //src.Add("Test2");
            //src.Add("Test3");
            //src.Add("Test4");

            ////List<string> target = new List<string>();
            //src.ForEach(delegate (string file) {
            //    file = file + ".bak";
            //});

            //string LATESTVERSION = "OCPP 9.09";
            //string versionInfo = "9.08_" + LATESTVERSION.Substring(5, LATESTVERSION.Length - 5);
            //Console.WriteLine(versionInfo);

            //IResourceList res = HubDataServices.HubDataServices.IHubDataServices.GetResourceList("worklist");

            //string guidNew = Guid.NewGuid().ToString();

            //Console.WriteLine(guidNew);

            //Console.WriteLine(DateTime.Now.ToString("yyyyMMdd_HHmmss_fff"));
            //Thread.Sleep(300);
            //Console.WriteLine(DateTime.Now.ToString("yyyyMMdd_HHmmss_fff"));

            //var file_name = "test.mp4";
            //Console.WriteLine((new FileInfo(file_name)).Extension);
            //string mimeType = System.Web.MimeMapping.GetMimeMapping(file_name);
            //Console.WriteLine(mimeType);

            //var fileTimeStamp = DateTime.Now.Ticks.ToString();
            //Console.WriteLine(fileTimeStamp);
            //var dt = new DateTime(Convert.ToInt64(fileTimeStamp));
            //Console.WriteLine(dt.ToUniversalTime());

            //Console.WriteLine(GetExcelColumnName(1));
            //Console.WriteLine(GetExcelColumnName(25));
            //Console.WriteLine(GetExcelColumnName(26));
            //Console.WriteLine(GetExcelColumnName(27));
            //Console.WriteLine(GetExcelColumnName(51));
            //Console.WriteLine(GetExcelColumnName(52));
            //Console.WriteLine(GetExcelColumnName(53));

            //string xlsx_file = @"C:\Users\gao00002\Downloads\636698399956239124_Quotelines_export.xlsx";
            //string xls_file = @"C:\Users\gao00002\Downloads\test.xls";
            //string pdf_file = @"C:\Users\gao00002\Downloads\1-9202025975-1_Certificate of Calibration.pdf";

            //Console.WriteLine(Path.GetExtension(xlsx_file));  //.xlsx

            //char[] buffer = new char[65536];
            //using (StreamReader reader = new StreamReader(xlsx_file, false))
            //{
            //    try
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //using (StreamReader reader = new StreamReader(xls_file, false))
            //{
            //    try
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //using (StreamReader reader = new StreamReader(pdf_file, false))
            //{
            //    try
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\636698399956239124_Quotelines_export.xlsx"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\636698399956239124_Quotelines_export - Copy.xls"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\1-9202025975-1_Certificate of Calibration.pdf"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\test.xls"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\test - Copy.xlsx"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\UserResponsibilities.csv"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\v8.json"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\v8.xls"));
            //Console.WriteLine(System.Web.MimeMapping.GetMimeMapping(@"C:\Users\gao00002\Downloads\v8.xlsx"));

            //var file_name = @"D:\ccode.txt";
            //using (StreamReader reader = new StreamReader(file_name))
            //{
            //    List<string> sb = new List<string>();
            //    while (reader.Peek() != -1)
            //    {
            //        var line = reader.ReadLine();
            //        var elements = line.Split('@');
            //        sb.Add($"CountryCodes.Add(\"{elements[0].Trim().Trim(',')}\", \"{elements[1].Trim().Trim(',')}\");");
            //    }
            //    File.WriteAllLines("D:\\CC.txt", sb);
            //}
            #endregion

            #region CountryCodes
            //Dictionary<string, string> CountryCodes = new Dictionary<string, string>();
            //try
            //{
            //    CountryCodes.Add("AFGHANISTAN", "AF");
            //    CountryCodes.Add("ALAND ISLANDS", "AX");
            //    CountryCodes.Add("ALBANIA", "AL");
            //    CountryCodes.Add("ALGERIA", "DZ");
            //    CountryCodes.Add("AMERICAN SAMOA", "AS");
            //    CountryCodes.Add("ANDORRA", "AD");
            //    CountryCodes.Add("ANGOLA", "AO");
            //    CountryCodes.Add("ANGUILLA", "AI");
            //    CountryCodes.Add("ANTARCTICA", "AQ");
            //    CountryCodes.Add("ANTIGUA AND BARBUDA", "AG");
            //    CountryCodes.Add("ARGENTINA", "AR");
            //    CountryCodes.Add("ARMENIA", "AM");
            //    CountryCodes.Add("ARUBA", "AW");
            //    CountryCodes.Add("AUSTRALIA", "AU");
            //    CountryCodes.Add("AUSTRIA", "AT");
            //    CountryCodes.Add("AZERBAIJAN", "AZ");
            //    CountryCodes.Add("BAHAMAS", "BS");
            //    CountryCodes.Add("BAHRAIN", "BH");
            //    CountryCodes.Add("BANGLADESH", "BD");
            //    CountryCodes.Add("BARBADOS", "BB");
            //    CountryCodes.Add("BELARUS", "BY");
            //    CountryCodes.Add("BELGIUM", "BE");
            //    CountryCodes.Add("BELIZE", "BZ");
            //    CountryCodes.Add("BENIN", "BJ");
            //    CountryCodes.Add("BERMUDA", "BM");
            //    CountryCodes.Add("BHUTAN", "BT");
            //    CountryCodes.Add("BOLIVIA", "BO");
            //    CountryCodes.Add("BOSNIA - HERZEGOVINA", "BA");
            //    CountryCodes.Add("BOTSWANA", "BW");
            //    CountryCodes.Add("BOUVET ISLAND", "BV");
            //    CountryCodes.Add("BRAZIL", "BR");
            //    CountryCodes.Add("BRITISH INDIAN OCEAN TERRITORY", "IO");
            //    CountryCodes.Add("BRUNEI DARUSSALAM", "BN");
            //    CountryCodes.Add("BULGARIA", "BG");
            //    CountryCodes.Add("BURKINA FASO", "BF");
            //    CountryCodes.Add("BURUNDI", "BI");
            //    CountryCodes.Add("CAMBODIA", "KH");
            //    CountryCodes.Add("CAMEROON", "CM");
            //    CountryCodes.Add("CANADA", "CA");
            //    CountryCodes.Add("CAPE VERDE", "CV");
            //    CountryCodes.Add("CAYMAN ISLANDS", "KY");
            //    CountryCodes.Add("CENTRAL AFRICAN REPUBLIC", "CF");
            //    CountryCodes.Add("CHAD", "TD");
            //    CountryCodes.Add("CHILE", "CL");
            //    CountryCodes.Add("CHINA", "CN");
            //    CountryCodes.Add("CHRISTMAS ISLAND", "CX");
            //    CountryCodes.Add("COCOS (KEELING) ISLANDS", "CC");
            //    CountryCodes.Add("COLOMBIA", "CO");
            //    CountryCodes.Add("COMOROS", "KM");
            //    CountryCodes.Add("CONGO", "CG");
            //    CountryCodes.Add("CONGO, THE DEMOCRATIC REPUBLIC OF THE", "CD");
            //    CountryCodes.Add("COOK ISLANDS", "CK");
            //    CountryCodes.Add("COSTA RICA", "CR");
            //    CountryCodes.Add("COTE D IVOIRE", "CI");
            //    CountryCodes.Add("CROATIA", "HR");
            //    CountryCodes.Add("CUBA", "CU");
            //    CountryCodes.Add("CYPRUS", "CY");
            //    CountryCodes.Add("CZECH REPUBLIC", "CZ");
            //    CountryCodes.Add("DENMARK", "DK");
            //    CountryCodes.Add("DJIBOUTI", "DJ");
            //    CountryCodes.Add("DOMINICA", "DM");
            //    CountryCodes.Add("DOMINICAN REPUBLIC", "DO");
            //    CountryCodes.Add("ECUADOR", "EC");
            //    CountryCodes.Add("EGYPT", "EG");
            //    CountryCodes.Add("EL SALVADOR", "SV");
            //    CountryCodes.Add("EQUATORIAL GUINEA", "GQ");
            //    CountryCodes.Add("ERITREA", "ER");
            //    CountryCodes.Add("ESTONIA", "EE");
            //    CountryCodes.Add("ETHIOPIA", "ET");
            //    CountryCodes.Add("FALKLAND ISLANDS (MALVINAS)", "FK");
            //    CountryCodes.Add("FAROE ISLANDS", "FO");
            //    CountryCodes.Add("FIJI", "FJ");
            //    CountryCodes.Add("FINLAND", "FI");
            //    CountryCodes.Add("FRANCE", "FR");
            //    CountryCodes.Add("FRENCH GUIANA", "GF");
            //    CountryCodes.Add("FRENCH POLYNESIA", "PF");
            //    CountryCodes.Add("FRENCH SOUTHERN TERRITORIES", "TF");
            //    CountryCodes.Add("GABON", "GA");
            //    CountryCodes.Add("GAMBIA", "GM");
            //    CountryCodes.Add("GEORGIA", "GE");
            //    CountryCodes.Add("GERMANY", "DE");
            //    CountryCodes.Add("GHANA", "GH");
            //    CountryCodes.Add("GIBRALTAR", "GI");
            //    CountryCodes.Add("GREECE", "GR");
            //    CountryCodes.Add("GREENLAND", "GL");
            //    CountryCodes.Add("GRENADA", "GD");
            //    CountryCodes.Add("GUADELOUPE", "GP");
            //    CountryCodes.Add("GUAM", "GU");
            //    CountryCodes.Add("GUATEMALA", "GT");
            //    CountryCodes.Add("GUINEA", "GN");
            //    CountryCodes.Add("GUINEA-BISSAU", "GW");
            //    CountryCodes.Add("GUYANA", "GY");
            //    CountryCodes.Add("HAITI", "HT");
            //    CountryCodes.Add("HEARD ISLAND AND MCDONALD ISLANDS", "HM");
            //    CountryCodes.Add("HOLY SEE (VATICAN CITY STATE)", "VA");
            //    CountryCodes.Add("HONDURAS", "HN");
            //    CountryCodes.Add("HONG KONG", "HK");
            //    CountryCodes.Add("HUNGARY", "HU");
            //    CountryCodes.Add("ICELAND", "IS");
            //    CountryCodes.Add("INDIA", "IN");
            //    CountryCodes.Add("INDONESIA", "ID");
            //    CountryCodes.Add("IRAN, ISLAMIC REPUBLIC OF", "IR");
            //    CountryCodes.Add("IRAQ", "IQ");
            //    CountryCodes.Add("IRELAND", "IE");
            //    CountryCodes.Add("ISRAEL", "IL");
            //    CountryCodes.Add("ITALY", "IT");
            //    CountryCodes.Add("JAMAICA", "JM");
            //    CountryCodes.Add("JAPAN", "JP");
            //    CountryCodes.Add("JORDAN", "JO");
            //    CountryCodes.Add("KAZAKHSTAN", "KZ");
            //    CountryCodes.Add("KENYA", "KE");
            //    CountryCodes.Add("KIRIBATI", "KI");
            //    CountryCodes.Add("KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KP");
            //    CountryCodes.Add("KOREA, REPUBLIC OF", "KR");
            //    CountryCodes.Add("KUWAIT", "KW");
            //    CountryCodes.Add("KYRGYZSTAN", "KG");
            //    CountryCodes.Add("LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LA");
            //    CountryCodes.Add("LATVIA", "LV");
            //    CountryCodes.Add("LEBANON", "LB");
            //    CountryCodes.Add("LESOTHO", "LS");
            //    CountryCodes.Add("LIBERIA", "LR");
            //    CountryCodes.Add("LIBYAN ARAB JAMAHIRIYA", "LY");
            //    CountryCodes.Add("LIECHTENSTEIN", "LI");
            //    CountryCodes.Add("LITHUANIA", "LT");
            //    CountryCodes.Add("LUXEMBOURG", "LU");
            //    CountryCodes.Add("MACAO", "MO");
            //    CountryCodes.Add("MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF", "MK");
            //    CountryCodes.Add("MADAGASCAR", "MG");
            //    CountryCodes.Add("MALAWI", "MW");
            //    CountryCodes.Add("MALAYSIA", "MY");
            //    CountryCodes.Add("MALDIVES", "MV");
            //    CountryCodes.Add("MALI", "ML");
            //    CountryCodes.Add("MALTA", "MT");
            //    CountryCodes.Add("MARSHALL ISLANDS", "MH");
            //    CountryCodes.Add("MARTINIQUE", "MQ");
            //    CountryCodes.Add("MAURITANIA", "MR");
            //    CountryCodes.Add("MAURITIUS", "MU");
            //    CountryCodes.Add("MAYOTTE", "YT");
            //    CountryCodes.Add("MEXICO", "MX");
            //    CountryCodes.Add("MICRONESIA, FEDERATED STATES OF", "FM");
            //    CountryCodes.Add("MOLDOVA, REPUBLIC OF", "MD");
            //    CountryCodes.Add("MONACO", "MC");
            //    CountryCodes.Add("MONGOLIA", "MN");
            //    CountryCodes.Add("MONTSERRAT", "MS");
            //    CountryCodes.Add("MOROCCO", "MA");
            //    CountryCodes.Add("MOZAMBIQUE", "MZ");
            //    CountryCodes.Add("MYANMAR", "MM");
            //    CountryCodes.Add("NAMIBIA", "NA");
            //    CountryCodes.Add("NAURU", "NR");
            //    CountryCodes.Add("NEPAL", "NP");
            //    CountryCodes.Add("NETHERLANDS", "NL");
            //    CountryCodes.Add("NETHERLANDS ANTILLES", "AN");
            //    CountryCodes.Add("NEW CALEDONIA", "NC");
            //    CountryCodes.Add("NEW ZEALAND", "NZ");
            //    CountryCodes.Add("NICARAGUA", "NI");
            //    CountryCodes.Add("NIGER", "NE");
            //    CountryCodes.Add("NIGERIA", "NG");
            //    CountryCodes.Add("NIUE", "NU");
            //    CountryCodes.Add("NORFOLK ISLAND", "NF");
            //    CountryCodes.Add("NORTHERN MARIANA ISLANDS", "MP");
            //    CountryCodes.Add("NORWAY", "NO");
            //    CountryCodes.Add("OMAN", "OM");
            //    CountryCodes.Add("PAKISTAN", "PK");
            //    CountryCodes.Add("PALAU", "PW");
            //    CountryCodes.Add("PALESTINIAN TERRITORY, OCCUPIED", "PS");
            //    CountryCodes.Add("PANAMA", "PA");
            //    CountryCodes.Add("PAPUA NEW GUINEA", "PG");
            //    CountryCodes.Add("PARAGUAY", "PY");
            //    CountryCodes.Add("PERU", "PE");
            //    CountryCodes.Add("PHILIPPINES", "PH");
            //    CountryCodes.Add("PITCAIRN", "PN");
            //    CountryCodes.Add("POLAND", "PL");
            //    CountryCodes.Add("PORTUGAL", "PT");
            //    CountryCodes.Add("PUERTO RICO", "PR");
            //    CountryCodes.Add("QATAR", "QA");
            //    CountryCodes.Add("REUNION", "RE");
            //    CountryCodes.Add("ROMANIA", "RO");
            //    CountryCodes.Add("RUSSIAN FEDERATION", "RU");
            //    CountryCodes.Add("RWANDA", "RW");
            //    CountryCodes.Add("SAINT HELENA", "SH");
            //    CountryCodes.Add("SAINT KITTS AND NEVIS", "KN");
            //    CountryCodes.Add("SAINT LUCIA", "LC");
            //    CountryCodes.Add("SAINT PIERRE AND MIQUELON", "PM");
            //    CountryCodes.Add("SAINT VINCENT AND THE GRENADINES", "VC");
            //    CountryCodes.Add("SAMOA", "WS");
            //    CountryCodes.Add("SAN MARINO", "SM");
            //    CountryCodes.Add("SAO TOME AND PRINCIPE", "ST");
            //    CountryCodes.Add("SAUDI ARABIA", "SA");
            //    CountryCodes.Add("SENEGAL", "SN");
            //    CountryCodes.Add("SERBIA AND MONTENEGRO", "CS");
            //    CountryCodes.Add("SEYCHELLES", "SC");
            //    CountryCodes.Add("SIERRA LEONE", "SL");
            //    CountryCodes.Add("SINGAPORE", "SG");
            //    CountryCodes.Add("SLOVAKIA", "SK");
            //    CountryCodes.Add("SLOVENIA", "SI");
            //    CountryCodes.Add("SOLOMON ISLANDS", "SB");
            //    CountryCodes.Add("SOMALIA", "SO");
            //    CountryCodes.Add("SOUTH AFRICA", "ZA");
            //    CountryCodes.Add("SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "GS");
            //    CountryCodes.Add("SPAIN", "ES");
            //    CountryCodes.Add("SRI LANKA", "LK");
            //    CountryCodes.Add("SUDAN", "SD");
            //    CountryCodes.Add("SURINAME", "SR");
            //    CountryCodes.Add("SVALBARD AND JAN MAYEN", "SJ");
            //    CountryCodes.Add("SWAZILAND", "SZ");
            //    CountryCodes.Add("SWEDEN", "SE");
            //    CountryCodes.Add("SWITZERLAND", "CH");
            //    CountryCodes.Add("SYRIAN ARAB REPUBLIC", "SY");
            //    CountryCodes.Add("台湾", "TW");
            //    CountryCodes.Add("TAIWAN, PROVINCE OF CHINA", "TW");
            //    CountryCodes.Add("TAIWAN, REPUBLIC OF CHINA", "TW");
            //    CountryCodes.Add("TAIWAN", "TW");
            //    CountryCodes.Add("TAJIKISTAN", "TJ");
            //    CountryCodes.Add("TANZANIA, UNITED REPUBLIC OF", "TZ");
            //    CountryCodes.Add("THAILAND", "TH");
            //    CountryCodes.Add("THE NETHERLANDS", "NL");
            //    CountryCodes.Add("TIMOR-LESTE", "TL");
            //    CountryCodes.Add("TOGO", "TG");
            //    CountryCodes.Add("TOKELAU", "TK");
            //    CountryCodes.Add("TONGA", "TO");
            //    CountryCodes.Add("TRINIDAD AND TOBAGO", "TT");
            //    CountryCodes.Add("TUNISIA", "TN");
            //    CountryCodes.Add("TURKEY", "TR");
            //    CountryCodes.Add("TURKMENISTAN", "TM");
            //    CountryCodes.Add("TURKS AND CAICOS ISLANDS", "TC");
            //    CountryCodes.Add("TUVALU", "TV");
            //    CountryCodes.Add("UGANDA", "UG");
            //    CountryCodes.Add("UKRAINE", "UA");
            //    CountryCodes.Add("UNITED ARAB EMIRATES", "AE");
            //    CountryCodes.Add("UNITED KINGDOM", "GB");
            //    CountryCodes.Add("UK", "GB");
            //    CountryCodes.Add("UNITED STATES", "US");
            //    CountryCodes.Add("US", "US");
            //    CountryCodes.Add("USA", "US");
            //    CountryCodes.Add("UNITED STATES MINOR OUTLYING ISLANDS", "UM");
            //    CountryCodes.Add("URUGUAY", "UY");
            //    CountryCodes.Add("UZBEKISTAN", "UZ");
            //    CountryCodes.Add("VANUATU", "VU");
            //    CountryCodes.Add("VENEZUELA", "VE");
            //    CountryCodes.Add("VIET NAM", "VN");
            //    CountryCodes.Add("VIRGIN ISLANDS, BRITISH", "VG");
            //    CountryCodes.Add("VIRGIN ISLANDS, U.S.", "VI");
            //    CountryCodes.Add("WALLIS AND FUTUNA", "WF");
            //    CountryCodes.Add("WESTERN SAHARA", "EH");
            //    CountryCodes.Add("YEMEN", "YE");
            //    CountryCodes.Add("ZAMBIA", "ZM");
            //    CountryCodes.Add("ZIMBABWE", "ZW");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region CreateReferenceNumber; Order JObject,
            //string init = "CUST-PEK-CN-1809";
            //byte[] init_b = Encoding.ASCII.GetBytes(init);

            //var base64 = Convert.ToBase64String(init_b);
            //Console.WriteLine(base64);

            //Console.WriteLine(DateTime.Now.ToString("yyMM"));

            //var checksum = GetChecksum(init);
            //Console.WriteLine(checksum);

            //var temp = 123;
            //var s_temp = temp.ToString().PadLeft(2, '0');
            //Console.WriteLine(s_temp);

            //var value = "01";
            //int seq = int.Parse(value);
            //Console.WriteLine(seq);

            //var file_name = @"D:\cities.csv";
            //using (StreamReader reader = new StreamReader(file_name))
            //{
            //    List<string> sb = new List<string>();
            //    while (reader.Peek() != -1)
            //    {
            //        var line = reader.ReadLine();
            //        var elements = line.Split(',');
            //        sb.Add($"CityCodes.Add(\"{elements[0].Trim().Trim(',')}\", \"{elements[1].Trim().Trim(',')}\");");
            //    }
            //    File.WriteAllLines("D:\\CityC.txt", sb);
            //}


            //string jsonString3 = "{\"Site\": [{\"Id\": \"37ycgnzn3\"}],\"Product\": [{\"Id\": \"32ymy7c43\"}],\"ProductFamily\": [{\"Id\": \"zya949c73\"}],\"Service\": [{ \"Id\": \"6fxvdr253\"}],\"Sequence\": 3,\"DiscountPercentage\": 0.3}";
            //string jsonString2 = "{\"Site\": [{\"Id\": \"37ycgnzn2\"}],\"Product\": [{\"Id\": \"32ymy7c42\"}],\"ProductFamily\": [{\"Id\": \"zya949c72\"}],\"Service\": [{ \"Id\": \"6fxvdr252\"}],\"Sequence\": 2,\"DiscountPercentage\": 0.2}";
            //string jsonString1 = "{\"Site\": [{\"Id\": \"37ycgnzn\"}],\"Product\": [{\"Id\": \"32ymy7c4\"}],\"ProductFamily\": [{\"Id\": \"zya949c7\"}],\"Service\": [{ \"Id\": \"6fxvdr25\"}],\"Sequence\": 1,\"DiscountPercentage\": 0.1}";
            //List<JObject> list = new List<JObject>();
            //list.Add(JObject.Parse(jsonString3));
            //list.Add(JObject.Parse(jsonString2));
            //list.Add(JObject.Parse(jsonString1));

            //var new_list = list.OrderBy(d => Convert.ToInt32(d["Sequence"].ToString()));
            #endregion

            #region DateTime parse from ISO8601 format 
            ////string dt = "2018-09-25T16:49:20.026ZT00:00:00";// Fail
            //string dt = "2018-10-18T03:05:35.9826363+00:00";
            ////string dt = "2018-10-31T03:05:35.9826445Z"; // Successful
            //DateTime dtObject;
            ////if( DateTime.TryParse(dt, null,System.Globalization.DateTimeStyles.RoundtripKind, out dtObject))
            //if( DateTime.TryParse(dt, null,System.Globalization.DateTimeStyles.RoundtripKind, out dtObject))
            //{
            //    Console.WriteLine("Successful.");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}
            #endregion

            #region DateTime ToString ISO8601 Fomrat
            //Console.WriteLine(DateTime.UtcNow.ToString("o")); //2019-12-02T07:04:51.4021600Z
            //Console.WriteLine(DateTime.UtcNow.ToString("s")); //2019-12-02T07:04:51
            //Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssK")); //2019-12-02T07:04:51Z
            #endregion

            #region Quote CFD formula
            //Regex reg = new Regex(@"\w*\[\w+\]\w*");
            // Match
            //string test0 = "[Price]*[Quantity]*[Discount]";
            //string test1 = "[Price] * [Quantity] * [Discount]";
            //string test2 = "[Price] * [Quantity]";
            //string test3 = "[Price] * 2";
            //string test4 = "2 * [Price]";

            //// Mismatch
            //string test5 = "Price]";
            //string test6 = "Price";
            //string test7 = "2*[Price";

            //Console.WriteLine(reg.IsMatch(test0));
            //MatchCollection matches_0 = reg.Matches(test0);
            //foreach (var m in matches_0)
            //{
            //    Console.WriteLine(m.ToString());
            //}

            //Console.WriteLine(reg.IsMatch(test1));
            //MatchCollection matches = reg.Matches(test1);
            //foreach (var m in matches)
            //{
            //    Console.WriteLine(m.ToString());
            //}

            //Console.WriteLine(reg.IsMatch(test2));
            //Console.WriteLine(reg.IsMatch(test3));
            //Console.WriteLine(reg.IsMatch(test4));

            //Console.WriteLine(reg.IsMatch(test5));
            //Console.WriteLine(reg.IsMatch(test6));
            //Console.WriteLine(reg.IsMatch(test7));
            #endregion

            #region Temp1
            //string express_string = "100 * 5 - 2";
            //string result = new DataTable().Compute(express_string, null).ToString();

            //Console.WriteLine(result);

            //JArray test = JArray.Parse("\"Site\": [{\"Id\": \"37ycgnzn\"}]");

            //byte[] data;
            //using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            //{
            //    data = new byte[8];
            //    crypto.GetBytes(data);
            //}
            //Console.WriteLine(string.Join("-", data));
            #endregion

            #region JSON Object Parse
            //Console.WriteLine(DateTime.Now.ToString("MMdd"));
            //Console.WriteLine(DateTime.Now.ToString("yyMMdd"));

            //var content = File.ReadAllText("quote_header.json");
            //var data = JObject.Parse(content);
            //var companyObject = data["Company"]; // Not null

            //Tuple<bool, JObject> testObject = new Tuple<bool, JObject>(true, data);
            //Console.WriteLine(testObject.ToString());
            //var customer1 = data.SelectToken("Company.Name").ToString();
            //var customer2 = data.SelectToken("Company.Name", false).ToString();

            //Console.WriteLine(DateTime.UtcNow.ToString("o"));


            //var jObj = new JObject()
            //{
            //    {"Test","fff" }
            //};

            //object test = null;
            //var jObj = JObject.FromObject(new
            //{
            //    noname = test,
            //    another = new { T1 = "teet1" }
            //});

            //////var testObject = jObj.GetValue("Test")?.ToString();
            ////var testObject = jObj.SelectToken("Test")?.ToString();
            //var test1Object = jObj.SelectToken("empty.T2")?.ToString();

            //var nonname = jObj.GetValue("noname")?.ToString();
            //if (nonname == "Inhouse")
            //{
            //    Console.WriteLine("null");
            //}
            //string new_one = nonname ?? string.Empty;
            //double result = Convert.ToDouble(nonname);
            //if (nonname == "")
            //{
            //    Console.WriteLine("equal null?");
            //}

            #endregion

            #region Temp2
            //string target = "Dear Sir, \\nThank you for your inquiry. We are pleased to supply our quotation as follows:";
            //var new_value = target.Replace("\n", " ");
            //Console.WriteLine(new_value);

            //int init = 1;
            //object init_object = (object)init;
            ////var dest = init_object as string;
            //var dest = init_object.ToString();
            //Console.WriteLine(dest);

            //var newId = Guid.NewGuid().ToString();
            //Console.WriteLine(newId);

            //double t1 = 76;
            //double t2 = 75.3;
            //double t3 = 74.567;

            //Console.WriteLine(t1.ToString("F"));
            //Console.WriteLine(t2.ToString("F"));
            //Console.WriteLine(t3.ToString("F"));
            #endregion

            #region Culture Investigation
            //var nonNeutralCultures = GetNonNeutralCultureInfos();
            //var culture = GetCultureInfo(null, null);
            //var culture = GetCultureInfo("GB", "GBP");

            //DisplayCultureInfo();
            //CheckCultureInfo();
            //GetCultureInfoForNeutralCulture();

            //Dictionary<string, CultureInfo> ISOCurrenciesToACultureMap = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            //    .Select(c => new { c, new RegionInfo(c.LCID).ISOCurrencySymbol })
            //    .GroupBy(x => x.ISOCurrencySymbol)
            //    .ToDictionary(g => g.Key, g => g.First().c, StringComparer.OrdinalIgnoreCase);

            //var maaping = MappingCurrency();

            //var culture = GetCultureInfos("GBP");
            //double target = 1234567.23;
            //foreach (var cul in culture)
            //{
            //    var formatted = target.ToString("C", cul);
            //    Console.WriteLine($"Culture:{cul.Name}::{formatted}");
            //}

            #endregion

            #region Currency Format
            //double c1 = 767676;
            //double c2 = 7575.3;
            //double c3 = 7474.567;

            //Console.WriteLine(c1.ToString("C", culture));
            //Console.WriteLine(c2.ToString("C", culture));
            //Console.WriteLine(c3.ToString("C", culture));

            //Console.WriteLine($"== {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")} ==");

            #endregion

            #region StopWatch
            //var stopWatch = new Stopwatch();
            //stopWatch.Start();

            //Thread.Sleep(500);
            //Console.WriteLine($"1.Elapsed: {stopWatch.ElapsedMilliseconds}ms");

            //Thread.Sleep(1500);
            //Console.WriteLine($"2. Elapsed: {stopWatch.ElapsedMilliseconds}ms");

            //Thread.Sleep(800);
            //stopWatch.Stop();
            //Console.WriteLine($"Elapsed: {stopWatch.ElapsedMilliseconds}ms");
            #endregion

            #region JSON SelectToken
            //try
            //{
            //    var jobj = JObject.FromObject(new
            //    {
            //        Test1 = "test1",
            //        Test2 = new { Test2Sub = "Test2Sub" },
            //        Test3 = new
            //        {
            //            Test3Sub = new { ObjToRemove = "toberemoved" },
            //            Test3Text = "RemoveNode"
            //        }
            //    });

            //    var tempTest3 = jobj.SelectToken("Test3.Test3Sub")?.ToObject<JObject>();

            //    var subObject = jobj.GetValue("Test3")?.ToObject<JObject>();
            //    subObject.Remove("Test3Sub");
            //    jobj["Test3"] = subObject;

            //    Console.WriteLine(jobj.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Random
            //Random random1 = new Random(); // 10
            //Console.WriteLine(random1.Next());
            //random1 = new Random();
            //Console.WriteLine(random1.Next());
            //random1 = new Random();
            //Console.WriteLine(random1.Next());
            //random1 = new Random();
            //Console.WriteLine(random1.Next());

            //Random random2 = new Random(); // 10
            //int count = 0;
            //while (count++ < 10)
            //{
            //    //var time = random.Next(1, 20);
            //    var r1 = random1.Next();
            //    var r2 = random2.Next();
            //    Console.WriteLine($"1:{r1}");
            //    Console.WriteLine($"2:{r2}");
            //}
            #endregion

            #region UtcNow.ToString("o")
            //Console.WriteLine(DateTime.Now.ToString("o"));
            //Console.WriteLine(DateTime.UtcNow.ToString("o"));
            #endregion

            #region Test Parallel

            //0123456789
            //Parallel.ForEach("12345678".ToCharArray(), new ParallelOptions { MaxDegreeOfParallelism = 8 }, a =>
            //{
            //    Console.WriteLine($"===[{a}][{DateTime.UtcNow.ToString()}]Calling cfd api.");

            //    HttpClient client = new HttpClient
            //    {
            //        BaseAddress = new Uri("https://8xocktxfyb.execute-api.eu-west-1.amazonaws.com/")
            //    };
            //    client.DefaultRequestHeaders.Add("x-session-id", "ed11b479-bfa9-430e-ab34-1767e70c0de8");
            //    client.DefaultRequestHeaders.Add("Referer", "https://stg.ironbridge.io/quoteheader?id=ysanftyu");//82hb9x64
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    var input = new JObject()
            //    {
            //        { "QuoteHeaderID", "ysanftyu" }
            //    };
            //    var content = new StringContent(input.ToString(), Encoding.UTF8, "application/json");

            //    HttpResponseMessage response = client.PostAsync($"stg/quote/cfd/new", content).Result;
            //    Console.WriteLine($"===[{a}]cfd/new response:{response.StatusCode.ToString()}");

            //    HttpClient statusClient = new HttpClient
            //    {
            //        BaseAddress = new Uri("https://8xocktxfyb.execute-api.eu-west-1.amazonaws.com/")
            //    };
            //    statusClient.DefaultRequestHeaders.Add("x-session-id", "ed11b479-bfa9-430e-ab34-1767e70c0de8");
            //    statusClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    bool isGenerated = false;
            //    var resultObject = new JObject();
            //    int count = 0;
            //    while (isGenerated == false && count < 90)
            //    {
            //        HttpResponseMessage statusResponse = client.GetAsync($"stg/quote/document/status/ysanftyu").Result;
            //        var result = statusResponse.Content.ReadAsStringAsync().Result;
            //        resultObject = JObject.Parse(result);
            //        isGenerated = resultObject.GetValue("Status")?.ToString() == "Generated";
            //        Console.WriteLine($"===[{a}][{DateTime.UtcNow.ToString()}]::STATUS::{result}");
            //        count++;
            //        Thread.Sleep(60000);
            //    }
            //    if (isGenerated)
            //    {
            //        Console.WriteLine($"===[{a}][{DateTime.UtcNow.ToString()}]SUCCESS::{resultObject}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"===[{a}][{DateTime.UtcNow.ToString()}]FAIL::{resultObject}");
            //    }
            //});

            //Console.WriteLine("Executed.");

            #endregion

            #region Task.Run()
            //Console.WriteLine($"===0===[{DateTime.Now.ToString()}]");

            //Task.Run(()=> {
            //    var response = ReadBaidu().Result;
            //});

            //Console.WriteLine($"===10===[{DateTime.Now.ToString()}]");
            #endregion

            #region JSON JArray
            //string source = "Hi, \n\nThis is a test string. \nThis is another test string. \n\nBest Regards, \nName";
            //var test = source.Split(new string[] { "\n" }, StringSplitOptions.None);
            //Console.WriteLine(test);

            //int count = 6814;
            //int number = (int)Math.Ceiling((double)count / 100);
            //Console.WriteLine(number);

            //var jarr = new JArray();
            //jarr.Add("test1");
            //jarr.Add("test2");
            //jarr.Add("test3");
            //var jobj = new JObject();
            //jObj.Add("Comments", jarr);

            //foreach (var ar in jarr)
            //{
            //    Console.WriteLine(ar.ToString());
            //}

            //var commentList = new List<string>();
            //var result = string.Join("\n", commentList.ToArray());

            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmm")); 
            #endregion

            #region JSON Parse
            //var testObject = JObject.FromObject(new {
            //    Forename = "tester"
            //});


            //var testJAObject = new JArray("note1", "note2");
            //var result = string.Join("\r\n", testJAObject);

            ////var name = testObject.GetValue("Forename")?.ToString();
            //var name = testObject.GetValue("Surname")?.ToString();

            //Console.WriteLine($"result:{name}");

            #endregion

            #region Remove Invalid Characters for Reference Numer

            //string manuf = "D+M Manufacturer";
            //string anotherManuf = "A   B   C   D";

            //var manufName = GetShortName(manuf);
            //Console.WriteLine(manufName);

            //var anotherManufName = GetShortName(anotherManuf);
            //Console.WriteLine(anotherManufName);

            //string illegal = "\"M\"\\a/r+y/ h**ad:>> a\\/:*?\"| li*tt|l+e|| la\"mb.?";
            //string illegal = "\"M\"\\a/r+&@[{,$=;^'#%~]`\\/:*?<>|}y/ h**ad:>> a\\/:*?\"| li*tt|l+e|| la\"mb.?";
            //string illegal = "J $ ?@ 01 K technology";
            //var result = RemoveInvalidCharactersExt(illegal);
            //var result = RemoveInvalidCharacter(illegal);
            //var result = RemoveInvalidCharactersPattern(illegal);
            //var result = KeepValidCharacters(illegal);

            //Console.WriteLine(result);

            //Console.WriteLine(new string(Path.GetInvalidFileNameChars()));
            //Console.WriteLine(new string(Path.GetInvalidPathChars()));

            //TestCharMethods();

            //var fileName = "Formal_D+M -LET-GB-191014-A6-01_201910141358_LesleyL.pdf";
            //var result = $"https://s3-eu-west-1.amazonaws.com/cfd.prod.ironbridge.keysight.com/quoting_cfd/{HttpUtility.UrlEncode(fileName)}";
            //Console.WriteLine(result);

            //char nullChar = (char)0x0000;

            //var testCharString = new string(new char[] { nullChar });

            //Console.WriteLine(testCharString);

            #endregion

            #region Polymorphism
            //var shapes = new List<Shape>
            //{
            //    new Rectangle(),
            //    new Triangle(),
            //    new Circle()
            //};

            //// Polymorphism at work #2: the virtual method Draw is
            //// invoked on each of the derived classes, not the base class.
            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}

            //// Keep the console open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            #endregion

            #region JSON JObject parse
            //SubCustomArray instance = new SubCustomArray();
            //var inputs = new string[] { "test1", "test2" };

            //instance.AddAll(inputs.AsEnumerable());

            //string url = "https://s3.eu-west-1.amazonaws.com/cfd.stg.ironbridge.keysight.com/quoting_cfd/Formal_KEYS-710-DE-191203-2F-01_201912030559_JinbaoG.pdf";
            //var filename = Path.GetFileName(url);
            //Console.WriteLine(filename);

            //XmlDocument xmlDoc = new XmlDocument();
            //string json = @"{
            //  'Email': 'james@example.com',
            //  'Active': true,
            //  'CreatedDate': '2013-01-20T00:00:00Z',
            //  'Roles': [
            //    'User',
            //    'Admin'
            //  ],
            //  'Team': {
            //    '@Id': 2,
            //    'Name': 'Software Developers',
            //    'Description': 'Creators of fine software products and services.'
            //  }
            //}";

            ////XNode node = JsonConvert.DeserializeXNode(json, "Root");
            //XmlDocument node = JsonConvert.DeserializeXmlNode(json, "Root");
            //var declare = node.CreateXmlDeclaration("1.0", "UTF-8", "no");
            //node.PrependChild(declare);
            //node.Save("practise.xml");
            //Console.WriteLine(node.OuterXml);

            //int number = 10;
            //Console.WriteLine($"{number}");

            //string filename = "practise.pdf";
            //var filenameWithoutExtention = Path.GetFileNameWithoutExtension(filename);

            //int pageNumber = 2;
            //int total = 602;
            //double perc = ((double)pageNumber * 100) / (double)total;
            ////int percent1 = Convert.ToInt32(Math.Floor((((double)pageNumber * 100) / (double)total) * 100));
            //int percent1 = (int)((double)pageNumber * 100 / total * 100 * 0.7);

            //Console.WriteLine(percent1);

            ////string result = "{\n  \"StatusCode\": 200,\n  \"Content\": \"{\\\"Data\\\":[]}\"\n}";
            //string result1 = "\"{\n  \"StatusCode\": 200,\n  \"Content\": \"{\\\"Data\\\":[]}\"\n}\"";
            //JObject results = null;
            //try
            //{
            //    var result = result1.Substring(1, result1.Length - 2);
            //    results = JObject.Parse(result);
            //}
            //catch (Exception ex)
            //{
            //    results = new JObject();
            //    throw;
            //} 
            #endregion

            #region ASCII Test
            //string source = "steâ€-A.3â€45-#-_gj";

            //byte[] ascii = Encoding.ASCII.GetBytes(source);
            //int index = 0;
            //foreach (char ch in source)
            //{
            //    Console.WriteLine(ch);
            //    Console.WriteLine(ascii[index]);
            //    Console.WriteLine(Char.GetNumericValue(ch));
            //    Console.WriteLine(Char.IsLetterOrDigit(ch));
            //    Console.WriteLine(Char.GetUnicodeCategory(ch).ToString());
            //    Console.WriteLine("-------------------------------------");
            //    index++;
            //} 
            #endregion

            #region JObject with null element
            //var jobj = new JObject()
            //{
            //    { "Id", null}
            //};

            //List<string> entity_ids = new List<string>();
            //var e_id = jobj.GetValue("Id")?.ToString();
            //entity_ids.Add(e_id); 
            #endregion

            #region Misc
            //string source = "abc<test>ok&pass\"bei'yes";
            //var order = DeserializeServiceOrder();

            //double rate = -30;
            //double quoted_price = 25.0;
            //quoted_price = quoted_price * (1 - rate / 100); 
            #endregion

            #region Base64
            //string userName = Encoding.UTF8.GetString(Convert.FromBase64String("ZnRw"));//"ftp";
            //string password = Encoding.UTF8.GetString(Convert.FromBase64String("IVFBWjJ3c3g=")); //"!QAZ2wsx";

            //Console.WriteLine(userName);
            //Console.WriteLine(password); 
            #endregion

            #region TimeStamp
            ////Console.WriteLine(DateTime.Now.Ticks);

            //Console.WriteLine(DateTime.Now.ToUniversalTime());
            //Console.WriteLine(DateTime.UtcNow.ToString("o"));

            ////var ticks_now = 637382001664525714;
            //////var iccks_now = 177050556017923
            ////var ticks_nwo = 1602566607272;
            //TimeSpan ts = new TimeSpan(621355968000000000);
            //DateTime start = new DateTime(1970, 1, 1);
            //Console.WriteLine(621355968000000000);
            //Console.WriteLine(start.Ticks);
            ////Console.WriteLine(ts.Days);
            ////Console.WriteLine(ts.Hours);
            ////Console.WriteLine(ts.Minutes);
            ////Console.WriteLine(ts.Seconds);
            ////Console.WriteLine(ts.Milliseconds);
            //Console.WriteLine("------------------------");

            ////DateTime dt = new DateTime(ticks);
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToString());
            //Console.WriteLine(dt.ToFileTimeUtc().ToString());
            //Console.WriteLine(dt.Ticks.ToString());

            //var epoch = (dt.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            //Console.WriteLine(epoch);

            //string unixTimestamp = Convert.ToString((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            //Console.WriteLine(unixTimestamp);

            //1603786844
            //1602566607272
            //1603787021
            //1603787098
            //1603787064.168816 
            #endregion

            #region loss of precision
            //decimal dividend = Decimal.One;
            //decimal divisor = 3;
            //var result = dividend / divisor * divisor;
            //Console.WriteLine(result);
            //// The following displays 0.9999999999999999999999999999 to the console
            //Console.WriteLine(dividend / divisor * divisor);

            // loss of precision
            //double d1 = 10000000000000000000000d;
            //d1 += 1;
            //Console.WriteLine(d1); 
            #endregion

            #region Demo volatile
            var worker = new Worker();
            Console.WriteLine("Main thread: Launching work thread");

            var workerTask = Task.Run(worker.DoWork);

            Thread.Sleep(1000);

            Console.WriteLine("Main Thread: Request to terminate work thread");
            worker.RequestStop();

            workerTask.Wait();

            Console.WriteLine("Main Thread: The work thread is terminated.");
            #endregion

            //int a = 249;
            //double b = 2.0131918;
            //double c = 0.3;
            //int d = 1;
            //var value = (a - b - c * b * d) / a;

            //var rValue = Math.Round(value, 0);

            //Console.WriteLine(rValue);

            Console.ReadKey(true);
        }

        private static ServiceOrder DeserializeServiceOrder()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ServiceOrder));
                TextReader reader = new StreamReader("OCPP_1-11653179796-1.xml");
                if (serializer != null)
                {
                    ServiceOrder rptConfig = (ServiceOrder)serializer.Deserialize(reader);
                    reader.Close();
                    return rptConfig;
                }
                else
                {
                    Logger.Instance.Error("GetReportConfiguration Failed");
                    return new ServiceOrder();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void TestCharMethods()
        {
            var invalidSourceString = "][+&@}{,$=;^'#%~`\\/:*?\"><|_- .0123456789aA";
            foreach (var ch in invalidSourceString)
            {
                //Console.WriteLine($"{ch} is letter: {char.IsLetter(ch)}");
                Console.WriteLine($"{ch} is digit or letter: {char.IsLetterOrDigit(ch)}");
            }

            //Console.WriteLine("=======================================================");
            //Console.WriteLine($"V is digit: {char.IsDigit('V')}");
        }

        public static string RemoveInvalidCharacters(string input)
        {
            var invalidSourceString = new string(Path.GetInvalidPathChars()) + new string(Path.GetInvalidFileNameChars());
            Regex reg = new Regex($"[{Regex.Escape(invalidSourceString)}]");
            var result = reg.Replace(input, string.Empty);
            return result;
        }

        public static string RemoveInvalidCharactersExt(string input)
        {
            //input = input.Replace("]", "");
            //var invalidSourceString = "]" + new string(Path.GetInvalidPathChars()) + new string(Path.GetInvalidFileNameChars()) + "+&@[{,$=;^}'#%~`\\/:*?\"<>|"; //+&@[{,$=;^}'#%~`\/:*?"<>|
            var invalidSourceString = "][+&@}{,$=;^'#%~`\\/:*?\"><|";
            Regex reg = new Regex($"[{Regex.Escape(invalidSourceString)}]");
            var result = reg.Replace(input, string.Empty);
            return result;
        }

        public static string RemoveInvalidCharactersPattern(string input)
        {
            Regex reg = new Regex("^[a-zA-Z0-9]+$");
            return reg.Replace(input, string.Empty);
        }

        public static string KeepValidCharacters(string input)
        {
            var result = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());
            return result;
        }

        private static string GetShortName(string manuf)
        {
            string newManuf = manuf.Trim().Replace(" ", "").ToUpper();
            var companyCode = newManuf.Length <= 4 ? newManuf : newManuf.Substring(0, 4);
            return companyCode;
        }

        private static async Task<string> ReadBaidu()
        {
            Console.WriteLine($"===1===[{DateTime.Now.ToString()}]");
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://lcossdo2.cos.is.keysight.com/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            Console.WriteLine($"===2===[{DateTime.Now.ToString()}]");

            var response = await client.GetAsync("cgi-bin/catsApi/catsApi.pl?method=getOCPPHubList&ClientType=CATS");
            Console.WriteLine($"===3 ({response.IsSuccessStatusCode})===[{DateTime.Now.ToString()}]");

            //Task.Run(() =>
            //{
            //    Console.WriteLine($"===3===[{DateTime.Now.ToString()}]");
            //    var response = client.GetAsync("cgi-bin/catsApi/catsApi.pl?method=getOCPPHubList&ClientType=CATS").Result;
            //    Console.WriteLine($"===4===[{DateTime.Now.ToString()}]");
            //});
            Console.WriteLine($"===5===[{DateTime.Now.ToString()}]");
            return string.Empty;
        }

        private static void DisplayCultureInfo()
        {
            var result = new Dictionary<string, string>();
            var missed = new List<string>();

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    result.Add(ci.Name, ci.DisplayName);
                }
                catch
                {
                    missed.Add($"[{ci.Name}] - [{ci.DisplayName}]");
                }
            }
            Console.WriteLine(result.Count);
            Console.WriteLine("=======================");
            Console.WriteLine(missed.Count);
            Console.WriteLine("=======================");

            var dicList = new List<string>();
            foreach (var item in result)
            {
                Console.WriteLine($"[{item.Key}] - [{item.Value}]");
                dicList.Add($"[{item.Key}] - [{item.Value}]");
            }
            File.WriteAllLines("D:\\cultureInfos.txt", dicList.ToArray());
            File.WriteAllLines("D:\\cultureInfos_missed.txt", missed.ToArray());

        }

        private static Dictionary<string, string> MappingCurrency()
        {
            var result = new Dictionary<string, string>();

            foreach (var ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                try
                {
                    var ri = new RegionInfo(ci.Name);

                    result[ri.ISOCurrencySymbol] = ri.CurrencySymbol;
                }
                catch { }
            }

            return result;
        }

        private static void CheckCultureInfo()
        {
            var result = new List<string>();
            result.Add("[{ci.LCID}]-[{ci.DisplayName}]-[{ci.Name}]-[{ri.CurrencyEnglishName}]-[{ri.CurrencySymbol}]-[{ri.ISOCurrencySymbol}]-[{ci.NumberFormat.CurrencyDecimalSeparator}]-[{ci.NumberFormat.CurrencyGroupSeparator}]");
            var missed = new List<string>();

            var targetLans = new List<string>();
            //targetLans.Add("en");
            //targetLans.Add("en-US");
            targetLans.Add("en-GB");
            //targetLans.Add("en-001");
            //targetLans.Add("en-AU");
            //targetLans.Add("en-DE");

            //targetLans.Add("es-ES");
            //targetLans.Add("es-MX");

            //targetLans.Add("fr");
            //targetLans.Add("fr-FR");

            //targetLans.Add("it");
            //targetLans.Add("it-IT");

            //targetLans.Add("pt-BR");
            //targetLans.Add("ja-JP");

            //targetLans.Add("zh-CN");
            //targetLans.Add("zh-TW");

            //targetLans.Add("kr");
            //targetLans.Add("ko-KR");

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    if (!targetLans.Contains(ci.Name)) continue;
                    var ri = new RegionInfo(ci.Name);
                    var data = $"[{ci.LCID}]-[{ci.DisplayName}]-[{ci.Name}]-[{ri.CurrencyEnglishName}]-[{ri.CurrencySymbol}]-[{ri.ISOCurrencySymbol}]-[{ci.NumberFormat.CurrencyDecimalSeparator}]-[{ci.NumberFormat.CurrencyGroupSeparator}]";
                    result.Add(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    missed.Add(ci.Name);
                }
            }
            Console.WriteLine("=======================");
            Console.WriteLine(missed.Count);
            Console.WriteLine("=======================");

            File.WriteAllLines("D:\\cultureInfo_details.txt", result.ToArray());
            File.WriteAllLines("D:\\cultureInfos_details_missed.txt", missed.ToArray());
        }

        private static void GetCultureInfoForNeutralCulture()
        {
            var result = new List<string>();
            var missed = new List<string>();

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //all.Select(c=>c.NumberFormat.CurrencySymbol)
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    if (ci.IsNeutralCulture)
                    {
                        var ri = new RegionInfo(ci.Name);
                        var data = $"[{ci.LCID}]-[{ci.DisplayName}]-[{ci.Name}]-[{ri.CurrencyEnglishName}]-[{ri.CurrencySymbol}]-[{ri.ISOCurrencySymbol}]-[{ci.NumberFormat.CurrencyDecimalSeparator}]-[{ci.NumberFormat.CurrencyGroupSeparator}]";
                        result.Add(data);
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    missed.Add(ci.Name);
                }
            }
            Console.WriteLine("=======================");
            Console.WriteLine(result.Count);
            Console.WriteLine("=======================");

            File.WriteAllLines("D:\\cultureInfo_neutral_details.txt", result.ToArray());
            //File.WriteAllLines("D:\\cultureInfos_details_missed.txt", missed.ToArray());
        }

        private static void MapCultureInfo()
        {
            var result = new List<string>();

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    var ri = new RegionInfo(ci.Name);
                    var data = $"[{ci.LCID}]-[{ci.DisplayName}]-[{ci.Name}]-[{ri.CurrencyEnglishName}]-[{ri.CurrencySymbol}]-[{ri.ISOCurrencySymbol}]";
                    result.Add(data);
                }
                catch { }
            }

            result.ForEach((element) =>
            {
                Console.WriteLine(element);
            });
        }

        private static List<CultureInfo> GetCultureInfos(string countryCodeAlpha2, string currencyCode)
        {
            var result = new List<CultureInfo>();

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    var ri = new RegionInfo(ci.Name);
                    if (ri.TwoLetterISORegionName == countryCodeAlpha2 && ri.ISOCurrencySymbol == currencyCode)
                    {
                        result.Add(ci);
                    }
                }
                catch { }
            }

            return result;
        }

        private static List<CultureInfo> GetCultureInfos(string currencyCode)
        {
            var result = new List<CultureInfo>();

            var all = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine(all.Length);
            foreach (var ci in all)
            {
                try
                {
                    var ri = new RegionInfo(ci.Name);
                    if (ri.ISOCurrencySymbol == currencyCode)
                    {
                        result.Add(ci);
                    }
                }
                catch { }
            }

            return result;
        }

        private static List<CultureInfo> GetNonNeutralCultureInfos()
        {
            var result = new List<CultureInfo>();

            foreach (var ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                try
                {
                    if (ci.IsNeutralCulture) continue;
                    var ri = new RegionInfo(ci.Name);
                    result.Add(ci);
                }
                catch { }
            }

            return result;
        }

        private static CultureInfo GetCultureInfo(string countryCodeAlpha2, string currencyCode)
        {
            foreach (var ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                try
                {
                    var ri = new RegionInfo(ci.Name);
                    if (ri.TwoLetterISORegionName == countryCodeAlpha2 && ri.ISOCurrencySymbol == currencyCode)
                    {
                        return ci;
                    }
                }
                catch { }
            }

            return null; ;
        }

        private static string GetChecksum(string s)
        {
            int checksum = 0;
            foreach (char c in s)
            {
                checksum += Convert.ToByte(c);
            }
            //return checksum.ToString("X4");
            return checksum.ToString("X8");
        }

        private static string GetExcelColumnName(int columnNumber)
        {
            string columnName = String.Empty;
            int modulo;

            while (columnNumber > 0)
            {
                modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                columnNumber = (int)((columnNumber - modulo) / 26);
            }

            return columnName;
        }

        public void GenerateFromJSON()
        {
            string apiurl = "http://demos.componentone.com/ASPNET/C1WebAPIService/api/excel";  //web api demo url 
            var url = "http://services.odata.org/V4/Northwind/Northwind.svc/Products?$format=json";  //get products from ODATA service  

            using (var clientjs = new HttpClient())
            {
                HttpResponseMessage responseJSON = clientjs.GetAsync(url).Result;
                responseJSON.EnsureSuccessStatusCode();
                var responseBody = responseJSON.Content.ReadAsStringAsync().Result;  //Get JSON from ODATA service  

                var jsonObject = JObject.FromObject(JsonConvert.DeserializeObject(responseBody));
                var data = jsonObject["value"];  //use JsonConvert to deserialize raw json  

                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    var fileFormat = "xlsx";
                    formData.Add(new StringContent("Test"), "FileName");
                    formData.Add(new StringContent(fileFormat), "FileFormat");
                    formData.Add(new StringContent(JsonConvert.SerializeObject(data)), "Data");
                    //Call WebAPI to get Excel  
                    var response = client.PostAsync(apiurl, formData).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Invalid response.");
                        return;
                    }
                    var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                    if (!Directory.Exists(tempPath))
                    {
                        Directory.CreateDirectory(tempPath);
                    }
                    //Save Excel to Tem directory.  
                    var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", "Test", fileFormat));
                    using (var newFile = File.Create(tempFilePath))
                    {
                        response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                    }
                    //Open Excel to view.  
                    Process.Start(tempFilePath);
                }
            }
        }

        public static void GenerateFromXML()
        {
            string apiurl = "http://demos.componentone.com/ASPNET/C1WebAPIService/api/excel";  //web api demo url  

            DataTable dt = new System.Data.DataTable();
            dt.TableName = "Products";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Active", typeof(bool));
            dt.Rows.Add(1, "Electronics", true);
            dt.Rows.Add(2, "Food", true);
            dt.Rows.Add(3, "Garments", true);
            dt.Rows.Add(4, "Stationary", true);
            dt.Rows.Add(5, "Antiques", false);

            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, System.Data.XmlWriteMode.IgnoreSchema);
            var fileFormat = "xlsx";

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent("Test"), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                //Save Excel file to Temp directory  
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", "Test", fileFormat));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        private static void FindAllDataSheet()
        {
            string[] allFiles = Directory.GetFiles(@"D:\WCSS_Engineering_STE\STE_SOURCE\SOURCE\MUTS\", "DATA_SHEET", SearchOption.AllDirectories);
            Console.WriteLine(allFiles.Length);
        }

        private static bool isValidUrl(string url_string)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url_string) as HttpWebRequest;
                request.UseDefaultCredentials = true;
                request.PreAuthenticate = true;
                request.Credentials = CredentialCache.DefaultCredentials;
                //request.Credentials = new NetworkCredential("gao00002@keysight.com", "","keysight.com");
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private static void Test(bool isThrowException)
        {
            if (isThrowException)
            {
                throw new Exception("Test Exception.");
            }

            Console.WriteLine("Test Statement!");
        }

        private static string reFormat(string s)
        {
            return string.Format("'{0}'", s);
        }

        private static void LdapCallback(IAsyncResult ar)
        {
            string result = svc.EndldapAuth(ar);
            Console.WriteLine(result);
        }

        private static bool CreateRemoteConnection(string path, string usr, string passwd)
        {
            Console.WriteLine("======Begin CreateRemoteConnection======");
            string parameters = "use \"" + path + "\" " + passwd + @" /user:" + usr;
            ProcessStartInfo createNet = new ProcessStartInfo("net.exe", parameters);

            createNet.RedirectStandardOutput = true;
            createNet.RedirectStandardError = true;
            createNet.CreateNoWindow = true;
            createNet.UseShellExecute = false;
            createNet.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = Process.Start(createNet);
            p.WaitForExit();

            string tmpstr = string.Empty;
            string msg = "";
            string errmsg = "";
            while ((tmpstr = p.StandardOutput.ReadLine()) != null)
            {
                msg += tmpstr + "\r\n";
            }



            while ((tmpstr = p.StandardError.ReadLine()) != null)
            {
                errmsg += tmpstr + "\r\n";
            }
            Console.WriteLine("msg::" + msg);
            Console.WriteLine("errmsg::" + errmsg);
            Console.WriteLine("======End CreateRemoteConnection======");

            if (p.ExitCode == 0) return true;
            else return false;
        }

        private static bool DisconnectRemoteSite(string path)
        {
            System.Diagnostics.ProcessStartInfo createNet = new ProcessStartInfo("net.exe", "use /delete  " + path);

            createNet.RedirectStandardOutput = true;
            createNet.RedirectStandardError = true;
            createNet.CreateNoWindow = true;
            createNet.UseShellExecute = false;
            createNet.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = Process.Start(createNet);
            p.WaitForExit();

            if (p.ExitCode == 0) return true;
            else
            {
                string tmpstr = "";
                string errmsg = "";

                while ((tmpstr = p.StandardError.ReadLine()) != null)
                {
                    errmsg += tmpstr + "\r\n";
                }

                Console.WriteLine(errmsg);

                return false;
            }
        }

        private static int Rsync(string srcPath, string destPath, bool backup, ref string outmsg)
        {
            //
            string m_rsyncServerIP = "lbeisdo9.bei.is.keysight.com";
            string m_moduleName_rsync = "dbuploader";
            //
            string srcPath_win = srcPath;
            string destPath_win = destPath.Replace("/", @"\");

            srcPath = srcPath.Replace(@"\", "/");
            srcPath = srcPath.Replace(":", "");

            destPath = destPath.Replace(@"\", "/");
            destPath = destPath.Replace(":", "");

            System.Diagnostics.ProcessStartInfo rsync;

            if (backup)
            {
                rsync = new ProcessStartInfo("rsync.exe", "-v -rlt -z -b --suffix=_backup --delete --partial \"/cygdrive/" + srcPath + "\"" + " \"" + m_rsyncServerIP + "::" + m_moduleName_rsync + "/" + destPath + "\"");
            }
            else
            {
                rsync = new ProcessStartInfo("rsync.exe", "-v -rlt -z --delete --partial \"/cygdrive/" + srcPath + "\"" + " \"" + m_rsyncServerIP + "::" + m_moduleName_rsync + "/" + destPath + "\"");
            }

            rsync.RedirectStandardOutput = true;
            rsync.RedirectStandardError = true;
            rsync.CreateNoWindow = true;
            rsync.UseShellExecute = false;

            rsync.WindowStyle = ProcessWindowStyle.Hidden;


            Process p = Process.Start(rsync);


            p.PriorityClass = ProcessPriorityClass.BelowNormal;

            string tmpstr = string.Empty;
            string msg = "";
            string errmsg = "";
            outmsg = string.Empty;

            p.WaitForExit(30000);

            while ((tmpstr = p.StandardOutput.ReadLine()) != null)
            {
                msg += tmpstr + "\r\n";
            }


            while ((tmpstr = p.StandardError.ReadLine()) != null)
            {
                errmsg += tmpstr + "\r\n";
            }

            return p.ExitCode;
        }

        private static void ExportEnvironment()
        {
            string mEnvDbFile = @"C:\ocpp\Dev_Dev\environm_1.mdb";
            string mImportFolder = @"C:\ocpp\Dev_Dev";
            string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            OleDbConnection connection = new OleDbConnection(strConnection);
            try
            {
                string cmdString = string.Format("SELECT * INTO [agilent_model.txt] in \"{0}\" \"Text;\" from [agt_model]", mImportFolder);
                //string cmdString = string.Format("INSERT INTO [agt_model] (agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle) SELECT agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle FROM [Text;DATABASE={0}].[{1}]", mImportFolder, "agilent_models.txt");
                OleDbCommand command = new OleDbCommand(cmdString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

        private static void ImportEnvironment()
        {
            string mEnvDbFile = @"C:\ocpp\Dev_Dev\environm.mdb";
            string mImportFolder = @"C:\ocpp\Dev_Dev";
            string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            OleDbConnection connection = new OleDbConnection(strConnection);
            try
            {
                string cmdString = string.Format("SELECT * INTO [agt_model] FROM [agilent_models.txt] IN \"{0}\" \"Text;\"", mImportFolder);
                OleDbCommand command = new OleDbCommand(cmdString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

        private static void ImportEnvironmentExist()
        {
            Stopwatch watch = Stopwatch.StartNew();
            string mEnvDbFile = @"C:\ocpp\Dev_Dev\environm.mdb";
            string mImportFolder = @"C:\ocpp\Dev_Dev";
            string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            OleDbConnection connection = new OleDbConnection(strConnection);
            try
            {
                connection.Open();
                string dropCommand = "DROP TABLE [agt_model]";
                string insertCommand = string.Format("SELECT * INTO [agt_model] FROM [agilent_models.txt] IN \"{0}\" \"Text;\"", mImportFolder);
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                //Drop Table
                command.CommandText = dropCommand;
                command.ExecuteNonQuery();

                //Batch Insert
                command.CommandText = insertCommand;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();

            watch.Stop();
            Console.WriteLine($"It takes: {watch.Elapsed.TotalMilliseconds.ToString()} milliseconds.");
        }

        private static void ExportSystems()
        {
            string mEnvDbFile = @"C:\ocpp\Dev_Dev\environm_1.mdb";
            string mImportFolder = @"C:\ocpp\Dev_Dev";
            string strConnection = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';", mEnvDbFile);
            OleDbConnection connection = new OleDbConnection(strConnection);
            try
            {
                string cmdString = string.Format("SELECT * INTO [system.txt] in \"{0}\" \"Text;\" from [systems]", mImportFolder);
                //string cmdString = string.Format("INSERT INTO [agt_model] (agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle) SELECT agilent_model,mfr_cd,mfr_model,model_descr,model_option,option_descr,cal_cycle FROM [Text;DATABASE={0}].[{1}]", mImportFolder, "agilent_models.txt");
                OleDbCommand command = new OleDbCommand(cmdString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
    }

    public class Worker
    {
        //private volatile bool mShouldStop;
        private bool mShouldStop;

        public void DoWork()
        {
            bool work = false;

            while (!mShouldStop)
            {
                work = !work;
            }

            Console.WriteLine("Work thread: Terminating...");
        }

        public void RequestStop()
        {
            mShouldStop = true;
        }
    }

    public class BaseClass
    {
        public virtual int Age { get; set; } = 1;
    }

    public class DerivedClass : BaseClass
    {
        public override int Age { get; set; } = 2;
    }
}
