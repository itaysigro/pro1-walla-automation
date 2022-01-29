using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace pro1_walla_automation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.walla.co.il");

            //Maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            IWebElement element = driver.FindElement(By.CssSelector("#root > div > div > header > div.first-row > div > div.promotions.no-mobile > div.promo.mail > a > div:nth-child(2) > div.line-1"));
            element.Click();
            Thread.Sleep(3000);


            IWebElement email = driver.FindElement(By.CssSelector("#wrapper > section > fieldset > a"));
            email.Click();

            IWebElement UserName = driver.FindElement(By.CssSelector("#username"));
            UserName.SendKeys("itaysigroni23");


            IWebElement checkGood = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li:nth-child(1) > div.input-button > button"));
            if (checkGood != null)
            {
                checkGood.Click();
                Thread.Sleep(3000);

                if (driver.FindElement(By.Id("usernameApproveMessage")) != null)
                {
                    Thread.Sleep(2000);


                }
                else
                {
                    Console.WriteLine("is not good");
                }

                var password = driver.FindElement(By.CssSelector("input[type=password]"));
                password.SendKeys("123456798");

                if (driver.FindElement(By.CssSelector("#errorNewPassword > span.text")) != null)
                {
                    password.Clear();
                    password.SendKeys("A1357911a*");
                }

                var FirstName = driver.FindElement(By.CssSelector("#fname"));
                FirstName.SendKeys("dada");

                Thread.Sleep(2000);


                var LastName = driver.FindElement(By.CssSelector("#sname"));
                LastName.SendKeys("dadada");

                var phone = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li.message.info-button-space > app-input-user-phone > form > div > select"));
                phone.SendKeys("054");

                var phone1 = driver.FindElement(By.CssSelector("#postfix"));
                phone1.SendKeys("6776933");

                var day = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li:nth-child(6) > app-date-picker > form > div.label-input.flex-1-1-1-1.birthdate > select.form-control.date-field.day.ng-untouched.ng-pristine.ng-invalid"));
                day.SendKeys("20");

                var month = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li:nth-child(6) > app-date-picker > form > div.label-input.flex-1-1-1-1.birthdate > select.form-control.date-field.month.ng-untouched.ng-pristine.ng-invalid"));
                month.SendKeys("10");


                var years = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li:nth-child(6) > app-date-picker > form > div.label-input.flex-1-1-1-1.birthdate > select.form-control.date-field.year.ng-untouched.ng-pristine.ng-invalid"));
                years.SendKeys("1995");

                var gander = driver.FindElement(By.CssSelector("body > app-root > div > main > div > app-register > form > fieldset > section > ul > li.button-row > app-input-genders > form > fieldset > ul > li:nth-child(2) > label"));
                gander.Click();

                var check1 = driver.FindElement(By.CssSelector("#disclaimer"));
                check1.Click();

                var creacte = driver.FindElement(By.CssSelector("#submit-button"));

                var finish = driver.FindElement(By.CssSelector("#submit-button"));
                finish.Click();



            }


            //Close the browser
            // driver.Close();
        }
    }
}
