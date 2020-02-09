
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Entrypoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "3";
     
        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child("+ option +")"));

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("This checkbox is checked!");
        }
        else
        {
            Console.WriteLine("This checkbox is NOT checked");
        }

        driver.Quit();

    }

}


