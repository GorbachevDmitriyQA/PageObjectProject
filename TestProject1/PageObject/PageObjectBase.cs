using Demos.TestManager;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    /// <summary>
    /// База для страниц и общих методов взаимодействия
    /// </summary>
    public class PageObjectBase
    {
        /// <summary>
        /// Доступ к драйверу
        /// </summary>
        protected IWebDriver driver = Main.driver;
        /// <summary>
        /// Ожидаение 30 сек
        /// </summary>
        protected WebDriverWait wait;
        /// <summary>
        /// Ожидаение 10 сек
        /// </summary>
        protected WebDriverWait waitShort;
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public PageObjectBase()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            waitShort = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
    }
}
