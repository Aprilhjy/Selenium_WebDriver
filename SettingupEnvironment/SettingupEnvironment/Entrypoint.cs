
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Entrypoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromDropDownMenu;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuEliments = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";


        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine(dropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuEliments));

        Console.WriteLine(elementFromDropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu.Click();

        Console.WriteLine("The selected value is " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(5000);

        for (int i = 1; i < 4; i++)
        {
            dropDownMenuEliments = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";

            elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuEliments));

            Console.WriteLine("The " + i +" option from the drop down menu is:" + elementFromDropDownMenu.GetAttribute("value"));
        }


        Thread.Sleep(5000);

        driver.Quit();

    }

}


