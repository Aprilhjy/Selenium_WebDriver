
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Entrypoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/id/";
        string ID = "testImage";
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            GreenMessage("Yes! I can see the element, it's right there!!!");
        }
        else
        {
            RedMessage("Well, something went wrong, I couldn't see the element!");
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

