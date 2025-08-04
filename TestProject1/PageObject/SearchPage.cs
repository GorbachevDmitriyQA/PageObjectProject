using OpenQA.Selenium;


namespace TestProject1.PageObject
{
    /// <summary>
    /// Страница поиска
    /// </summary>
    public class SearchPage : PageObjectBase
    {
        /// <summary>
        /// Поле поиска
        /// </summary>
        private IWebElement searchField =>
            driver.FindElement(By.XPath("//input[@placeholder='Поиск']"));
        /// <summary>
        /// Текущая/Активная категория поиска
        /// </summary>
        public IWebElement activeSearchCategory =>
            driver.FindElement(By.XPath("//*[@data-test-id='tab-link-active']"));
        /// <summary>
        /// Список публикаций
        /// </summary>
        private ICollection<IWebElement> publicationList =>
            driver.FindElements(By.XPath("//article"));
        /// <summary>
        /// Вводи запрос для поиска
        /// </summary>
        /// <param name="text">Текст для запроса</param>
        /// <returns></returns>
        public SearchPage SetTextForSearchField(string text)
        {
            wait.Until(_ => searchField?.Displayed ?? false);
            searchField.Click();
            searchField.SendKeys(text);
            searchField.SendKeys(Keys.Enter);
            return this;
        }
        /// <summary>
        /// Получаем текст активной/выбранной категории поиска
        /// </summary>
        /// <returns></returns>
        public string GetCurrentActiveSearchCategoryText()
        {
            wait.Until(_ => activeSearchCategory?.Displayed ?? false);
            return activeSearchCategory.Text;
        }
        /// <summary>
        /// Возвращаем заголовок первой отображаемой публикации
        /// </summary>
        /// <returns></returns>
        public string GetFirstDisplayedPublicationHeaderText()
        {
            wait.Until(_ => publicationList.Count > 0);
            var publication = publicationList.First();
            return publication.FindElement(By.XPath("//h2")).Text;
        }
    }
}
