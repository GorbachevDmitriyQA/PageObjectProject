using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    /// <summary>
    /// Страница Хабр.Новости
    /// </summary>
    public class FeedHabrPage : PageObjectBase
    {
        #region Локаторы
        /// <summary>
        /// Кнопка "Настройка ленты"
        /// </summary>
        private IWebElement lentaSettings =>
            driver.FindElement(By.XPath("//button[contains(text(),'Настройки ленты')]"));
        /// <summary>
        /// Блок с фильтрами
        /// </summary>
        private IWebElement filterForm =>
            driver.FindElement(By.XPath("//form[@class='my-feed-filter__form']"));
        /// <summary>
        /// Конкретный фильтр
        /// </summary>
        /// <param name="filterName"></param>
        /// <returns></returns>
        private IWebElement filterBlock(string filterName) =>
            filterForm.FindElement(By.XPath($"//legend[contains(text(),'{filterName}')]/parent::fieldset"));

        #endregion Локаторы
        #region Методы
        /// <summary>
        /// Нажимаем на кнопку "Настройка ленты"
        /// </summary>
        /// <returns></returns>
        public FeedHabrPage LentaSettingButtonClick()
        {
            wait.Until(_ => lentaSettings?.Displayed ?? false);
            lentaSettings.Click();
            return this;
        }
        /// <summary>
        /// Получить состояние отображения конкретного фильтра
        /// </summary>
        /// <param name="filterBlockName">Название фильтра</param>
        /// <returns></returns>
        public bool GetFilterBlockIsDisplayed(string filterBlockName)
        {
            wait.Until(_ => filterForm?.Displayed ?? false);
            return wait.Until(_ => filterBlock(filterBlockName)?.Displayed ?? false);
        }
        #endregion Методы
    }
}
