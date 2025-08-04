using OpenQA.Selenium;
namespace TestProject1.PageObject
{
    /// <summary>
    /// Header Хабр
    /// </summary>
    public class HeaderBlock : PageObjectBase
    {
        /// <summary>
        /// Кнопка поиска
        /// </summary>
        private IWebElement searchButton =>
            driver.FindElement(By.XPath("//a[@data-test-id='search-button']"));

        /// <summary>
        /// Нажимаем на кнопку "Поиска"
        /// </summary>
        /// <returns></returns>
        public HeaderBlock SearchButtonClick()
        {
            wait.Until(_ => searchButton?.Displayed ?? false);
            searchButton.Click();
            return this;
        }
    }
}
