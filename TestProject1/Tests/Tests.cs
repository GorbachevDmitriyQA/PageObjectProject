using Demos.TestManager;
using TestProject1.DataModels;

namespace TestProject1
{
    /// <summary>
    /// Тестовые тесты
    /// </summary>
    [TestFixture]
    public class Tests : Main
    {
        /// <summary>
        /// Подготоваливаем тестовые данные
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<SearchData> ContextSearchData()
        {
            return ContextSearchDataFromXml();
        }

        [Test]
        /// <summary>
        /// Проверки отображения фильтров Настройка ленты => Новости.Хабр
        /// </summary>
        public void CheckHabrFilterDisplayed()
        {
            Main.Manager.FeedHabrSteps
                .LentaSettingClick()//1
                .Validate.CheckFilterBlockState();//2
        }


        [Test, TestCaseSource(nameof(ContextSearchData))]
        /// <summary>
        /// Проверка корректного контекстного поиска и отображения 
        /// </summary>
        public void CheckContextSearchForHabr(SearchData data)
        {
            Main.Manager.HeaderSteps.ClickSearchButton();
            Main.Manager
                .SearchingSteps.InitSearchByText(data.TextForSearching)
                .Validator.CheckSuccesSearchForContextAndCurrentActiveCategory(data);
        }
    }
}