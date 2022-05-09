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
    class Program : Selenium_Base
    {
        static void Main(string[] args)
        {

            Login login = new Login();

            //login.LogintoPatintWard();
            login.RegisterAPatient();
            login.FindPatientRecord();
            login.ScheduleAppointment();



        }
    }
}
