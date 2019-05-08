using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eAppealTestSuite
{
    class AppealsForm
    {
        public AppealsForm()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        /// <FirstPage>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        

        

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'I Agree')]")]
        public IWebElement BtnIAgree { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Submit')]")]
        public IWebElement SubmitAppeal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Examination-Position for which you applied')]")]
        public IWebElement FirstHeading { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-42")]
        public IWebElement ApplicationRejection { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-43")]
        public IWebElement AppraisalOfPromotability { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-44")]
        public IWebElement EvaluationOfTraining { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-45")]
        public IWebElement Interview { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-46")]
        public IWebElement PerformanceTest { get; set; }


        [FindsBy(How = How.Id, Using = "x-auto-47")]
        public IWebElement VeteranCredit { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-48")]
        public IWebElement WrittenTests { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-49")]
        public IWebElement ComputerAdministeredTests { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Disqualifications')]")]
        public IWebElement SecondHeading { get; set; }


        [FindsBy(How = How.Id, Using = "x-auto-40")]
        public IWebElement Background { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-41")]
        public IWebElement InaccurateDisclosure { get; set; }

        [FindsBy(How = How.Id, Using = "//div[contains(text(), 'Discipline/Personnel Action')]")]
        public IWebElement ThirdHeading { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-30")]
        public IWebElement Suspension { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-31")]
        public IWebElement LayOff { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-32")]
        public IWebElement ProbationaryDischarge { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-33")]
        public IWebElement ProbationaryReduction { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-34")]
        public IWebElement ReductionDueToLayOff { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-35")]
        public IWebElement ReleaseFromTemporaryEmployment { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-36")]
        public IWebElement Transfer { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-37")]
        public IWebElement ClassificationStudy { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-39")]
        public IWebElement Resignation { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-29-input")]
        public IWebElement ExaminationName { get; set; }

        
        [FindsBy(How = How.Id, Using = "x-auto-28-input")]
        public IWebElement ExaminationNumber { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Other')]")]
        public IWebElement FouthHeading { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-50")]
        public IWebElement Others { get; set; }



        [FindsBy(How = How.Id, Using = "x-auto-53")]
        public IWebElement PositionHeadingID { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-52")]
        public IWebElement DisqualificatioHeadingID { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-51")]
        public IWebElement DisciplineHeadingID { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-54")]
        public IWebElement OtherHeadingID { get; set; }


        

        [FindsBy(How = How.Id, Using = "x-auto-55")]
        public IWebElement FillingYourSelf { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-0-input")]
        public IWebElement FName { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-1-input")]
        public IWebElement MName { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-2-input")]
        public IWebElement LName { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-3-input")]
        public IWebElement Aka { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-4-input")]
        public IWebElement LastFourSSN { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-8-input")]
        public IWebElement ContactPhone { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-5-input")]
        public IWebElement MailingAddress { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-6-input")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-7-input")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-10-input")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-11-input")]
        public IWebElement PreferredEmail { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-12-input")]
        public IWebElement ConfirmEmail { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-14-input")]
        public IWebElement EmployeeNumber { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-16-input")]
        public IWebElement Payroll { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-15-input")]
        public IWebElement EmployingDepartment { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Attach Document')]")]
        public IWebElement Attach { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-95")]
        public IWebElement Browse { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-96-input")]
        public IWebElement AttachmentDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Attach Additional Documents')]")]
        public IWebElement AttachAdditional { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-99")]
        public IWebElement BrowseAdditional { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-100-input")]
        public IWebElement DescriptionAdditional { get; set; }

        
        [FindsBy(How = How.Id, Using = "x-auto-57-input")]
        public IWebElement AppealIssue { get; set; }

        [FindsBy(How = How.Id, Using = "x-auto-58-input")]
        public IWebElement Remedy { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Submit')]")]
        public IWebElement SubmitBtn { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Accept and Submit') and @class='GBO-C-SNI   GBO-C-SIJ']")]
        public IWebElement AcceptPopupBtn { get; set; }



        
        public void FillFormForPosition(string examinationPosition, string examinationNumber, string examinationName, string appleant, string fName, string mName, string lName, string aka,
                                        string lastFourSSN, string contactPhone, string mailingAddress, string city, string state, string zip, string email, string cEmail, string empNumber,
                                        string payroll, string department, string appealIssue, string document, string attachmentDesciption,  string remedy
            )
        {
           // SubmitAppeal.Clicks();
            BtnIAgree.Clicks();
           
            PositionHeadingID.Clicks();
            if (examinationPosition == "Application Reject")
            {
                ApplicationRejection.Clicks();
            }
            else if (examinationPosition == "Appraisal of Promotability")
            {
                AppraisalOfPromotability.Clicks();
            }
            else if (examinationPosition == "Evaluation of Training and Experience")
            {
                EvaluationOfTraining.Clicks();
            }
            else if (examinationPosition == "Interview")
            {
                Interview.Clicks();
            }
            else if (examinationPosition == "Performance Test")
            {
                PerformanceTest.Clicks();
            }
            else if (examinationPosition == "Veteran Credit")
            {
                VeteranCredit.Clicks();
            }
            else if (examinationPosition == "Paper-and-Pencil Written Tests")
            {
                WrittenTests.Clicks();
            }
            else if (examinationPosition == "Computer-Administered Tests")
            {
                ComputerAdministeredTests.Clicks();
            }

            ExaminationNumber.SendKeys(examinationNumber);
            ExaminationName.SendKeys(examinationName);
            if(appleant == "Yourself")
            {
                FillingYourSelf.Click();
            }
            FName.EnterText(fName);
            MName.EnterText(mName);
            LName.EnterText(lName);
            Aka.EnterText(aka);
            LastFourSSN.EnterText(lastFourSSN);
            ContactPhone.EnterText(contactPhone);
            MailingAddress.EnterText(mailingAddress);
            City.EnterText(city);
            State.ClearText(state);
            ZipCode.EnterText(zip);
            PreferredEmail.EnterText(email);
            ConfirmEmail.EnterText(cEmail);
            EmployeeNumber.EnterText(empNumber);
            Payroll.EnterText(payroll);
            EmployingDepartment.EnterText(department);
            AppealIssue.EnterText(appealIssue);
            Attach.Clicks();
            Browse.UploadFile(document);
            AttachmentDescription.EnterText(attachmentDesciption);
            Remedy.SendKeys(remedy);
            SubmitBtn.Clicks();
            AcceptPopupBtn.Clicks();

        }

        public void FillFormForDisqualification(string disqulificationType, string examinationNumber, string examinationName, string appleant, string fName, string mName, string lName, string aka,
                                        string lastFourSSN, string contactPhone, string mailingAddress, string city, string state, string zip, string email, string cEmail, string empNumber,
                                        string payroll, string department, string appealIssue, string documentLocation, string attachmentDesciption, string authDoc, string authDocDesc, string remedy
            )
        {
            //SubmitAppeal.Clicks();
            BtnIAgree.Clicks();

            DisqualificatioHeadingID.Clicks();
            if (disqulificationType.Contains("Background"))
            {
                Background.Clicks();


                ExaminationNumber.SendKeys(examinationNumber);
                ExaminationName.SendKeys(examinationName);
                if (appleant == "Yourself")
                {
                    FillingYourSelf.Click();
                }
                waitForPageUntilElementIsVisible(By.Id("x-auto-0-input"), 20);
                FName.EnterText(fName);
                MName.EnterText(mName);
                LName.EnterText(lName);
                Aka.EnterText(aka);
                LastFourSSN.EnterText(lastFourSSN);
                ContactPhone.EnterText(contactPhone);
                MailingAddress.EnterText(mailingAddress);
                City.EnterText(city);
                State.ClearText(state);
                ZipCode.EnterText(zip);
                PreferredEmail.EnterText(email);
                ConfirmEmail.EnterText(cEmail);
                EmployeeNumber.EnterText(empNumber);
                Payroll.EnterText(payroll);
                EmployingDepartment.EnterText(department);
                AppealIssue.EnterText(appealIssue);
                Attach.Clicks();
                Browse.UploadFile(documentLocation);
                AttachmentDescription.EnterText(attachmentDesciption);
                Remedy.SendKeys(remedy);
                SubmitBtn.Clicks();
                AcceptPopupBtn.Clicks();
            }
            else if (disqulificationType.Contains("Inaccurate Disclosure"))
            {
                  InaccurateDisclosure.Clicks();

                ExaminationNumber.SendKeys(examinationNumber);
                ExaminationName.SendKeys(examinationName);
                if (appleant == "Yourself")
                {
                    FillingYourSelf.Click();
                }
                waitForPageUntilElementIsVisible(By.Id("x-auto-0-input"), 10);
                FName.EnterText(fName);
                waitForPageUntilElementIsVisible(By.Id("x-auto-1-input"), 10);
                MName.EnterText(mName);
                LName.EnterText(lName);
                Aka.EnterText(aka);
                LastFourSSN.EnterText(lastFourSSN);
                ContactPhone.EnterText(contactPhone);
                MailingAddress.EnterText(mailingAddress);
                City.EnterText(city);
                State.ClearText(state);
                ZipCode.EnterText(zip);
                PreferredEmail.EnterText(email);
                ConfirmEmail.EnterText(cEmail);
                EmployeeNumber.EnterText(empNumber);
                Payroll.EnterText(payroll);
                EmployingDepartment.EnterText(department);
                AppealIssue.EnterText(appealIssue);
                Attach.Clicks();
                Browse.UploadFile(documentLocation);
                AttachmentDescription.EnterText(attachmentDesciption);
                AttachAdditional.Clicks();
                BrowseAdditional.UploadFile(authDoc);
                DescriptionAdditional.EnterText(authDocDesc);
                Remedy.SendKeys(remedy);
                SubmitBtn.Clicks();
                AcceptPopupBtn.Clicks();
            }
           
           

        }

        public void FillFormForDiscipline(string discipline, string examinationNumber, string examinationName, string appleant, string fName, string mName, string lName, string aka,
                                        string lastFourSSN, string contactPhone, string mailingAddress, string city, string state, string zip, string email, string cEmail, string empNumber,
                                        string payroll, string department, string appealIssue, string notificationDocument, string attachmentDesciption, string classificationDoc, string ClassificationDocDesc, string remedy
            )
        {
            // SubmitAppeal.Clicks();
            BtnIAgree.Clicks();

            DisciplineHeadingID.Clicks();
            if (discipline.Contains("1-5 day Suspension") || discipline.Contains("LayOff") ||
                discipline.Contains("Probationary Discharge") || discipline.Contains("Probationary Reduction") ||
                discipline.Contains("Reduction due to Lay-Off") || discipline.Contains("Release From Temporary Employment") ||
                discipline.Contains("Transfer") || discipline.Contains("Resignation"))
            {
                if (discipline.Contains("1-5 day Suspension"))
                {
                    Suspension.Clicks();
                }
                else if (discipline.Contains("LayOff"))
                {
                    LayOff.Clicks();
                }
                else if (discipline.Contains("Probationary Discharge"))
                {
                    ProbationaryDischarge.Clicks();
                }
                else if (discipline.Contains("Probationary Reduction"))
                {
                    ProbationaryReduction.Clicks();
                }
                else if (discipline.Contains("Reduction due to Lay-Off"))
                {
                    ReductionDueToLayOff.Clicks();
                }
                else if (discipline.Contains("Release From Temporary Employment"))
                {
                    ReleaseFromTemporaryEmployment.Clicks();
                }
                else if (discipline.Contains("Transfer"))
                {
                    Transfer.Clicks();
                }
                else if (discipline.Contains("Resignation"))
                {
                    Resignation.Clicks();
                }
                if (appleant.Contains("Yourself"))
                {
                    FillingYourSelf.Click();
                }
                FName.EnterText(fName);
                MName.EnterText(mName);
                LName.EnterText(lName);
                Aka.EnterText(aka);
                LastFourSSN.EnterText(lastFourSSN);
                ContactPhone.EnterText(contactPhone);
                MailingAddress.EnterText(mailingAddress);
                City.EnterText(city);
                State.ClearText(state);
                ZipCode.EnterText(zip);
                PreferredEmail.EnterText(email);
                ConfirmEmail.EnterText(cEmail);
                EmployeeNumber.EnterText(empNumber);
                Payroll.EnterText(payroll);
                EmployingDepartment.EnterText(department);
                AppealIssue.EnterText(appealIssue);
                Attach.Clicks();
                Browse.UploadFile(notificationDocument);
                AttachmentDescription.EnterText(attachmentDesciption);
                Remedy.SendKeys(remedy);
                SubmitBtn.Clicks();
                AcceptPopupBtn.Clicks();

            }

            else if (discipline.Contains("ClassificationStudy"))
            {
                ClassificationStudy.Clicks();
                ExaminationNumber.SendKeys(examinationNumber);
                ExaminationName.SendKeys(examinationName);
                if (appleant == "Yourself")
                {
                    FillingYourSelf.Click();
                }
                FName.EnterText(fName);
                MName.EnterText(mName);
                LName.EnterText(lName);
                Aka.EnterText(aka);
                LastFourSSN.EnterText(lastFourSSN);
                ContactPhone.EnterText(contactPhone);
                MailingAddress.EnterText(mailingAddress);
                City.EnterText(city);
                State.ClearText(state);
                ZipCode.EnterText(zip);
                PreferredEmail.EnterText(email);
                ConfirmEmail.EnterText(cEmail);
                EmployeeNumber.EnterText(empNumber);
                Payroll.EnterText(payroll);
                EmployingDepartment.EnterText(department);
                AppealIssue.EnterText(appealIssue);
                Attach.Clicks();
                Browse.UploadFile(notificationDocument);
                AttachmentDescription.EnterText(attachmentDesciption);
                AttachAdditional.Clicks();
                BrowseAdditional.UploadFile(classificationDoc);
                DescriptionAdditional.EnterText(ClassificationDocDesc);
                Remedy.SendKeys(remedy);
                SubmitBtn.Clicks();
                AcceptPopupBtn.Clicks();
            }
           

        }

        public void FillFormForOthers(string examinationPosition, string appleant, string fName, string mName, string lName, string aka,
                                        string lastFourSSN, string contactPhone, string mailingAddress, string city, string state, string zip, 
                                        string email, string cEmail, string empNumber, string payroll, string department, string appealIssue,
                                        string remedy
            )
        {
            // SubmitAppeal.Clicks();
            BtnIAgree.Clicks();

            OtherHeadingID.Clicks();
            Others.Clicks();

            if (appleant == "Yourself")
            {
                FillingYourSelf.Click();
            }
            FName.EnterText(fName);
            MName.EnterText(mName);
            LName.EnterText(lName);
            Aka.EnterText(aka);
            LastFourSSN.EnterText(lastFourSSN);
            ContactPhone.EnterText(contactPhone);
            MailingAddress.EnterText(mailingAddress);
            City.EnterText(city);
            State.ClearText(state);
            ZipCode.EnterText(zip);
            PreferredEmail.EnterText(email);
            ConfirmEmail.EnterText(cEmail);
            EmployeeNumber.EnterText(empNumber);
            Payroll.EnterText(payroll);
            EmployingDepartment.EnterText(department);
            AppealIssue.EnterText(appealIssue);   
            Remedy.SendKeys(remedy);
            SubmitBtn.Clicks();
            AcceptPopupBtn.Clicks();

        }




        public IWebElement waitForPageUntilElementIsVisible(By locator, int maxSec)
        {
            return new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(maxSec))
                 .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }



        public static string ReadData(int rowNumber, string columnName, List<Datacollection> collectionName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in collectionName
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }


}

