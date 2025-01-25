using OpenQA.Selenium;
using System;
using System.Threading;

namespace CazamioNewProject.GuiHelpers
{
    public class ToasterSuccessfully
    {
        public static Boolean IsVisible(IWebElement element, int timeoutInSeconds = 10, int intervalInMilliseconds = 100)
        {
            var waitTime = TimeSpan.FromSeconds(timeoutInSeconds);
            var interval = TimeSpan.FromMilliseconds(intervalInMilliseconds);
            var startTime = DateTime.Now;

            while (DateTime.Now - startTime < waitTime)
            {
                try
                {
                    // Проверяем, что элемент доступен и видим
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Toaster message: {element.Text}");
                        return true;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Игнорируем, так как элемент может еще не существовать
                }
                catch (StaleElementReferenceException)
                {
                    // Игнорируем, так как элемент может быть временно недоступен
                }

                // Ждем перед следующей попыткой
                Thread.Sleep(interval);
            }

            // Если время истекло, возвращаем false
            return false;
        }
    }

    public class TitlesCheck
    {
        public static Boolean IsVisible(IWebElement element, int timeoutInSeconds = 10, int intervalInMilliseconds = 100)
        {
            var waitTime = TimeSpan.FromSeconds(timeoutInSeconds);
            var interval = TimeSpan.FromMilliseconds(intervalInMilliseconds);
            var startTime = DateTime.Now;

            while (DateTime.Now - startTime < waitTime)
            {
                try
                {
                    // Проверяем, что элемент доступен и видим
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Title name: {element.Text}");
                        return true;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Игнорируем, так как элемент может еще не существовать
                }
                catch (StaleElementReferenceException)
                {
                    // Игнорируем, так как элемент может быть временно недоступен
                }

                // Ждем перед следующей попыткой
                Thread.Sleep(interval);
            }

            // Если время истекло, возвращаем false
            return false;
        }
    }

    //public class TitlesCheck
    //{
    //    public static Boolean IsVisible(IWebElement element)
    //    {
    //        WaitUntil.WaitSomeInterval(100);
    //        try
    //        {
    //            if (element.Enabled == true)
    //            {
    //                Console.WriteLine($"Title name: {element.Text}");

    //                return true;
    //            }

    //            return false;
    //        }
    //        catch (NoSuchElementException) { return false; }

    //        catch (StaleElementReferenceException) { return false; }
    //    }
    //}
}
