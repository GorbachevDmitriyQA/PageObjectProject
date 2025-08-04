using TestProject1.PageObject;
using TestProject1.TestManager;
using TestProject1.TestManager.Validations;

namespace Demos.TestManager
{
    /// <summary>
    /// Класс шагов для страницы "Поиска"
    /// </summary>
    public class SearchingSteps : StepsBase
    {
        /// <summary>
        /// Переменная для вызова цепочки проверок с текущими шагами
        /// </summary>
        public readonly SearchValidator Validator = new();
        /// <summary>
        /// Страница поиска
        /// </summary>
        private SearchPage searchPage = new();
        /// <summary>
        /// Начать поиск по тексту
        /// </summary>
        /// <param name="searchText">Текст для поиска</param>
        /// <returns></returns>
        public SearchingSteps InitSearchByText(string searchText)
        {
            searchPage.SetTextForSearchField(searchText);
            return this;
        }
    }
}
