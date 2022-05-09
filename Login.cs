using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Collections.ObjectModel;
using DemoQASite;

namespace OpenMRS
{
    class Login : Selenium_Base
    {
        
        public void LogintoPatintWard()
        {
            open("https://demo.openmrs.org/openmrs/");
            wait(2000);

            sendKeys(FindXPath("//input[@id='username']"), "Admin");
            wait(2000);
            sendKeys(FindXPath("//input[@id='password']"), "Admin123");
            wait(2000);
            click(FindXPath("//li[@id='Inpatient Ward']"));
            wait(2000);
            click(FindXPath("//input[@id='loginButton']"));
            wait(10000);
        }
        public void NextButton()
        {
            click(FindXPath("//button[@id='next-button']"));
            wait(2000);
        }
        public void BackToHome()
        {
            click(FindXPath("//i[@class='icon-home small']"));
            wait(2000);
        }
        public void RegisterAPatient()
        {
            LogintoPatintWard();
            click(FindXPath("//a[@id='referenceapplication-registrationapp-registerPatient-homepageLink-referenceapplication-registrationapp-registerPatient-homepageLink-extension']"));
            wait(2000);
            sendKeys(FindXPath("//input[@name='givenName']"), "Laxmi");
            wait(2000);
            sendKeys(FindXPath("//input[@name='familyName']"), "Gorai");
            wait(2000);
            NextButton();

            getAction().MoveToElement(FindXPath("//select[@id='gender-field']"));
            wait(1000);
            click(FindXPath("//option[text()='Female']"));
            wait(2000);
            NextButton();

            sendKeys(FindXPath("//input[@name='birthdateDay']"), "31");
            wait(2000);
            getAction().MoveToElement(FindXPath("//select[@id='birthdateMonth-field']"));
            wait(1000);
            click(FindXPath("//option[text()='August']"));
            wait(2000);
            sendKeys(FindXPath("//input[@name='birthdateYear']"), "2001");
            wait(2000);
            NextButton();

            sendKeys(FindXPath("//input[@id='address1']"), "Shanti Nagar");
            wait(2000);
            sendKeys(FindXPath("//input[@id='address2']"), "Benachity");
            wait(2000);
            sendKeys(FindXPath("//input[@id='cityVillage']"), "Durgapur");
            wait(2000);
            sendKeys(FindXPath("//input[@id='stateProvince']"), "West Bengal");
            wait(2000);
            sendKeys(FindXPath("//input[@id='country']"), "India");
            wait(2000);
            sendKeys(FindXPath("//input[@id='postalCode']"), "713213");
            wait(2000);
            NextButton();

            sendKeys(FindXPath("//input[@name='phoneNumber']"), "7541258222");
            wait(2000);
            NextButton();

            click(FindXPath("//select[@id='relationship_type']"));
            wait(2000);
            click(FindXPath("//option[@data-val='Parent']"));
            wait(2000);
            sendKeys(FindXPath("//input[@class='person-typeahead ng-pristine ng-untouched ng-valid ng-empty']"), "R.K");
            wait(2000);
            NextButton();

            click(FindXPath("//input[@id='submit']"));
            wait(15000);

            BackToHome();
        }
        public void FindPatientRecord()
        {
            click(FindXPath("//a[@id='coreapps-activeVisitsHomepageLink-coreapps-activeVisitsHomepageLink-extension']"));
            wait(2000);
            sendKeys(FindXPath("//input[@id='patient-search']"), "Laxmi");
            wait(2000);
            click(FindXPath("//tr[@class='odd']"));
            wait(2000);
        }
        public void ScheduleAppointment()
        {
            click(FindXPath("//i[@class='icon-share-alt edit-action']"));
            wait(2000);
            close();
        }
    }

}
