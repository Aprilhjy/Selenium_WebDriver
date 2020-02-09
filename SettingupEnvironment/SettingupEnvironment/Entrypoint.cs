
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Entrypoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
     
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test Text");

        Thread.Sleep(5000);

        Console.WriteLine(textBox.GetAttribute("value"));

        Thread.Sleep(5000);

        driver.Quit();

    }

}


