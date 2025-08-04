using TestProject1.PageObject;
using TestProject1.DataModels;

namespace TestProject1.TestManager.Validations
{
    /// <summary>
    /// Проверки для шагов контекстного поиска по Хабру
    /// </summary>
    public class SearchValidator : StepsBase
    {
        /// <summary>
        /// Страница контекстного поиска
        /// </summary>
        private SearchPage searchPage = new();
        /// <summary>
        /// Проверить текст заголовка первой отображаемой публикации
        /// </summary>
        /// <returns></returns>
        public SearchValidator CheckSuccesSearchForContextAndCurrentActiveCategory(SearchData data)
        {
            Assert.Multiple(() =>
            {
                Assert.That(searchPage.GetCurrentActiveSearchCategoryText(), Is.EqualTo(data.ActiveSearchCategory),
                    "Текущая/Активная категория не совпадает с ожидаемой");
                Assert.That(searchPage.GetFirstDisplayedPublicationHeaderText(), Is.EqualTo(data.ExpectedFirstPublicationHeader),
                    "Текст заголовка для первой найденной публикации не совпадает с ожидаемым");
            });
            return this;
        }
    }
}
