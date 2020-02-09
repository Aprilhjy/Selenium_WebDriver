
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Entrypoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figurmg";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see the css path element");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see the CSS Path Element");

        }

       

        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the XPath Element");
        }
        else
        {
            RedMessage("I can't see the XPath Element");
        }



        driver.Quit();
       
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
        
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;

    }
}

