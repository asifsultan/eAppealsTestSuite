using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppealTestSuite
{
    class Program
    {

        string filePath = "C:\\eAppeals.xlsx";
        // Browser web reference
        // IWebDriver driver = new ChromeDriver();
        Dictionary<int, string> testResult = new Dictionary<int, string>();
        Dictionary<int, string> errorMessage = new Dictionary<int, string>();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chrome");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            PropertiesCollection.driver.Manage().Window.Maximize();
            testResult.Add(0, "Status");
            errorMessage.Add(0, "Reason of failure");


        }
        [Test]
        public void SubmitFormForPosition()
        {

            List<Datacollection> data = new List<Datacollection>();
            data = ExcelLibrary.PopulateInCollection(filePath, "Position");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(filePath, "Position"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmappdev02:2240/eappeals_form/");


                    Console.WriteLine("Opened URL");




                    AppealsForm form = new AppealsForm();

                    form.FillFormForPosition(ExcelLibrary.ReadData(i, "Examination Position"), ExcelLibrary.ReadData(i, "Examination Number"), ExcelLibrary.ReadData(i, "Examimation Name"), ExcelLibrary.ReadData(i, "Whos Filling"),
                                             ExcelLibrary.ReadData(i, "FName"), ExcelLibrary.ReadData(i, "MName"), ExcelLibrary.ReadData(i, "LName"), ExcelLibrary.ReadData(i, "Aka"),
                                             ExcelLibrary.ReadData(i, "Last 4 SSN"), ExcelLibrary.ReadData(i, "Phone"), ExcelLibrary.ReadData(i, "Mailing Address"), ExcelLibrary.ReadData(i, "City"),
                                             ExcelLibrary.ReadData(i, "State"), ExcelLibrary.ReadData(i, "Zip"), ExcelLibrary.ReadData(i, "Email Address"), ExcelLibrary.ReadData(i, "Confirm Email"),
                                             ExcelLibrary.ReadData(i, "Employee Number"), ExcelLibrary.ReadData(i, "PayRoll"), ExcelLibrary.ReadData(i, "Department"), ExcelLibrary.ReadData(i, "Appeal Issue"),
                                             ExcelLibrary.ReadData(i, "Notification Document"), ExcelLibrary.ReadData(i, "Attachment Details"), ExcelLibrary.ReadData(i, "Remedy")

                        );





                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            PropertiesCollection.driver.Close();

        }

        [Test]
        public void SubmitFormForDisqualification()
        {

            List<Datacollection> data = new List<Datacollection>();
            data = ExcelLibrary.PopulateInCollection(@"C:\eAppeals.xlsx", "Disqualification");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\eAppeals.xlsx", "Disqualification"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmappdev02:2240/eappeals_form/");


                    Console.WriteLine("Opened URL");




                    AppealsForm form = new AppealsForm();

                    form.FillFormForDisqualification(ExcelLibrary.ReadData(i, "Disqualifications"), ExcelLibrary.ReadData(i, "Examination Number"), ExcelLibrary.ReadData(i, "Examimation Name"), 
                                             ExcelLibrary.ReadData(i, "Whos Filling"), ExcelLibrary.ReadData(i, "FName"), ExcelLibrary.ReadData(i, "MName"), ExcelLibrary.ReadData(i, "LName"),
                                             ExcelLibrary.ReadData(i, "Aka"), ExcelLibrary.ReadData(i, "Last 4 SSN"), ExcelLibrary.ReadData(i, "Phone"), ExcelLibrary.ReadData(i, "Mailing Address"), 
                                             ExcelLibrary.ReadData(i, "City"), ExcelLibrary.ReadData(i, "State"), ExcelLibrary.ReadData(i, "Zip"), ExcelLibrary.ReadData(i, "Email Address"), 
                                             ExcelLibrary.ReadData(i, "Confirm Email"), ExcelLibrary.ReadData(i, "Employee Number"), ExcelLibrary.ReadData(i, "PayRoll"), ExcelLibrary.ReadData(i, "Department"), 
                                             ExcelLibrary.ReadData(i, "Appeal Issue"), ExcelLibrary.ReadData(i, "Notification Document"), ExcelLibrary.ReadData(i, "Attachment Details"),
                                             ExcelLibrary.ReadData(i, "Auth Document"), ExcelLibrary.ReadData(i, "Authorization Details"), ExcelLibrary.ReadData(i, "Remedy")

                        );





                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            //PropertiesCollection.driver.Close();

        }

        [Test]
        public void SubmitFormForDiscipline()
        {

            List<Datacollection> data = new List<Datacollection>();
            data = ExcelLibrary.PopulateInCollection(filePath, "Discipline");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(filePath, "Discipline"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmappdev02:2240/eappeals_form/");


                    Console.WriteLine("Opened URL");




                    AppealsForm form = new AppealsForm();

                    form.FillFormForDiscipline(ExcelLibrary.ReadData(i, "Discipline"), ExcelLibrary.ReadData(i, "Examination Number"), ExcelLibrary.ReadData(i, "Examination Name"), ExcelLibrary.ReadData(i, "Whos Filling"), ExcelLibrary.ReadData(i, "FName"), ExcelLibrary.ReadData(i, "MName"), 
                         ExcelLibrary.ReadData(i, "LName"), ExcelLibrary.ReadData(i, "Aka"), ExcelLibrary.ReadData(i, "Last 4 SSN"), ExcelLibrary.ReadData(i, "Phone"),
                         ExcelLibrary.ReadData(i, "Mailing Address"),  ExcelLibrary.ReadData(i, "City"), ExcelLibrary.ReadData(i, "State"), ExcelLibrary.ReadData(i, "Zip"),
                         ExcelLibrary.ReadData(i, "Email Address"), ExcelLibrary.ReadData(i, "Confirm Email"), ExcelLibrary.ReadData(i, "Employee Number"), ExcelLibrary.ReadData(i, "PayRoll"),
                         ExcelLibrary.ReadData(i, "Department"), ExcelLibrary.ReadData(i, "Appeal Issue"), ExcelLibrary.ReadData(i, "Notification Document"), ExcelLibrary.ReadData(i, "Attachment Details"),
                         ExcelLibrary.ReadData(i, "Classification Doc"), ExcelLibrary.ReadData(i, "Classification Desc"), ExcelLibrary.ReadData(i, "Remedy")

                        ); ;





                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            PropertiesCollection.driver.Close();

        }

        [Test]
        public void SubmitFormForOthers()
        {

            List<Datacollection> data = new List<Datacollection>();
            data = ExcelLibrary.PopulateInCollection(filePath, "Others");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(filePath, "Others"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmappdev02:2240/eappeals_form/");


                    Console.WriteLine("Opened URL");




                    AppealsForm form = new AppealsForm();

                    form.FillFormForOthers(ExcelLibrary.ReadData(i, "Examination Position"), ExcelLibrary.ReadData(i, "Whos Filling"), ExcelLibrary.ReadData(i, "FName"), ExcelLibrary.ReadData(i, "MName"), 
                        ExcelLibrary.ReadData(i, "LName"), ExcelLibrary.ReadData(i, "Aka"), ExcelLibrary.ReadData(i, "Last 4 SSN"), ExcelLibrary.ReadData(i, "Phone"), ExcelLibrary.ReadData(i, "Mailing Address"),
                        ExcelLibrary.ReadData(i, "City"), ExcelLibrary.ReadData(i, "State"), ExcelLibrary.ReadData(i, "Zip"), ExcelLibrary.ReadData(i, "Email Address"),
                        ExcelLibrary.ReadData(i, "Confirm Email"), ExcelLibrary.ReadData(i, "Employee Number"), ExcelLibrary.ReadData(i, "PayRoll"), ExcelLibrary.ReadData(i, "Department"),
                        ExcelLibrary.ReadData(i, "Appeal Issue"),  ExcelLibrary.ReadData(i, "Remedy")

                        );





                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            PropertiesCollection.driver.Close();

        }



        [TearDown]
        public void CleanUp()
        {

            try
            {
                OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
                //  PropertiesCollection.driver.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Close the browser");
        }
        //public static string ReadData(int rowNumber, string columnName, List<Datacollection> collectionName)
        //{
        //    try
        //    {
        //        //Retriving Data using LINQ to reduce much of iterations
        //        string data = (from colData in collectionName
        //                       where colData.colName == columnName && colData.rowNumber == rowNumber
        //                       select colData.colValue).SingleOrDefault();

        //        //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
        //        return data.ToString();
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
    }
}
