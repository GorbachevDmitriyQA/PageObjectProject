using TestProject1.PageObject;

namespace TestProject1.TestManager.Validations
{
    /// <summary>
    /// Проверки для шагов Новости.Хабр
    /// </summary>
    public class FeedHabrValidator : StepsBase
    {
        /// <summary>
        /// Страница Новости.Хабр
        /// </summary>
        private FeedHabrPage feedHabrPage = new();
        /// <summary>
        /// Проверка отображения фильтров в настройке ленты Новости.Хабр
        /// </summary>
        public void CheckFilterBlockState()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(feedHabrPage.GetFilterBlockIsDisplayed("Тип публикации"),
                    "Фильтр \"Тип публикации\" не отображается на странице");
                Assert.IsTrue(feedHabrPage.GetFilterBlockIsDisplayed("Порог рейтинга"),
                    "Фильтр \"Порог рейтинга\" не отображается на странице");
                Assert.IsTrue(feedHabrPage.GetFilterBlockIsDisplayed("Уровень сложности"),
                    "Фильтр \"Уровень сложности\" не отображается на странице");
            });
        }

    }
}
