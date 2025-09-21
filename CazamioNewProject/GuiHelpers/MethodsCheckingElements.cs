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



        public static bool IsNotVisible(IWebElement element, int timeoutInSeconds = 10, int intervalInMilliseconds = 100)
        {
            var waitTime = TimeSpan.FromSeconds(timeoutInSeconds);
            var interval = TimeSpan.FromMilliseconds(intervalInMilliseconds);
            var startTime = DateTime.Now;

            while (DateTime.Now - startTime < waitTime)
            {
                try
                {
                    // Если элемент существует и видим - значит он ещё отображается
                    if (element != null && element.Displayed)
                    {
                        Console.WriteLine($"Toaster message is still visible: {element.Text}");
                        Thread.Sleep(interval);
                        continue;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Элемент не найден - значит не видим
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    // Элемент устарел - значит не видим
                    return true;
                }
                catch (Exception ex) when (ex is WebDriverException || ex is NullReferenceException)
                {
                    // Другие возможные исключения, связанные с отсутствием элемента
                    return true;
                }

                Thread.Sleep(interval);
            }

            // Если за время ожидания элемент ни разу не исчез - возвращаем false
            return false;
        }
    }

    public class ToasterWarning
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



        public static bool IsNotVisible(IWebElement element, int timeoutInSeconds = 10, int intervalInMilliseconds = 100)
        {
            var waitTime = TimeSpan.FromSeconds(timeoutInSeconds);
            var interval = TimeSpan.FromMilliseconds(intervalInMilliseconds);
            var startTime = DateTime.Now;

            while (DateTime.Now - startTime < waitTime)
            {
                try
                {
                    // Если элемент существует и видим - значит он ещё отображается
                    if (element != null && element.Displayed)
                    {
                        Console.WriteLine($"Toaster message is still visible: {element.Text}");
                        Thread.Sleep(interval);
                        continue;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Элемент не найден - значит не видим
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    // Элемент устарел - значит не видим
                    return true;
                }
                catch (Exception ex) when (ex is WebDriverException || ex is NullReferenceException)
                {
                    // Другие возможные исключения, связанные с отсутствием элемента
                    return true;
                }

                Thread.Sleep(interval);
            }

            // Если за время ожидания элемент ни разу не исчез - возвращаем false
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

                Thread.Sleep(interval);
            }

            return false;
        }
    }

    public class MessagesUnderFieldsCheck
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

                Thread.Sleep(interval);
            }

            return false;
        }
    }

    public class SubjectEmail
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
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Subject email: {element.Text}");
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

            return false;
        }
    }

    public class ButtonName
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
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Button name: {element.Text}");
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

            return false;
        }
    }

    public class TextSubtitle
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
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Subtitle: {element.Text}");
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

                Thread.Sleep(interval);
            }

            return false;
        }
    }

    public class Record
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
                    if (element != null && element.Enabled)
                    {
                        Console.WriteLine($"Record: {element.Text}");
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

                Thread.Sleep(interval);
            }

            return false;
        }
    }
}
